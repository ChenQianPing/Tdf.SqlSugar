using SqlSugarRepository;
using System.Configuration;

namespace Tdf.SqlSugar
{
    public class SqlSugarRepositoryBase : DbRepository
    {
        private static readonly string SqlServerConnString =
        ConfigurationManager.ConnectionStrings["SqlServerConnString"].ToString();

        private static readonly string OracleConnString =
        ConfigurationManager.ConnectionStrings["OracleConnString"].ToString();

        public ConnectionConfig SqlServerConnection =
            new ConnectionConfig() { ConnectionString = SqlServerConnString, DbType = DbType.SqlServer };

        public ConnectionConfig OracleConnection =
            new ConnectionConfig() { ConnectionString = OracleConnString, DbType = DbType.Oracle };
    }
}
