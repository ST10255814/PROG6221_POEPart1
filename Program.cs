namespace poePart1
{
    internal class Recipe
    {
        static void Main(string[] args)
        {
            //Declarations
            List<string> allIngrediantNames = new List<string>();
            List<string> allSteps = new List<string>();
            List<int> allQuantities = new List<int>();
            List<string> allUnitsOfMeasure = new List<string>();

            int choice;

            Methods mt = new Methods(); //Object used to call methods from class methods 

            Console.WriteLine("Welcome! Please select one of the following options to create your recipe: " +
                "\n0: Add Ingrediants\n1: Add steps\n2: Display recipe\n3: Scale recipe\n4: Reset Scale\n5: Clear recipe\n6: Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            while(choice != 6 ) //performs switch case until the value 6 is entered to stop the program
            {
                switch (choice) 
                {
                    case 0:
                        //Calls method to add all ingradiants with its parameters 
                        mt.addIngrediants(allIngrediantNames, allQuantities, allUnitsOfMeasure);
                        break;

                    case 1:
                        //Calls method to add all steps with its parameters 
                        mt.addSteps(allSteps);
                        break;

                    case 2:
                        //Calls method to display the entire recipe with its parameters 
                        mt.displayRecipe(allIngrediantNames, allSteps, allQuantities, allUnitsOfMeasure);
                        break;

                    case 3:
                        //Calls method to scale the quantities of the recipe with its parameters 
                        mt.scaleRecipe(allQuantities);
                        break;

                    case 4:
                        //Calls method to reset the recipe quantities back to its original form with its parameters 
                        mt.resetScale(allQuantities);
                        break;

                    case 5:
                        //Calls method to clear the entire recipe with its parameters 
                        mt.clearRecipe(allIngrediantNames, allSteps, allQuantities, allUnitsOfMeasure);
                        break;

                    case 6:
                        //Exit statement 
                        Console.WriteLine("Thank you for using this application! ");
                        break;

                    default:
                        //Shows user to select a correct option 
                        Console.WriteLine("Please select a valid option.");
                        break;
                }
                Console.WriteLine("Welcome! Please select one of the following options to create your recipe: " +
                "\n0: Add Ingrediants\n1: Add steps\n2: Display recipe\n3: Scale recipe\n4: Reset Scale\n5: Clear recipe\n6: Exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
