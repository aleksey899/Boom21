using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class LogOfRequestsFor:IIdentifier
    {
        public int ListClientId { get; set; }

        public int EstateАgentId { get; set; }

        public int CustomerId { get; set; }

        public int SellerId { get; set; }

        LogOfRequestsFor(int EstateАgentid, int ListClientId, int CustomerId, int SellerId)
        {
            this.ListClientId = ListClientId;
            this.EstateАgentId = EstateАgentId;
            this.CustomerId = CustomerId;
            this.SellerId = SellerId;
        }








    }


}