using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Boom21.repository;

namespace Boom21.Domains
{

    public class Sale: IIdentifier
    {
        public int Id { get; set; }
        public int CadastralNumber { get; set; }

        public int CustomerId { get; set; }

        public string Location { get; set; }

        public int EstateАgentId { get; set; }

        public Sale (int cadastralNumber, int customerId, string location, int estateАgentId, int id)
        {
            CadastralNumber = cadastralNumber;
            CustomerId = customerId;
            Location = location;
            EstateАgentId = estateАgentId;
            Id = id;
            
        }








    }


}