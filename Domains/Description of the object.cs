using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DescriptionOfTheObject.Domains
{

    public class DescriptionOfTheObject
    {
        public int DescriptionOfTheObjectt { get; set; }

        public decimal Prise { get; set; }

        public string Feature { get; set; }

        public int Photo { get; set; }

        public int SellerId { get; set; }

        DescriptionOfTheObject(int DescriptionOfTheObjectt, decimal Prise, string Feature, int Photo, int SellerId)
        {
            this.DescriptionOfTheObjectt = DescriptionOfTheObjectt;
            this.Prise = Prise;
            this.Feature = Feature;
            this.Photo = Photo;
            this.SellerId = SellerId;
        }








    }


}