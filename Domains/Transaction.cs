using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Transaction.Domains
{

    public class Transaction
    {
        public int Transactionid { get; set; }

        public int OperationLog { get; set; }

        public decimal Balance { get; set; }

        Transaction(int Transactionid, int OperationLog, decimal Balance)
        {
            this.Transactionid = Transactionid;
            this.OperationLog = OperationLog;
            this.Balance = Balance;
            
        }








    }


}