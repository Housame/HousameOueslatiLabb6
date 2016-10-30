using HousameOueslati_Labb6.Grafic;
using HousameOueslati_Labb6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6
{
    class GameStory
    {
        public enum Prize {Money=1, Army, Land, Nothing };
        public static Prize prize = new Prize(); // priset som kungen erbjudit
        static int steps;
        public static int Steps
        {
            get { return steps; }
            set { steps = value; }
        } // för att följa planen som fåtts av mentor

        static Conversation Con = new Conversation();

        public  void TheGame()
        {
            Texts.BeginText();
            Home();
            
            
        }

        private void Home()
        {

            GUI.HouseSpace();
            Texts.HomeQuestions();
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    GUI.Sleeping();
                    Bar();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Bar();
                    break;
            }
        }

        private void Bar()
        {
            Console.Clear();
            Con.barman.PlaceArround();
            Client.Timer(3);
            Console.Clear();
            GUI.Drinking();
            Client.Timer(3);
            Console.Clear();
            Con.barman.LookLike();
            Client.Timer(3);
            Console.WriteLine("\n\n");
            Con.BarmanConv1();
            Texts.TalkToBarman();
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Con.BarmanConv2();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    GUI.OutOfBar();
                    Client.Timer(3);
                    Console.Clear();
                    Con.BarmanConv2();
                    break;
            }
        }

        internal static void Town()
        {
            Console.Clear();
            Console.WriteLine("You are at step {0}", Steps);
            GUI.Map();
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1: 
                    MentorPlace();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    BlackSmithPlace();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    WizardPlace();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    TheStablePlace();
                    break;
            }
        }

        private static void TheStablePlace()
        {
            Console.Clear();
            Con.horse.PlaceArround();
            Client.Timer(3);
            if (Steps == 4)
            {
                Console.Clear();
                Con.horse.LookLike();
                Client.Timer(2);
                Steps ++;
                ToTheKing();
                
                
            }
            else
                Texts.FollowTheMentor(Steps);
            Client.Timer(1.5);
            Town();
        }

        private static void ToTheKing()
        {
            Console.Clear();
            if (Steps == 5)
            {
                Console.WriteLine("It's time to head to the castle!");
                Console.WriteLine("Go there? Press 1 else Press 2");
                var input = Console.ReadKey(true).Key;
                switch(input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ToTheCastle();
                        
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Town();
                        break;
                }
            }
        }

        private static void ToTheCastle()
        {
            Console.Clear();
            Con.king.PlaceArround();
            Client.Timer(3);
            Console.Clear();
            Texts.EnteringTheCastle();
            Client.Timer(3);
            Console.Clear();
            Con.king.LookLike();
            Client.Timer(2.5);
            Con.KingConv();
            FinalGame.GoToDragon();
        }

        private static void WizardPlace()
        {
            Console.Clear();
            Con.wizard.PlaceArround();
            Client.Timer(3.5);
            Console.Clear();
            Con.wizard.LookLike();
            Client.Timer(3);
            if (Steps == 3)
            {
                Con.WizardConv();
                Steps ++;
                Town();
            }
            else if (Steps == 5)
            { Console.WriteLine("You're ready to go to the king, do it now!!!"); }
            else
                Texts.FollowTheMentor(Steps);
            Client.Timer(1.5);
            Town();
        }

        private static void BlackSmithPlace()
        {
            Console.Clear();
            Con.blacksmith.PlaceArround();
            Client.Timer(3);
            Console.Clear();
            if (Steps == 2)
            {
                Con.BlackSmithConv();
                Steps ++;
                Town();
            }
            else if (Steps == 5)
            { Console.WriteLine("You're ready to go to the king, do it now!!!"); }

            else
                Texts.FollowTheMentor(Steps);
            Client.Timer(1.5);
            Town();
        }

        private static void MentorPlace()
        {
            Console.Clear();
            if (Steps == 0)
            { Steps=2; }
            else if (Steps == 5)
            {
                Console.WriteLine("You're ready to go to the king, do it now!!!");
                Client.Timer(2);
                ToTheCastle();
            }
            
            Con.mentor.LookLike();
            Client.Timer(2);
            Con.MentorConv();
            
            
            
        }
    }
    class Conversation  // converstaioner mellan figurer
    {
        

        #region Class variables

        public Horse horse = new Horse();
        public Knight knight = new Knight();
        public King king = new King();
        public BlackSmith blacksmith = new BlackSmith();
        public Wizard wizard = new Wizard();
        public Princess princess = new Princess();
        public Dragon dragon = new Dragon();
        public Barman barman = new Barman();
        public Mentor mentor = new Mentor();
        #endregion
       

        public void BarmanConv1()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("**You and the Barman**");
            Console.WriteLine("**********************");
            knight.Speak(Dialog.dialog[0]);
            Client.Timer(1.5);
            barman.Speak(Dialog.dialog[1]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[2]);
            Client.Timer(1.5);
            barman.Speak(Dialog.dialog[3]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[4]);
            Console.ReadKey();
        }

        internal void BarmanConv2()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("**You and the Barman**");
            Console.WriteLine("**********************");
            knight.Speak(Dialog.dialog[8]);
            Client.Timer(1.5);
            barman.Speak(Dialog.dialog[9]);
            Client.Timer(1.5);
            barman.Speak(Dialog.dialog[10]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[11]);
            Client.Timer(1.5);
            barman.Speak(Dialog.dialog[12]);
            Client.Timer(1.5);
            barman.Speak(Dialog.dialog[13]);
            Client.Timer(1.5);
            Texts.AcceptTheQuest();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    barman.Speak(Dialog.dialog[14]);
                    Client.Timer(1.5);
                    barman.Speak(Dialog.dialog[15]);
                    GameStory.Town();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    GUI.OutOfBar();
                    Client.Timer(3);
                    barman.Speak(Dialog.dialog[14]);
                    Client.Timer(1.5);
                    barman.Speak(Dialog.dialog[15]);
                    Client.Timer(1.5);
                    GameStory.Town();
                    break;



            }
        }

        internal void MentorConv()
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("**You and Your mentor**");
            Console.WriteLine("***********************");
            mentor.Speak(Dialog.dialog[16]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[17]);
            Client.Timer(1.5);
            mentor.Speak(Dialog.dialog[18]);
            Client.Timer(1.5);
            Console.ReadKey();
            Texts.Plan();
            GameStory.Town();
        }

        internal void BlackSmithConv()
        {
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("**You and the BlackSmith**");
            Console.WriteLine("**************************");
            blacksmith.Speak(Dialog.dialog[19]);
            Client.Timer(3);
            GUI.Sword();
            Client.Timer(3);
            knight.Speak(Dialog.dialog[20]);
            Client.Timer(1.5);
            blacksmith.Speak(Dialog.dialog[21]);
            Client.Timer(1.5);
            blacksmith.Speak(Dialog.dialog[22]);
            Client.Timer(1.5);
            Console.ReadKey();

        }

        internal void WizardConv()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("**You and the Wizard**");
            Console.WriteLine("**********************");
            wizard.Speak(Dialog.dialog[23]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[24]);
            Client.Timer(1.5);
            wizard.Speak(Dialog.dialog[25]);
            Client.Timer(1.5);
            wizard.Speak(Dialog.dialog[26]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[27]);
            Client.Timer(1.5);
            wizard.Speak(Dialog.dialog[28]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[29]);
            Client.Timer(1.5);
            wizard.Speak(Dialog.dialog[30]);
            Client.Timer(1.5);
            Console.ReadKey();
        }

        internal void KingConv()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("**You and  the  King**");
            Console.WriteLine("**********************");
            king.Speak(Dialog.dialog[31]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[32]);
            Client.Timer(1.5);
            king.Speak(Dialog.dialog[33]);
            Client.Timer(1.5);
            Texts.Demands();
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    GameStory.prize = (GameStory.Prize)1;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    GameStory.prize = (GameStory.Prize)2 ;
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    GameStory.prize = (GameStory.Prize)3;
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    GameStory.prize = (GameStory.Prize)4 ;
                    break;
            }
            king.Speak(Dialog.dialog[34]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[35]);
            Client.Timer(1.5);

        }

        internal void PrincessConv()
        {
            Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("**You and the Princess**");
            Console.WriteLine("************************");
            princess.Speak(Dialog.dialog[36]);
            Client.Timer(1.5);
            knight.Speak(Dialog.dialog[37]);
            Client.Timer(1.5);
        }

        internal void DragonConv()
        {
            
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("**You and the Dragon**");
            Console.WriteLine("**********************");
            dragon.Speak(Dialog.dialog[39]);
            Client.Timer(3);
            knight.LookLike();
            knight.Speak(Dialog.dialog[38]);
        }
    }
}
