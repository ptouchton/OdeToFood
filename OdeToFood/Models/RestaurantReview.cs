﻿

using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        [Range(1,10)]
        public int Rating { get; set; }
        [Required]
        public string Body { get; set; }
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }
    }
}