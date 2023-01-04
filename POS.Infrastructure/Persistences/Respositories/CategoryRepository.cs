using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Respositories
{
    internal class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly PosContext _context;
        public CategoryRepository(PosContext context)
        {
            _context = context;
        }
    }
}
