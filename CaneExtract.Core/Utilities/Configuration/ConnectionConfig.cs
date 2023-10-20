using Microsoft.Data.SqlClient;

namespace CaneExtract.Core.Utilities.Configuration
{
    public class ConnectionConfig
    {
        //private SqlConnection _connection;

        //public SqlConnection Connection
        //{
        //    get
        //    {
        //        if (_connection == null)
        //            _connection = new SqlConnection(ConnString);
        //        return _connection;
        //    }
        //}

        //public string ConnString
        //{
        //    get
        //    {
        //        return CoreConfig.GetConnectionString("Default");
        //    }
        //}

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(CoreConfig.GetConnectionString("Default"));
            }
        }
    }
}
