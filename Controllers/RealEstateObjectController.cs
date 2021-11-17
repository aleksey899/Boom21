using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/RealEstateObject")]
    public class RealEstateObjectController : ControllerBase

    [HttpPost("CadastralNumber")]
     public string CadastralNumber(string str)
    {
        return str;// Кадастровый номер
    }

    [HttpPost("CustomerId")]
    public string CustomerId(string str)
    {
        return str;// Идентификатор клиента
    }


    [HttpPost("Location")]
    public string Location(string str)
    {
        return str;// Местоположение
    }

    [HttpPost("EstateАgentId")]
    public string EstateАgentId(string str)
    {
        return str;// Идентификатор агентов по недвижимости
    }

}
   