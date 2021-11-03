using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/ViewingRealEstate")]
    public class BuyerController : ControllerBase
    
        [HttpPost("ViewingRealEstate")]
        public string ViewingRealEstate(string str)
        {
            return str;// просмотр продающуюся объектов недвижимости
        }

        [HttpPost("Viewingrealestate")]
        public string ViewingRealEstate(string str)
        {
            return str;// просмотр выбранной недвижимости
        }

        [HttpPost("ChoosingHouse")]
        public string ChoosingHouse(string str)
        {
            return str;// выбор дома
        }

        [HttpPost("PayMent")]
        public string PayMent(string str)
        {
            return str;
        }
        [HttpPost("ConclusionOfTheContract")]
        public string ConclusionOfTheContract(string str)
        {
            return str;// заключение договора
        }

    
}