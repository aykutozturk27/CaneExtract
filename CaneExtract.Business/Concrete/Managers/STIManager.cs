using CaneExtract.Business.Abstract;
using CaneExtract.DataAccess.Abstract;
using CaneExtract.Entities.Concrete;
using CaneExtract.Entities.Dtos;

namespace CaneExtract.Business.Concrete.Managers
{
    public class STIManager : ISTIService
    {
        private readonly ISTIDal _iStiDAl;

        public STIManager(ISTIDal iStiDAl)
        {
            _iStiDAl = iStiDAl;
        }

        public List<STI> GetAllWithParameters(string prosedureName, STIWithSTKParameterDto sTIWithSTKParameterDto)
        {
            var list = _iStiDAl.ExecuteListStoreProsedure(prosedureName, sTIWithSTKParameterDto);
            var stock = 0;
            foreach (var item in list)
            {
                if (item.TransactionType == 0)
                    stock += item.Quantity;
                else
                    stock -= item.Quantity;
                item.Stock = stock;
            }
            return list;
        }
    }
}
