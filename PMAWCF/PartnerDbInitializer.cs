using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PMAWCF
{
    public class PartnerDbInitializer : DropCreateDatabaseAlways<PartnerDB>
    {
        protected override void Seed(PartnerDB context)
        {
            base.Seed(context);
            context.Partners.Add(new Partner() { PartnerId = 1, PartnerName = "ADatum Ltd.", Email = "info@adatum.com", Balance = 533.2m, Classification = "", PType = "Customer", VatRegNo = "A001" });
            context.Partners.Add(new Partner() { PartnerId = 2, PartnerName = "NorthWind Traders Ltd", Email = "info@northwind.com", Balance = 333.2m, Classification = "A", PType = "Vendor" ,VatRegNo="B001"});
            context.Partners.Add(new Partner() { PartnerId = 3, PartnerName = "Contoso Ltd.", Email = "info@contoso.com", Balance = 700.2m, Classification = "B", PType = "Vendor", VatRegNo = "C001" });
            context.Partners.Add(new Partner() { PartnerId = 4, PartnerName = "Fabrikam Ltd.", Email = "info@fabrikam.com", Balance = 803.2m, Classification = "", PType = "Customer", VatRegNo = "D001" });

        }
    }
}
