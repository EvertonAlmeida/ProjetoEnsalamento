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
    public class FaseAppService : AppServiceBase<ProjetoEnsalamentoContext>, IFaseAppService
    {
        private readonly IFaseService _faseService;

        public FaseAppService(IFaseService faseService)
        {
            _faseService = faseService;
        }

        public void Add(FaseViewModel faseViewModel)
        {
           var fase = Mapper.Map<FaseViewModel, Fase>(faseViewModel);
            BeginTransaction();
            _faseService.Add(fase);
            Commit();
        }   

        public FaseViewModel GetById(Guid id)
        {
            return Mapper.Map<Fase, FaseViewModel>(_faseService.GetById(id));
        }

        public IEnumerable<FaseViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Fase>, IEnumerable<FaseViewModel>>(_faseService.GetAll());
        }

        public void Update(FaseViewModel faseViewModel)
        {
            var fase = Mapper.Map<FaseViewModel, Fase>(faseViewModel);
            BeginTransaction();
            _faseService.Update(fase);
            Commit();
        }

        public void Remove(FaseViewModel faseViewModel)
        {
            var fase = Mapper.Map<FaseViewModel, Fase>(faseViewModel);
            BeginTransaction();
            _faseService.Remove(fase);
            Commit();
        }
    }
}