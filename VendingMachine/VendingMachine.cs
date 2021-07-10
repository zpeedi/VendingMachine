using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        //Dictionary<int, int> money = new Dictionary<int, int>();
        List<Product> products = new List<Product>();
        //int[] denominations = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
        int[] denominations = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
        int money;
       


        public VendingMachine(List<Product> products)
        {
            this.products = products;
            money = 0;
        }

        public VendingMachine()
        {
            products.Add(new Snuff(19, "Du har nu jord under läppen.", "ser ut som jord och luktar lite märkligt."));
            products.Add(new Condome(59, "Irrelevent", "En 10-pack kondomer."));
            products.Add(new Chocolate(8, "En chokladbit.", "Brun nästan helt fast gegga med papper runt."));
            money = 0;
        }

        public int Money
        {
            get { return money; }
        }

        public Product Purchase(Product product)
        {
            Type t = product.GetType();
            Product p;

            //Denna if satsen hadfe jag hellre butt mot något annat men jag ör osäker på om det går. 
            //Helst hade jag velat sklriva något i stil med Product p = new product.GetType(); och
            //slippa if satsen helt
            if (t == typeof(Chocolate)) {
                p = new Chocolate();
            }
            else if (t == typeof(Condome))
            {
                p = new Condome();
            }
            else 
            {
                p = new Snuff();
            }
            
            if (product.price > money)
            {
                return null;
            }
            else
            {
                money -= product.price;
                
                return p;
            }


        }
        public List<Product> ShowAll()
        {
            return products;
        }
        public void InsertMoney(int denomination)
        {
            //int nrOfCoins;
            money += denomination;
            //money.TryGetValue(denomination, out nrOfCoins);
            //money.TryAdd(denomination, ++nrOfCoins);
        }

        public Dictionary<int, int> EndTransaction()
        {
            /*
            Dictionary<int, int> returnMoney = money;
            money = new Dictionary<int, int>();
            InitMoney();*/

            Dictionary<int, int> returnMoney = new Dictionary<int, int>();
            foreach(int d in denominations)
            {
                returnMoney.Add(d, money / d);
                money = (money % d); 
            }
            money = 0;
            return returnMoney;
        }
    }
}
