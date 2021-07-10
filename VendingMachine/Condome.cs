using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Condome : Product
    {
        private int condomesLeft;
        public Condome(int price, string useInfo, string examineInfo) : base(price, useInfo, examineInfo)
        {
            productName = "Kondomer";
            condomesLeft = 10;
        }

        public Condome()
        {
            productName = "Kondomer";
            condomesLeft = 10;
            price = 59;
            useInfo = "Smakar gott.";
            examineInfo = "En 10-pack kondomer.";
        }

        public int CondomesLeft
        {
            get{ return condomesLeft; }
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
