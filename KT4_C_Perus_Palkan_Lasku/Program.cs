using System;

namespace KT4_C_Perus_Palkan_Lasku
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          * PALKKA-LASKURI V 0.0.1
          * 
          * LAURI LIUKKONEN
          * 
          * Koulutehtävä 4 C# Perus: Palkan lasku
          * 
          * 
          * 
          */
            #region f: esitiedot e: prerequisites

            /* f: Sovelluksen esitiedot, kuten versio, kehittäjä and muistiinpanot
               e: Program prerequisities, like version, author and notes
            */

            string version = "Palkkalaskuri V 0.0.1 ";
            string notes = @"-|27.03.2023|Euron symboli ei toimi kaikilla WIN32/64 cmd.exe-versioilla unicoden tulkintaongelman vuoksi.";
            string creator = "Lauri Liukkonen";
            string instructionMessage = " -Syötä tarvittavat esitiedot jotka sovellus kysyy\n -Sovellus laskee ne yhteen kollektiiviseksi kuukausipalkaksi";


            // f: tervehdysteksti, e: welcome message (continues after line break \n)
            // f: tekstin ei tarvitse olla keskitetty, sillä voit jäsentää sen laitaan ottamalla välit pois.
            // e: text paragraph does not have to be in middle, because you can also fix it left by taking all spaces out

            #endregion

            #region f: MENU : valuutan säätäminen e: MENU: setting currency menu

            /* 
             * f: TÄRKEÄÄ
             * Stringit ovat eri valuuttojen unicode-muotoja, joista käyttäjä valitsee mieleisensä vastaavalla char-vaihtoehdolla. 
             * e: IMPORTANT
             * esimerkki: cureuro = \u20ac (euromerkki, €) käyttäjä valitsee mieleisensä char-vaihtoehdon viitaten siihen valuuttamuotoon joka on A
             * Strings are unicode-formats of different currencies, and user picks suitable char implicating on that currency
             * example: curEuro = \u20ac (euro sign, €) user picks char curEuroC option which is A
             */
            string curEuro = "\u20ac";
            char curEuroC = 'A';
            string curPound = "\u00A3";
            char curPoundC = 'B';
            string curDollar = "\u0024";
            char curDollarC = 'C';
            string curYen = "\u00A5";
            char curYenC = 'D';

            /* f: ERI VALUUTAT UNICODENA e: DIFFERENT CURRENCIES IN UNICODE:
             *  Punta (pound), £ = \u00A3
             *  Dollari (dollar), $ = \u0024
             *  Jeni (Yen) ¥ = \u00A5
             *  Euro, € = \u20AC !!BUG - !! f: ei toimi kaikilla WIN32/64 alustoilla , e: not working on all WIN32/64 cmd.exe versions
             */



            string cur = curEuro; // f: asetetaan euro vakioksi samalla julistaen muuttuja e: setting euro as default same time declaring variable

            //MENU///

            //f: Luodaan ehto (valinta) joka looppaa menua
            //e: We create condition (valinta) which loops the menu

            string separator = "-------------------------------------------------------------"; //f: separaattori e: separator

            bool valinta = false;

            while (!valinta)
            {
                Console.Clear(); // f: nollataan konsoli loopin alussa e: clear console at begin of loop 
                Console.ForegroundColor = ConsoleColor.Yellow; // f: otsikon väri keltainen e: header color yellow
                Console.WriteLine("Valitse mieleinen valuutta kirjoittamalla vastaava kirjain");
                Console.ForegroundColor = ConsoleColor.DarkGray; // f: separaattorin väri harmaa e: paragraph color white
                Console.WriteLine(separator); //f:separaattori e:separator
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"      {curEuroC} Euro || {curPoundC} Punta || {curDollarC} Dollari || {curYenC} Jeni      "); // f: menun printti e: print of menu
                Console.WriteLine(separator);

                char currencyPick = Convert.ToChar(Console.ReadLine()); // f: käyttäjän syöte konvertoidaan char-muotoon e: converting user input to char

                // f: säännöt e: rules

                if (currencyPick == curEuroC) // euro
                {
                    cur = curEuro; // f:  valinnan seuraukset e: consequences of selection
                    valinta = true; // f: vapautus loopista koska valinta = true e: releasing from loop because valinta = true
                }
                else if (currencyPick == curPoundC) // f: punta e: pound
                {
                    cur = curPound;
                    valinta = true;
                }
                else if (currencyPick == curDollarC) // f: dollari e: dollar
                {
                    cur = curDollar;
                    valinta = true;
                }
                else if (currencyPick == curYenC) // f: jeni e: yen 
                {
                    cur = curYen;
                    valinta = true;
                }
                else // f: ei olemassaolevan valinnan seuraukset palauttavat looppiin e:non existing option consequences return to loop
                {
                    Console.WriteLine("Anteeksi, mutta valintaasi ei ole olemassa. Yritä uudelleen. \n Jatka painamalla mitä tahansa näppäintä.");
                    Console.ReadKey();
                    // f: valinta = edelleen false e: valinta = still false
                }
            }


            #endregion

            #region f: MENU aloitusvalikko e:MENU startmenu
            Console.Clear();

            // f: tervehdystekstin tulostus, rivi 1 e: welcome message print, line 1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{version}, by {creator}");

            // f: tummanharmaa separaattori e: dark gray separator
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(separator);

            // f: keltainen otsikko e: yellow header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kehittäjän huomiot:");

            // dev notes, f: valkoinen e: white
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(notes);

            // f: keltainen otsikko e: yellow header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nOhje:");

            // f: ohjeet e: instructions
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(instructionMessage);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(separator);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Valuuttamuoto: ({cur}). \n \n Paina mitä tahansa näppäintä aloittaaksesi...");

            Console.ReadKey();

            #endregion

            #region f: käyttäjän syötteet e: user inputs
            Console.Clear(); // Pyyhitään näyttö , Clearing screen

            // f: juoksevan tekstin ennaltamäärätyt lauseet e: pre-set sentences of running text
            string inputfeed1 = "Tuntipalkkasi on";
            string inputfeed2 = "normaaleja tunteja on kertynyt";
            string inputfeed3 = "150% ylityötunteja on kertynyt";

            Console.WriteLine("Syötä tuntipalkkasi (" + cur + ")"); // f: haetaan ensimmäinen arvo eli tuntipalkka e: getting first value which is hourly wages
            int hourlyWages = Convert.ToInt32(Console.ReadLine()); // f: ja pyydetään käyttäjän input e:and asking user input

            Console.Clear(); // Pyyhitään näyttö , Clearing screen

            Console.WriteLine($"{inputfeed1} {hourlyWages}{cur}. \n Syötä nyt normaalipalkkaiset tunnit kuukauden ajalta:");
            // Toistetaan syötetyt arvot ja pyydetään normaalipalkkaiset tunnit , repeating input values and ask for more

            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // Pyyhitään näyttö , Clearing screen

            Console.WriteLine($"{inputfeed1}: {hourlyWages}{cur} ja {inputfeed2}: {hours}kpl.\n Syötä nyt pyhätunnit 150% korotuksella tehdyt ylityö-, ja pyhätunnit:");
            int hours150p = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // Pyyhitään näyttö , Clearing screen

            Console.WriteLine($"{inputfeed1}: {hourlyWages}{cur}, {inputfeed2}{hours} ja {inputfeed3}: {hours150p}kpl. \n Syötä nyt 200% korotuksella tehdyt ylityö- ja pyhätunnit:");
            int hours200p = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // Pyyhitään näyttö , Clearing screen

            #endregion

            #region f: summaus ja tulostus e: results and print

            // f: SUMMAUS e: CALCUCLATION

            double otMultip150 = 1.5; // f: ylityökertoja 150%
            double otMultip200 = 2;  // f: ylityökertoja 200%

            //f : laskutoimitukset e: calcuclations
            double hourResult = hours * hourlyWages;  // f: normaalit tuntipalkat e: normal hourly wages
            double hour150Result = Convert.ToDouble(hours150p * (hourlyWages * otMultip150)); //f: 150% ylityöpalkat e: 150% overtime wages
            double hour200Result = Convert.ToDouble(hours200p * (hourlyWages * otMultip200)); //f: 200% ylityöpalkat e: 200% overtime wages
            double monthResult = hourResult + hour150Result + hour200Result; // f: yhteensä per kk e: overall per month 


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Antamasi tiedot:"); // f: otsikko e : header
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(separator); // f: separaattori e: separator
            Console.ResetColor(); // f: värin reset e: color reset

            // f: kollektiivisten tuntien printti e: print of all collective hours 
            Console.WriteLine($"Tuntipalkka: {hourlyWages}{cur}\nNormaalit tunnit: {hours}\n100% pyhätunnit: {hours150p}\n200% pyhätunnit: {hours200p}");

            // f: separaattori ennen viimeistä listausta e: separator before final list
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(separator);

            // f: keltainen otsikko e: yellow header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Lopputulos:");
            Console.ResetColor(); // f: värin reset e: color reset

            // f: lopullinen listaus e: final listing
            Console.WriteLine($"- Normaalit tunnit (yhteensä: {hours}) = {hourResult}{cur}");
            Console.WriteLine($"- Ylityötunnit 150% (yhteensä: {hours150p}) = {hour150Result}{cur}");
            Console.WriteLine($"- Ylityötunnit 200% (yhteensä: {hours200p}) = {hour200Result}{cur}");

            // f: separaattori e: separator
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(separator);

            // f: keltainen otsikko e: yellow header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yhteensä (koko kukausi):");

            Console.ResetColor(); // f: värin reset e: color reset
            // f: loppusumman printti e: print of final sum
            Console.WriteLine(monthResult + cur);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(separator);
            Console.ResetColor(); // f: värin reset e: color reset

            // f: pari kauneuspykälää e: couple of pretty new lines
            Console.WriteLine("\n\n");
            #endregion


        }
    }
}
