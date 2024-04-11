namespace poePart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            List<string> allIngrediantNames = new List<string>();
            List<string> allSteps = new List<string>();
            List<int> allQuantities = new List<int>();
            List<string> allUnitsOfMeasure = new List<string>();

            int choice;

			//Object used to call methods from class methods
			RecipeManager recipeManager = new RecipeManager(); 
            PrintUtil printUtil = new PrintUtil();
            

            printUtil.DisplayWelcomeMessage(); 
            printUtil.DisplayChoiceMessage();

            choice = Convert.ToInt32(Console.ReadLine()); 

            while(choice != 6) //performs switch case until the value 6 is entered to stop the program
            {
                switch (choice) 
                {
                    case 0:
                        //Calls method to add all ingradiants with its parameters 
                        recipeManager.addIngrediants(allIngrediantNames, allQuantities, allUnitsOfMeasure);
                        break;

                    case 1:
                        //Calls method to add all steps with its parameters 
                        recipeManager.addSteps(allSteps);
                        break;

                    case 2:
						//Calls method to display the entire recipe with its parameters 
						printUtil.DisplayRecipe(allIngrediantNames, allSteps, allQuantities, allUnitsOfMeasure);
						break;

                    case 3:
                        //Calls method to scale the quantities of the recipe with its parameters 
                        recipeManager.scaleRecipe(allQuantities);
                        break;

                    case 4:
                        //Calls method to reset the recipe quantities back to its original form with its parameters 
                        recipeManager.resetScale(allQuantities);
                        break;

                    case 5:
                        //Calls method to clear the entire recipe with its parameters 
                        recipeManager.clearRecipe(allIngrediantNames, allSteps, allQuantities, allUnitsOfMeasure);
                        break;

                    case 6:
                        //Exit statement 
                        break;

                    default:
                        //Shows user to select a correct option 
                        printUtil.DisplayInvalidOptionMessage();
                        break;
                }
                printUtil.DisplayWelcomeMessage();
				printUtil.DisplayChoiceMessage();
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
