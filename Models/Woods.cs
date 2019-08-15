using System;
using System.ComponentModel.DataAnnotations;

namespace LostInTheWoods.Models
{
    public class Trail
    {
        [Key]
        public int id {get; set;}
        
        [Required]
        [MinLength(2)]
        [Display(Name = "Trail Name")]
        public string name {get; set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Description")]
        public string description {get;set;}

        [Required]
        [Display(Name = "Length")]
        public int? length {get;set;}
        
        [Required]
        [Display(Name = "Elevation")]
        public float? elevation {get;set;}

        [Required]
        [Display(Name = "Longitude")]
        public float? longitude {get; set;}
        
        [Required]
        [Display(Name = "Latitude")]
        public float? latitude {get; set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}

    }
}