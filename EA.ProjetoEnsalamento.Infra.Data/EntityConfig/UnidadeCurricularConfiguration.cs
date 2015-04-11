
using EA.ProjetoEnsalamento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace EA.ProjetoEnsalamento.Infra.Data.EntityConfig
{
    public class UnidadeCurricularConfiguration : EntityTypeConfiguration<UnidadeCurricular>
    {

        public UnidadeCurricularConfiguration()
        {
            HasKey(m => m.UnidadeCurricularId);

            Property(m => m.Nome)
                .IsRequired();
        }
    }
}
