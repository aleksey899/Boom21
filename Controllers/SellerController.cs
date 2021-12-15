using Microsoft.AspNetCore.Mvc;
using Boom21.repository;
using Boom21.Domains;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Seller")]
    public class SellerController : ControllerBase
    {

        [HttpPut("Create")]
        public bool Create(Seller seller)
        {
            return Storages.SellerStorage.Create(seller); ;
        }

        [HttpGet("Read")]
        public EstateАgent Read(int Id)
        {
            return Storages.SellerStorage.Read(Id);
        }

        [HttpPut("Update")]
        public EstateАgent Update(Seller seller)
        {
            return Storages.SellerStorage.Update(seller);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.SellerStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.SellerStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.SellerStorage.ReadFromXmlFile();
        }
    }
}