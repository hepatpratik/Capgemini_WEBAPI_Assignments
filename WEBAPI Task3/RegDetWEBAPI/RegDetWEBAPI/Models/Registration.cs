using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegDetWEBAPI.Models
{
    public partial class Registration
    {
        public int Rid { get; set; }
        public string Fname { get; set; }
        public string Mailid { get; set; }
        public int Contactno { get; set; }
        public string Exp { get; set; }
        public string Skillset { get; set; }
    }
}
