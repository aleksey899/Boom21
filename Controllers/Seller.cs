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

    [HttpPost("Realestateplacement")]
    public string Realestateplacement(string str)
    {
        return str;// размещение недвижимости для продажи
    }
    [HttpPost("Providesapreview")]
    public string Providesapreview(string str)
    {
        return str;// предоставление возможности просмотра недвижимости
    }
    [HttpPost("Conclusionofthecontract")]
    public string Conclusionofthecontract(string str)
    {
        return str;// заключение договора

    }
} 