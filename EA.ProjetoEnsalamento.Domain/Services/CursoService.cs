using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;
using EA.ProjetoEnsalamento.Domain.ValueObjects;

namespace EA.ProjetoEnsalamento.Domain.Services
{
    public class CursoService :ServiceBase<Curso>, ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly ICursoReadOnlyRepository _cursoReadOnlyRepository;

        public CursoService(ICursoRepository cursoRepository, ICursoReadOnlyRepository cursoReadOnlyRepository) 
            : base(cursoRepository)
        {
            _cursoRepository = cursoRepository;
            _cursoReadOnlyRepository = cursoReadOnlyRepository;
        }

        public override Curso GetById(Guid id)
        {
            return _cursoReadOnlyRepository.GetById(id);
        }

        public override IEnumerable<Curso> GetAll()
        {
            return _cursoReadOnlyRepository.GetAll();
        }

        public ValidationResult AdicionarCurso(Curso curso)
        {
           var resultadoValidacao = new ValidationResult();

           if (!curso.IsValid())
            {
                resultadoValidacao.AdicionarErro(curso.ResultadoValidacao);
                return resultadoValidacao;
            }

            Add(curso);
            return resultadoValidacao;
        }
    }
}