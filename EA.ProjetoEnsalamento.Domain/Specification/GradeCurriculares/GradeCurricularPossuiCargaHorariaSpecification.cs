using System;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Specification;

namespace EA.ProjetoEnsalamento.Domain.Specification.GradeCurriculares
{
    public class GradeCurricularPossuiCargaHorariaSpecification : ISpecification<GradeCurricular>
    {
        public bool IsSatisfiedBy(GradeCurricular gradeCurricular)
        {
            return gradeCurricular.CargaHoraria > 0;
        }
    }
}