using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        // >This class's modelChoice numbers for the droids. Used when adding a new droid.
        const int PROTOCOL_MC = 1;
        const int UTILITY_MC = 2;
        const int JANITOR_MC = 3;
        const int ASTROMECH_MC = 4;

        int _freeSpot = 0;// >Marks the location to add a new droid.

        Droid[] droidsArray = new Droid[100];// >Holds all of the droids.




        // >Add a droid to the list.
        public void AddADroid()
        {
            int modelChoice = 0;
            string newDroidModel = string.Empty;
            string newDroidMaterial = string.Empty;
            string newDroidColor = string.Empty;

            // >Set the model.
            SelectModel(ref newDroidModel, ref modelChoice);
            // >Set the material.
            SelectMaterial(ref newDroidMaterial);
            // >Set the color.
            SelectColor(ref newDroidColor);

            // >These choices depend on the model chosen.
            switch (modelChoice)
            {
                // >MC stands for Model Catagory.
                case PROTOCOL_MC:
                    int newDroidNumOfLanguages = 0;// >The number of languages that the droid knows.

                    // >Select the number of languages.
                    SelectNumberOfLanquages(ref newDroidNumOfLanguages);

                    // >Create a new droid in the array's free spot.
                    droidsArray[_freeSpot] = new ProtocolDroid(newDroidModel, newDroidMaterial, newDroidColor, newDroidNumOfLanguages);
                    break;
                case UTILITY_MC:
                case JANITOR_MC:
                case ASTROMECH_MC:
                    bool newDroidToolBox = false;// >If the droid has a toolbox.
                    bool newDroidComputerConnection = false;// >If the droid has a computer connection.
                    bool newDroidArm = false;// >If the droid has and newDroidArm.

                    // >set if it has a tool box.
                    SelectToolBoxBool(ref newDroidToolBox);
                    // >Set if it has a computer connection.
                    SelectComputerConnectionBool(ref newDroidComputerConnection);
                    // >Set if it has an arm.
                    SelectArmBool(ref newDroidArm);

                    if (modelChoice == UTILITY_MC)
                    {
                        // >Create a new droid in the array's free spot.
                        droidsArray[_freeSpot] = new UtilityDroid(newDroidModel, newDroidMaterial, newDroidColor, newDroidToolBox, newDroidComputerConnection, newDroidArm);
                    }
                    else
                    {
                        switch (modelChoice)
                        {
                            case JANITOR_MC:
                                bool newDroidTrashCompactor = false;// >If the droid has a trash compactor.
                                bool newDroidVacuum = false;// >If the droid has a vacuum.

                                // >Set if it has a trash compactor.
                                SelectTrashCompactorBool(ref newDroidTrashCompactor);
                                // >Set if it has a vacuum.
                                SelectVacuumBool(ref newDroidVacuum);

                                // >Create a new droid in the array's free spot.
                                droidsArray[_freeSpot] = new JanitorDroid(newDroidModel, newDroidMaterial, newDroidColor, newDroidToolBox, newDroidComputerConnection, newDroidArm, newDroidTrashCompactor, newDroidVacuum);
                                break;
                            case ASTROMECH_MC:
                                bool newDroidFireExtinquisher = false;// >If the droid has a FireExtinquisher.
                                int newDroidNumberOfShips = 0;// >The number of ships the droid has worked on.

                                // >Set if it has a FireExtinquisher.
                                SelectFireExtinquisherBool(ref newDroidFireExtinquisher);

                                // >Set the number of ships worked on.
                                SelectNumberOfShips(ref newDroidNumberOfShips);

                                // >Create a new droid in the array's free spot.
                                droidsArray[_freeSpot] = new AstromechDroid(newDroidModel, newDroidMaterial, newDroidColor, newDroidToolBox, newDroidComputerConnection, newDroidArm, newDroidFireExtinquisher, newDroidNumberOfShips);
                                break;
                        }
                    }
                    break;
            }
            // >Inform the user that the addition was successful.
            UserInterface.WriteToScreen("");
            UserInterface.WriteToScreen("-- The droid has been added to the list --");
            UserInterface.WriteToScreen("");

            // >Change the free spot.
            _freeSpot++;
        }

        // >Displays model choices for the user until they select one.
        void SelectModel(ref string model, ref int choice)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Select the model");
                UserInterface.WriteToScreen(DroidPricing.model1.Name.PadRight(10) + ": 1");
                UserInterface.WriteToScreen(DroidPricing.model2.Name.PadRight(10) + ": 2");
                UserInterface.WriteToScreen(DroidPricing.model3.Name.PadRight(10) + ": 3");
                UserInterface.WriteToScreen(DroidPricing.model4.Name.PadRight(10) + ": 4");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 4);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            choice = 1;
                            model = DroidPricing.model1.Name;
                            break;
                        case 2:
                            choice = 2;
                            model = DroidPricing.model2.Name;
                            break;
                        case 3:
                            choice = 3;
                            model = DroidPricing.model3.Name;
                            break;
                        case 4:
                            choice = 4;
                            model = DroidPricing.model4.Name;
                            break;
                    }
                }
            }
        }

        // >Displays material choices for the user until they select one.
        void SelectMaterial(ref string material)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Select the Material");
                UserInterface.WriteToScreen(DroidPricing.mat1.Name.PadRight(10) + ": 1");
                UserInterface.WriteToScreen(DroidPricing.mat2.Name.PadRight(10) + ": 2");
                UserInterface.WriteToScreen(DroidPricing.mat3.Name.PadRight(10) + ": 3");
                UserInterface.WriteToScreen(DroidPricing.mat4.Name.PadRight(10) + ": 4");
                UserInterface.WriteToScreen(DroidPricing.mat5.Name.PadRight(10) + ": 5");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 5);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            material = DroidPricing.mat1.Name;
                            break;
                        case 2:
                            material = DroidPricing.mat2.Name;
                            break;
                        case 3:
                            material = DroidPricing.mat3.Name;
                            break;
                        case 4:
                            material = DroidPricing.mat4.Name;
                            break;
                        case 5:
                            material = DroidPricing.mat5.Name;
                            break;
                    }
                }
            }
        }

        // >Displays color choices for the user until they select one.
        void SelectColor(ref string color)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Select the Color");
                UserInterface.WriteToScreen(DroidPricing.color1.PadRight(8) + ": 1");
                UserInterface.WriteToScreen(DroidPricing.color2.PadRight(8) + ": 2");
                UserInterface.WriteToScreen(DroidPricing.color3.PadRight(8) + ": 3");
                UserInterface.WriteToScreen(DroidPricing.color4.PadRight(8) + ": 4");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 5);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            color = DroidPricing.color1;
                            break;
                        case 2:
                            color = DroidPricing.color2;
                            break;
                        case 3:
                            color = DroidPricing.color3;
                            break;
                        case 4:
                            color = DroidPricing.color4;
                            break;
                    }
                }
            }
        }


        // >Displays a menu allowing the user to input a number.
        void SelectNumberOfLanquages(ref int lanquages)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Input the number of languages");
                UserInterface.WriteToScreen("(1 - 1,000,000)");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 1000000);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Give the input value to the languages variable.
                    lanquages = selectedOption;
                }
            }
        }

        // >Displays a menu allowing the user to select if it has a tool box or not.
        void SelectToolBoxBool(ref bool toolBox)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Does the droid have a Tool Box?");
                UserInterface.WriteToScreen("Yes: 1");
                UserInterface.WriteToScreen("No:  2");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 2);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            toolBox = true;
                            break;
                        case 2:
                            toolBox = false;
                            break;
                    }
                }
            }
        }

        // >Displays a menu allowing the user to select if it has a computer connection or not.
        void SelectComputerConnectionBool(ref bool connection)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Does the droid have a Computer Connection?");
                UserInterface.WriteToScreen("Yes: 1");
                UserInterface.WriteToScreen("No:  2");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 2);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            connection = true;
                            break;
                        case 2:
                            connection = false;
                            break;
                    }
                }
            }
        }

        // >Displays a menu allowing the user to select if it has an arm or not.
        void SelectArmBool(ref bool armChoice)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Does the droid have an Arm?");
                UserInterface.WriteToScreen("Yes: 1");
                UserInterface.WriteToScreen("No:  2");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 2);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            armChoice = true;
                            break;
                        case 2:
                            armChoice = false;
                            break;
                    }
                }
            }
        }

        // >Displays a menu allowing the user to select if it has a trash compactor or not.
        void SelectTrashCompactorBool(ref bool compactorChoice)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Does the droid have a Trash Compactor?");
                UserInterface.WriteToScreen("Yes: 1");
                UserInterface.WriteToScreen("No:  2");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 2);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            compactorChoice = true;
                            break;
                        case 2:
                            compactorChoice = false;
                            break;
                    }
                }
            }
        }

        // >Displays a menu allowing the user to select if it has a vacuum or not.
        void SelectVacuumBool(ref bool vacuumChoice)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Does the droid have a Vacuum?");
                UserInterface.WriteToScreen("Yes: 1");
                UserInterface.WriteToScreen("No:  2");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 2);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            vacuumChoice = true;
                            break;
                        case 2:
                            vacuumChoice = false;
                            break;
                    }
                }
            }
        }

        // >Displays a menu allowing the user to select if it has a fire extinquisher or not.
        void SelectFireExtinquisherBool(ref bool extinquisherChoice)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Does the droid have a Fire Extinquisher?");
                UserInterface.WriteToScreen("Yes: 1");
                UserInterface.WriteToScreen("No:  2");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(1, 2);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Set the choice.
                    switch (selectedOption)
                    {
                        case 1:
                            extinquisherChoice = true;
                            break;
                        case 2:
                            extinquisherChoice = false;
                            break;
                    }
                }
            }
        }

        // >Displays a menu allowing the user to input a number.
        void SelectNumberOfShips(ref int numOfShips)
        {
            int selectedOption = -1;// >The chosen option. -1 is an invalid option.

            // >Print the menu until a valid selection is made.
            while (selectedOption == -1)
            {
                UserInterface.WriteToScreen("Input the number of ships this droid has worked on");
                UserInterface.WriteToScreen("(0 - 1,000,000)");
                UserInterface.WriteToScreen("");

                // >Get the user's choice.
                selectedOption = UserInterface.GetAndValidateSelection(0, 1000000);

                // >If the input was good.
                if (selectedOption != -1)
                {
                    // >Give the input value to the languages variable.
                    numOfShips = selectedOption;
                }
            }
        }


        // >Writes information on all of the droids.
        public void PrintDroidList()
        {
            for (int i=0; i < droidsArray.Length; i++)
            {
                // >Check if the element is empty.
                if (droidsArray[i] != null)
                {
                    UserInterface.WriteToScreen("--------------------------");
                    UserInterface.WriteToScreen(droidsArray[i].ToString());
                    UserInterface.WriteToScreen("--------------------------");
                }
                else
                {
                    UserInterface.WriteToScreen("");
                    UserInterface.WriteToScreen("-- There are no more Droids in the list --");
                    UserInterface.WriteToScreen("");

                    return;
                }
            }
        }


    }
}
