using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories.ReadOnly
{
    public class UnidadeCurricularReadOnlyRepository : RepositoryBaseReadOnly, IUnidadeCurricularReadOnlyRepository
    {
        public UnidadeCurricular GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From UnidadeCurricular u " +
                          "WHERE u.UnidadeCurricularId ='" + id + "'";

                var unidadeCurricular = cn.Query<UnidadeCurricular>(sql);

                return unidadeCurricular.FirstOrDefault();
            }
        }

        public IEnumerable<UnidadeCurricular> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From UnidadeCurricular";

                var unidadeCurricular = cn.Query<UnidadeCurricular>(sql);

                return unidadeCurricular;
            }
        }
    }
}