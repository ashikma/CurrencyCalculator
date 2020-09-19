using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CurrencyCalculator.Models;
using CurrencyCalculator.DAL;

namespace CurrencyCalculator.BLL
{
    public class CurrensyBLL
    {
        CurrensyDb currensyDb;

        public CurrensyBLL()
        {
            this.currensyDb = new CurrensyDb();
        }
        public List<Currency> GetAllCurrencies()
        {
            return this.currensyDb.GetCurrencies();
        }

    }
}