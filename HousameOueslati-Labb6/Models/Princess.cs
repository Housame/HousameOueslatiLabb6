using HousameOueslati_Labb6.Grafic;
using HousameOueslati_Labb6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6.Models
{
    class Princess : Ispeakable, ILook, IPlace
    {
        public void LookLike()
        {
            GUI.Princess();
        }

        public void PlaceArround()
        {
            GUI.Mountain();
        }

        public void Speak(string s)
        {
            Console.WriteLine(s);
        }
    }
}
