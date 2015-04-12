using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly
{
    public interface ICursoReadOnlyRepository
    {
        Curso GetById(Guid id);
        IEnumerable<Curso> GetAll();
    }
}