using CurrencyCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyCalculator.BLL
{
    public class LoginBLL
    {

        public bool IfUserExist( BaseUser baseUser)
        {
            return baseUser.NickName == "alex" && baseUser.Password == "1234";
            // connect to database to check if user exist
        }
    }
}