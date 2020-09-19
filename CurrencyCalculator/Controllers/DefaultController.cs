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
        CurrencyViewModel viewModel;

        public DefaultController()
        {
            this.currensyBLL = new CurrensyBLL();
        }

        [HttpGet]
        public ActionResult Index()
        {
           
            List<Currency> list = this.currensyBLL.GetAllCurrencies();
            return View(list);
        }

        [HttpPost]
        public ActionResult Calculate(string from, string to, double sum)
        {
           
            double result = this.currensyBLL.Calculate( from,  to,  sum);
            
            return View(result);
        }
    }
}