using System;
using System.IO;
namespace ClassTrial
{
    public class MainClass
    {

        public static void Main(string[] args)
        {

            int userOption = 0;
            App myApp = new App();

            do
            {
                printMenu();
                userOption = optionPrompt();
                myApp.showFullInfo = false;
                switch (userOption)
                {
                    case 1:
                        clrScr();
                        Console.WriteLine(myApp.getPreviousDevice());
                        break;
                    case 2:
                        clrScr();
                        Console.WriteLine(myApp.getNextDevice());
                        break;
                    case 3:
                        clrScr();
                        Console.WriteLine(myApp.getFirstDevice());
                        break;
                    case 4:
                        clrScr();
                        Console.WriteLine(myApp.getLastDevice());
                        break;
                    case 5:
                        clrScr();
                        myApp.showFullInfo = true;
                        Console.WriteLine(myApp.getCurrentDevice());
                        break;
                    case 6:
                        clrScr();
                        printHelp(); // Change mode to 'Help'


                        break;
                    case 7:
                        clrScr();
                        // Exit
                        printExit();
                        break;
                    default:
                        // Error
                        break;

                }
            } while (userOption != 7);
        }

        public static void printMenu()
        {
            Console.WriteLine("\n    -- Device Info System --\n");
            Console.WriteLine("\n -------------------------------\n");
            Console.WriteLine("|\tMenu options\n");
            Console.WriteLine("|\n");
            Console.WriteLine("|\t1 = Previous device\n");
            Console.WriteLine("|\t2 = Next device\n");
            Console.WriteLine("|\t3 = First device\n");
            Console.WriteLine("|\t4 = Last device\n");
            Console.WriteLine("|\t5 = More info\n");
            Console.WriteLine("|\t6 = Help\n");
            Console.WriteLine("|\n");
            Console.WriteLine("|\t7 = Exit\n");
            Console.WriteLine(" -------------------------------\n\n");
        }

        static void printHelp()
        {
            Console.WriteLine("\n    -- Device Info System --\n");
            Console.WriteLine(" --------------------------------------------------\n");
            Console.WriteLine("|\n");
            Console.WriteLine("| -- Help --\n");
            Console.WriteLine("|\n");
            Console.WriteLine("| Device Information system displays basic\n");
            Console.WriteLine("| and full information about devices.\n");
            Console.WriteLine("| \n");
            Console.WriteLine("| Browsing devices:\n");
            Console.WriteLine("|\n");
            Console.WriteLine("| Option 1&2 from the menu: Moves backwards\n");
            Console.WriteLine("| and forwards through the device list.\n");
            Console.WriteLine("|\n");
            Console.WriteLine("| Option 3&4 from the menu: Jumps straight to\n");
            Console.WriteLine("| the first/last device in the device list.\n");
            Console.WriteLine("|\n");
            Console.WriteLine("| Show more information:\n");
            Console.WriteLine("|\n");
            Console.WriteLine("|  Option 5 prints more details and specs\n");
            Console.WriteLine("|  for the currently viewed device.\n");
            Console.WriteLine("|\n");
            Console.WriteLine(" --------------------------------------------------\n");
            Console.WriteLine("|\n");
            Console.WriteLine("|  Choose 1 - Back to main menu \n");
            Console.WriteLine("|  Choose 7 - Exit \n");
            Console.WriteLine("|\n");
            Console.WriteLine(" --------------------------------------------------\n\n");

            int opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)
            {
                Console.Clear();
                printMenu();
            }
            else if (opt == 7)
            {
                Console.Clear();
                printExit();
            }
        }

        static int optionPrompt()
        {

            Console.WriteLine("Choose and option and press Enter\n\n");
            int userOpt = Convert.ToInt32(Console.ReadLine());

            return userOpt;
        }

        static void printerMsg()
        {
            Console.WriteLine("Not a valid option. See menu options!\n");
            optionPrompt();
        }

        static void printExit()
        {
            Console.WriteLine("\n    --      Goodbye!      --\n\n");
        }

        public static void clrScr()
        {
            Console.Clear();
        }

        public MainClass()
        {
        }
    }
}
