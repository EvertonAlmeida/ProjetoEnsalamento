using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Infra.Data.EntityConfig;

namespace EA.ProjetoEnsalamento.Infra.Data.Context
{
    public class ProjetoEnsalamentoContext : BaseDbContext
    {
        public ProjetoEnsalamentoContext()
            : base("ProjetoEnsalamento")
        {
        }

        public DbSet<Modalidade> Modalidade { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //convetions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //general custon Context properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //ModelConfiguration
            modelBuilder.Configurations.Add(new ModalidadeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// sobrescrever o SaveChanges para definir a DataCadastro ao add no BD
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}