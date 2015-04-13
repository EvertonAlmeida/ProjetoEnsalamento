using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly
{
    public interface IGradeCurricularReadOnlyRepository
    {
        GradeCurricular GetById(Guid id);
        IEnumerable<GradeCurricular> GetAll(); 
    }
}