using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper_Wars
{
    class Game
    {

        // beggining dialogue sequence
        void BeginDialogue(int a, string Text)
        {

            if (a == 0)
            {
                Console.WriteLine("[PRESS A BUTTON TO ADVANCE DIALOGUE]");
                Console.ReadKey(true);
                Console.WriteLine(Text);
                Console.ReadKey(true);
            }
            else if (a == 1)
            {
                Console.WriteLine("[PRESS A BUTTON TO ADVANCE DIALOGUE]");
                Console.ReadKey(true);
                Console.WriteLine("Aedificator Ortego: " + Text);
                Console.ReadKey(true);
            }



        }

        // dialogue sequence
        void Dialogue(int a, string Text)
        {
            if (a == 0)
            {
                Console.WriteLine(Text);
                Console.ReadKey(true);
            }
            else if (a == 1)
            {
                Console.WriteLine("Aedificator Ortego: " + Text);
                Console.ReadKey(true);
            }




        }


        // dialouge advancing function
        void EndDialogue(int a, string Text)
        {
            if (a == 0)
            {
                Console.WriteLine(Text);
                Console.WriteLine("" +
                                "" +
                                "");
                Console.ReadKey(true);
            }
            else if (a == 1)
            {
                Console.WriteLine("Aedificator Ortego: " + Text);
                Console.WriteLine("" +
                                "" +
                                "");
                Console.ReadKey(true);
            }






        }

        //function for upcoming decision from dialogue
        string DecisionDialogue(int a, string Question, string option1, string option2, string option3)
        {
            PlayerChoice = "";
            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
            {
                //display promblems and solutions

                if (a == 0)
                {
                    {
                        Console.WriteLine(Question);
                        Console.WriteLine("" +
                                        "" +
                                        "");

                        Console.WriteLine("1:" + option1);

                        Console.WriteLine("2:" + option2);


                        if (option3 != "")
                        {
                            Console.WriteLine("3:" + option3);
                        }

                        //player input
                        Console.Write("> ");
                        PlayerChoice = Console.ReadLine();
                    }

                    // if invalid input,
                    if (PlayerChoice != "1" && PlayerChoice != "2")
                    {
                        if (PlayerChoice == "3" && option3 != "")
                        {
                            continue;
                        }


                        Console.Clear();
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("press a button");
                        Console.ReadKey(true);
                    }

                }
                else if (a == 1)
                {
                    Console.WriteLine("Aedificator Ortego: " + Question);
                    Console.WriteLine("" +
                                    "" +
                                    "");

                    Console.WriteLine("1:" + option1);

                    Console.WriteLine("2:" + option2);


                    if (option3 != "")
                    {
                        Console.WriteLine("3:" + option3);
                    }

                    //player input
                    Console.Write("> ");
                    PlayerChoice = Console.ReadLine();
                }

                // if invalid input,
                if (PlayerChoice != "1" && PlayerChoice != "2")
                {
                    if (PlayerChoice == "3" && option3 != "")
                    {
                        continue;
                    }


                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("press a button");
                    Console.ReadKey(true);

                }






                //return PlayerChoice;
            }
            return PlayerChoice;
        }
    }
}
