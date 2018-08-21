using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models.ViewModels
{
    public class HomeViewModel
    {
        public RestaurantReview TopRatedReview { get; set; }
        public Restaurant RecentRatedReviewName { get; set; }
        public RestaurantReview RecentReviewScore { get; set; }
        public RestaurantReview TopRatedPub { get; set; }
    }
}