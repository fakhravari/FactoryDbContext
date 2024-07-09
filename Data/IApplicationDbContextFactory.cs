namespace FactoryDbContext.Data
{
    public interface IApplicationDbContextFactory
    {
        ApplicationDbContext CreateDbContext(bool isReadOnly);
    }
}
