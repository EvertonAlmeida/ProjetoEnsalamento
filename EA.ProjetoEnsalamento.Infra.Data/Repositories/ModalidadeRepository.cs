using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Infra.Data.Context;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories
{
    public class ModalidadeRepository : RepositoryBase<Modalidade, ProjetoEnsalamentoContext>, IModalidadeRepository
    {
    }
}
