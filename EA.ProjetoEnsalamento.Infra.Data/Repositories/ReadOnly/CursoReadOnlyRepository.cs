using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories.ReadOnly
{
    public class CursoReadOnlyRepository : RepositoryBaseReadOnly, ICursoReadOnlyRepository
    {
        public Curso GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Curso c " +
                          "WHERE c.CursoId ='" + id + "'";

                var curso = cn.Query<Curso>(sql);

                return curso.FirstOrDefault();
            }
        }

        public IEnumerable<Curso> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Curso c " +
                          "inner join Modalidade m " +
                          "on c.ModalidadeId = m.ModalidadeId ";

                var cursos = cn.Query<Curso, Modalidade, Curso>(
                    sql,
                    (c, m) =>
                    {
                        c.Modalidade = m;

                        return c;
                    }, splitOn: "CursoId, ModalidadeId");

                return cursos;
            }
        }
    }
}