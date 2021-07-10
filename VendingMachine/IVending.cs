using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    interface IVending
    {
        public Product Purchase(Product product);
        public List<Product> ShowAll();
        public void InsertMoney(int denomination);
        public Dictionary<int,int> EndTransaction();

    }
}
