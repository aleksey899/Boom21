using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/RealEstateAgent")]
    public class RealEstateAgentController : ControllerBase

    [HttpPost("Listofproperties")]
     public string Viewingrealestate(string str)
    {
        return str;// предоставление списка продающуеся недвижимости
    }

    [HttpPost("Permissiontoview")]
    public string Permissiontoview(string str)
    {
        return str;// получение разрешения на просмотр дома
    }

    [HttpPost("Realestatedemonstrations")]
    public string Choosingahouse(string str)
    {
        return str;// демонстрация недвижимости
    }

    [HttpPost("Conclusionofthecontract")]
    public string Conclusionofthecontract(string str)
    {
        return str;// заключение договора
    }
}
   