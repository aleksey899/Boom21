using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class AgencyAccount: MVID
    {
        public int AgencyAccountid { get; set; }

        public int OperationNumber { get; set; }


        AgencyAccount(int AgencyAccountid, int OperationNumber)
        {
            this.AgencyAccountid = AgencyAccountid;
            this.OperationNumber = OperationNumber;
           
        }








    }


}