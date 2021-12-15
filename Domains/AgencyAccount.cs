using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository; 

namespace Boom21.Domains
{

    public class AgencyAccount: IIdentifier
    {
        public int Id { get; set; }
        public int AgencyAccountid { get; set; }

        public int OperationNumber { get; set; }


        public AgencyAccount(int agencyAccountid, int operationNumber, int id)
        {
            AgencyAccountid = agencyAccountid;
            OperationNumber = operationNumber;
            Id = id;

        }








    }


}