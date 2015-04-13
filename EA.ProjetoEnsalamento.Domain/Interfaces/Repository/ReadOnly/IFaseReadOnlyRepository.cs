using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly
{
    public interface IFaseReadOnlyRepository
    {
        Fase GetById(Guid id);
        IEnumerable<Fase> GetAll();
    }
}