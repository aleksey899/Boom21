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
    [Route("/Customer")]
    public class CustomerController : ControllerBase
    {
        [HttpPut("Create")]
        public bool Create(Customer customer)
        {
            return Storages.CustomerStorage.Create(customer); ;
        }

        [HttpGet("Read")]
        public Customer Read(int Id)
        {
            return Storages.CustomerStorage.Read(Id);
        }

        [HttpPut("Update")]
        public Customer Update(Customer customer)
        {
            return Storages.CustomerStorage.Update(customer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.CustomerStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.CustomerStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.CustomerStorage.ReadFromXmlFile();
        }




    }
    

}
   