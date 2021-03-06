﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public ICollection<RestaurantReview> Reviews { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
        public bool Pub { get; set; }
        public bool VFriendly { get; set; }
    }
}