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
    public class CursoAppService : AppServiceBase<ProjetoEnsalamentoContext>, ICursoAppService
    {
        private readonly ICursoService _cursoService;

        public CursoAppService(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        public ValidationAppResult Add(CursoViewModel cursoViewModel)
        {
            var curso = Mapper.Map<CursoViewModel, Curso>(cursoViewModel);

            BeginTransaction();

            var result = _cursoService.AdicionarCurso(curso);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            _cursoService.Add(curso);

            Commit();

            return DomainToApplicationResult(result);
        }

        public CursoViewModel GetById(Guid id)
        {
            return Mapper.Map<Curso, CursoViewModel>(_cursoService.GetById(id));
        }

        public IEnumerable<CursoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Curso>, IEnumerable<CursoViewModel>>(_cursoService.GetAll());
        }

        public void Update(CursoViewModel cursoViewModel)
        {
            var curso = Mapper.Map<CursoViewModel, Curso>(cursoViewModel);
            BeginTransaction();
            _cursoService.Update(curso);
            Commit();
        }

        public void Remove(CursoViewModel cursoViewModel)
        {
            var curso = Mapper.Map<CursoViewModel, Curso>(cursoViewModel);
            BeginTransaction();
            _cursoService.Remove(curso);
            Commit();
        }
        public void Dispose()
        {
            _cursoService.Dispose();
        }
    }
}