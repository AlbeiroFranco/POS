﻿using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace POS.Infrastructure.FileStorage
{
    public class AzureStorage : IAzureStorage
    {
        private readonly string _connetionString;
        public AzureStorage(IConfiguration configuration)
        {
            _connetionString = configuration.GetConnectionString("AzureStorage")!;
        }

        public async Task<string> SaveFile(string container, IFormFile file)
        {
            var client = new BlobContainerClient(_connetionString, container);

            await client.CreateIfNotExistsAsync();

            await client.SetAccessPolicyAsync(PublicAccessType.Blob);   

            var extension = Path.GetExtension(file.Name);
            
            var fileName = $"{Guid.NewGuid}{extension}";

            var blob = client.GetBlobClient(fileName);

            await blob.UploadAsync(file.OpenReadStream());

            return blob.Uri.ToString();
        }

        public async Task<string> EditFile(string container, IFormFile file, string route)
        {
            await RemoveFile(route, container);

            return await SaveFile(container, file);
        }

        public async Task RemoveFile(string container, string route)
        {
            if (string.IsNullOrEmpty(route))
            {
                return;
            }

            var client = new BlobContainerClient(_connetionString, container);

            await client.CreateIfNotExistsAsync();

            var file = Path.GetFileName(route);

            var blob = client.GetBlobClient(file);

            await blob.DeleteIfExistsAsync();

        }

       
    }
}
