using System;
using System.Collections.Generic;
using AutoMapper;
using EA.ProjetoEnsalamento.Application.Interfaces;
using EA.ProjetoEnsalamento.Application.ViewModels;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;
using EA.ProjetoEnsalamento.Infra.Data.Context;

namespace EA.ProjetoEnsalamento.Application
{
    public class ModalidadeAppService : AppServiceBase<ProjetoEnsalamentoContext>,IModalidadeAppService
    {
        private readonly IModalidadeService _modalidadeService;

        public ModalidadeAppService(IModalidadeService modalidadeService)
        {
            _modalidadeService = modalidadeService;
        }

        public void Add(ModalidadeViewModel modalidadeViewModel)
        {
            var modalidade = Mapper.Map<ModalidadeViewModel, Modalidade>(modalidadeViewModel);
            BeginTransaction();
            _modalidadeService.Add(modalidade);
            Commit();
        }

        public ModalidadeViewModel GetById(Guid id)
        {
            return Mapper.Map<Modalidade, ModalidadeViewModel>(_modalidadeService.GetById(id));
        }

        public IEnumerable<ModalidadeViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Modalidade>, IEnumerable<ModalidadeViewModel>>(_modalidadeService.GetAll());
        }

        public void Update(ModalidadeViewModel modalidadeViewModel)
        {
            var modalidade = Mapper.Map<ModalidadeViewModel, Modalidade>(modalidadeViewModel);
            BeginTransaction();
            _modalidadeService.Update(modalidade);
            Commit();
        }

        public void Remove(ModalidadeViewModel modalidadeViewModel)
        {
            var modalidade = Mapper.Map<ModalidadeViewModel, Modalidade>(modalidadeViewModel);
            BeginTransaction();
            _modalidadeService.Remove(modalidade);
            Commit();
        }

        public void Dispose()
        {
            _modalidadeService.Dispose();
        }
    }
}