
using EA.ProjetoEnsalamento.Domain.Entities;
using System;
using System.Collections.Generic;
namespace EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly
{
    public interface IModalidadeReadOnlyRepository
    {
        Modalidade GetById(Guid id);
        IEnumerable<Modalidade> GetAll();
    }
}
