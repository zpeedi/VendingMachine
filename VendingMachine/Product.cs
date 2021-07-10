using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Product
    {
        public  int price;
        public string useInfo;
        public string examineInfo;
        public string productName;

        public Product(int price, string useInfo, string examineInfo)
        {
            this.price = price;
            this.useInfo = useInfo;
            this.examineInfo = examineInfo;
        }

        public Product()
        {

        }
        public string Examine()
        {
            return examineInfo + "\nVaran kostar " + price + " kronor.";
        }
        public virtual string Use()
        {
            return useInfo;
        }

    }
}
