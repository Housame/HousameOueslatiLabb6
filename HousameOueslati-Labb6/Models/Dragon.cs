using HousameOueslati_Labb6.Grafic;
using HousameOueslati_Labb6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6.Models
{
    class Dragon : Ispeakable, ILook, IPlace
    {
        public void LookLike()
        {
            GUI.Dragon();
        }

        public void PlaceArround()
        {
            GUI.DragonPlace();
        }

        public void Speak(string s)
        {
            Console.WriteLine(s);
            Client.Timer(2.5);
            GUI.Dragon();
        }
    }
}
