using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegDetWEBAPI.Models
{
    public partial class Product
    {
        public int Pcode { get; set; }
        public string Pname { get; set; }
        public int? UnitPrice { get; set; }
        public string Pdesc { get; set; }
        public string Category { get; set; }
        public int? Stockinhand { get; set; }
    }
}
