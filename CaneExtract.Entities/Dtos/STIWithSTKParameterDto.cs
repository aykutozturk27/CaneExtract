using CaneExtract.Core.Entities;

namespace CaneExtract.Entities.Dtos
{
    public class STIWithSTKParameterDto : IDto
    {
        public string? CommodityCode { get; set; }//Malkodu
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
