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
    [Route("/Sale")]
    public class SaleController : ControllerBase

    {

        [HttpPut("Create")]
        public bool Create(Sale sale)
        {
            return Storages.SaleStorage.Create(sale); ;
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.SaleStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(Sale sale)
        {
            return Storages.SaleStorage.Update(sale);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.SaleStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.SaleStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.SaleStorage.ReadFromXmlFile();
        }

    }


}
   