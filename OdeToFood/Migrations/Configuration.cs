using System.Collections.Generic;
using System.Globalization;
using OdeToFood.Models;

namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name, new Restaurant { Name = "Literal Bella", City = "Portland", Country = "USA" }, new Restaurant { Name = "Ellie's Grill", City = "Beaverton", Country = "USA" }, new Restaurant
            {
                Name = "Patty's Diner",
                City = "Beaverton",
                Country = "USA",
                Reviews = new List<RestaurantReview>{
                    new RestaurantReview{Rating = 9,Body = "Great!"}
                }
            });

            for (var i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Restaurant{Name = i.ToString(), City = "Nowhere", Country= "USA"});
            }
        }
    }
}
