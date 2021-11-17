using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DescriptionOfTheObject.Domains
{

    public class AgencyAccount
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