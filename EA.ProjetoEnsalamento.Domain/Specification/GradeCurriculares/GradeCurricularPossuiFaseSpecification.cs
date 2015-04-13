using System;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Specification;

namespace EA.ProjetoEnsalamento.Domain.Specification.GradeCurriculares
{
    public class GradeCurricularPossuiFaseSpecification : ISpecification<GradeCurricular>
    {
        public bool IsSatisfiedBy(GradeCurricular gradeCurricular)
        {
            return gradeCurricular.FaseId != Guid.Empty;
        }
    }
}