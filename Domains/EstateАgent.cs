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
        public int Id { get; set; }
        public int EstateАgentid { get; set; }

        public string FirstName { get; set; }

        public string Phone { get; set; }

        public int ListClient { get; set; }

        public EstateАgent(int estateАgentid, string firstName,  string phone, int listClient, int id)
        {
            EstateАgentid = estateАgentid;
            FirstName = firstName;
            Phone = phone;
            ListClient = listClient;
            Id = id;
        }








    }


}