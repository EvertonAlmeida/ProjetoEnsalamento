using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Specification.Cursos;
using EA.ProjetoEnsalamento.Domain.Validation.Base;

namespace EA.ProjetoEnsalamento.Domain.Validation.Cursos
{
    public class CursoEstaConsistenteValidation : FiscalBase<Curso>
    {
        public CursoEstaConsistenteValidation()
        {
            var cursoModalidade = new CursoPossuiModalidadeCadastradoSpecification();
            base.AdicionarRegra("CursoModalidade", new Regra<Curso>(cursoModalidade,"Curso não possui modalidade cadastrado"));
        }
    }
}