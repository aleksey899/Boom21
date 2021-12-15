using Microsoft.AspNetCore.Mvc;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Transaction")]
    public class TransactionController : ControllerBase
    {
        [HttpPut("Create")]
        public bool Create(Transaction transaction)
        {
            return Storages.TransactionStorage.Create(transaction); ;
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.TransactionStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(Transaction transaction)
        {
            return Storages.TransactionStorage.Update(transaction);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.TransactionStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.TransactionStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.TransactionStorage.ReadFromXmlFile();
        }
    }
}