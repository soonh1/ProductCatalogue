using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogue.Models
{
    public class Kid
    {
        public int KidID { get; set; }
        public int ProductID { get; set; }
        public int TypeID { get; set; }

        public Type Type { get; set; }
        public Product Product { get; set; }
    }
}
