using CaneExtract.Entities.Concrete;
using CaneExtract.Entities.Dtos;

namespace CaneExtract.MvcWebUI.Models
{
    public class GeneralModel
    {
        public STIWithSTKParameterDto STIWithSTKParameter { get; set; }
        public List<STI> STI { get; set; }
    }
}
