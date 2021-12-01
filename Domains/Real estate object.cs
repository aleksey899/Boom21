using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class RealEstateObject :MVID
    {
        public int Balanceid { get; set; }

        public decimal Debit { get; set; }

        public decimal Ñredit { get; set; }

        public int AgencyAccountid { get; set; }

        RealEstateObject (int Balanceid, decimal Debit, decimal Ñredit, int AgencyAccountid)
        {
            this.Balanceid = Balanceid;
            this.Debit = Debit;
            this.Ñredit = Ñredit;
            this.AgencyAccountid = AgencyAccountid;
        }








    }


}