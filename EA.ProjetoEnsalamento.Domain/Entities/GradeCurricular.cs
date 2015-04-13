using System;
using EA.ProjetoEnsalamento.Domain.Validation.GradeCurriculares;
using EA.ProjetoEnsalamento.Domain.ValueObjects;

namespace EA.ProjetoEnsalamento.Domain.Entities
{
    public class GradeCurricular
    {
        public GradeCurricular()
        {
            GradeCurricularId = Guid.NewGuid();
        }

        public Guid GradeCurricularId { get; set; }
        public Guid FaseId { get; set; }
        public virtual Fase Fase { get; set; }
        public Guid UnidadeCurricularId { get; set; }
        public virtual UnidadeCurricular UnidadeCurricular { get; set; }
        public Guid CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual int CargaHoraria { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }

        public bool IsValid()
        {
            var fiscal = new GradeCurricularEstaConsistenteValidation();

            ResultadoValidacao = fiscal.Validar(this);

            return ResultadoValidacao.IsValid;
        }
    }
}