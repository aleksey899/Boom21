using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/MonetaryAccounting")]
    public class MonetaryAccountingController : ControllerBase

    [HttpPost("Balanceid")]
    public string Balanceid(string str)
    {
        return str;// Идентификатор баланса
    }

    [HttpPost("Debit ")]
    public string Debit(string str)
    {
        return str;// Дебит
    }


    [HttpPost("Сredit")]
    public string Сredit(string str)
    {
        return str;// Кредит
    }

    [HttpPost("AgencyAccountid")]
    public string AgencyAccountid(string str)
    {
        return str;// Идентификатор учетной записи агентства
    }

}
   