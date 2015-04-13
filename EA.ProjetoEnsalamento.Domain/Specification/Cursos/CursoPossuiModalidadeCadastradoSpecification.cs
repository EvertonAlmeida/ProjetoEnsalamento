using System;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Specification;

namespace EA.ProjetoEnsalamento.Domain.Specification.Cursos
{
    public class CursoPossuiModalidadeCadastradoSpecification : ISpecification<Curso>
    {
        public bool IsSatisfiedBy(Curso curso)
        {
            return curso.ModalidadeId != Guid.Empty;
        }
    }
}