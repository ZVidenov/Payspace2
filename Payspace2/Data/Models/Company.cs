using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payspace2.Data.Models
{
    public class Company : MainEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
