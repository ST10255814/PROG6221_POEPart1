using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poePart1
{
    internal class Methods
    {
        private int scaleFactor; //Global variable used for later calculations 
        /*
         * Allows the user to specify the amount of ingrediants and allows for each input and qauntity to be recorded and saved 
         * into multiple array lists to be displayed and perform calculations on later 
         */
        public void addIngrediants(List<string> allIngrediantNames, List<int> allQuantities, List<string> allUnitsOfMeasures)
        {
            string ingrediantName, unitOfMeasure, temp; 
            int amount;

            Console.WriteLine("How many ingrediants does the recipe contain? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantity; i++) //for loop for the amount of ingrediants required 
            {
                Console.WriteLine("Enter ingrediant name: ");
                ingrediantName = Console.ReadLine();

                allIngrediantNames.Add(ingrediantName);

                Console.WriteLine("How much of the ingrediant is needed? ");
                amount = Convert.ToInt32(Console.ReadLine());

                allQuantities.Add(amount);

                Console.WriteLine("What is the unit of measurement?");
                unitOfMeasure = Console.ReadLine();

                allUnitsOfMeasures.Add(unitOfMeasure);

            }
        }
        /*
         * Clears all array elements to allow for an entire new recipe to be entered 
         */
        public void clearRecipe(List<string> allIngrediantNames, List<string>allSteps, List<int> allQuantities, 
            List<string> allUnitsOfMeasures)
        {
            allIngrediantNames.Clear();
            allSteps.Clear();
            allQuantities.Clear();
            allUnitsOfMeasures.Clear();

            Console.WriteLine("Recipe cleared");
        }
        /*
         * This function allows the user to add as many steps as they want/needed
         */
        public void addSteps(List<string> allSteps)
        {
            String stepDescription;

            Console.WriteLine("How many steps are there? ");
            int noOfSteps = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfSteps; i++)//Iterates over the amount of steps required and allows user input for each step
            {
                Console.WriteLine("What is the description of step " + (i + 1));
                stepDescription = Console.ReadLine();

                allSteps.Add(stepDescription);
            }
        }
        /*
         * This functions displays the recipe with all array elements with the use of a for loop 
         */
        public void displayRecipe(List<string> allIngrediantNames, List<string> allSteps, List<int> allQuantities,
            List<string> allUnitOfMeasures) 
        {
            Console.WriteLine("Recipe:\n");

            Console.WriteLine("Ingrediants:");
            for (int i = 0; i < allIngrediantNames.Count; i++)
            {
                Console.WriteLine(allIngrediantNames[i] + " " + allQuantities[i] + "" + allUnitOfMeasures[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Steps:");
            for (int i = 0; i < allSteps.Count; i++)
            {
                Console.WriteLine("Step " + (i+1) + ": " + allSteps[i]);
            }
        }

        /*
         * This function scales the recipe to the number of people (scaleFactor) required and replaces the new value in the index
         * of the old value
         */

        public void scaleRecipe(List<int> allQuantities) 
        {
            Console.WriteLine("What factor would you like to scale the recipe by? E.g 3");
            scaleFactor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < allQuantities.Count; i++)
            {
                int value = allQuantities[i] * scaleFactor;

                allQuantities[i] = value;
            }
        }
        /*
         * This function resets the quantities of the ingrediants back to its original value and replaces the old scaled value index
         * position with the orginal value
         */
        public void resetScale(List<int> allQuantities)
        {
            for (int i = 0; i < allQuantities.Count; i++)
            {
                int value = allQuantities[i] / scaleFactor;

                allQuantities[i] = value;
            }
        }
    }
}
