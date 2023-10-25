using CaneExtract.Entities.Concrete;
using CaneExtract.Entities.Dtos;

namespace CaneExtract.Business.Abstract
{
    public interface IStiService
    {
        List<Sti> GetAllWithParameters(string prosedureName, StiWithStkParameterDto sTIWithSTKParameterDto);
    }
}
