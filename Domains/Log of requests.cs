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
        public int Id { get; set; }
        public int ListClientId { get; set; }

        public int EstateАgentId { get; set; }

        public int CustomerId { get; set; }

        public int SellerId { get; set; }

        public LogOfRequestsFor(int estateАgentid, int listClientId, int customerId, int sellerId, int id)
        {
            ListClientId = listClientId;
            EstateАgentId = estateАgentid;
            CustomerId = customerId;
            SellerId = sellerId;
            Id = id;
        }








    }


}