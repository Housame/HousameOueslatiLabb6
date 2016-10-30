using HousameOueslati_Labb6.Grafic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6
{
    class Client
    {
        static GameStory gameStory = new GameStory();
        public  void Start()
        {
            PrintMenus.PrintWelcome();
            
            Timer(1.5);
            Console.Clear();
            PrintMenus.Start();
            Console.ReadKey();
            gameStory.TheGame();

        }




        public static void Timer(double seconds)
        {
            {
                double sec = seconds;
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(sec));
                    return;
                });
                t.Wait();

            }
        } // en timer för att användaren sk kunna se felmeddelande innan ClearLines tar bort den "för grafisk förbättring"

    }
}
