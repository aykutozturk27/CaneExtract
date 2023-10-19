using CaneExtract.Business.Abstract;
using CaneExtract.Business.Constants;
using CaneExtract.Entities.Dtos;
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(STIWithSTKParameterDto sTIWithSTKParameterDto)
        {
            if(ModelState.IsValid)
            {
                var list = _sTIService.GetAllWithParameters(SqlProsedure.GetAllWithParameters, sTIWithSTKParameterDto);
                ViewBag.List = list;
                if(list != null)
                {
                    return RedirectToAction("Detail", list);
                }
                return View(sTIWithSTKParameterDto);
            }
            return View(sTIWithSTKParameterDto);
        }

        public IActionResult Detail()
        {
            var list = ViewBag.List;
            return View(list);
        }
    }
}
