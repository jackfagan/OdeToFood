using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class OdeToFoodDb : DbContext
    {
        public OdeToFoodDb() : base("DbConnection") { }

        public OdeToFoodDb(string connection) : base(connection) { }

        public DbSet<Restaurant> Restaurants{ get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}