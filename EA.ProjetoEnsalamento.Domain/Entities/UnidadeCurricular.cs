using System;

namespace EA.ProjetoEnsalamento.Domain.Entities
{
    public class UnidadeCurricular
    {
        public UnidadeCurricular()
        {
            UnidadeCurricularId = Guid.NewGuid();
        }

        public Guid UnidadeCurricularId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; } 
    }
}