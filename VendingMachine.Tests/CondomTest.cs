using System;
using System.Collections.Generic;
using System.Text;
using Xunit;



namespace VendingMachine.Tests
{
    public class CondomTest
    {
        [Fact]
        public void CondomeUseTest()
        {
            Condome condome = new Condome();
            int before = 10;
            condome.Use();

            Assert.True(before > condome.CondomesLeft);
        }
    }
}
