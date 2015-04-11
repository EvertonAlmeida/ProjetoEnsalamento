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
    public class UnidadeCurricularAppService : AppServiceBase<ProjetoEnsalamentoContext>, IUnidadeCurricularAppService
    {
        private readonly IUnidadeCurricularService _unidadeCurricularService;

        public UnidadeCurricularAppService(IUnidadeCurricularService unidadeCurricularService)
        {
            _unidadeCurricularService = unidadeCurricularService;
        }

        public void Add(UnidadeCurricularViewModel unidadeCurricularViewModel)
        {
            var unidadeCurricular = Mapper.Map<UnidadeCurricularViewModel, UnidadeCurricular>(unidadeCurricularViewModel);
            BeginTransaction();
            _unidadeCurricularService.Add(unidadeCurricular);
            Commit();
        }

        public UnidadeCurricularViewModel GetById(Guid id)
        {
            return Mapper.Map<UnidadeCurricular, UnidadeCurricularViewModel>(_unidadeCurricularService.GetById(id));
        }

        public IEnumerable<UnidadeCurricularViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<UnidadeCurricular>, IEnumerable<UnidadeCurricularViewModel>>(_unidadeCurricularService.GetAll());
        }

        public void Update(UnidadeCurricularViewModel unidadeCurricularViewModel)
        {
            var unidadeCurricular = Mapper.Map<UnidadeCurricularViewModel, UnidadeCurricular>(unidadeCurricularViewModel);
            BeginTransaction();
            _unidadeCurricularService.Update(unidadeCurricular);
            Commit();
        }

        public void Remove(UnidadeCurricularViewModel unidadeCurricularViewModel)
        {
            var unidadeCurricular = Mapper.Map<UnidadeCurricularViewModel, UnidadeCurricular>(unidadeCurricularViewModel);
            BeginTransaction();
            _unidadeCurricularService.Remove(unidadeCurricular);
            Commit();
        }

        public void Dispose()
        {
            _unidadeCurricularService.Dispose();
        }
    }
}