using System;
using System.Collections.Generic;
using AutoMapper;
using EA.ProjetoEnsalamento.Application.Interfaces;
using EA.ProjetoEnsalamento.Application.Validation;
using EA.ProjetoEnsalamento.Application.ViewModels;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;
using EA.ProjetoEnsalamento.Infra.Data.Context;

namespace EA.ProjetoEnsalamento.Application
{
    public class GradeCurricularAppService : AppServiceBase<ProjetoEnsalamentoContext>, IGradeCurricularAppService
    {
        private readonly IGradeCurricularService _gradeCurricularService;

        public GradeCurricularAppService(IGradeCurricularService gradeCurricularService)
        {
            _gradeCurricularService = gradeCurricularService;
        }

        public ValidationAppResult Add(GradeCurricularViewModel gradeCurricularViewModel)
        {
            var gradeCurricular = Mapper.Map<GradeCurricularViewModel, GradeCurricular>(gradeCurricularViewModel);

            BeginTransaction();

            var result = _gradeCurricularService.AdicionarGradeCurricular(gradeCurricular);

            if (!result.IsValid)
                return DomainToApplicationResult(result);

            _gradeCurricularService.Add(gradeCurricular);

            Commit();

            return DomainToApplicationResult(result);
        }

        public GradeCurricularViewModel GetById(Guid id)
        {
            return Mapper.Map<GradeCurricular, GradeCurricularViewModel>(_gradeCurricularService.GetById(id));
        }

        public IEnumerable<GradeCurricularViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<GradeCurricular>, IEnumerable<GradeCurricularViewModel>>(_gradeCurricularService.GetAll());
        }

        public void Update(GradeCurricularViewModel gradeCurricularViewModel)
        {
            var gradeCurricular = Mapper.Map<GradeCurricularViewModel, GradeCurricular>(gradeCurricularViewModel);
            BeginTransaction();
            _gradeCurricularService.Update(gradeCurricular);
            Commit();
        }

        public void Remove(GradeCurricularViewModel gradeCurricularViewModel)
        {
            var gradeCurricular = Mapper.Map<GradeCurricularViewModel, GradeCurricular>(gradeCurricularViewModel);
            BeginTransaction();
            _gradeCurricularService.Remove(gradeCurricular);
            Commit();
        }

        public void Dispose()
        {
            _gradeCurricularService.Dispose();
        }
    }
}