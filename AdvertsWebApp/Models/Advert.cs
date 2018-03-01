using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvertsWebApp.Models
{
    public class Advert
    {
        public int AdvertId { get; set; }
       
        [DisplayName("Sludinājuma cena")]
        [Required]
        public double Price { get; set; }
        [DisplayName("Sludinājuma nosaukums")]
        [StringLength(100, MinimumLength = 1)]
        [Required(ErrorMessage ="Lauks {0} ir vajadzīgs!")]
        public string Name { get; set; }
        [DisplayName("Sludinājuma teksts")]
        public string AdvertText { get; set; }
        public DateTime CreationTime { get; set; }
    }
}