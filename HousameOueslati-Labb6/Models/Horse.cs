using HousameOueslati_Labb6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6.Models
{
    class Horse : ILook, IPlace
    {
        public void LookLike()
        {
            GUI.Horse();
        }

        public void PlaceArround()
        {
            GUI.Stable();
        }
    }
}
