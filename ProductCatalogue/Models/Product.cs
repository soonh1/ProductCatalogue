using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogue.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public byte[] Image { get; set; }

        public string Gender { get; set; }
        public string Type { get; set; }
    }
}
