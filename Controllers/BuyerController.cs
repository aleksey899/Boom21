using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

       namespace Employment.Controllers
    {
    [ApiController]
    [Route("/Buyer")]
    public class BuyerController : ControllerBase
    
        [HttpPost("Viewingrealestate")]
        public string Viewingrealestate(string str)
        {
            return str;// просмотр продающуюся объектов недвижимости
        }

        [HttpPost("Viewingrealestate")]
        public string Viewingrealestate(string str)
        {
            return str;// просмотр выбранной недвижимости
        }

        [HttpPost("Choosingahouse")]
        public string Choosingahouse(string str)
        {
            return str;// выбор дома
        }

        [HttpPost("Payment")]
        public string Payment(string str)
        {
            return str;
        }
        [HttpPost("Conclusionofthecontract")]
        public string Conclusionofthecontract(string str)
        {
            return str;// заключение договора
        }
       
    }   
