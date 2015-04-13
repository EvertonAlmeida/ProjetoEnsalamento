using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;
using EA.ProjetoEnsalamento.Domain.ValueObjects;

namespace EA.ProjetoEnsalamento.Domain.Services
{
    public class GradeCurricularService : ServiceBase<GradeCurricular>, IGradeCurricularService
    {
        private readonly IGradeCurricularRepository _gradeCurricularRepository;
        private readonly IGradeCurricularReadOnlyRepository _gradeCurricularReadOnlyRepository;

        public GradeCurricularService(IGradeCurricularRepository gradeCurricularRepository, IGradeCurricularReadOnlyRepository gradeCurricularReadOnlyRepository) 
            : base(gradeCurricularRepository)
        {
            _gradeCurricularRepository = gradeCurricularRepository;
            _gradeCurricularReadOnlyRepository = gradeCurricularReadOnlyRepository;
        }

        public override GradeCurricular GetById(Guid id)
        {
            return _gradeCurricularReadOnlyRepository.GetById(id);
        }

        public override IEnumerable<GradeCurricular> GetAll()
        {
            return _gradeCurricularReadOnlyRepository.GetAll();
        }

        public ValidationResult AdicionarGradeCurricular(GradeCurricular gradeCurricular)
        {
            var resultadoValidacao = new ValidationResult();

            if (!gradeCurricular.IsValid())
            {
                resultadoValidacao.AdicionarErro(gradeCurricular.ResultadoValidacao);
                return resultadoValidacao;
            }

            Add(gradeCurricular);
            return resultadoValidacao;
        }
    }
}