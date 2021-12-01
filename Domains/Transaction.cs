using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Transaction:MVID
    {
        public int Transactionid { get; set; }

        public int OperationLog { get; set; }

        public decimal Balance { get; set; }

        public Transaction(int transactionid, int operationLog, decimal balance)
        {
            this.Transactionid = Transactionid;
            this.OperationLog = OperationLog;
            this.Balance = Balance;
            
        }








    }


}