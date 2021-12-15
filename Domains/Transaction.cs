using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Transaction:IIdentifier
    {
        public int Id { get; set; }
        public int Transactionid { get; set; }

        public int OperationLog { get; set; }

        public decimal Balance { get; set; }

        public Transaction(int transactionid, int operationLog, decimal balance, int id)
        {
            Transactionid = transactionid;
            OperationLog = operationLog;
            Balance = balance;
            Id = id;
        }








    }


}