using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Condom : Product
    {
        int condomesLeft;
        public Condom(int price, string useInfo, string examineInfo) : base(price, useInfo, examineInfo)
        {
            productName = "Kondomer";
            condomesLeft = 10;
        }

        public Condom()
        {
            productName = "Kondomer";
            condomesLeft = 10;
            price = 59;
            useInfo = "Smakar gott.";
            examineInfo = "En 10-pack kondomer.";
        }

        public override string Use()
        {
            if (condomesLeft > 0)
            {
                condomesLeft--;
                examineInfo = examineInfo + " " + condomesLeft + " Kondomer kvar. ";
                Console.WriteLine(examineInfo);
                return "Nu har du " + condomesLeft + " kvar."; ;
            }
            else
            {
                return "De är slut";
            }
        }
    }
  
    
}
