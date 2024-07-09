using Microsoft.EntityFrameworkCore;
using FactoryDbContext.Models;
using FactoryDbContext.Data;

namespace FactoryDbContext.Repositories
{
    public class ProductRepository
    {
        private readonly IApplicationDbContextFactory _dbContextFactory;

        public ProductRepository(IApplicationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<Product>> GetAllAsync(bool isReadOnly)
        {
            using (var context = _dbContextFactory.CreateDbContext(isReadOnly))
            {
                return await context.Products.ToListAsync();
            }
        }

        public async Task AddAsync(Product entity)
        {
            using (var context = _dbContextFactory.CreateDbContext(false))
            {
                context.Products.Add(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
