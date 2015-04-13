using System;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Specification;

namespace EA.ProjetoEnsalamento.Domain.Specification.GradeCurriculares
{
    public class GradeCurricularPossuiUnidadeCurricularSpecification : ISpecification<GradeCurricular>
    {
        public bool IsSatisfiedBy(GradeCurricular gradeCurricular)
        {
            return gradeCurricular.UnidadeCurricularId != Guid.Empty;
        }
    }
}