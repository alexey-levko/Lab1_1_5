using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hello_Operators_lect
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
//do something
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                    
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    finally
                    {

                    } }
//end do something
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        #region ToFromBinary
        static void My_Binary()
        {
            //begin code 
            uint decNumber;

            do
            {
                Console.WriteLine("Input positive number:");
            } while (!uint.TryParse(Console.ReadLine(), out decNumber));

            var binString = "";
            var tempInt=decNumber;
            uint power2 = 0x80000000;

            while (tempInt < power2) power2 /= 2;
            for (; power2 >0; power2 /= 2)
            {
                if (tempInt >= power2)
                {
                    binString += '1';
                    tempInt -= power2;
                }
                else binString += '0';
            }
            if (binString == "") binString = "0";
            Console.WriteLine(binString);
            //end code 
        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            //begin code 
            uint number1,number2;

            do
            {
                Console.WriteLine("Input first positive number:");
            } while (!uint.TryParse(Console.ReadLine(), out number1));
            do
            {
                Console.WriteLine("Input second positive number:");
            } while (!uint.TryParse(Console.ReadLine(), out number2));

            string unarySumString="";
            for (int i = 0; i < number1; i++)
            {
                unarySumString += "1";
            }
            unarySumString += "#";
            for (int i = 0; i < number2; i++)
            {
                unarySumString += "1";
            }

            Console.WriteLine("{0}", unarySumString);

            while ((unarySumString[0] != '#') & (unarySumString[unarySumString.Length-1] != '#'))
            {
                unarySumString = unarySumString.Substring(1, unarySumString.Length - 2);
            }

            Console.WriteLine("{0}",unarySumString);

            if((unarySumString[0] == '#')) unarySumString = unarySumString.Substring(1, unarySumString.Length - 1);
                                      else unarySumString = unarySumString.Substring(0, unarySumString.Length - 1);

            int unaryNumber = 0;
            while (unaryNumber < unarySumString.Length) unaryNumber++;

            Console.WriteLine("'{0}' = {1}", unarySumString, unaryNumber);

            //end code 
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            //begin code 

            //string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            //{ ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};

            //end code                      
        }

        #endregion
    }
}
