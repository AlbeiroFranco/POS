using Microsoft.Extensions.Configuration;
using POS.Infrastructure.FileStorage;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Infrastrure.Pesistences.Context;

namespace POS.Infrastructure.Persistences.Respositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly POSContext _context;
        public ICategoryRepository Category { get; private set; }

        public IUserRepository User { get; private set; }

        public IAzureStorage Storage { get; private set; }

        public UnitOfWork(POSContext context, IConfiguration configuration)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            User = new UserRepository(_context);
            Storage = new AzureStorage(configuration);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
