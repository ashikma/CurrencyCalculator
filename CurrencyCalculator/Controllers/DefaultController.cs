using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CurrencyCalculator.BLL;
using CurrencyCalculator.Models;

namespace CurrencyCalculator.Controllers
{
    public class DefaultController : Controller
    {

        CurrensyBLL currensyBLL;
        

        public DefaultController()
        {
            this.currensyBLL = new CurrensyBLL();
        }

        [HttpGet]
        public ActionResult Index()
        {
           
            CurrencyViewModelSimple  cms= this.currensyBLL.GetViewModel();
            return View(cms);
        }

        [HttpPost]
        public ActionResult Calculate(string from, string to, double sum)
        {
            CurrencyViewModelFull cmf = this.currensyBLL.GetViewModel(from, to, sum);
            return View("index", cmf);
        }
    }
}