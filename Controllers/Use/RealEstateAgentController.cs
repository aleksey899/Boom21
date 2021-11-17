using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/RealEstateAgentController")]
    public class RealEstateAgentController : ControllerBase
    {
   
          [HttpPost("ListOfProperties")]
           public string ListOfProperties(string str)
          {
            return str;// предоставление списка продающуеся недвижимости
          }

         [HttpPost("PermissionToView")]
         public string PermissionToView(string str)
         {
           return str;// получение разрешения на просмотр дома
         }

        [HttpPost("RealestateDemonstrations")]
        public string RealestateDemonstrations(string str)
        {
          return str;// демонстрация недвижимости
        }

        [HttpPost("ConclusionOfTheContract")]
        public string ConclusionOfTheContract(string str)
       {
         return str;// заключение договора
       }
    }
}
