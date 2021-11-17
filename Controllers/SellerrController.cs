using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Seller")]
    public class SellerController : ControllerBase

    [HttpPost("Sellerid")]
     public string Sellerid(string str)
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

    [HttpPost("HouseId")]
    public string HouseId(string str)
    {
        return str;// Идентификатор дома
    }

}
   