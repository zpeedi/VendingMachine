using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VendingMachine.Tests
{
    public class ChoklatTest
    {
        [Fact]
        public void EatenWhenUsedTest()
        {
            Chocolate choklate = new Chocolate();
            choklate.Use();
            Assert.True(choklate.Eaten);
        }

        [Fact]
        public void NewChoklateNotEatenTest()
        {
            Chocolate choklate = new Chocolate();
            Assert.False(choklate.Eaten);
        }
    }
}
