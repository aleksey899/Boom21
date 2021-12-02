using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Seller: IIdentifier
    {
        public int Sellerid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public int HouseId { get; set; }

        Seller(int Sellerid, string FirstName, string LastName, string Phone, int HouseId)
        {
            this.Sellerid = Sellerid;
            this.FirstName = FirstName;
            this.Phone = Phone;
            this.HouseId = HouseId;
        }








    }


}