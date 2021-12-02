using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class EstateАgent:IIdentifier
    {
        public int EstateАgentid { get; set; }

        public string FirstName { get; set; }

        public string Phone { get; set; }

        public int ListClient { get; set; }

        EstateАgent(int EstateАgentid, string FirstName,  string Phone, int ListClient)
        {
            this.EstateАgentid = EstateАgentid;
            this.FirstName = FirstName;
            this.Phone = Phone;
            this.ListClient = ListClient;
        }








    }


}