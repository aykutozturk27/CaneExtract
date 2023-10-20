﻿using CaneExtract.Core.Entities;

namespace CaneExtract.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> ExecuteListStoreProsedure(string prosedureName, params object[] parameters);
        T ExecuteStoreProsedure(string prosedureName, params object[] parameters);
    }
}
