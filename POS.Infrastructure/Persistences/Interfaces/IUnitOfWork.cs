namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestras interface a nivel de reposiorio
        ICategoryRepository Category { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
