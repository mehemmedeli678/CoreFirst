using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207CoreFirst.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public  decimal Price { get; set; }
        public short  Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
