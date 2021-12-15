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
    [Route("/RealEstateObject")]
    public class RealEstateObjectController : ControllerBase
    {

        [HttpPut("Create")]
        public bool Create(RealEstateObject realEstateObject)
        {
            return Storages.RealEstateObjectStorage.Create(realEstateObject); ;
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.RealEstateObjectStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(RealEstateObject realEstateObject)
        {
            return Storages.RealEstateObjectStorage.Update(realEstateObject);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.RealEstateObjectStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.RealEstateObjectStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.RealEstateObjectStorage.ReadFromXmlFile();
        }


    }



}
   