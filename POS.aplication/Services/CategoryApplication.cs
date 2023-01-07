using AutoMapper;
using POS.Aplication.Commons.Bases;
using POS.Aplication.Dtos.Request;
using POS.Aplication.Dtos.Response;
using POS.Aplication.Interfaces;
using POS.Aplication.Validators.Category;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Aplication.Services
{
    public class CategoryApplication : ICategoryApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly CategoryValidator _validationRules;

        public CategoryApplication(IUnitOfWork unitOfWork, IMapper mapper, CategoryValidator validationRules)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        public Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategories()
        {
            throw new NotImplementedException();
        }
        public Task<BaseResponse<CategoryResponseDto>> CategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }
        public Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
        public Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
        public Task<BaseResponse<BaseEntityResponse<CategoryResponseDto>>> ListCategories(BaseFiltersRequest filters)
        {
            throw new NotImplementedException();
        }
        public Task<BaseResponse<bool>> RemoveCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
