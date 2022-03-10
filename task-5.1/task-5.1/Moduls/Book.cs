using System;
using System.Collections.Generic;
using System.Text;

namespace task_5._1.Moduls
{
    internal class Book : Product
    {
        public string authorName;
        public int pageCount;
        public int discountPercent;

        public Book(string producName, int costPrice, int salePrice, string authorName, int pageCount, int discountPercent) : base(producName, costPrice, salePrice)
        {
            this.authorName = authorName;
            this.pageCount = pageCount;
            this.discountPercent = discountPercent;
        }
        public void AllAbout()
        {
            Console.WriteLine($"Ad: {productName} Maya dəyəri: {costPrice}  Satış dəyəri: {salePrice}  Müəllif: {authorName}  Səhifə sayı: {pageCount} Endirim: {discountPercent}");
        }

        public float GetDiscountedPrice()
        {
            return salePrice - ((salePrice * discountPercent) / 100);
        }
    }
}
