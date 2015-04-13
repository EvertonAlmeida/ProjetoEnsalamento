using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories.ReadOnly
{
    public class GradeCurricularReadOnlyRepository : RepositoryBaseReadOnly, IGradeCurricularReadOnlyRepository
    {
        public GradeCurricular GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From GradeCurricular G " +
                          "WHERE g.GradeCurricularId ='" + id + "'";

                var gradeCurricular = cn.Query<GradeCurricular>(sql);

                return gradeCurricular.FirstOrDefault();
            }
        }

        public IEnumerable<GradeCurricular> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From GradeCurricular g " +
                          "inner join Fase f " +
                          "on g.FaseId = f.FaseId " +
                          "inner join UnidadeCurricular u " +
                          "on g.UnidadeCurricularId = u.UnidadeCurricularId " +
                          "inner join Curso c " +
                          "on g.CursoId = c.CursoId ";

                var gradeCurricular = cn.Query<GradeCurricular, Fase, UnidadeCurricular, Curso, GradeCurricular>(
                    sql,
                    (g, f, u, c) =>
                    {
                        g.Fase = f;
                        g.UnidadeCurricular = u;
                        g.Curso = c;

                        return g;
                    }, splitOn: "GradeCurricularId, FaseId, UnidadeCurricularId, CursoId");

                return gradeCurricular;
            }
        }
    }
}