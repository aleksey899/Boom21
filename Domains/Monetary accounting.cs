using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class MonetaryAccounting:IIdentifier
    {
        public int Balanceid { get; set; }

        public decimal Debit { get; set; }

        public decimal Сredit { get; set; }

        public int AgencyAccountid { get; set; }

        MonetaryAccounting(int Balanceid, decimal Debit, decimal Сredit, int AgencyAccountid)
        {
            this.Balanceid = Balanceid;
            this.Debit = Debit;
            this.Сredit = Сredit;
            this.AgencyAccountid = AgencyAccountid;
        }








    }


}