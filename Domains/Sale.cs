using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RealEstateObject.Domains
{

    public class RealEstateObject
    {
        public int CadastralNumber { get; set; }

        public int CustomerId { get; set; }

        public string Location { get; set; }

        public int Estate픤entId { get; set; }

        RealEstateObject(int CadastralNumber, int CustomerId, string Location, int Estate픤entId)
        {
            this.CadastralNumber = CadastralNumber;
            this.CustomerId = CustomerId;
            this.Location = Location;
            this.Estate픤entId = Estate픤entId;
        }








    }


}