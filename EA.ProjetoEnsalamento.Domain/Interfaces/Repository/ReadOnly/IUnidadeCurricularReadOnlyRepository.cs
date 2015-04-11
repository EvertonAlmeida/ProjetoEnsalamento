using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly
{
    public interface IUnidadeCurricularReadOnlyRepository
    {
        UnidadeCurricular GetById(Guid id);
        IEnumerable<UnidadeCurricular> GetAll();
    }
}