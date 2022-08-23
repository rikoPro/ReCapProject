﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int RentId { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public DateTime RentDate { get; set; }


    }
}
