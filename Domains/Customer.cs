using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Customer.Domains
{

    public class Customer
    {
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
