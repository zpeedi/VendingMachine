using System;
using Xunit;


namespace VendingMachine.Tests
{
    public class VendingMachineTest
    {
        [Fact]
        public void InsertMoneyTest()
        {
            VendingMachine vendingMachine = new VendingMachine();
            int expected = 5 + 50 + 100;
            vendingMachine.InsertMoney(5);
            vendingMachine.InsertMoney(50);
            vendingMachine.InsertMoney(100);

            Assert.Equal(expected, vendingMachine.Money);
            vendingMachine.EndTransaction();
        }

        [Fact]
        public void voidEndTransactionTest()
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(5);
            vendingMachine.InsertMoney(50);
            vendingMachine.InsertMoney(100);
            vendingMachine.EndTransaction();

            Assert.Equal(0, vendingMachine.Money);

        }

        [Fact]
        public void PurchaseWithNoMoneyTest()
        {
            VendingMachine vendingMachine = new VendingMachine();
            Product p = vendingMachine.Purchase(new Snuff());

            Assert.Null(p);
        }

        [Fact]
        public void PurchaseWithMoneyTest()
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(100);
            Product p = vendingMachine.Purchase(new Snuff());

            Assert.Equal(typeof(Snuff), p.GetType());
        }

    }
}
