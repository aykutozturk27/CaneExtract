using CaneExtract.Core.Entities;

namespace CaneExtract.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> ExecuteListStoreProsedure(string prosedureName, object parameters);
        T ExecuteStoreProsedure(string prosedureName, object parameters);
    }
}
