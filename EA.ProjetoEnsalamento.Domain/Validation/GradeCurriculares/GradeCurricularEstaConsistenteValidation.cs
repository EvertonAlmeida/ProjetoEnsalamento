using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Specification.Cursos;
using EA.ProjetoEnsalamento.Domain.Specification.GradeCurriculares;
using EA.ProjetoEnsalamento.Domain.Validation.Base;

namespace EA.ProjetoEnsalamento.Domain.Validation.GradeCurriculares
{
    public class GradeCurricularEstaConsistenteValidation : FiscalBase<GradeCurricular>
    {
        public GradeCurricularEstaConsistenteValidation()
        {
            var gradeCurricularFase = new GradeCurricularPossuiFaseSpecification();
            base.AdicionarRegra("GradeCurricularFase", new Regra<GradeCurricular>(gradeCurricularFase, "Grade Curricular não possui fase cadastrada"));
            
            var gradeCurricularUnidadeCurricular = new GradeCurricularPossuiUnidadeCurricularSpecification();
            base.AdicionarRegra("GradeCurricularUnidadeCurricular", new Regra<GradeCurricular>(gradeCurricularUnidadeCurricular, "Grade Curricular não possui Unidade Curricular cadastrada"));
            
            var gradeCurricularCurso = new GradeCurricularPossuiCursoSpecification();
            base.AdicionarRegra("GradeCurricularCurso", new Regra<GradeCurricular>(gradeCurricularCurso, "Grade Curricular não possui Curso cadastrada"));

            var gradeCurricularCargaHoraria = new GradeCurricularPossuiCargaHorariaSpecification();
            base.AdicionarRegra("GradeCurricularCargaHoraria", new Regra<GradeCurricular>(gradeCurricularCargaHoraria, "Carga horaria tem que ser maior que zero"));
        }    
    }
}