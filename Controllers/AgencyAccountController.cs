using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/AgencyAccount")]
    public class AgencyAccountController : ControllerBase

    [HttpPost("AgencyAccountid")]
    public string AgencyAccountid(string str)
    {
        return str;// Идентификатор учетной записи агентства
    }

    [HttpPost("OperationNumber ")]
    public string OperationNumber(string str)
    {
        return str;// Номер операции
    }

}
   