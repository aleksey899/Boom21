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
    [Route("/AgencyAccount")]
    public class AgencyAccountController : ControllerBase
    {
        [HttpPost("CreateResume")]
        public string CreateResume(string str)
        {
            return str;// создать резюме
        }

        [HttpGet("ViewVacancies")]
        public string ViewVacancies(string str)
        {
            return str;// просмотр вакансий
        }

        [HttpPost("SendRequest")]
        public string SendRequest(string str)
        {
            return str;// отправление заявки
        }

        [HttpGet("ViewResponse")]
        public string ViewResponse(string str)
        {
            return str;// просмотреть ответ
        }

        [HttpPut("Create")]
        public bool Create(AgencyAccount agencyAccount)
        {
            return Storages.AgencyAccountStorage.Create(agencyAccount); ;
        }

        [HttpGet("Read")]
        public AgencyAccount Read(int Id)
        {
            return Storages.AgencyAccountStorage.Read(Id);
        }

        [HttpPut("Update")]
        public AgencyAccount Update(AgencyAccount agencyAccount)
        {
            return Storages.AgencyAccountStorage.Update(agencyAccount);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.AgencyAccountStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.AgencyAccountStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.AgencyAccountStorage.ReadFromXmlFile();
        }

    }
} 
