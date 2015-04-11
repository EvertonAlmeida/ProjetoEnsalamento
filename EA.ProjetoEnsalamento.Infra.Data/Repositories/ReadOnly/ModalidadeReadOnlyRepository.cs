using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories.ReadOnly
{
    public class ModalidadeReadOnlyRepository : RepositoryBaseReadOnly, IModalidadeReadOnlyRepository
    {
        public Modalidade GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Modalidade m " +
                          "WHERE m.ModalidadeId ='" + id + "'";

                var modaidade = cn.Query<Modalidade>(sql);

                return modaidade.FirstOrDefault();
            }
        }

        public IEnumerable<Modalidade> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Modalidade";

                var modalidade = cn.Query<Modalidade>(sql);

                return modalidade;
            }
        }
    }
}
