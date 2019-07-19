using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data.Entities
{
    public class Product
    {
        public int id { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = false)]

        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]

        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")]

        public DateTime LastSlae { get; set; }

        [Display(Name = "Is Availabe")]

        public DateTime IsAvailabe { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]

        public decimal Stock { get; set; }
    }
}
