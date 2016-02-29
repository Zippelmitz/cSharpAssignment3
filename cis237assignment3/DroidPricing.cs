using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    static class DroidPricing
    {
        // >Droid models.
        public static SimpleCatagory model1 = new SimpleCatagory("Protocal", 150.00m);
        public static SimpleCatagory model2 = new SimpleCatagory("Utility", 200.00m);
        public static SimpleCatagory model3 = new SimpleCatagory("Janitor", 300.00m);
        public static SimpleCatagory model4 = new SimpleCatagory("Astromech", 400.00m);

        // >Materials.
        public static SimpleCatagory mat1 = new SimpleCatagory("Tin", 60.00m);
        public static SimpleCatagory mat2 = new SimpleCatagory("Iron", 100.00m);
        public static SimpleCatagory mat3 = new SimpleCatagory("Steel", 200.00m);
        public static SimpleCatagory mat4 = new SimpleCatagory("Aluminium", 400.00m);
        public static SimpleCatagory mat5 = new SimpleCatagory("Titanium", 500.00m);

        // >Colors.
        public static string color1 = "Blue";
        public static string color2 = "Green";
        public static string color3 = "Red";
        public static string color4 = "White";

        // >Features.
        public const decimal COST_PER_LANGUAGE = 10.00m;

        public static decimal toolBoxCost = 15.00m;
        public static decimal computerConnectionCost = 10.00m;
        public static decimal armCost = 30.00m;

        public static decimal trashCompactorCost = 100.00m;
        public static decimal vacuumCost = 40.00m;

        public static decimal fireExtinquisherCost = 10.00m;
        public const decimal COST_PER_SHIP = 5.00m;

        // >Array filled with the models.
        public static SimpleCatagory[] modelsArray = new SimpleCatagory[] { model1, model2, model3, model4 };

        // >Array filled with the materials.
        public static SimpleCatagory[] materialsArray = new SimpleCatagory[] { mat1, mat2, mat3 };


        // >Find and return the price of a model.
        public static decimal FindModelCost(string model)
        {
            // >Loop through the array until a name matches and return that price.
            for (int i = 0; i < modelsArray.Length; i++)
            {
                if (model == modelsArray[i].Name)
                {
                    return modelsArray[i].Price;
                }
            }
            
            // >If no match was found, return 0.
            return 0.0m;
        }

        // >Find and return the price of a material.
        public static decimal FindMaterialCost(string material)
        {
            // >Loop through the array until a name matches and return that price.
            for (int i = 0; i < materialsArray.Length; i++)
            {
                if (material == materialsArray[i].Name)
                {
                    return materialsArray[i].Price;
                }
            }

            // >If no match was found, return 0.
            return 0.0m;
        }




    }
}
