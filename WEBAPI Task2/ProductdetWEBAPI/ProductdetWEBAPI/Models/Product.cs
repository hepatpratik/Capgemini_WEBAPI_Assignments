using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductdetWEBAPI.Models
{
    public partial class Product
    {
        [Key]
        public int Pcode { get; set; }
        public string Pname { get; set; }
        public int? UnitPrice { get; set; }
        public string Pdesc { get; set; }
        public string Category { get; set; }
        public int? Stockinhand { get; set; }
    }
}
