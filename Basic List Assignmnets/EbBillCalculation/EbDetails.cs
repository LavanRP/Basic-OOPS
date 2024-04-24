using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBillCalculation
{
    public class EbDetails
    {
        public string UserName {get;set;}
        public string UserId {get;set;}
        public string PhoneNo {get;set;}
        public string MailId {get;set;}
        public int UnitUsed {get;set;}
        public int Amount {get;set;}
        public string BillId {get;set;}

        public void CalculateAmount()
        {
            Amount=UnitUsed*5;
        }
    }
}