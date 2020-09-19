using CurrencyCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyCalculator.BLL
{
    public class CurrencyViewModel
    {
       public  List<Currency> CurrencyList { get; set; }
       public double Result { get; set; }
    }
}