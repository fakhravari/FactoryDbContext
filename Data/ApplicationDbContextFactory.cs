using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FactoryDbContext.Data
{
    public class ApplicationDbContextFactory : IApplicationDbContextFactory
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ApplicationDbContext CreateDbContext(bool isReadOnly)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = isReadOnly
                ? _configuration.GetConnectionString("ReadDatabase")
                : _configuration.GetConnectionString("WriteDatabase");

            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
