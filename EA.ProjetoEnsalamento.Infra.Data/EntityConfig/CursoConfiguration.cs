using System.Data.Entity.ModelConfiguration;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Infra.Data.EntityConfig
{
    public class CursoConfiguration : EntityTypeConfiguration<Curso>
    {
        public CursoConfiguration()
        {
            HasKey(c => c.CursoId);

            Property(c => c.Nome)
                .IsRequired();

            Property(c => c.NumeroFase)
                .IsRequired();

            Ignore(c => c.ResultadoValidacao);

            HasRequired(c => c.Modalidade)
           .WithMany()
           .HasForeignKey(e => e.ModalidadeId);
        }
    }
}