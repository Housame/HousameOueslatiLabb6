using HousameOueslati_Labb6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6.Models
{
    class Mentor : Ispeakable, ILook
    {
        public void LookLike()
        {
            GUI.Mentor();
        }

        public void Speak(string s)
        {
            Console.WriteLine(s);
        }
    }
}
