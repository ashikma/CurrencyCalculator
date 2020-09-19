using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CurrencyCalculator.Models;

namespace CurrencyCalculator.DAL
{
    public class CurrensyDb
    {

        public List<Currency> GetCurrencies()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("https://www.boi.org.il/currency.xml");
            DataTable dt = ds.Tables[1];
            List<Currency> list = new List<Currency>();
            foreach(DataRow dr in dt.Rows)
            {
                Currency c = new Currency();
                c.Country = dr["Country"].ToString();
                c.CurrencyCode = dr["CurrencyCode"].ToString();
                c.Name = dr["Name"].ToString();
                c.Rate = double.Parse(dr["Rate"].ToString());
                c.Unit = int.Parse(dr["Unit"].ToString());
                list.Add(c);
            }
            return list;
        }

    }
}