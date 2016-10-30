using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6.Grafic
{
    class Texts
    {
        #region Texts
        public static void BeginText()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("*********   Introduction   **********");
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");
            Console.WriteLine("*        You're the knight          *");
            Console.WriteLine("*  You had slaughtered some dragons *");
            Console.WriteLine("*        in the big war on dragons  *");
            Console.WriteLine("*        But nowadays you are       *");
            Console.WriteLine("*        just a normal guy          *");
            Console.WriteLine("*      that drink and bang whores   *");
            Console.WriteLine("*************************************");
            Console.ReadKey();
        }

        internal static void DragonIsKilled()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("** You killed the dragon **");
            Console.WriteLine("***************************");
        }

        internal static void KillDragon()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*     The dragon surrended      *");
            Console.WriteLine("*                               *");
            Console.WriteLine("* 1. Kill the dragon            *");
            Console.WriteLine("*                               *");
            Console.WriteLine("* 2. Arrest it and make him your*");
            Console.WriteLine("*                               *");
            Console.WriteLine("*********************************");
        }

        internal static void WizardPlace()
        {
            Console.WriteLine("\n\n********************************");
            Console.WriteLine("*                              *");
            Console.WriteLine("*    I can't see anything      *");
            Console.WriteLine("* It has with her powers to do *");
            Console.WriteLine("*  I see only Butterflies      *");
            Console.WriteLine("*                              *");
            Console.WriteLine("********************************");

        }

        internal static void GameOver()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*    The princess is saved   *");
            Console.WriteLine("*    You've got you prize    *");
            Console.WriteLine("*          {0}               *",GameStory.prize);
            Console.WriteLine("*                            *");
            Console.WriteLine("*      It could be better    *");
            Console.WriteLine("******************************");
            Console.ReadKey();

        }

        internal static void HomeQuestions()
        {
            Console.WriteLine("\n\n*****************************");
            Console.WriteLine("*    1. Go to the bed       *");
            Console.WriteLine("*                           *");
            Console.WriteLine("*    2. Go to the bar       *");
            Console.WriteLine("*                           *");
            Console.WriteLine("*****************************");

        }

        internal static void TalkToBarman()
        {
            Console.Clear();
            Console.WriteLine("\n\n*****************************");
            Console.WriteLine("*    1. Talk to the barman  *");
            Console.WriteLine("*                           *");
            Console.WriteLine("*    2. Ask him to shut up  *");
            Console.WriteLine("*                           *");
            Console.WriteLine("*****************************");

        }


        internal static void Lazy()
        {
            Console.WriteLine("\n\n*****************************");
            Console.WriteLine("*     You're sleepin        *");
            Console.WriteLine("*     So lazy you are       *");
            Console.WriteLine("*      Dreaming about       *");
            Console.WriteLine("*      Dragons and Princess *");
            Console.WriteLine("*****************************");
            Client.Timer(3);
            Console.Clear();
            Console.WriteLine("\n*****************************");
            Console.WriteLine("*     Now you're awake      *");
            Console.WriteLine("*     What a dream          *");
            Console.WriteLine("*      Its only a dream     *");
            Console.WriteLine("*      Now to the reality   *");
            Console.WriteLine("*     Im heading to the bar *");
            Console.WriteLine("*****************************");
            Console.ReadKey();
        }

        internal static void FollowTheMentor(int x)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*    Follow the leads         *");
            Console.WriteLine("* That you've got from mentor *");
            Console.WriteLine("*     Or go there now again   *");
            Console.WriteLine("*     You are at step {0}     *", x);
            Console.WriteLine("*******************************");
        }

        internal static void AcceptTheQuest()
        {
            Console.Clear();
            Console.WriteLine("\n\n*****************************");
            Console.WriteLine("*    1. Accept the Quest    *");
            Console.WriteLine("*                           *");
            Console.WriteLine("*    2. Refuse the Quest    *");
            Console.WriteLine("*                           *");
            Console.WriteLine("*****************************");
        }

        internal static void EnteringTheCastle()
        {
            Console.WriteLine(@"                         |        l~~~~~~~l      |       ");
            Console.WriteLine(@"                        /\   l^^^^^^^^^^^^^^^l  /\                   ");
            Console.WriteLine(@"                       /__\ _l O  O  O  O  O l_/__\                  ");
            Console.WriteLine(@"                       l   l l               l     l                 ");
            Console.WriteLine(@"                       l   l l               l     l                 ");
            Console.WriteLine(@"        [^^^]          l  [^^^]             [^^^]  l          [^^^]  ");
            Console.WriteLine(@"        [ o ]-------------[ o ]-------------[ o ]-------------[ o ]  ");
            Console.WriteLine(@"        [   ]             [   ]     ___     [   ]             [   ]  ");
            Console.WriteLine(@"        [   ]             [   ]    /   \    [   ]             [   ]  ");
            Console.WriteLine(@"        [   ]             [   ]   |     |   [   ]   o         [   ]  ");
            Console.WriteLine(@"        [   ]             [   ]   |     |   [   ]~\_|_        [   ]  ");
            Console.WriteLine(@"________[___]_____________[___]___|_____|___[___]_/\_/\_______[___]__");
            Console.WriteLine(@"\n                          ENTERING THE CASTLE                      ");
        }

        internal static void NoChoice()
        {
            Console.WriteLine("\n\n*****************************");
            Console.WriteLine("*                           *");
            Console.WriteLine("*     It seems like         *");
            Console.WriteLine("*       I have no choice    *");
            Console.WriteLine("*     Or Debt Collectors    *");
            Console.WriteLine("*       Will kill me        *");
            Console.WriteLine("*****************************");
        }

        internal static void Plan()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("* 1. Go to the BlackSmith  *");
            Console.WriteLine("* 2. After that to Wizard  *");
            Console.WriteLine("* 3. then to the stable    *");
            Console.WriteLine("* 4. Then head to the king *");
            Console.WriteLine("****************************");
            Console.WriteLine("Read the plan carefully to succeed");
            Console.ReadKey();
        }

        internal static void Demands()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("* 1. 10000 piece of gold     *");
            Console.WriteLine("* 2. Be the head of my army  *");
            Console.WriteLine("* 3. Give you one of my lands*");
            Console.WriteLine("* 4. Nothing                 *");
            Console.WriteLine("******************************");

        }
        #endregion //Bara texter inga hanteringar
    }
}
