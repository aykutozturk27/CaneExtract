using CaneExtract.Core.DataAccess.EntityFramework;
using CaneExtract.DataAccess.Abstract;
using CaneExtract.DataAccess.Concrete.EntityFramework.Contexts;
using CaneExtract.Entities.Concrete;

namespace CaneExtract.DataAccess.Concrete.EntityFramework
{
    public class EfSTIDal : EfEntityRepositoryBase<STI, CaneExtractContext>, ISTIDal
    {
    }
}
