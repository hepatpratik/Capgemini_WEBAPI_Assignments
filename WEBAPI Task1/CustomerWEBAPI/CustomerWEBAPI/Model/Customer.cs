using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerWEBAPI.Model
{
    public class Customer
    {
        public int cid { get; set; }
        public string cname { get; set; }

        public string caddr { get; set; }

        public double contactno { get; set; }

        public string cmailaddr { get; set; }
    }
}
