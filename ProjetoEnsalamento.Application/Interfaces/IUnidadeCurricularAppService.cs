using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Application.Interfaces
{
    public interface IUnidadeCurricularAppService : IDisposable
    {
        void Add(UnidadeCurricularViewModel unidadeCurricularViewModel);
        UnidadeCurricularViewModel GetById(Guid id);
        IEnumerable<UnidadeCurricularViewModel> GetAll();
        void Update(UnidadeCurricularViewModel unidadeCurricularViewModel);
        void Remove(UnidadeCurricularViewModel unidadeCurricularViewModel);
    }
}