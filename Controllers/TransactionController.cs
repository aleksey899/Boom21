using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Transaction")]
    public class TransactionController : ControllerBase

    [HttpPost("Transactionid")]
    public string Transactionid(string str)
    {
        return str;// Идентификатор транзакции
    }

    [HttpPost("OperationLog")]
    public string OperationLog(string str)
    {
        return str;// Журнал операций
    }


    [HttpPost("Balance")]
    public string Balance(string str)
    {
        return str;// Баланс
    }

    [HttpPut()]
    public string Create(string str)
    {
        return str;
    }

    [HttpGet()]
    public string Read(string str)
    {
        return str;
    }

    [HttpPatch()]
    public string Update(string str)
    {
        return str;
    }

    [HttpDelete()]
    public string Delete(string str)
    {
        return str;
    }



}
