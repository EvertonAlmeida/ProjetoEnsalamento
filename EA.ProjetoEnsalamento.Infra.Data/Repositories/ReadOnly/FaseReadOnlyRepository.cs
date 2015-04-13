using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories.ReadOnly
{
    public class FaseReadOnlyRepository : RepositoryBaseReadOnly, IFaseReadOnlyRepository
    {
        public Fase GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Fase f " +
                          "WHERE f.FaseId ='" + id + "'";

                var fase = cn.Query<Fase>(sql);

                return fase.FirstOrDefault();
            }
        }

        public IEnumerable<Fase> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Fase";

                var fase = cn.Query<Fase>(sql);

                return fase;
            }
        }
    }
}