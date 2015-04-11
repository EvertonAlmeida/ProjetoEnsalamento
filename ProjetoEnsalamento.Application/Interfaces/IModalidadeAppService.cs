using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Application.Interfaces
{
    public interface IModalidadeAppService : IDisposable
    {
        void Add(ModalidadeViewModel modalidadeViewModel);
        ModalidadeViewModel GetById(Guid id);
        IEnumerable<ModalidadeViewModel> GetAll();
        void Update(ModalidadeViewModel modalidadeViewModel);
        void Remove(ModalidadeViewModel modalidadeViewModel);
    }
}