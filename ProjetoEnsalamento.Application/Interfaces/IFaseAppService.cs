using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Application.Interfaces
{
    public interface IFaseAppService
    {
        void Add(FaseViewModel faseViewModel);
        FaseViewModel GetById(Guid id);
        IEnumerable<FaseViewModel> GetAll();
        void Update(FaseViewModel faseViewModel);
        void Remove(FaseViewModel faseViewModel); 
    }
}