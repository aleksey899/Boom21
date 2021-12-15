using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class RealEstateObject :IIdentifier
    {
        public int Id { get; set; }
        public int Balanceid { get; set; }

        public decimal Debit { get; set; }

        public decimal Сredit { get; set; }

        public int AgencyAccountid { get; set; }

        public RealEstateObject(int balanceid, decimal debit, decimal credit, int agencyAccountid, int id)
        {
            Balanceid = balanceid;
            Debit = debit;
            Сredit = credit;
            AgencyAccountid = agencyAccountid;
            Id = id;
        }








    }


}