using CaneExtract.Core.Entities;

namespace CaneExtract.Entities.Dtos
{
    public class STIWithSTKParameterDto : IDto
    {
        public string? CommodityCode { get; set; }//Malkodu
        public int StartDateInt { get; set; }
        public int EndDateInt { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
    }
}
