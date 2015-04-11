
using EA.ProjetoEnsalamento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace EA.ProjetoEnsalamento.Infra.Data.EntityConfig
{
    public class ModalidadeConfiguration : EntityTypeConfiguration<Modalidade>
    {

        public ModalidadeConfiguration()
        {
            HasKey(m => m.ModalidadeId);

            Property(m => m.Nome)
                .IsRequired();
        }
    }
}
