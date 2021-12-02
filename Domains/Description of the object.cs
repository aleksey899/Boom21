using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class DescriptionOfTheObject:IIdentifier
    {
        public int Id { get; set; }
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