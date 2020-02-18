using Shopping.Application.Services.Interfaces;
using Shopping.Domain.Entities.Entities;
using Shopping.Endpoint.ViewModel;
using Shopping.Utilities.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Endpoint.MVC.Controllers
{
    public class SellController : Controller
    {
        private readonly IFactorService factorService;
        private readonly IMapperFacade mapperFacade;

        public SellController(IFactorService factorService, IMapperFacade mapperFacade)
        {
            this.factorService = factorService;
            this.mapperFacade = mapperFacade;
        }
        // GET: Sell
        public ActionResult Index()
        {
            var list = factorService.GetAll().Select(x => mapperFacade.Map<Factor, FactorListModel>(x)).ToList();

            return View(list);
        }

        public ActionResult Create()
        {
            var model = new SellModel();
            model.FactorNumber = factorService.GetNewFactorNumber();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(SellModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = mapperFacade.CreateMapAndMap<SellModel, Factor>(model);
                var result = factorService.Add(entity);

                // return success json result

            }

            // return unsuccess json result


            return View(model);
        }
    }
}