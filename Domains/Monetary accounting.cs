using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LogOfRequestsFor.Domains
{

    public class MonetaryAccounting
    {
        public int Balanceid { get; set; }

        public decimal Debit { get; set; }

        public decimal �redit { get; set; }

        public int AgencyAccountid { get; set; }

        MonetaryAccounting(int Balanceid, decimal Debit, decimal �redit, int AgencyAccountid)
        {
            this.Balanceid = Balanceid;
            this.Debit = Debit;
            this.�redit = �redit;
            this.AgencyAccountid = AgencyAccountid;
        }








    }


}