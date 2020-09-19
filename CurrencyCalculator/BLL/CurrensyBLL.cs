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

        public CurrencyViewModel GetViewModel(string from, string to, double sum)
        {
            CurrencyViewModel viewModel = new CurrencyViewModel();
            viewModel.CurrencyList = GetAllCurrencies();
            viewModel.Result = this.Calculate(from, to, sum);
            return viewModel;
        }

        public List<Currency> GetAllCurrencies()
        {
            return this.currensyDb.GetCurrencies();
        }

        public double GetRate(string from)
        {
            List<Currency> list = GetAllCurrencies();
            foreach(Currency c in list)
            {
                if (c.CurrencyCode == from)
                    return c.Rate;
            }
            return 0;
        }

        public double Calculate(string from, string to, double sum)
        {
            if (sum == 0)
                return 0;
            double rateFrom = GetRate(from);
            double rateTo =GetRate(to);
            int unitFrom = GetUnit(from);
            int unitTo = GetUnit(to);
            return (rateFrom / unitFrom) / (rateTo / unitTo) * sum;

        }

        public int GetUnit(string from)
        {
            List<Currency> list = GetAllCurrencies();
            foreach (Currency c in list)
            {
                if (c.CurrencyCode == from)
                    return c.Unit;
            }
            return 0;
        }

        internal double Calculate(string v1, string from, string v2, string to, double v3, double sum)
        {
            throw new NotImplementedException();
        }
    }
}