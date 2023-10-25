using CaneExtract.Business.Abstract;
using CaneExtract.Business.Constants;
using CaneExtract.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CaneExtract.MvcWebUI.Controllers
{
    public class StiController : Controller
    {
        private readonly IStiService _sTIService;

        public StiController(IStiService sTIService)
        {
            _sTIService = sTIService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GetStiList(StiWithStkParameterDto stiWithSTKParameter)
        {
            var startDate = DateTime.Parse(stiWithSTKParameter.StartDate);
            var endDate = DateTime.Parse(stiWithSTKParameter.EndDate);
            var commodityCode = stiWithSTKParameter.CommodityCode;
            var list = _sTIService.GetAllWithParameters(SqlProsedure.GetAllWithParameters,
                new StiWithStkParameterDto() { CommodityCode = commodityCode, StartDateInt = Convert.ToInt32(startDate.ToOADate()), EndDateInt = Convert.ToInt32(endDate.ToOADate()),
                StartDate = stiWithSTKParameter.StartDate, EndDate = stiWithSTKParameter.EndDate});
            return JsonConvert.SerializeObject(list);
        }
    }
}
