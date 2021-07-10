using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Chocolate : Product
    {
        bool eaten;
        public Chocolate(int price, string useInfo, string examineInfo) : base(price, useInfo, examineInfo)
        {
            productName = "Choklad";
            eaten = false;
        }

        public Chocolate()
        {
            productName = "Choklad";
            eaten = false;         
            price = 8;
            useInfo = "Smakar gott.";
            examineInfo = "Brun nästan helt fast gegga med papper runt.";
        }

        //Denna property finns enbart för at kunna testa
        public bool Eaten
        {
            get { return eaten; }
        }
        public override string Use()
        {
            if (eaten)
            {
                return "Du har redan ätit upp den";
            }
            else
            {
                eaten = true;
                examineInfo = "Det är bara pappret kvar.";
                return "Smakar gott";
            }
        }

    }
}
