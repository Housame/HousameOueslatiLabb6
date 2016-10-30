using HousameOueslati_Labb6.Grafic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb6
{
    class GUI
    {
        #region   Grafics
        public static void Map()
        {
            Console.WriteLine("                 The Map                 ");
            Console.WriteLine("==========================================");
            Console.WriteLine(@"| |          |             |          | |");
            Console.WriteLine(@"| |  The     |             |  The (4) | |");
            Console.WriteLine(@"| |  Wizard  |             |  Royal   | |");
            Console.WriteLine(@"| |__(3)_____|             |__Stable__| |");
            Console.WriteLine(@"|                                       |");
            Console.WriteLine(@"|-|  The     |             |          | |");
            Console.WriteLine(@"| |  Black-  |             |  Home    | |");
            Console.WriteLine(@"| |  Smith   |             |          | |");
            Console.WriteLine(@"|-|___(2)____|             |__________| |");
            Console.WriteLine(@"|                                       |");
            Console.WriteLine(@"| |          |             |          | |");
            Console.WriteLine(@"| |  The     |             |  The     | |");
            Console.WriteLine(@"| |  Bar     |             |  Mentor  | |");
            Console.WriteLine(@"| |__________|             |____(1)___| |");
            Console.WriteLine("==========================================");
        }

        internal static void RideDragon()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                                 _                           ");
            Console.WriteLine(@"                              ==(W{==========-      /===-                ");
            Console.WriteLine(@"                                ||  (.--.)         /===-_---~~~~~~~----__");
            Console.WriteLine(@"                                | \_,|**|,__      |===-~___            _,-'`");
            Console.WriteLine(@"                   -==\\        `\ ' `--'   ),    `//~\\   ~~~~`--._.-~     ");
            Console.WriteLine(@"               ______-==|        /`\_. .__/\ \    | |  \\          _-~`     ");
            Console.WriteLine(@"         __--~~~  ,-/-==\\      (   | .  |~~~~|   | |   `\       ,'         ");
            Console.WriteLine(@"      _-~       /'    |  \\     )__/==0==-\<>/   / /      \     /           ");
            Console.WriteLine(@"    .'        /       |   \\      /~\___/~~\/  /' /        \   /            ");
            Console.WriteLine(@"   /  ____  /         |    \`\.__/-~~   \  |_/'  /          \/'             ");
            Console.WriteLine(@"  /-'~    ~~~~~---__  |     ~-/~         ( )   /'        _--~`              ");
            Console.WriteLine(@"                    \_|      /        _) | ;  ),   __--~~                   ");
            Console.WriteLine(@"                      '~~--_/      _-~/- |/ \   '-~ \                       ");
            Console.WriteLine(@"                     {\__--_/}    / \\_>-|)<__\      \                      ");
            Console.WriteLine(@"                     /'   (_/  _-~  | |__>--<__|      |                     ");
            Console.WriteLine(@"                    |   _/) )-~     | |__>--<__|      |                     ");
            Console.WriteLine(@"                    / /~ ,_/       / /__>---<__/      |                     ");
            Console.WriteLine(@"                   o-o _//        /-~_>---<__-~      /                      ");
            Console.WriteLine(@"                   (^(~          /~_>---<__-      _-~                       ");
            Console.WriteLine(@"                  ,/|           /__>--<__/     _-~                          ");
            Console.WriteLine(@"               ,//('(          |__>--<__|     /                  .--_       ");
            Console.WriteLine(@"              ( ( '))          |__>--<__|    |                 /' _-_~\     ");
            Console.WriteLine(@"           `-)) )) (           |__>--<__|    | -The Dragon    /'  /   ~\`\   ");
            Console.WriteLine(@"          ,/,'//( (             \__>--<__\    \            /'  //      ||   ");
            Console.WriteLine(@"        ,( ( ((, ))              ~-__>--<_~-_  ~--__---~'/'/  /'       VV   ");
            Console.WriteLine(@"      `~/  )` ) ,/|                 ~-_~>--<_/-__      __-~ _/              ");
            Console.WriteLine(@"    ._-~//( )/ )) `                    ~~-'_/_/ /~~~~~__--~                 ");
            Console.WriteLine(@"     ;'( ')/ ,)(                              ~~~~~~~~                      ");
            Console.WriteLine(@"    ' ') '( (/                                                              ");
            Console.WriteLine(@"        }                                                                   ");
            Console.WriteLine(@"                                                                ");
            Console.ResetColor();
        }

        internal static void HappyEnd()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                                                     ,.=,,==. ,,_");
            Console.WriteLine(@"                                    _ ,====, _    |I|`` ||  `|I `|           ");
            Console.WriteLine(@"                _|\_,              |`I|    || `==,|``   ^^   ``  |           ");
            Console.WriteLine(@"        ,.--,   \_ `a\_            | ``    ^^    ||_,===TT`==,,_ | -    -    ");
            Console.WriteLine(@"   6^`--:_ ||  ,/  ,-,,\           |,==Y``Y==,,__| \L=_-`'   +J/`            ");
            Console.WriteLine(@"  / \```\ \|\_/ /-/\\  `            \|=_  ' -=#J/..-|=_-     =|              ");
            Console.WriteLine(@" /  \.., | \/  /-/  `                |=_   -;-='`. .|=_-     =|----T--,      ");
            Console.WriteLine(@"/   \..,'|    /-|                    |=/\  -|=_-. . |=_-/^\  =||-|-|::|____  ");
            Console.WriteLine(@"    \__     \_L-==,                  |=||  -|=_-. . |=_-| |  =|-|-||::\____  ");
            Console.WriteLine(@"    |  /   \_.-..=                   |=LJ  -|=_-. . |=_-|_|  =||-|-|:::::::  ");
            Console.WriteLine(@"    \ /    /--_/\                    |=_   -|=_-_.  |=_-     =|-|-||::::::   ");
            Console.WriteLine(@"   _J`   .'-_,/\_``=                 |=_   -|=//^\. |=_-     =||-|-|:::::::  ");
            Console.WriteLine(@"`X`    \/--_/    `-`             ,   |/&_,_-|=||  | |=_-     =|-|-||:::::::  ");
            Console.WriteLine(@"/   \   |_/                   ,--``8%,/    ',%||  | |=_-     =||-|-|%::::::  ");
            Console.WriteLine(@"   _/  / /                ,---`_,888`  ,.'''''`-.,|,|/!,--,.&\|&\-,|&#:::::  ");
            Console.WriteLine(@"./`; /`/`                |;:;K`__,...;=\_____,=``           %%%&     %#,---  ");
            Console.WriteLine(@"    \\\\                 |;::::::::::::|       `'.________+-------\   ``     ");
            Console.WriteLine(@"     w w           |    /8M%;:::;;:::::|                  |        `-------  ");
            Console.WriteLine(@"                   |   |`   88`V  /&8%\|_______,__,,      |                  ");
            Console.WriteLine(@"                   |   /,  %8,  ,/&888% &,       ,  `-----`,--..../|--,,,,_  ");
            Console.WriteLine(@"                  / \/88%  88%  8888%88% &,       \,     `\      /     &,,   ");
            Console.WriteLine(@"                  |,M8,  , `8%   ,,8% `8, `         , \,        &\     ,&##  ");
            Console.WriteLine(@"                 /8888%  888`    ```    `            `  `               ```  ");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"                               ,/     _,---._         ");
            Console.WriteLine(@"                    ,       _,'/|  ,-'       `.                   ");
            Console.WriteLine(@"                     \.__,-' // `./   ____     \                  ");
            Console.WriteLine(@"                      \\    //   `. ,'\__/`.    \                 ");
            Console.WriteLine(@"                       \\  //      `.,'  `./`.   `.               ");
            Console.WriteLine(@"                        ||//         `-.   `.'|    \              ");
            Console.WriteLine(@"                        / ,`,===========:=- |-|     \             ");
            Console.WriteLine(@"            __        ,' )\,_        ,-'    | |      `.__         ");
            Console.WriteLine(@"          /))/)       \,/)/ \\\    /'      /`-|          `---.___ ");
            Console.WriteLine(@"         ())'_)       / '   /,\\ ,/       |`-,'                   ");
            Console.WriteLine(@"         /)).\____,-_/  , ,'~  \\|        |--|          ,         ");
            Console.WriteLine(@"        (()||_)~~~~|' ,','      )'        `._,\  `.     `.        ");
            Console.WriteLine(@"         ((\\/      \/_/       (          / `.-\   \      )       ");
            Console.WriteLine(@"           /\\                  `,       /    \-`-.,'   ,/        ");
            Console.WriteLine(@"          / ')\                        ,'     /`-./   ,'---.____  ");
            Console.WriteLine(@"         |     |                      /   ,--'   /   /---.______  ");
            Console.WriteLine(@"         |  |  |            ,-.-. _,-'  ,-,-._  /  _/             ");
            Console.WriteLine(@"         |_/|_,'           /\/ ) `  /|,/\/\_, `-  /\              ");
            Console.WriteLine(@"          // ||_          //'|/\__,'\|(/'|/ \___,'`,)             ");
            Console.WriteLine(@"          `-  ~~          `  `           `                        ");
            Console.ReadKey();
            Environment.Exit(0);
            
        }

        internal static void DragonSurrended()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                                                       ____________");
            Console.WriteLine(@"                                 (`-..________....-- - ''  ____..._.-`         ");
            Console.WriteLine(@"                                  \\`._______.._,.-- - '''     ,'              ");
            Console.WriteLine(@"                                  ; )`.      __..- '`-.      /                 ");
            Console.WriteLine(@"                                 / / _.- ' _,.;;._ `-._,'                      ");
            Console.WriteLine(@"                                / /   ,-' _.-'  //   ``--._``._                ");
            Console.WriteLine(@"                              ,','_.- ' ,-' _.- (( = - -. `-._`-._____         ");
            Console.WriteLine(@"                            ,;.''__..- '   _..--.\\.--'````--.._``-.`-._`.     ");
            Console.WriteLine(@"             _ |\,' .-''        ```-'`---'`-...__,._  ``-.`-.`-.`.             ");
            Console.WriteLine(@"  _ _.-,'(__)\__)\-'' `     ___  .          `     \      `--._                 ");
            Console.WriteLine(@",',)---' /|)          `     `      ``-.   `     /     /     `     `-.          ");
            Console.WriteLine(@"\_____--.  '`  `               __..-.  \     . (   < _...-----..._   `.        ");
            Console.WriteLine(@" \_,--..__. \\ .-`.\----'';``,..-.__ \  \      ,`_. `.,-'`--'`---''`.  )       ");
            Console.WriteLine(@"           `.\`.\  `_.-..' ,'   _,-..'  /..,-''(, ,'; (_______`___..'__        ");
            Console.WriteLine(@"                 ((, (, __(((, (, __, '  ``'-- `'`.(\  `.,..______   SSt       ");
            Console.WriteLine(@"                                                      ``--------..._``--.__    ");
            Console.ResetColor();
        }

        internal static void Mentor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"                          ");
            Console.WriteLine(@"               .--.         ");
            Console.WriteLine(@"               , , )        ");
            Console.WriteLine(@"               <  /)        ");
            Console.WriteLine(@"             _(())\)        ");
            Console.WriteLine(@"          .-' (()/  '-.     ");
            Console.WriteLine(@"        _ / ()      \    / .");
            Console.WriteLine(@"       oo)__ / ()  \  |   / ");
            Console.WriteLine(@"       :~    \_  ) _ / _ /  ");
            Console.WriteLine(@"       |      | -(--| (,/ | ");
            Console.WriteLine(@"       |                    ");
            Console.WriteLine(@"       |     /   )   \   |  ");
            Console.WriteLine(@"       |                    ");
            Console.WriteLine(@" |     | (     \  |         ");
            Console.WriteLine(@"       |     | (  | /       ");
            Console.WriteLine(@"       |     /  .     |  |/ ");
            Console.WriteLine(@"       |     |  :     |     ");
            Console.WriteLine(@"       |     | __ / _____\  ");
            Console.WriteLine(@"      .,,.  oo = '  oo='    ");
            Console.ResetColor();
        }

        internal static void Stable()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"   _____,,;;;`;       ;';;;,,_____");
            Console.WriteLine(@",~(  )  , )~~\|       |/~~( ,  (  )~;         ");
            Console.WriteLine(@"' / / --`--,             .--'-- \ \ `         ");
            Console.WriteLine(@" /  \    | '             ` |    /  \          ");
            Console.WriteLine(@"                                              ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"        ,--,                                  ");
            Console.WriteLine(@"  _ ___/ /\|                                  ");
            Console.WriteLine(@" ;( )__, )                                    ");
            Console.WriteLine(@"; //   '--;                                   ");
            Console.WriteLine(@"  \     |                                     ");
            Console.WriteLine(@"   ^    ^                                     ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"                                              ");
            Console.WriteLine(@"       _ ____                                 ");
            Console.WriteLine(@"     /( ) _   \                               ");
            Console.WriteLine(@"    / //   /\` \,  ||--||--||-                ");
            Console.WriteLine(@"      \|   |/  \|  ||--||--||-                ");
            Console.WriteLine(@"~^~^~^~~^~~~^~~^^~^^^^^^^^^^^^");
            Console.ResetColor();
        }

        internal static void Horse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@". . . .      ");
            Console.WriteLine(@"                      ,`,`,`,`,               ");
            Console.WriteLine(@". . . .               `\`\`\`\;               ");
            Console.WriteLine(@"`\`\`\`\`,            ~|;!;!;\!               ");
            Console.WriteLine(@" ~\;\;\;\|\          (--,!!!~`!       .       ");
            Console.WriteLine(@"(--,\\\===~\         (--,|||~`!     ./        ");
            Console.WriteLine(@" (--,\\\===~\         `,-,~,=,:. _,//         ");
            Console.WriteLine(@"  (--,\\\==~`\        ~-=~-.---|\;/J,         ");
            Console.WriteLine(@"   (--,\\\((```==.    ~'`~/       a |         ");
            Console.WriteLine(@"     (-,.\\('('(`\\.  ~'=~|     \_.  \        ");
            Console.WriteLine(@"        (,--(,(,(,'\\. ~'=|       \\_;>       ");
            Console.WriteLine(@"          (,-( ,(,(,;\\ ~=/        \          ");
            Console.WriteLine(@"          (,-/ (.(.(,;\\,/          )         ");
            Console.WriteLine(@"           (,--/,;,;,;,\\         ./------.   ");
            Console.WriteLine(@"             (==,-;-'`;'         /_,----`. \  ");
            Console.WriteLine(@"     ,.--_,__.-'                    `--.  ` \ ");
            Console.WriteLine(@"    (='~-_,--/        ,       ,!,___--. \  \_)");
            Console.WriteLine(@"   (-/~(     |         \   ,_-         | ) /_|");
            Console.WriteLine(@"   (~/((\    )\._,      |-'         _,/ /     ");
            Console.WriteLine(@"    \\))))  /   ./~.    |           \_\;      ");
            Console.WriteLine(@" ,__/////  /   /    )  /                      ");
            Console.WriteLine(@"  '===~'   |  |    (, <.                      ");
            Console.WriteLine(@"           / /       \. \                     ");
            Console.WriteLine(@"         _/ /          \_\                    ");
            Console.WriteLine(@"        /_!/            >_\                   ");
            Console.WriteLine(@"        }                                     ");
            Console.WriteLine(@"                                      ");
            Console.ResetColor();
        }
        internal static void TheBar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("          The Bar    ");
            Console.WriteLine(@"         ,~,       ");
            Console.WriteLine(@"         )))Y                  ");
            Console.WriteLine(@"        ((((,\________________ ");
            Console.WriteLine(@"        \)/( [_____________    ");
            Console.WriteLine(@"        (   \  |  [_]   [_]    ");
            Console.WriteLine(@"         )___\ |   |     |     ");
            Console.WriteLine(@"         (| (\ |   |     |     ");
            Console.WriteLine(@"  BAR    q`_ q`_  _|_   _|_    ");
            Console.ResetColor();
        }

        internal static void Barman()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("              The BarMan");
            Console.WriteLine(@"            .sS$$$$$$$$$$$$$$Ss.");
            Console.WriteLine(@"          .$$$$$$$$$$$$$$$$$$$$$$s.       ");
            Console.WriteLine(@"          $$$$$$$$$$$$$$$$$$$$$$$$S.      ");
            Console.WriteLine(@"          $$$$$$$$$$$$$$$$$$$$$$$$$$s.    ");
            Console.WriteLine(@"          S$$$$'        `$$$$$$$$$$$$$    ");
            Console.WriteLine(@"          `$$'            `$$$$$$$$$$$.   ");
            Console.WriteLine(@"           :               `$$$$$$$$$$$   ");
            Console.WriteLine(@"          :                 `$$$$$$$$$$   ");
            Console.WriteLine(@"       .====.  ,=====.       $$$$$$$$$$   ");
            Console.WriteLine(@"     .'      ~'       '    .s$$$$$$$$$$   ");
            Console.WriteLine(@"     :       :         := _  $$$$$$$$$$$  ");
            Console.WriteLine(@"     `.  ()  :   ()    '  ~=$$$$$$$$$$$'   ");
            Console.WriteLine(@"       ~==== ~`.      .'    $$$$$$$$$$$   ");
            Console.WriteLine(@"        .'     ~====~     sS$$$$$$$$$'    ");
            Console.WriteLine(@"        :      .         $$$$$' $$$$      ");
            Console.WriteLine(@"      .sS$$$$$$$$Ss.     `$$'   $$$'      ");
            Console.WriteLine(@"     $$$$$$$$$$$$$$$s         s$$$$       ");
            Console.WriteLine(@"     $SSSSSSSSSSSSSSS$        $$$$$       ");
            Console.WriteLine(@"          :                   $$$$'       ");
            Console.WriteLine(@"           `.                 $$$'        ");
            Console.WriteLine(@"             `.               :           ");
            Console.WriteLine(@"              :               :           ");
            Console.WriteLine(@"              :              .'`.         ");
            Console.WriteLine(@"             .'.           .'   :         ");
            Console.WriteLine(@"            : .$s.       .'    .'         ");
            Console.WriteLine(@"            :.S$$$S.   .'    .'           ");
            Console.WriteLine(@"            : $$$$$$`.'    .'             ");
            Console.WriteLine(@"               $$$$   `. .'               ");
            Console.ResetColor();
        }

        internal static void Sword()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                     /   ))     |\         )               ).     ");
            Console.WriteLine(@"               c--. (\  ( `.    / )  (\   ( `.     ).     ( (                 ");
            Console.WriteLine(@"               | |   ))  ) )   ( (   `.`.  ) )    ( (      ) )                ");
            Console.WriteLine(@"               | |  ( ( / _..----.._  ) | ( ( _..----.._  ( (                 ");
            Console.WriteLine(@" ,-.           | |---) V.'-------.. `-. )-/.-' ..------ `--) \._              ");
            Console.WriteLine(@" | /===========| |  (   |      ) ( ``-.`\/'.-''           (   ) ``-._         ");
            Console.WriteLine(@" | | / / / / / | |--------------------->  <-------------------------_>=-      ");
            Console.WriteLine(@" | \===========| |                 ..-'./\.`-..                _,,-'          ");
            Console.WriteLine(@" `-'           | |-------._------''_.-'----`-._``------_.-----'               ");
            Console.WriteLine(@"               | |         ``----''            ``----''                       ");
            Console.WriteLine(@"               | |                                                            ");
            Console.WriteLine(@"               c--`                                                           ");
            Console.ResetColor();
        }

        internal static void OutOfBar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                                           |           /   ");
            Console.WriteLine(@"                                           |          /    ");
            Console.WriteLine(@"  .-------.            _.----._           /|   gluk  /     ");
            Console.WriteLine(@" / ?  |    \     Now get the   \         / |  ___gluk      ");
            Console.WriteLine(@"|/\\  |  //\|     hell outta    |       / R| //\\\ /       ");
            Console.WriteLine(@"|.I.) | (.I.|        here!!     |      / A |(( **)^        ");
            Console.WriteLine(@"|\o/  |  \O |        |      \_  |      )B /| \ o=:MM       ");
            Console.WriteLine(@"'-----------'        |        .-|     (  / |  ) //         ");
            Console.WriteLine(@"                     |      _/ /|      )/  |  | |\_._/(   /");
            Console.WriteLine(@"    #!@%#X@!         |     |X|/ |     (/   |  \_______(  / ");
            Console.WriteLine(@"   You stupid        |     (_)  |          | /          / /");
            Console.WriteLine(@"____Bastard!____/____|__________|__________|/          / / ");
            Console.WriteLine(@"       \|  .---. ___/___   /            .             / /  ");
            Console.WriteLine(@"          (( ^  ) ____| )   /                        / /   ");
            Console.WriteLine(@"  .        >:-o`//    \ \____                    `  / /    ");
            Console.WriteLine(@"_______________//______\.__| (_____________________/ /     ");
            Console.WriteLine(@"db____________()___________\_(_____________________|/      ");
            Console.WriteLine(@"                                                           ");
            Client.Timer(3);
            Console.Clear();

            Console.WriteLine(@"                                                            ");
            Console.WriteLine(@"                                                     ___, ------,       ");
            Console.WriteLine(@"             _, --.-- -.__, --'         /                               ");
            Console.WriteLine(@"           , ' _,'_`._ \                    _, -'           ___,|       ");
            Console.WriteLine(@"          ; --'       `^-.                ,'        __,---'   ||        ");
            Console.WriteLine(@"        ,'               \             ,'      _,-'          ||         ");
            Console.WriteLine(@"       /                  \         _,'     ,-' ||                      ");
            Console.WriteLine(@"      :                    .      ,'     _,' |:                         ");
            Console.WriteLine(@"      |                    :     `.    ,'                    |:         ");
            Console.WriteLine(@"      | _,-      |       `-,'                      ::                   ");
            Console.WriteLine(@"     ,'____ ,  ,-'  `.   , |,         `.                     : \        ");
            Console.WriteLine(@"     ,'    `-,'       ) / \/ \          \                     : :       ");
            Console.WriteLine(@"     | _\   o _,-'    ' -.           `.                    \ \          ");
            Console.WriteLine(@"      `o_,-'  `-,-' ____   ,` )-.______,'  `.                   : :     ");
            Console.WriteLine(@"       \-\    _,---'    `-. -'.\  `.  /     `.                  \  \    ");
            Console.WriteLine(@"        / `--'             `.   \   \:        \                  \,.\   ");
            Console.WriteLine(@"       (____,  \  |    \\        \                 :\ \\                ");
            Console.WriteLine(@"        )         _,-'    `   | |    | \        \                 \\_\\ ");
            Console.WriteLine(@"       / _,-'            | |   ,' -`._ _\                 \,'           ");
            Console.WriteLine(@"       `-----' |`-.           ;/   (__ ,' `-._; -'`\           _,--'    ");
            Console.WriteLine(@"     ,'        |   `._     _,' \-._ / Y    ,-'      \      _,-'         ");
            Console.WriteLine(@"    / _ |      `---'    :,-|   |    `     _,-'\_,--'   \                ");
            Console.WriteLine(@"   :          `|       \`-._ /  | '     `.,-' `._`         \            ");
            Console.WriteLine(@"   | _\_ _,\/ _,-'|                     `-._       \                    ");
            Console.WriteLine(@"   :   ,-         `.-'_,--'    \                         `       \      ");
            Console.WriteLine(@"   | ,'           ,--'      _,--\           _,                    :     ");
            Console.WriteLine(@"    )         .    \___,---'   ) `-.____,--' |                          ");
            Console.WriteLine(@"   _\    .     `    ||        :            \                      ;     ");
            Console.WriteLine(@" ,'  \    `.    )--';        |             `-.                  /       ");
            Console.WriteLine(@"|     \     ; --^._,-'         |                `-._            _/_\    ");
            Console.WriteLine(@"\    ,'`---' |                    `--._____,-'_'  \                     ");
            Console.WriteLine(@" \_,'                         `._                          _,-'     `   ");
            Console.WriteLine(@"          -    -             ,-'  `---.___           __,---'            ");
            Console.WriteLine(@", '             `---------'                                 ");
            Client.Timer(3);
            Console.Clear();
            Texts.NoChoice();
            Client.Timer(3);
            Console.Clear();
            Console.WriteLine(@"                                           |           /");
            Console.WriteLine(@"                                           |     Why do you         ");
            Console.WriteLine(@"  .-------.            _.----._           /|     keep going         ");
            Console.WriteLine(@" /    |    \          /        \         / |        back in         ");
            Console.WriteLine(@"|//\\ | .||||        |      ? ? |       / R| //\\  / there?         ");
            Console.WriteLine(@"|.I.) | |o-o|        |    ,,,,  |      / A |( .. )/                 ");
            Console.WriteLine(@"|\=/  |  \-/|        |   (  .|. |      )B /| \O //                  ");
            Console.WriteLine(@"'-----------'        |    \ -/ .|     (  / |  ) )/\                 ");
            Console.WriteLine(@"                     | ^  _||_  |      )/  | /| //\\_     /         ");
            Console.WriteLine(@"                     | \\/    \___    (/   |O/|_/ |__)   /          ");
            Console.WriteLine(@"                     |  \\/   |---O        | /          / /         ");
            Console.WriteLine(@"_____________________|____|   |_|__________|/          / /          ");
            Console.WriteLine(@"                          \___|                       / /           ");
            Console.WriteLine(@"  .                       | | |      `               / /            ");
            Console.WriteLine(@"                          |_|_|_                    / /             ");
            Console.WriteLine(@"_________________________(__|___)__________________/ /              ");
            Console.WriteLine(@"db_________________________________________________|/               ");
            Console.WriteLine(@"                                                                    ");
            Client.Timer(3);
            Console.Clear();
            Console.ResetColor();
        }

        internal static void BlackSmithPlace()
        {
            Console.WriteLine("                   The Blacksmith Place");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"       |______________                                         ");
            Console.WriteLine(@"[======|______________ >                                                  ");
            Console.WriteLine(@"       |                                                                   ");
            Console.WriteLine(@"       '                                                                   ");
            Console.WriteLine(@"                                                                           ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"      /| ________________                                                  ");
            Console.WriteLine(@"O |===|*>________________ >                                             ");
            Console.WriteLine(@"      \|                                                                   ");
            Console.WriteLine(@"                                                                           ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"           /\                                                 /\           ");
            Console.WriteLine(@" _         )(______________________   ______________________)(_            ");
            Console.WriteLine(@"(_)///////(**)______________________> <______________________(**)\\\\\\\(_)");
            Console.WriteLine(@"           )()(                                                            ");
            Console.WriteLine(@"           \/                                                 \/           ");
            Console.WriteLine(@"                                                                           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"         /> _________________________________                              ");
            Console.WriteLine(@"[########[]__________________________________>                              ");
            Console.WriteLine(@"         \>                                                                ");
            Console.WriteLine(@"                                                                           ");
            Console.WriteLine(@"                                                                           ");
            Console.ResetColor();
        }

        internal static void DragonPlace()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                  _________________          ");
            Console.WriteLine(@"             ____/#################\____                 ");
            Console.WriteLine(@"         ___/################,##########\___             ");
            Console.WriteLine(@"       _/################/##/ \##\##########\_           ");
            Console.WriteLine(@"      /#################/\##| |##/\###########\          ");
            Console.WriteLine(@"     /##################\ \#| |#/ /############\         ");
            Console.WriteLine(@"    |####################\ \| |/ /##############|        ");
            Console.WriteLine(@"    |####################{{{\ /}}}##############|        ");
            Console.WriteLine(@"    |###################{{<.> <.>}}#############|        ");
            Console.WriteLine(@"    |#####################{ | | }###############|        ");
            Console.WriteLine(@"    |#####################{ | | }####_#######__#|        ");
            Console.WriteLine(@"    |#####################/_| |_\##_( )###__(  )_        ");
            Console.WriteLine(@"    |####################{(_)_(_)}(  ` )_( '__ ` )       ");
            Console.WriteLine(@"    |#####################{VV_VV}##(__( `)_(  )-` )      ");
            Console.WriteLine(@"    |#####################\^^))^/######(   )_')  )       ");
            Console.WriteLine(@"    |######################--((-########( ' _)__)        ");
            Console.WriteLine(@"    |########################))##########(__)###|        ");
            Console.WriteLine(@"    |########################(##################|        ");
            Console.WriteLine(@"    |###########################################|        ");
            Console.WriteLine(@"    |###########################################|        ");
            Console.WriteLine(@"    |###########################################|        ");
            Console.WriteLine(@"    |###########################################|        ");
            Console.WriteLine(@"\ | /########| |################################| \ | /  ");
            Console.WriteLine(@"_\|/|#######/   \####################\|/########|__\|/___");
            Console.WriteLine(@"            \   /                                        ");
            Console.WriteLine(@"             \ /                                         ");
            Console.WriteLine(@"              V                                          ");
            Console.ResetColor();
        }

        internal static void Mountain()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@" * *******************************************************************************");
            Console.WriteLine(@"*                    /   \              /'\       _                              *");
            Console.WriteLine(@"*\_..           /'.,/     \_         .,'   \     / \_                            *");
            Console.WriteLine(@"*    \         /            \      _/       \_  /    \     _                     *");
            Console.WriteLine(@"*     \__,.   /              \    /           \/.,   _|  _/ \                    *");
            Console.WriteLine(@"*          \_/                \  /',.,''\      \_ \_/  \/    \                   *");
            Console.WriteLine(@"*                           _  \/   /    ',../',.\    _/      \                  *");
            Console.WriteLine(@"*             /           _/m\  \  /    |         \  /.,/'\   _\                 *");
            Console.WriteLine(@"*           _/           /MMmm\  \_     |          \/      \_/  \                *");
            Console.WriteLine(@"*          /      \     |MMMMmm|   \__   \          \_       \   \_              *");
            Console.WriteLine(@"*                  \   /MMMMMMm|      \   \           \       \    \             *");
            Console.WriteLine(@"*                   \  |MMMMMMmm\      \___            \_      \_   \            *");
            Console.WriteLine(@"*                    \|MMMMMMMMmm|____.'  /\_            \       \   \_          *");
            Console.WriteLine(@"*                    /'.,___________...,,'   \            \   \        \         *");
            Console.WriteLine(@"*                   /       \          |      \    |__     \   \_       \        *");
            Console.WriteLine(@"*                 _/        |           \      \_     \     \    \       \_      *");
            Console.WriteLine(@"*                /                               \     \     \_   \        \     *");
            Console.WriteLine(@"*                                                 \     \      \   \__      \    *");
            Console.WriteLine(@"*                                                  \     \_     \     \      \   *");
            Console.WriteLine(@"*                                                   |      \     \     \      \  *");
            Console.WriteLine(@"*                                                    \            |            \ *");
            Console.WriteLine(@" * *******************************************************************************");
            Console.ResetColor();
        }

        internal static void WizardPlace()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" __   __       ___   ___      ___   ___");
            Console.WriteLine(@"(  \,/  )     ( @ \Y/ @ )    ((o)\,/(o))           ");
            Console.WriteLine(@" \_ | _/       \__+|+__/      \__ | __/            ");
            Console.WriteLine(@" (_/ \_)        {_/ \_}        {_/'\_}             ");
            Console.WriteLine(@"                                                   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                                                   ");
            Console.WriteLine(@" ___   ___     ___   ___       __   __             ");
            Console.WriteLine(@"( @ \v/ m )   { ~ \,/ ~ }     (()\,/  )            ");
            Console.WriteLine(@" \__+|+__/     \_~_|_~_/       \_ | _/             ");
            Console.WriteLine(@"  {_/ \_}       (_/'\_)        { /'\*}             ");
            Console.WriteLine(@"                                                   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                                   ");
            Console.WriteLine(@" __ Y __        __   __       ___   ___            ");
            Console.WriteLine(@"(()\o/())     ( s \Y/ s )    ( q \,/ p )           ");
            Console.WriteLine(@" \_ I _/       \_<>|<>_/      \_ 6|9 _/            ");
            Console.WriteLine(@"  (/I\)         (_/'\_)        {_/ \_}               ");
            Console.ResetColor();
        }

        internal static void King()
        {
            Console.WriteLine(@".        ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                            / \                   ");
            Console.WriteLine(@"                           _\ /_                  ");
            Console.WriteLine(@"                 .     .  (,'v`.)  .     .        ");
            Console.WriteLine(@"                 \)   ( )  ,' `.  ( )   (/        ");
            Console.WriteLine(@"                  \`. / `-'     `-' \ ,'/         ");
            Console.WriteLine(@"                   : '    _______    ' :          ");
            Console.WriteLine(@"                   |  _,-'  ,-.  `-._  |          ");
            Console.WriteLine(@"                   |,' ( )__`-'__( ) `.|          ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                   (|,-,'-._   _.-`.-.|)          ");
            Console.WriteLine(@"                   /  /<( o)> <( o)>\  \          ");
            Console.WriteLine(@"                   :  :     | |     :  :          ");
            Console.WriteLine(@"                   |  |     ; :     |  |          ");
            Console.WriteLine(@"                   |  |    (.-.)    |  |          ");
            Console.WriteLine(@"                   |  |  ,' ___ `.  |  |          ");
            Console.WriteLine(@"                   ;  |)/ ,'---'. \(|  :          ");
            Console.WriteLine(@"               _,-/   |/\(       )/\|   \-._      ");
            Console.WriteLine(@"         _..--'.-(    |   `-'''-'   |    )-.`--.._");
            Console.WriteLine(@"                  `.  ;`._________,':  ,'         ");
            Console.WriteLine(@"                 ,' `/               \'`.         ");
            Console.WriteLine(@"                      `------.------'         King");
            Console.ResetColor();
        }

        internal static void Princess()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"       _                           _");
            Console.WriteLine(@"      / `._        \+O+/        _.' \           ");
            Console.WriteLine(@"     ( @ : `.      //`\\      .' : @ )          ");
            Console.WriteLine(@"      \  `.  `.   ((a a))   .'  .'  /           ");
            Console.WriteLine(@"       \;' `.  `.((( - ))).'  .' `;/            ");
            Console.WriteLine(@"        \`.  `.  ((()=()))  .'  .'/             ");
            Console.WriteLine(@"         ) :-._`/`(('Y'))`\'_.-: (              ");
            Console.WriteLine(@"         (`..../ / (_ * _)\ \....')             ");
            Console.WriteLine(@"          > ---/ /  )(  \ \---<                 ");
            Console.WriteLine(@"         / .'.\ \_/\\_//\_/ /.'. \              ");
            Console.WriteLine(@"         | o _.-\/ _) '*'(_\/ -._ o |           ");
            Console.WriteLine(@"         |`'   ;/         \;   `' |             ");
            Console.WriteLine(@"         '.o_.-/           \-._o.'              ");
            Console.WriteLine(@"           '._/             \_.'                ");
            Console.WriteLine(@"             /               \                  ");
            Console.WriteLine(@"            /                 \                 ");
            Console.WriteLine(@"           /                   \                ");
            Console.WriteLine(@" Princess /                     \               ");
            Console.WriteLine(@"         /                       \              ");
            Console.WriteLine(@"         `----....._____.....----'              ");
            Console.ResetColor();
        }

        public static void HouseSpace()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========================================================");
            Console.WriteLine(@"|      #                                               |");
            Console.WriteLine(@"|     'O'                                   __]        |");
            Console.WriteLine(@"|     /|\                                   | |        |");
            Console.WriteLine(@"|     / \                                  TheChair    |");
            Console.WriteLine(@"|                                                      |");
            Console.WriteLine(@"|---------------|                                      |");
            Console.WriteLine(@"|    The bed    |                                     ((");
            Console.WriteLine(@"|               |                            The door ((");
            Console.WriteLine(@"|---------------|                                     ((");
            Console.WriteLine(@"|                                                      |");
            Console.WriteLine(@"|                                                      |");
            Console.WriteLine(@"|  _______                                             |");
            Console.WriteLine(@"|  | O  o| Cook                        a cat           |");
            Console.WriteLine(@"|  | o  O| Food                       _==>             |");
            Console.WriteLine("========================================================");
            Console.ResetColor();
        }

        public static void Sleeping()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================================");
            Console.WriteLine(@"|                                                      |");
            Console.WriteLine(@"|                                           __]        |");
            Console.WriteLine(@"|                                           | |        |");
            Console.WriteLine(@"|                                          TheChair    |");
            Console.WriteLine(@"|     The bed                                          |");
            Console.WriteLine(@"|---------------|                                      |");
            Console.WriteLine(@"| Zzzz          |                                     ((");
            Console.WriteLine(@"| 0-<--<        |                            The door ((");
            Console.WriteLine(@"|---------------|                                     ((");
            Console.WriteLine(@"|                                                      |");
            Console.WriteLine(@"|                                                      |");
            Console.WriteLine(@"|  _______                                             |");
            Console.WriteLine(@"|  | O  o| Cook                        a cat           |");
            Console.WriteLine(@"|  | o  O| Food                       _==>             |");
            Console.WriteLine("========================================================");
            Console.ResetColor();
            Texts.Lazy();

        }

        public static void Drinking()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@".===================================================================.");
            Console.WriteLine(@"||                                                                 ||  ");
            Console.WriteLine(@"|| -=]                                                             ||  ");
            Console.WriteLine(@"|| -=]                                                             ||  ");
            Console.WriteLine(@"||                            ___                                  ||  ");
            Console.WriteLine(@"||                          .'   '.                                ||  ");
            Console.WriteLine(@"||                         /       \           oOoOo               ||  ");
            Console.WriteLine(@"||                        |   O  O  |       ,==|||||               ||  ");
            Console.WriteLine(@"||                         \       /       _|| |||||               ||  ");
            Console.WriteLine(@"||                          '.___.'    _.-'^|| |||||               ||  ");
            Console.WriteLine(@"||                        __/_______.-'     '==HHHHH               ||  ");
            Console.WriteLine(@"||                   _.-'` /                   '''''               || ");
            Console.WriteLine(@"||                .- '    /   oOoOo                                ||  ");
            Console.WriteLine(@"||                `-._ /    ==|||||                                ||  ");
            Console.WriteLine(@"|| '-/._|| |||||                                                   ||  ");
            Console.WriteLine(@"||                     /    ^|||||||                               || ");
            Console.WriteLine(@"||                    /     '==HHHHH                               ||    ");
            Console.WriteLine(@"||                   / _______''''                                 || ");
            Console.WriteLine(@"||                   `\       `\                                   || ");
            Console.WriteLine(@"||                     \        `\   /                             || ");
            Console.WriteLine(@"||                      \         `\/                              || ");
            Console.WriteLine(@"||                      /                                          || ");
            Console.WriteLine(@"||                     /                                           || ");
            Console.WriteLine(@"|| BAR / _____                                                     || ");
            Console.WriteLine(@"||                                                                 || ");
            Console.WriteLine(@"'===================================================================' ");
            Console.ResetColor();

        }

        public static void Castle()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"   ___                                                    ___                       ");
            Console.WriteLine(@"                      T)))                       __,___,_                    T)))               ");
            Console.WriteLine(@"                      |                          TT  )   )                   |                  ");
            Console.WriteLine(@"                     /T\                         ||  )   )                  /T\                 ");
            Console.WriteLine(@"                    / L \                        ||-^--^-'                 / L \                ");
            Console.WriteLine(@"                   / [O] \                       ||                       / [O] \               ");
            Console.WriteLine(@"                  /   T   \                  _.+'||'+._                  /   T   \              ");
            Console.WriteLine(@"                 |____|____|             _.+'____/\____'+._             |____|____|             ");
            Console.WriteLine(@"                   [_]|[_]              [_]_____[||]_____[_]              [_]|[_]               ");
            Console.WriteLine(@"                  .[_]|[_].             [_]_____[||]_____[_]             .[_]|[_].              ");
            Console.WriteLine(@"          ._._._._|IIIIIII|._._._._.___.====================.___._._._._.|IIIIIII|_._._._.      ");
            Console.WriteLine(@"         /|\._./\|/   L   \|/._._.\|[_] \/   \II/[]\II/   \/ [_]|/._._.\|/   L   \|/\._./|\     ");
            Console.WriteLine(@"        []TTTTTTT[]==[O]==[]TTTTTTTT[_] /\_._.II_[]_II._._/\ [_]TTTTTTTT[]==[O]==[]TTTTTTT[]    ");
            Console.WriteLine(@"        []|._._.|[]   T   []._./\._.[_]/  [__]/  ||  \[__]  \[_]._./\._.[]   T   []|._._.|[]    ");
            Console.WriteLine(@"        []IIIIIII[]IIIIIII[]IIIIIIII[_]===[__]\._||_./[__]===[_]IIIIIIII[]IIIIIII[]IIIIIII[]    ");
            Console.WriteLine(@"       /|--------[]-------[]--------[_]---[__]-+=II=+-[__]---[_]--------[]-------[]--------|\   ");
            Console.WriteLine(@"      /|| _/T\_  ||\\_I_//||  _/T\_ [_]    \_\_/T\/T\_/_/    [_] _/T\_  ||\\_I_//||  _/T\_ ||\  ");
            Console.WriteLine(@"      ||| |_O_| ,/|=/_|_\=|\, |_O_| [_]    |_L_LT||TJ_J_|    [_] |_O_| ,/|=/_|_\=|\, |_O_| |||  ");
            Console.WriteLine(@"      ||| |_O_| |||___|___||| |_O_| [_]____[]/|||/\|||\[]    [_] |_O_| |||___|___||| |_O_| |||  ");
            Console.WriteLine(@"      [_]\IIIII/[_]\IIIII/[_]\IIIII/[_]IIII[]\==/%%\==/[]IIII[_]\IIIII/[_]\IIIII/[_]\IIIII/[_]  ");
            Console.WriteLine(@"      [_].\_I_/.[_].\_I_/.[_].\_I_/.[_]\II/[].\_\%%/_/.[]\II/[_].\_I_/.[_].\_I_/.[_].\_I_/.[_]  ");
            Console.WriteLine(@"      L_J./   \.L_J./   \.L_J./   \.L_JI  I[]./      \.[]I  IL_J./   \.L_J./   \.L_J./   \.L_J  ");
            Console.WriteLine(@"      L_J|     |L_J|     |L_J|     |L_J|  |[]|        |[]|  |L_J|     |L_J|     |L_J|     |L_J  ");
            Console.WriteLine(@"      L_J |_____|L_J|_____|L_J|_____|L_J|__|[]|        |[]|__|L_J|_____|L_J|_____|L_J|_____|L_J ");
            Console.ResetColor();
        }

        public static void Dragon()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"                          ,     \    /      ,        ");
            Console.WriteLine(@"                         / \    )\__/(     / \                   ");
            Console.WriteLine(@"                        /   \  (_\  /_)   /   \                  ");
            Console.WriteLine(@"     __________________/_____\__\@  @/___/_____\_________________");
            Console.WriteLine(@"     |                          |\../|                          |");
            Console.WriteLine(@"     |                           \VV/                           |");
            Console.WriteLine(@"     |                                                          |");
            Console.WriteLine(@"     |               How dare you to come to me                 |");
            Console.WriteLine(@"     |                     You'll be my meal                    |");
            Console.WriteLine(@"     |                                                          |");
            Console.WriteLine(@"     |__________________________________________________________|");
            Console.WriteLine(@"                   |    /\ /      \\       \ /\    |             ");
            Console.WriteLine(@"                   |  /   V        ))       V   \  |             ");
            Console.WriteLine(@"                   |/     `       //        '     \|             ");
            Console.WriteLine(@"                   `              V                '  ");
            Console.ResetColor();
        }

        public static void Knight()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"        I'm the dragon slayer         ");
            Console.WriteLine(@"                                    /)");
            Console.WriteLine(@"                                   // ");
            Console.WriteLine(@"                 __*_             //  ");
            Console.WriteLine(@"              /-(____)           //   ");
            Console.WriteLine(@"             ////- -|\          //    ");
            Console.WriteLine(@"          ,____o% -,_          //     ");
            Console.WriteLine(@"         /  \\   |||  ;       //      ");
            Console.WriteLine(@"        /____\....::./\      //       ");
            Console.WriteLine(@"       _/__/#\_ _,,_/--\    //        ");
            Console.WriteLine(@"       /___/######## \/""-(\</        ");
            Console.WriteLine(@"      _/__/ '#######  ""^(/</         ");
            Console.WriteLine(@"    __/ /   ,)))=:=(,    //.          ");
            Console.WriteLine(@"   |,--\   /Q...... /.  (/            ");
            Console.WriteLine(@"   /       .Q....../..\               ");
            Console.WriteLine(@"          /.Q ..../...\               ");
            Console.WriteLine(@"         /......./.....\              ");
            Console.WriteLine(@"         /...../  \.....\             ");
            Console.WriteLine(@"         /_.._./   \..._\             ");
            Console.WriteLine(@"          (` )      (` )              ");
            Console.WriteLine(@"          | /        \ |              ");
            Console.WriteLine(@"          '(          )'              ");
            Console.WriteLine(@"         /+|          |+\             ");
            Console.WriteLine(@" |,/          \,/  Knight              ");
            Console.ResetColor();

        }

        public static void Wizard()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"          .--.   _,  ");
            Console.WriteLine(@"      .--;    \ /(_              ");
            Console.WriteLine(@"     /    '.   |   '-._    . ' . ");
            Console.WriteLine(@"    |       \  \    ,-.)  -= * =-");
            Console.WriteLine(@"     \ /\_   '. \((` .(    '/. ' ");
            Console.WriteLine(@"      )\ /     \ )\  _/   _/     ");
            Console.WriteLine(@"     /  \\    .-'   '--. /_\     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"    |    \\_.' ,        \/||     ");
            Console.WriteLine(@"    \     \_.-';,_) _)'\ \||     ");
            Console.WriteLine(@"     '.       /`\   (   '._/     ");
            Console.WriteLine(@"       `\   .;  |  . '.          ");
            Console.WriteLine(@"         ).'  )/|      \         ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"         `    ` |  \|   |        ");
            Console.WriteLine(@"                 \  |   |        ");
            Console.WriteLine(@"                  '.|   |        ");
            Console.WriteLine(@"                     \  '\__     ");
            Console.WriteLine(@"                      `-._  '. _ ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"                         \`;-.` `._ ");
            Console.WriteLine(@"                          \ \ `'-._\");
            Console.WriteLine(@"                           \ |   ");
            Console.WriteLine(@"                            \ )  ");
            Console.WriteLine(@"                             \_\ ");
            Console.ResetColor();
        }

        public static void KnightFighting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                                               ");
            Console.WriteLine(@"                                                 .         ");
            Console.WriteLine(@"                                                 |\        ");
            Console.WriteLine(@"                                                 ||        ");
            Console.WriteLine(@"                                                 ||        ");
            Console.WriteLine(@"                                                 ||        ");
            Console.WriteLine(@"                                     , __,,       ||       ");
            Console.WriteLine(@"                                     =/= /       ||        ");
            Console.WriteLine(@"                         ,   ,       \j / o->o             ");
            Console.WriteLine(@"                        _)\_ /)      __//___,____/_\       ");
            Console.WriteLine(@"                        (/ (6\> __// /_ /__\_/_/           ");
            Console.WriteLine(@"                       /`  _ /\>< '_\/\/__/                ");
            Console.WriteLine(@"                      / , _//\  \>    _)_/                 ");
            Console.WriteLine(@"                     \_('  |  )>   x)_::\       ______,    ");
            Console.WriteLine(@"                            /  \> __//  o |----.,/(  )\\)) ");
            Console.WriteLine(@"                           \'  \|  )___/ \     \/  \\\\\   ");
            Console.WriteLine(@"                                                           ");
            Console.WriteLine(@"                            / +-/ o / ----+      |         ");
            Console.WriteLine(@"                                                           ");
            Console.WriteLine(@"                           / '     \_\,  ___     /         ");
            Console.WriteLine(@"                          /  \_ | _ /\_ | -' /,    / ");
            Console.WriteLine(@"                         / _ / / _ /   )\|  | _ /          ");
            Console.WriteLine(@"                        ((  / /    / _ / \_ \_(__          ");
            Console.WriteLine(@"                        \`./ /           / /  /            ");
            Console.WriteLine(@"                          \/ /           / / _ /           ");
            Console.WriteLine(@"                         _ /,/ _ / _ /,/                   ");
            Console.WriteLine(@"                   _____ / (______, ____ / _ / (______     ");
            Console.WriteLine(@"                        ^ -'             ^-'");
            Console.ResetColor();

        }

        public static void HorseFight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                             .  4                  ");
            Console.WriteLine(@"                           .$e$P *  .z          $      e.      ");
            Console.WriteLine(@"                    4.e$e$$$$$$$$$$''         $$.z$$$$*** $    ");
            Console.WriteLine(@"^ '*$ee.          .  4$$$$$$$$$$$$$$b$e  $*r   .$$e$$$$$' *$*' ");
            Console.WriteLine(@"     '*$$$$ec.   'b * 'e$$$$$$$$$$$$$$$$$$$*    $$$$$$$$$$     ");
            Console.WriteLine(@"          ^ '*$$$$$$$$$$$$$$$$$$$$$$$$$$Le.      .z$$$$$.      ");
            Console.WriteLine(@"                '$$$$$$$$$$$$$$$$$$$$$$$$C$     $F''  $$       ");
            Console.WriteLine(@"   $$$$$e.     .$$$$$$$$$$*$$$$$$$$$$$$$$$e * eP  $      $     ");
            Console.WriteLine(@"   ***e$P$$$ee.'  $ $$$$$'  $$$$$$$$$$$$$$$$**c        $'      ");
            Console.WriteLine(@"       * P  '*$$$  ' $$$$$  d$$$$$$$$$$$$$$$$e C'      $'      ");
            Console.WriteLine(@"             '$$$   $$$$'.$$$$$$$$$$$$$$$cCF *$$     z$P       ");
            Console.WriteLine(@"         ....4 *$$.   ' .$$$$$$$$$$$$$$$$$/$$$$    z$$'    r   ");
            Console.WriteLine(@"          'L3$F'' * Ce$$$$$$$$$$$$$$$$$$$$$$$c * *$*Pe$$3e.. .$ ");
            Console.WriteLine(@"      .$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$F % z$$$$$$$$$$$$*    ");
            Console.WriteLine(@"   4'''C$$$$$$$$$$$$$$$$$$$$$$$$$$$$^' *$ e   d$$$$P * *b'' * '");
            Console.WriteLine(@"    .$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ dF     $$$$$$  *e        ");
            Console.WriteLine(@"    $$$'   '$$$''' .e$$$$$$$$$$$c  d$  $     $$$$$         .   ");
            Console.WriteLine(@"   4$'       ' .ze$$$$$$$$$$$$$$$$.''* '     $$$$ .e$$$e.z$'   ");
            Console.WriteLine(@"   *$e    .$$$$$$$$$$$$$$$$$$$$$$$$c         '$$$ $$$$**$$'    ");
            Console.WriteLine(@"      e$$$$$$$$$$$$$%e$$$$$$$$$$$$$$c         ^$$$$*'*'$       ");
            Console.WriteLine(@"     $$$**$$**'*P*P  $$$$$$$$$$$$$$$$e          ''$e   ^'.     ");
            Console.WriteLine(@"      $$         .ee$$$$$$$$$$$$$$$$$$$$e          *$c         ");
            Console.WriteLine(@"      $$          '**$$$$$$$$$$$$$$$$$$$$$c         $$         ");
            Console.WriteLine(@"      $$                    $$$$$$$$$$$$$$$b        $$         ");
            Console.WriteLine(@"      $$ r           ze$$$  $$$$$$$$$$$$$$$*$$e...e$$'         ");
            Console.WriteLine(@"      $$$        ..z$$$$$$$ z$$$$$$$$$$$$$$  ^'*$**'           ");
            Console.WriteLine(@"      4$$$b   . d$$$$$$$$$$ $$$$$$$$$$$$$$$                    ");
            Console.WriteLine(@"       '$$$$   ''$$$$$$$$$$ $$$$$$$$$$$$$$'                    ");
            Console.WriteLine(@"          '*F z$$*'4$$$$$$$F $$$$$$$$$$$$'                     ");
            Console.WriteLine(@"               $'   *$$$$$*'  $$P$$$$$$$$                      ");
            Console.WriteLine(@"               '     $$$$'   $$$$ *$$$$$$c                     ");
            Console.WriteLine(@"                     $$$$b   3$$$c '*$$$$$c                    ");
            Console.WriteLine(@"                .e$$$$$*'    $  $L    '$$$'                    ");
            Console.WriteLine(@"           4$$$$$F'             ^'    J$$'                     ");
            Console.WriteLine(@"          $$$F$'$                     $$'                      ");
            Console.WriteLine(@"         d$$P                        $$'                       ");
            Console.WriteLine(@"                                    4$$                        ");
            Console.WriteLine(@"                                  .d$$..                       ");
            Console.WriteLine(@"                                 .$$$E'                       ");
            Console.ResetColor();
        }

        public static void DragonFight()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                                                  ");
            Console.WriteLine(@"                       /                            )         ");
            Console.WriteLine(@"                      (                             |\        ");
            Console.WriteLine(@"                     /|                              \\       ");
            Console.WriteLine(@"                    //                                \\      ");
            Console.WriteLine(@"                    ///                                 \|    ");
            Console.WriteLine(@"                  / ( \                                  )\   ");
            Console.WriteLine(@"                  \\  \_                               //)    ");
            Console.WriteLine(@"                   \\  :\__                           ///     ");
            Console.WriteLine(@"                    \\     )                         // \     ");
            Console.WriteLine(@"                     \\:  /                         // |/     ");
            Console.WriteLine(@"                      \\ / \                       //  \      ");
            Console.WriteLine(@"                       /)   \     ___..- '         ((  \_|    ");
            Console.WriteLine(@"                     //     /  .'  _.'           \ \  \       ");
            Console.WriteLine(@"                     /|       \(_\_____          \ | /        ");
            Console.WriteLine(@"                  (| _ _ __/ '-.       ) /.'                  ");
            Console.WriteLine(@"                     \\ .  '-.__ \          \_    / / \       ");
            Console.WriteLine(@"                      \\_'.     > ' -._   '.   \  / / /       ");
            Console.WriteLine(@"                       \ \      \     \    \   .' /.'         ");
            Console.WriteLine(@"                        \ \  '._ /     \  /   / .' |          ");
            Console.WriteLine(@"                         \ \_     \_ |    .'_/ __/            ");
            Console.WriteLine(@"                          \  \      \_ |   / / _ / \_         ");
            Console.WriteLine(@"                           \  \       / _.' /  /     \        ");
            Console.WriteLine(@"                           \   |     /.'   / .'       '-,_    ");
            Console.WriteLine(@"                            \   \  .'   _.'_ /             \  ");
            Console.WriteLine(@"               /\    /\      ) ___(    / _.'           \    | ");
            Console.WriteLine(@"              | _\__// \    (.'      _/               |    |  ");
            Console.WriteLine(@"              \/ _  __ / --'`    ,                   __/    / ");
            Console.WriteLine(@"              (_) / b)  \  '.   :            \___.-:_/ \__/   ");
            Console.WriteLine(@"              /:/:  ,     ) :        (      / _.'_/-' | _ _ / ");
            Console.WriteLine(@"                                                              ");
            Console.WriteLine(@"               /:/: __ /\ > __,_.----.__\    / (/ (/ (/       ");
            Console.WriteLine(@"              (_(, _ / V.'/--'    _ / __ / |   /              ");
            Console.WriteLine(@"               VvvV  //`    _.-' _.'     \   \                ");
            Console.WriteLine(@"                                                              ");
            Console.WriteLine(@"                 n_n//     (((/->/        |   /               ");
            Console.WriteLine(@"                                                              ");
            Console.WriteLine(@"                 '--'         ~= '          \  |              ");
            Console.WriteLine(@"                                            | | _,,,          ");
            Console.WriteLine(@"                                            \  \  /           ");
            Console.WriteLine(@"                                             '.__)            ");
            Console.WriteLine(@"                                                              ");
            Console.ResetColor();
        }
        #endregion
    }
}
