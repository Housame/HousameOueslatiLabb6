using HousameOueslati_Labb6.Grafic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6
{
    class FinalGame
    {
        
        static Conversation Con = new Conversation();
        public static bool dragonIsKilled ;

        public static void GoToDragon()
        {
            Console.Clear();
            Con.princess.PlaceArround();
            Client.Timer(2);
            Console.Clear();
            Con.dragon.PlaceArround();
            Client.Timer(2);
            Con.DragonConv();
            Console.WriteLine("Fight!!! Press anywhere!");
            Console.ReadKey();
            Fight();
            DragonSurrend();
        }

        static void DragonSurrend()
        {
            Console.Clear();
            GUI.DragonSurrended();
            Texts.KillDragon();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Texts.DragonIsKilled();
                    Client.Timer(1.5);
                    MeetThePrincess();
                    dragonIsKilled = true;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    GUI.RideDragon();
                    Client.Timer(1.5);
                    MeetThePrincess();
                    dragonIsKilled = false;
                    break;
            }
        }
        
        static void MeetThePrincess()
        {
            Console.Clear();
            Con.princess.PlaceArround();
            Client.Timer(2);
            Console.Clear();
            Con.princess.LookLike();
            Client.Timer(3);
            Console.Clear();
            Con.PrincessConv();
            if (dragonIsKilled == false && GameStory.prize == (GameStory.Prize)4)
                HappyEnding();
            else Texts.GameOver();

        }
        
        static void HappyEnding()
        {
            Console.Clear();
            Console.WriteLine("******************************************");
            Console.WriteLine("*               The End!!                *");
            Console.WriteLine("* The princess is in love with you       *");
            Console.WriteLine("*         You married her                *");
            Console.WriteLine("* The dragon is now the castle protector *");
            Console.WriteLine("*        You are the king now            *");
            Console.WriteLine("******************************************");

            GUI.HappyEnd();

        }
        
        static void Fight()
        {
            Console.Clear();
            GUI.HorseFight();
            Client.Timer(1.5);
            Console.Clear();
            GUI.DragonFight();
            Client.Timer(1.5);
            Console.Clear();
            GUI.KnightFighting();
            Client.Timer(1.5);
            Console.Clear();
            GUI.DragonFight();
            Client.Timer(0.5);
            Console.Clear();
            GUI.KnightFighting();
            Client.Timer(0.5);
            Console.Clear();
            GUI.DragonFight();
            Client.Timer(0.5);
            Console.Clear();
            GUI.KnightFighting();
            Client.Timer(0.5);
            Console.Clear();
            GUI.DragonFight();
            Client.Timer(0.2);
            Console.Clear();
            GUI.KnightFighting();
            Client.Timer(0.2);
            Console.Clear();
        }
    }
}
