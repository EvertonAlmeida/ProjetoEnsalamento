using System.Data.Entity.ModelConfiguration;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Infra.Data.EntityConfig
{
    public class FaseConfiguration : EntityTypeConfiguration<Fase>
    {
        public FaseConfiguration()
        {
            HasKey(m => m.FaseId);

            Property(m => m.Descricao)
                .IsRequired();
        }
    }
}