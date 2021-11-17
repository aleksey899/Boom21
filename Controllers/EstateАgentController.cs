using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/EstateАgent")]
    public class EstateАgentController : ControllerBase

    [HttpPost("EstateАgentid")]
     public string EstateАgentid(string str)
    {
        return str;// Идентификатор агента недвижимости
    }

    [HttpPost("FirstName")]
    public string FirstName(string str)
    {
        return str;// Имя
    }


    [HttpPost("Phone")]
    public string Phone(string str)
    {
        return str;// Телефон
    }

    [HttpPost("ListClient")]
    public string ListClient(string str)
    {
        return str;// Список клиентов
    }

}
   