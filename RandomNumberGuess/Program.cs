using System;

namespace zföklf
{
    class Program
    {
        static void Main(string[] args)
        {



            
            string start = "ja";
            
            while (start == "ja")
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    int versuche = 1;
                    int random = new Random().Next(1, 100);


                    Console.WriteLine("Dies ist ein Spiel wo Sie meine Zahl raten sollen.");


                    Console.ForegroundColor = ConsoleColor.Red;

                    while (versuche != 1000000000)
                        try
                        {
                            
                            Console.WriteLine("Bitte geben Sie eine Zahl ein!");
                            int input = Convert.ToInt32(Console.ReadLine());
                            


                            if (input < random && input > 0)
                            {
                                Console.WriteLine("zu niedrig");
                                ++versuche;

                            }
                            else if (input > random && input < 101)
                            {
                                Console.WriteLine("zu hoch");
                                ++versuche;

                            }
                            else if (input > 101 || input < 0 || input == 0)
                            {
                                Console.WriteLine("Es soll zwischen 1 und 100 sein!");
                                

                            }
                            else if (input == random)
                            {
                                Console.WriteLine("Richtig!!");

                                Console.ForegroundColor = ConsoleColor.Blue;

                                Console.WriteLine("Bravo du hast es geschaft mit " + versuche + " Versuch(e) ");
                                Console.WriteLine("Willst du nochmal spielen?[ja/nein]");

                               
                                start = Console.ReadLine();
                                break;

                            }

                        }
                        catch { Console.WriteLine("Eine Zahl!!"); }

                    

                }
                catch
                {
                    Console.WriteLine("Eine Zahl!!");
                }

                
            }

        }
       
    }
}
        
    

