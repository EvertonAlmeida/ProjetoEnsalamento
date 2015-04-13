using System;
using EA.ProjetoEnsalamento.Domain.Validation.Cursos;
using EA.ProjetoEnsalamento.Domain.ValueObjects;

namespace EA.ProjetoEnsalamento.Domain.Entities
{
    public class Curso
    {
        public Curso()
        {
            CursoId = Guid.NewGuid();
        }

        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public int NumeroFase { get; set; }
        public Guid ModalidadeId { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }

        public bool IsValid()
        {
            var fiscal = new CursoEstaConsistenteValidation();

            ResultadoValidacao = fiscal.Validar(this);

            return ResultadoValidacao.IsValid;
        }
    }
}