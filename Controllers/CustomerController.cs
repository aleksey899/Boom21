using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Customer")]
    public class CustomerController : ControllerBase

    [HttpPost("CustomerId")]
     public string CustomerId(string str)
    {
        return str;// Идентификатор клиента
    }

    [HttpPost("FirstName")]
    public string FirstName(string str)
    {
        return str;// Имя
    }

    [HttpPost("LastName")]
    public string LastName(string str)
    {
        return str;// Фамилия
    }

    [HttpPost("Phone")]
    public string Phone(string str)
    {
        return str;// Телефон
    }

    [HttpPost("RealEstatePreference")]
    public string RealEstatePreference(string str)
    {
        return str;// Предпочтение Недвижимости
    }

}
   