
using System.Collections.Generic;
namespace Sibahlenkosini.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public double Rating { get; set; }
        public List<Colors> Colors { get; set; }
        public List<Colors> ColorCustom { get; set; }
        public double QTY { get; set; } = 1;
        public bool IsAvailable { get; set; }
        public bool IsFixedPrice { get; set; }


    }
    public class Colors
    {
        public string color { get; set; }
    }
}
