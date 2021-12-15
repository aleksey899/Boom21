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
        public int Id { get; set; }
        public int Sellerid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public int HouseId { get; set; }

       public Seller(int sellerid, string firstName, string lastName, string phone, int houseId, int id)
        {
            Sellerid = sellerid;
            FirstName = firstName;
            Phone = phone;
            HouseId = houseId;
            Id =  id;
        }








    }


}