using System;

namespace EA.ProjetoEnsalamento.Domain.Entities
{
    public class Modalidade
    {
        public Modalidade()
        {
            ModalidadeId = Guid.NewGuid();
        }

        public Guid ModalidadeId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}