using System;

namespace EA.ProjetoEnsalamento.Domain.Entities
{
    public class Fase
    {
        public Fase()
        {
            FaseId = Guid.NewGuid();
        }

        public Guid FaseId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}