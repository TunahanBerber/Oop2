using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class CorporateCustomer:Customer  //Tüzel Müşteri 
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
