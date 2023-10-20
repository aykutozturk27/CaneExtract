using CaneExtract.Business.Abstract;
using CaneExtract.Core.Utilities.Configuration;
using CaneExtract.DataAccess.Abstract;
using CaneExtract.Entities.Concrete;
using CaneExtract.Entities.Dtos;

namespace CaneExtract.Business.Concrete.Managers
{
    public class STIManager : ConnectionConfig, ISTIService
    {
        private readonly ISTIDal _sTIDal;

        public STIManager(ISTIDal sTIDal)
        {
            _sTIDal = sTIDal;
        }

        public List<STI> GetAllWithParameters(string prosedureName, STIWithSTKParameterDto sTIWithSTKParameterDto)
        {
            var list = _sTIDal.ExecuteListStoreProsedure(prosedureName, sTIWithSTKParameterDto);

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
