using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/LogOfRequestsForViews")]
    public class LogOfRequestsForViewsController : ControllerBase

    [HttpPost("ListClientId")]
    public string ListClientId(string str)
    {
        return str;// Идентификатор списка клиентов
    }

    [HttpPost("EstateАgentId ")]
    public string EstateАgentId(string str)
    {
        return str;// Агенты по недвижимости
    }

    [HttpPost("CustomerId")]
    public string CustomerId(string str)
    {
        return str;// Идентификатор клиента
    }

    [HttpPost("SellerId")]
    public string SellerId(string str)
    {
        return str;// Идентификатор продавца
    }


}
   