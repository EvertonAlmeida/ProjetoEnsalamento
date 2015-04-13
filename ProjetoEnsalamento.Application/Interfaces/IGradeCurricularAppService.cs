using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Application.Validation;
using EA.ProjetoEnsalamento.Application.ViewModels;


namespace EA.ProjetoEnsalamento.Application.Interfaces
{
    public interface IGradeCurricularAppService : IDisposable
    {
        ValidationAppResult Add(GradeCurricularViewModel gradeCurricularViewModel);
        GradeCurricularViewModel GetById(Guid id);
        IEnumerable<GradeCurricularViewModel> GetAll();
        void Update(GradeCurricularViewModel gradeCurricularViewModel);
        void Remove(GradeCurricularViewModel gradeCurricularViewModel);
    }
}