namespace EA.ProjetoEnsalamento.Infra.Data.Interfaces
{
    public interface IUnitOfWork<TContext> where TContext : IDbContext, new()
    {
        void BeginTransaction();
        void SaveChanges();
    }
}