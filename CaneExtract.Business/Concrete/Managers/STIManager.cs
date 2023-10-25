using CaneExtract.Business.Abstract;
using CaneExtract.Core.Utilities.Configuration;
using CaneExtract.DataAccess.Abstract;
using CaneExtract.Entities.Concrete;
using CaneExtract.Entities.Dtos;

namespace CaneExtract.Business.Concrete.Managers
{
    public class StiManager : ConnectionConfig, IStiService
    {
        private readonly IStiDal _sTIDal;

        public StiManager(IStiDal sTIDal)
        {
            _sTIDal = sTIDal;
        }

        public List<Sti> GetAllWithParameters(string prosedureName, StiWithStkParameterDto sTIWithSTKParameterDto)
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
