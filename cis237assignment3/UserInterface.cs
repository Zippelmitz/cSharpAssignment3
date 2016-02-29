using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    static class UserInterface
    {

        // >Read a line from the console and return it.
        public static string ReadInputLine()
        {
            // >Get the input.
            string input = Console.ReadLine();
            return input;
        }

        // >Takes the input and writes it to the console.
        public static void WriteToScreen(string inputString)
        {
            Console.WriteLine(inputString);
        }

        // >Get user input, check the input can be parsed and is within a specified range. returns -1 if bad.
        public static int GetAndValidateSelection(int lowSelection, int highSelection)
        {
            // >Get the user's input.
            string input = ReadInputLine();

            try
            {
                // >Attempt to parse.
                int num = int.Parse(input);
                // >Check if number is within range.
                if (num >= lowSelection && num <= highSelection)
                {
                    return num;
                }
                else
                {
                    // >Write an error message.
                    WriteToScreen("");
                    WriteToScreen("*** That is not a valid selection ***");
                    WriteToScreen("");
                    return -1;
                }
            }
            catch //(Exception ex)
            {
                // >Write an error message.
                WriteToScreen("");
                WriteToScreen("*** That is not a valid selection ***");
                WriteToScreen("");
                return -1;
            }
        }


        // >Displays choices for the user, validates input, and sets the choice that was made.
        public static void Menu1(ref int topMenu, ref int optionChoice)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                WriteToScreen("1. Add a Droid");
                WriteToScreen("2. Print the Droid list");
                WriteToScreen("3. Exit");
                WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 3);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    switch (selectedOption)
                    {
                        case 1:
                            // >Stay in menu1.
                            topMenu = 1;
                            // >Choose option 1.
                            optionChoice = 1;
                            break;
                        case 2:
                            // >Stay in menu1.
                            topMenu = 1;
                            // >Choose option 2.
                            optionChoice = 2;
                            break;
                        case 3:
                            // >Stay in menu1.
                            topMenu = 1;
                            // >Choose option 3.
                            optionChoice = 3;
                            break;
                    }
                }
            }
        }

        



    }
}
