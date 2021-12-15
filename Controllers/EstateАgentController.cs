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
    [Route("/EstateАgent")]
    public class EstateАgentController : ControllerBase
    {

        [HttpPut("Create")]
        public bool Create(EstateАgent estateАgent)
        {
            return Storages.EstateАgentStorage.Create(estateАgent); ;
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.EstateАgentStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(EstateАgent estateАgent)
        {
            return Storages.EstateАgentStorage.Update(estateАgent);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.EstateАgentStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.EstateАgentStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.EstateАgentStorage.ReadFromXmlFile();
        }



    }

}
   