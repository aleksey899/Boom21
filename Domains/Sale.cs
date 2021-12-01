using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Sale: MVID
    {
        public int CadastralNumber { get; set; }

        public int CustomerId { get; set; }

        public string Location { get; set; }

        public int Estate픤entId { get; set; }

        public Sale (int CadastralNumber, int CustomerId, string Location, int Estate픤entId)
        {
            this.CadastralNumber = CadastralNumber;
            this.CustomerId = CustomerId;
            this.Location = Location;
            this.Estate픤entId = Estate픤entId;
        }








    }


}