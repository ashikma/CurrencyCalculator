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
        [HttpGet]
        public ActionResult Index()
        {
            CurrensyBLL currensyBLL = new CurrensyBLL();
            List<Currency> list = currensyBLL.GetAllCurrencies();
            return View(list);
        }
    }
}