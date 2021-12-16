using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;
using Boom21.Domains;


namespace Employment.Controllers
{
    [ApiController]
    [Route("/LogOfRequestsFor")]
    public class LogOfRequestsForController : ControllerBase
    {


        [HttpPut("Create")]
        public bool Create(LogOfRequestsFor logOfRequestsFor)
        {
            return Storages.LogOfRequestsForStorage.Create(logOfRequestsFor); 
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.LogOfRequestsForStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(LogOfRequestsFor logOfRequestsFor)
        {
            return Storages.LogOfRequestsForStorage.Update(logOfRequestsFor);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.LogOfRequestsForStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.LogOfRequestsForStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.LogOfRequestsForStorage.ReadFromXmlFile();
        }



    }


}
   