using EA.ProjetoEnsalamento.Infra.Data.Interfaces;

namespace EA.ProjetoEnsalamento.Application.Interfaces
{
    public interface IAppServiceBase<TContext> where TContext : IDbContext
    {
        void BeginTransaction();
        void Commit();
    }
}