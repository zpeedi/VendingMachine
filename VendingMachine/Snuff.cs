using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Snuff : Product
    {
        
        public Snuff(int price, string useInfo, string examineInfo) : base(price, useInfo, examineInfo)
        {
            productName = "Snus";
        } 

        public Snuff()
        {
            productName = "Snus";
            price = 19;
            useInfo = "Du har nu jord under läppen.";
            examineInfo = "ser ut som jord och luktar lite märkligt.";          
        }      

  

    }
}
