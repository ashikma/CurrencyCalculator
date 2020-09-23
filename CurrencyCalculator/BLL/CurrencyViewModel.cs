using CurrencyCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyCalculator.BLL
{
    public class CurrencyViewModelSimple
    {
       public  List<Currency> CurrencyList { get; set; }
      
    }

    public class CurrencyViewModelFull : CurrencyViewModelSimple
    {
       public  double Sum{get;set;}
       public Currency From{get;set;}
       public Currency To{get;set;}
       public double Result { get; set; }
    }
}