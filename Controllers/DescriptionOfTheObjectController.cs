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
    [Route("/DescriptionOfTheObject")]
    public class DescriptionOfTheObjectController : ControllerBase
    {

        [HttpPut("Create")]
        public bool Create(DescriptionOfTheObject descriptionOfTheObject)
        {
            return Storages.DescriptionOfTheObjectStorage.Create(descriptionOfTheObject); ;
        }

        [HttpGet("Read")]
        public DescriptionOfTheObject Read(int Id)
        {
            return Storages.DescriptionOfTheObjectStorage.Read(Id);
        }

        [HttpPut("Update")]
        public DescriptionOfTheObject Update(DescriptionOfTheObject descriptionOfTheObject)
        {
            return Storages.DescriptionOfTheObjectStorage.Update(descriptionOfTheObject);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.DescriptionOfTheObjectStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.DescriptionOfTheObjectStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.DescriptionOfTheObjectStorage.ReadFromXmlFile();
        }




    }

}
   