using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payspace2.Data.Models
{
    public class CoverImage : MainEntity
    {
        public string Url { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }

    }
}
