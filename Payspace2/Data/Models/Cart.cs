using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payspace2.Data.Models
{
    public class Cart : MainEntity
    {
        public int? UserId { get; set; }
        public User User { get; set; }
        public ICollection<CartProducts> Products { get; set; }
    }
}
