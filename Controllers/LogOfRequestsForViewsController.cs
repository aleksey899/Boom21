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
    [Route("/LogOfRequestsForViews")]
    public class LogOfRequestsForViewsController : ControllerBase
    {
        [HttpPut("Create")]
        public bool Create(LogOfRequestsForViews logOfRequestsForViews)
        {
            return Storages.LogOfRequestsForViewsStorage.Create(logOfRequestsForViews); ;
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.LogOfRequestsForViewsStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(LogOfRequestsForViews logOfRequestsForViews)
        {
            return Storages.LogOfRequestsForViewsStorage.Update(logOfRequestsForViews);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.LogOfRequestsForViewsStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.LogOfRequestsForViewsStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.LogOfRequestsForViewsStorage.ReadFromXmlFile();
        }



    }


}
   