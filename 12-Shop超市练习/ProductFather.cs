using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Shop超市练习
{
    class ProductFather
    {
        public double Price { get; set; }
        public double Count { get; set; }
        public string ID { get; set; }

        public ProductFather(double price,double count,string id) {
            this.Price = price;
            this.Count = count;
            this.ID = id;
        }
    }
}
