using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Infra.Data.Context;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories
{
    public class FaseRepository : RepositoryBase<Fase, ProjetoEnsalamentoContext>, IFaseRepository
    { 
    }
}