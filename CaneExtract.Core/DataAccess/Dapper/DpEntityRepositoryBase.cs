using CaneExtract.Core.Entities;
using CaneExtract.Core.Utilities.Configuration;
using Dapper;

namespace CaneExtract.Core.DataAccess.Dapper
{
    public class DpEntityRepositoryBase<T> : ConnectionConfig, IEntityRepository<T>
        where T : class, IEntity, new()
    {
        public List<T> ExecuteListStoreProsedure(string prosedureName, object parameters)
        {
            using (var connection = Connection)
            {
                var result = connection.Query<T>(prosedureName, parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public T ExecuteStoreProsedure(string prosedureName, object parameters)
        {
            using (var connection = Connection)
            {
                var result = connection.Query<T>(prosedureName, parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
    }
}
