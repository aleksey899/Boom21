using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/MonetaryAccounting")]
    public class MonetaryAccountingController : ControllerBase
    {

        [HttpPut("Create")]
        public bool Create(MonetaryAccounting monetaryAccounting)
        {
            return Storages.MonetaryAccountingStorage.Create(monetaryAccounting); ;
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.MonetaryAccountingStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(MonetaryAccounting monetaryAccounting)
        {
            return Storages.MonetaryAccountingStorage.Update(monetaryAccounting);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.MonetaryAccountingStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.MonetaryAccountingStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.MonetaryAccountingStorage.ReadFromXmlFile();
        }




    }


}
   