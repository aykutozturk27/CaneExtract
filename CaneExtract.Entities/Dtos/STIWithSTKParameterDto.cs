using CaneExtract.Core.Entities;

namespace CaneExtract.Entities.Dtos
{
    public class STIWithSTKParameterDto : IDto
    {
        public string? CommodityCode { get; set; }//Malkodu
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
