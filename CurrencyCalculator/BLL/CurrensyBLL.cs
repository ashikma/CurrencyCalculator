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
        List<Currency> list;

        public CurrensyBLL()
        {
            this.currensyDb = new CurrensyDb();
            list = this.currensyDb.GetCurrencies();
        }

       public CurrencyViewModelFull GetViewModel(string from, string to, double sum)
        {
            CurrencyViewModelFull viewModel = new CurrencyViewModelFull();
            viewModel.CurrencyList = this.GetAllCurrencies();
            viewModel.Result = this.Calculate(from, to, sum);
            viewModel.From = this.GetCarency(from);
            viewModel.To = this.GetCarency(to);
            viewModel.Sum = sum;
            return viewModel;
        }

        public CurrencyViewModelSimple GetViewModel()
        {
            CurrencyViewModelSimple viewModel = new CurrencyViewModelSimple();
            viewModel.CurrencyList = this.list;
            
            return viewModel;
        }

        private List<Currency> GetAllCurrencies()
        {
            return this.list;
        }
        private Currency GetCarency(string from)
        {
            foreach(Currency c in this.list)
            {
                if (c.CurrencyCode == from)
                    return c;
            }
            return null;
        }
        private double GetRate(string from)
        {
            List<Currency> list = GetAllCurrencies();
            foreach(Currency c in list)
            {
                if (c.CurrencyCode == from)
                    return c.Rate;
            }
            return 0;
        }

        private double Calculate(string from, string to, double sum)
        {
            if (sum == 0)
                return 0;
            double rateFrom = GetRate(from);
            double rateTo =GetRate(to);
            int unitFrom = GetUnit(from);
            int unitTo = GetUnit(to);
            return (rateFrom / unitFrom) / (rateTo / unitTo) * sum;

        }

        private int GetUnit(string from)
        {
            
            foreach (Currency c in this.list)
            {
                if (c.CurrencyCode == from)
                    return c.Unit;
            }
            return 0;
        }

       }
}