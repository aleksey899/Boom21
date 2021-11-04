using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/SellerController")]
    public class SellerController : ControllerBase
    {
 
        [HttpPost("RealEstatePlacement")]
        public string RealEstatePlacement(string str)
        {
          return str;// размещение недвижимости для продажи
        }
        [HttpPost("ProvidesPreview")]
        public string ProvidesPreview(string str)
        {
          return str;// предоставление возможности просмотра недвижимости
        }
        [HttpPost("ConclusionOfTheContract")]
        public string ConclusionOfTheContract(string str)
        {
          return str;// заключение договора
        }
    
   }
   
} 
