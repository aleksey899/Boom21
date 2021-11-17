using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Sale")]
    public class SaleController : ControllerBase

    [HttpPost("ListDepositsId")]
    public string ListDepositsId(string str)
    {
        return str;// Идентификатор Списка Депозитов
    }

    [HttpPost("ConcludedСontracts")]
    public string ConcludedСontracts(string str)
    {
        return str;// Заключенные контракты
    }


    [HttpPost("ListСlients")]
    public string ListСlients(string str)
    {
        return str;// Список клиентов
    }
    [HttpPost("CustomerId")]
    public string CustomerId(string str)
    {
            return str;// Идентификатор клиента
    }

    [HttpPost("Transaction")]
    public string Transaction(string str)
    {
        return str;// Операция
    }


}
   