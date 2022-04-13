using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductdetWEBAPI.Models
{
    public partial class Staffdet
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Exp { get; set; }
        public string Category { get; internal set; }
    }
}
