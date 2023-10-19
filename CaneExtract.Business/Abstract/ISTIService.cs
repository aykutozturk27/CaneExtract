using CaneExtract.Entities.Concrete;
using CaneExtract.Entities.Dtos;

namespace CaneExtract.Business.Abstract
{
    public interface ISTIService
    {
        List<STI> GetAllWithParameters(string prosedureName, STIWithSTKParameterDto sTIWithSTKParameterDto);
    }
}
