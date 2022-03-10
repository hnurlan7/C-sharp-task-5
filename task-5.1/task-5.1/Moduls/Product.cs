using System;
using System.Collections.Generic;
using System.Text;

namespace task_5._1.Moduls
{
    internal class Product
    {
        public string productName;
        public int costPrice;
        public int salePrice;

        public Product(string producName, int costPrice, int salePrice)
        {
            this.productName = producName;  
            this.costPrice = costPrice; 
            this.salePrice = salePrice; 
        }
    }
}
