using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyCalculator.Models
{
    public class Currency
    {
        public string Name { get; set; }
        public int Unit{get;set;}
        public  string CurrencyCode  { get; set; }
        public  string Country  { get; set; }
        public  double Rate  { get; set; }
    }
}