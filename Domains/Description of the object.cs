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

        public DescriptionOfTheObject(int descriptionOfTheObjectt, decimal prise, string feature, int photo, int sellerId, int id)
        {
           DescriptionOfTheObjectt = descriptionOfTheObjectt;
            Prise = prise;
            Feature = feature;
            Photo = photo;
            SellerId = sellerId;
            Id = id;
        }








    }


}