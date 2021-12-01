using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Estate픤ent:MVID
    {
        public int Estate픤entid { get; set; }

        public string FirstName { get; set; }

        public string Phone { get; set; }

        public int ListClient { get; set; }

        Estate픤ent(int Estate픤entid, string FirstName,  string Phone, int ListClient)
        {
            this.Estate픤entid = Estate픤entid;
            this.FirstName = FirstName;
            this.Phone = Phone;
            this.ListClient = ListClient;
        }








    }


}