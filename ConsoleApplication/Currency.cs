using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApplication
{
    public class Currency
    {
        int unit;

        public string Name { get; set; }
        public int Unit
        {
            get { return this.unit; }
            set { if (value>0 )
                    this.unit = value;
            else
                    throw new Exception("lkglkflkglklg");
            }
        }

    }
}