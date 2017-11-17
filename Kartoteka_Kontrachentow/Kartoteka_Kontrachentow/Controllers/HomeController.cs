using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kartoteka_Kontrachentow.Common;
using Kartoteka_Kontrachentow.ViewModels;
using Logic.Interfaces.Logics;

namespace Kartoteka_Kontrachentow.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContractorLogic _contractorLogic;

        public HomeController(IContractorLogic contractorLogic)
        {
            _contractorLogic = contractorLogic;
        }
        public ActionResult Index()
        {
            var allContractor = _contractorLogic.GetAll();
            var model = ContractorMapper.MapContractor(allContractor) ?? throw new ArgumentNullException("ContractorMapper.MapContractor(allContractor)");
            return View(model);
        }
        [HttpPost]
        public ActionResult AddContractor(ContractorViewModel model)
        {
            var message = "";
            if (ModelState.IsValid)
            {
                var mapedModel = ContractorMapper.MapContractor(model);
                _contractorLogic.Add(mapedModel);
                return RedirectToAction("Index");
            }
            message = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
            return View();
        }
        public ActionResult Contractor()
        {
            return View("AddContractor");
        }
    }
}