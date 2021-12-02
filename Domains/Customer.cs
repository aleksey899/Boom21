using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Customer: IIdentifier
    {
        public int Id { get; set; }
        public int Customerid { get ; set ; }
        
        public string FirstName { get; set ; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string RealEstatePreference { get; set; }

        Customer(int Customerid, string FirstName, string LastName, string Phone, string RealEstatePreference)
        {
            this.Customerid = Customerid;
            this.FirstName = FirstName;
            this.Phone = Phone;
            this.RealEstatePreference = RealEstatePreference;
        }








    }









}
