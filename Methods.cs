using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poePart1
{
    internal class Methods
    {
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

                Console.WriteLine("What is the unit of measurement?\n1: Tablespoon/s\n2: Teaspoon/s\n3: Cup/s");
                choice = Convert.ToInt32(Console.ReadLine());
                choice --;

                switch (choice)
                {
                    case 0:
                        if(quantity > 1)
                        {
                            unitOfMeasure = "Tablespoons";
                        }
                        else
                        {
                            unitOfMeasure = "Tablespoon";
                        }
                        break;

                    case 1:
                        if (quantity > 1)
                        {
                            unitOfMeasure = "Teaspoons";
                        }
                        else
                        {
                            unitOfMeasure = "Teaspoon";
                        }
                        break;

                    case 2: 
                        if (quantity > 1) 
                        {
                            unitOfMeasure = "Cups";
                        }
                        else
                        {
                            unitOfMeasure = "Cup";
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                temp = ingrediantName + ": " + quantity + " " + unitOfMeasure;

                allIngrediants[i] = temp;
            }
        }
        public void clearRecipe()
        {

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
        public void scaleRecipe(int scaleFactor) 
        {

        }
        public void resetScale(int scaleFactor)
        {

        }

    }
}
