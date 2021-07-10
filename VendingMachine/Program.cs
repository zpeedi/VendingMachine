using System;
using System.Collections.Generic;
using System.Linq;
namespace VendingMachine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            int choise = 1;
            List<Product> myProducts = new List<Product>();

            while (choise != 0)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("Du står vid en automat. Vad vill du göra?");
                Console.WriteLine("1) Handla");
                Console.WriteLine("2 Stoppa in pengar");
                Console.WriteLine("3 Lek med dina produkter");
                Console.WriteLine("0 Avsluta");
                Console.WriteLine("\n Du har " + vendingMachine.Money + " kronor instoppat i maskinen.");
                try
                {
                    choise = int.Parse(Console.ReadLine());

                    switch (choise)
                    {
                        case 1:
                            Shop(vendingMachine, myProducts);
                            break;


                        case 2:
                            InsertMoney(vendingMachine);
                            break;

                        case 3:
                            PlayWithProducts(vendingMachine, myProducts);
                            break;

                        case 0:
                            Dictionary<int, int> moneyBack = vendingMachine.EndTransaction();
                            Console.WriteLine("Detta är de pengar du får tillbaka.");

                            foreach (var item in moneyBack)
                            {
                                Console.WriteLine("Antal: " + item.Value + " Valuta: " + item.Key);
                            }
                            break;

                        default:
                            break;
                    }
                }
                catch 
                {
                    Console.WriteLine("Du har fått covid!!!");

                }
            }
           
            
            
        }

        public static void PlayWithProducts(VendingMachine vendingMachine, List<Product> myProducts)
        {
            int index = 0;
            int choosenProduct;
            char option;

            Console.WriteLine("Du har följande produkter.Välj en du vill undersöka eller använda");
            foreach (Product p in myProducts)
            {
                Console.Write(++index + ") ");
                Console.WriteLine(p.productName);
            }
            choosenProduct = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("(U)ndersöka eller (A)nvända?");
            try
            {
                option = char.Parse(Console.ReadLine());


                if (option == 'a' || option == 'A')
                {
                    Console.WriteLine(myProducts.ElementAt(choosenProduct).Use());
                }
                else if(option == 'u' || option == 'U')
                {
                    Console.WriteLine(myProducts.ElementAt(choosenProduct).Examine());
                }
            }
            catch 
            {
                Console.WriteLine("Du har fått covid!!!");
            }

        }

        public static void Shop(VendingMachine vendingMachine, List<Product> myProducts)
        {
            List<Product> productList = vendingMachine.ShowAll();
            int index = 0;

            Console.WriteLine("Ange vilken produkt du vill köpa.");
            foreach (Product p in productList)
            {
                Console.Write(++index + ") ");
                Console.WriteLine(p.productName);
                Console.WriteLine(" " + p.price + " kronor.");
            }

            Console.WriteLine("\n Du har " + vendingMachine.Money + " kronor instoppat i maskinen.");
            try
            {
                index = int.Parse(Console.ReadLine());
                Product product = vendingMachine.Purchase(productList.ElementAt(index - 1));
                if (product != null)
                {
                    myProducts.Add(product);
                }
                else
                {
                    Console.WriteLine("Du har för lite pengar!!!");
                }
            }
            catch 
            {
                Console.WriteLine("Du har fått covid!!!");
            }
        }

        public static void InsertMoney(VendingMachine vendingMachine)
        {
            int choise = 1;
            while (choise != 0)
            {
                Console.WriteLine("\n\nVilken sorts peng vill du stoppa in?");
                Console.WriteLine("1) Enkrona");
                Console.WriteLine("2) Femma");
                Console.WriteLine("3) Tia");
                Console.WriteLine("4) Femtiolapp");
                Console.WriteLine("5) Hundring");
                Console.WriteLine("6) Femhundring");
                Console.WriteLine("7) Tusenlapp");
                Console.WriteLine("0) Huvudmenyn");

                try
                {
                    choise = int.Parse(Console.ReadLine());
                }
                catch { }

                switch (choise)
                {
                    case 1:
                        vendingMachine.InsertMoney(1);
                        break;
                    case 2:
                        vendingMachine.InsertMoney(5);
                        break;
                    case 3:
                        vendingMachine.InsertMoney(10);
                        break;
                    case 4:
                        vendingMachine.InsertMoney(50);
                        break;
                    case 5:
                        vendingMachine.InsertMoney(100);
                        break;
                    case 6:
                        vendingMachine.InsertMoney(500);
                        break;
                    case 7:
                        vendingMachine.InsertMoney(1000);
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}
