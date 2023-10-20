using CaneExtract.Business.Abstract;
using CaneExtract.Business.Constants;
using CaneExtract.Entities.Dtos;
using CaneExtract.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaneExtract.MvcWebUI.Controllers
{
    public class STIController : Controller
    {
        private readonly ISTIService _sTIService;

        public STIController(ISTIService sTIService)
        {
            _sTIService = sTIService;
        }

        public IActionResult Index()
        {
            DateTime startDate = new DateTime(2016, 01, 01);
            DateTime endDate = new DateTime(2018, 01, 01);
            var list = _sTIService.GetAllWithParameters(SqlProsedure.GetAllWithParameters, 
                new STIWithSTKParameterDto() { CommodityCode = "1", StartDate = Convert.ToInt32(startDate.ToOADate()), EndDate = Convert.ToInt32(endDate.ToOADate()) });
            var result = new GeneralModel
            {
                STI = list
            };
            return View(result);
        }

        [HttpPost]
        public ActionResult GetSTIByParameter(string commodityCode, DateTime startDate, DateTime endDate)
        {
            if (ModelState.IsValid)
            {
                commodityCode = string.IsNullOrEmpty(commodityCode) ? "" : commodityCode;
                var list = _sTIService.GetAllWithParameters(SqlProsedure.GetAllWithParameters,
                    new STIWithSTKParameterDto() { CommodityCode = commodityCode, StartDate = Convert.ToInt32(startDate.ToOADate()), EndDate = Convert.ToInt32(endDate.ToOADate()) });
                if (list != null)
                {
                    return Json(list);
                }
                return Json(list);
            }
            return Json(new object[] { "hata" });
        }
    }
}
