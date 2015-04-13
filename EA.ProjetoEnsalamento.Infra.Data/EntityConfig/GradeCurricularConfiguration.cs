using System.Data.Entity.ModelConfiguration;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Infra.Data.EntityConfig
{
    public class GradeCurricularConfiguration : EntityTypeConfiguration<GradeCurricular>
    {

        public GradeCurricularConfiguration()
        {
            HasKey(g => g.GradeCurricularId);

            Ignore(c => c.ResultadoValidacao);

            HasRequired(c => c.Fase)
           .WithMany()
           .HasForeignKey(e => e.FaseId);

            HasRequired(c => c.UnidadeCurricular)
           .WithMany()
           .HasForeignKey(e => e.UnidadeCurricularId);

            HasRequired(c => c.Curso)
            .WithMany()
            .HasForeignKey(e => e.CursoId);

            Property(c => c.CargaHoraria)
             .IsRequired();
        }

    }
}