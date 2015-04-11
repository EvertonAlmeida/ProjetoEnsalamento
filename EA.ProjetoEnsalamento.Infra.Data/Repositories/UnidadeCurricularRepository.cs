using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Infra.Data.Context;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories
{
    public class UnidadeCurricularRepository : RepositoryBase<UnidadeCurricular, ProjetoEnsalamentoContext>, IUnidadeCurricularRepository
    {
    }
}