﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public int People { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}