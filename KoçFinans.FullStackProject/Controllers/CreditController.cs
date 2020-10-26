using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using KoçFinans.FullStackProject.Business;
using KoçFinans.FullStackProject.Business.Contracts;
using KoçFinans.FullStackProject.Business.DTO;
using KoçFinans.FullStackProject.Data.Entity;
using KoçFinans.FullStackProject.Utils.Validation;

namespace KoçFinans.FullStackProject.Controllers
{
    public class CreditController : Controller
    {
 
        private readonly ICreditScoreEngine _creditScoreEngine;
        private readonly IValidationService _validationService;

        public CreditController(ICreditScoreEngine creditScoreEngine, IValidationService validationService)
        {
            _creditScoreEngine = creditScoreEngine;

            _validationService = validationService;
           
        }

        public CreditController()
        {
          
        }
     
        public ActionResult CreditResult()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult CreditResult(UserInformation userInformation)
        {
            if (ModelState.IsValid) 
            {
                var values = ViewData.ModelState.Values;
                var errorMessage = _validationService.CheckModelHasErrorMessage(values);

                if (string.IsNullOrEmpty(errorMessage))
                {
                    var result = _creditScoreEngine.ReturnCreditLimit(userInformation);
                   ViewBag.resultLimit = result.Limit;
                   ViewBag.result = result.Result;
                }
                else
                {
                    ViewData["Error"] = errorMessage;
                }

                return View();
            }

            return View();
        }


    }
}