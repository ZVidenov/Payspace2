using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payspace2.Data.Models
{
    public class Product : MainEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public int? CoverImageId { get; set; }
        public CoverImage CoverImage { get; set; }
        public ICollection<Image> Images { get; set; }
        public int? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ICollection<ProductTags> Tags { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public ICollection<CartProducts> Carts { get; set; }
    }
}
