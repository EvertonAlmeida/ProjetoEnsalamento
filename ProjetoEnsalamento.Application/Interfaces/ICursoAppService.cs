using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Application.Validation;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Application.Interfaces
{
    public interface ICursoAppService : IDisposable
    {
        ValidationAppResult Add(CursoViewModel cursoViewModel);
        CursoViewModel GetById(Guid id);
        IEnumerable<CursoViewModel> GetAll();
        void Update(CursoViewModel cursoViewModel);
        void Remove(CursoViewModel cursoViewModel);
    }
}