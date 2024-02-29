using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poePart1
{
    internal class Methods
    {
        int scaleFactor, originalScaleFactor = 1;
        public void addIngrediants(List<string> allIngrediants)
        {
            string ingrediantName, unitOfMeasure = "", temp; 
            int choice;

            Console.WriteLine("How many ingrediants does the recipe contain? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Enter ingrediant name: ");
                ingrediantName = Console.ReadLine();

                Console.WriteLine("How much of the ingrediant is needed? ");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the unit of measurement?");
                unitOfMeasure = Console.ReadLine();
                
                temp = ingrediantName + ": " + quantity + " " + unitOfMeasure;

                allIngrediants[i] = temp;

            }
        }
        public void clearRecipe(List<string> allIngrediants, List<string>allSteps)
        {
            allIngrediants.Clear();
            allSteps.Clear();
        }
        public void addSteps(List<string> allSteps)
        {
            String stepDescription;

            Console.WriteLine("How many steps are there? ");
            int noOfSteps = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfSteps; i++)
            {
                Console.WriteLine("What is the description of step " + (i + 1));
                stepDescription = Console.ReadLine();

                allSteps[i] = stepDescription;
            }
        }
        public void displayRecipe(List<string> allIngrediants, List<string> allSteps) 
        {
            Console.WriteLine("Recipe:\n\n");

            for (int i = 0; i < allIngrediants.Count; i++)
            {
                Console.WriteLine("Ingrediants:\n");
                Console.WriteLine(allIngrediants[i]);
            }
            for (int i = 0; i < allSteps.Count; i++)
            {
                Console.WriteLine("Steps:\n");
                Console.WriteLine("Step " + (i+1) + ": " + allSteps[i]);
            }
        }
        public void scaleRecipe(List<string> allIngrediants) 
        {
            Console.WriteLine("What factor would you like to scale the recipe by? E.g 3");
            scaleFactor = Convert.ToInt32(Console.ReadLine());

            string temp = allIngrediants.Find("1-10000");


        }
        public void resetScale()
        {
            scaleFactor = originalScaleFactor;
        }

    }
}
