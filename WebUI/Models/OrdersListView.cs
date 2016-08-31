﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class OrdersListView
    {
        public DateTime CreationTime { get; set; }
        public string City { get; set; }
        public string Brand { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public string OrderStatus { get; set; }
        
    }
}