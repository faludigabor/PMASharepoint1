using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMAWCF
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string VatRegNo { get; set; }
        public string Email { get; set; }

        public decimal Balance { get; set; }
        public string PType { get; set; }
        public string Classification { get; set; }
        

    }
}