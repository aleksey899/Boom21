using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LogOfRequestsFor.Domains
{

    public class LogOfRequestsFor
    {
        public int ListClientId { get; set; }

        public int Estate픤entId { get; set; }

        public int CustomerId { get; set; }

        public int SellerId { get; set; }

        LogOfRequestsFor(int Estate픤entid, int ListClientId, int CustomerId, int SellerId)
        {
            this.ListClientId = ListClientId;
            this.Estate픤entId = Estate픤entId;
            this.CustomerId = CustomerId;
            this.SellerId = SellerId;
        }








    }


}