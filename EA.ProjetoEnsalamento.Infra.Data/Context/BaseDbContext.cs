using EA.ProjetoEnsalamento.Infra.Data.Interfaces;
using System.Data.Entity;

namespace EA.ProjetoEnsalamento.Infra.Data.Context
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
