using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poePart1
{
    internal class RecipeManager
    {
        PrintUtil printUtil = new PrintUtil();
        Ingrediant ingrediant = new Ingrediant();

        private int orignalScaleFactor = 1; //Global variable used for later calculations in the resetScale function
        /*
         * Allows the user to specify the amount of ingrediants and allows for each input and qauntity to be recorded and saved 
         * into multiple array lists to be displayed and perform calculations on later 
         */
        public void addIngrediants(List<string> allIngrediantNames, List<int> allQuantities, List<string> allUnitsOfMeasures)
        {
            printUtil.DisplayAmountOfIngrediantsMessage();
            int quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantity; i++) //for loop for the amount of ingrediants required 
            {
                printUtil.DisplayIgrediantNameMessage();
                ingrediant.setIngrediantName(Console.ReadLine());

                allIngrediantNames.Add(ingrediant.getIngrediantName()); //Adds ingrediant name into the list

                printUtil.DisplayQuantityOfIngrediantMessage();
                ingrediant.setAmount(Convert.ToInt32(Console.ReadLine()));

                allQuantities.Add(ingrediant.getAmount()); //Adds quantity of ingrediant to the list

                printUtil.DisplayUnitOfMeasurementMessage();
                ingrediant.setUnitOfMeasure(Console.ReadLine());

                allUnitsOfMeasures.Add(ingrediant.getUnitOfMeasure()); //Adds the unit of measure for the quantity into the list
            }
        }
        /*
         * Clears all array elements to allow for an entire new recipe to be entered 
         */
        public void clearRecipe(List<string> allIngrediantNames, List<string> allSteps, List<int> allQuantities,
            List<string> allUnitsOfMeasures)
        {
            //Uses the clear function to clear all lists
            allIngrediantNames.Clear();
            allSteps.Clear();
            allQuantities.Clear();
            allUnitsOfMeasures.Clear();

            printUtil.DisplayClearRecipeMessage();
            orignalScaleFactor = 1; //Resets scale factor back to one for the next recipe to be scaled
        }
        /*
         * This function allows the user to add as many steps as they want/needed
         */
        public void addSteps(List<string> allSteps)
        {
            String stepDescription;

            printUtil.DisplayAmountOfStepsMessage();
            int noOfSteps = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfSteps; i++)//Iterates over the amount of steps required and allows user input for each step
            {
                printUtil.DisplayStepDescriptionMessage(i);
                stepDescription = Console.ReadLine();

                allSteps.Add(stepDescription); //Adds the step after each iteration into the list allSteps
            }
        }

        /*
         * This function scales the recipe to the number of people (scaleFactor) required and replaces the new value in the index
         * of the old value
         */

        public void scaleRecipe(List<int> allQuantities)
        {
            printUtil.DisplayScaleRecipeMessage();
            int scaleFactor = Convert.ToInt32(Console.ReadLine());

            //Allows for multiple scales to be reset later on in the resetScale Function
            orignalScaleFactor = orignalScaleFactor * scaleFactor;

            for (int i = 0; i < allQuantities.Count; i++)
            {
                int value = allQuantities[i] * scaleFactor; //Multiples the index position i in the list by the scaleFactor

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
                int value = allQuantities[i] / orignalScaleFactor; //Resets all the qauntities in the list back to its original value

                allQuantities[i] = value;
            }
            orignalScaleFactor = 1;
        }
    }
}
