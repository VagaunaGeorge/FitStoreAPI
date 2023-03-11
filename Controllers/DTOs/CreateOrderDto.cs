using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitStoreAPI.Entities.OrderAggregate;

namespace FitStoreAPI.Controllers.DTOs
{
    public class CreateOrderDto
    {
        public bool SaveAddress { get; set; }  
        public ShippingAddress ShippingAddress { get; set; }
    }
}