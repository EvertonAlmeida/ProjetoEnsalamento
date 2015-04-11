using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EA.ProjetoEnsalamento.Infra.Data.Repositories.ReadOnly
{
    public class RepositoryBaseReadOnly
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["ProjetoEnsalamento"].ConnectionString);
            }
        }
    }
}
