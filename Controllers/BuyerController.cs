using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace Employment.Controllers
{
    [ApiController]
    [Route("/BuyerController")]
    public class BuyerController : ControllerBase
    {
        [HttpPost("ViewingRealEstate")]
        public string ViewingRealEstate(string str)
        {
            return str;// просмотр продающуюся объектов недвижимости
        }

        [HttpPost("ViewingRealEstate")]
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
        public string Payment(string str)
        {
            return str;
        }
        [HttpPost("ConclusionOfTheContract")]
        public string ConclusionOfTheContract(string str)
        {
            return str;// заключение договора
        }
        [HttpPut]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}
