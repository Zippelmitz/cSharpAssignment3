using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static bool exitApp = false;// >Switch to keep the program running.

        static int topMenuChoice = 1;// >Top menu selected.
        static int menuSelection = 0;// >Choice made in a menu.

        static DroidCollection droidCollection = new DroidCollection();// >Holds the droids.

        static void Main(string[] args)
        {

            // >If a topMenu returns -1 the propram will end.
            while (exitApp == false)
            {
                switch (topMenuChoice)
                {
                    case 1:
                        // >Display the menu and get the selected option.
                        UserInterface.Menu1(ref topMenuChoice, ref menuSelection);
                        switch (menuSelection)
                        {
                            case 1:
                                // >Add a droid.
                                droidCollection.AddADroid();
                                break;
                            case 2:
                                // >Print the droid list.
                                droidCollection.PrintDroidList();
                                break;
                            case 3:
                                // >Exit the program.
                                exitApp = true;
                                break;
                        }
                        break;
                    case 2:
                        // >Can be used for another menu.
                        break;

                }

            }
        }

    }
}
