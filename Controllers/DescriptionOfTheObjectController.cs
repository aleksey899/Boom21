using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/DescriptionOfTheObject")]
    public class DescriptionOfTheObjectController : ControllerBase

    [HttpPost("DescriptionOfTheObject")]
     public string DescriptionOfTheObject(string str)
    {
        return str;// Описание Объекта
    }

    [HttpPost("Prise")]
    public string Prise(string str)
    {
        return str;// Цена
    }


    [HttpPost("Feature")]
    public string Feature(string str)
    {
        return str;// Особенность
    }

    [HttpPost("Photo")]
    public string Photo(string str)
    {
        return str;// Фотографии
    }

    [HttpPost("SellerId")]
    public string SellerId(string str)
    {
        return str;// Идентификатор продавца
    }


}
   