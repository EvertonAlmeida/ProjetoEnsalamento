namespace EA.ProjetoEnsalamento.Infra.Data.Interfaces
{
    public interface IContextManager<TContext> where TContext : IDbContext, new()
    {
        IDbContext GetContext();
    }
}