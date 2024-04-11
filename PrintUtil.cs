using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poePart1
{
	public class PrintUtil
	{
		public void DisplayWelcomeMessage()
		{
			Console.WriteLine(RecipeConstants.WELCOME_MESSAGE);
		}
		public void DisplayChoiceMessage()
		{
			Console.WriteLine(RecipeConstants.CHOICE_MESSAGE);
		}
		public void DisplayInvalidOptionMessage()
		{
			Console.WriteLine(RecipeConstants.INVALID_OPTION_MESSAGE);
		}
		public void DisplayStepDescriptionMessage(int i)
		{
			Console.WriteLine(RecipeConstants.STEP_DESCRIPTION_MESSAGE + (i+1));
		}
		public void DisplayAmountOfStepsMessage()
		{
			Console.WriteLine(RecipeConstants.NUMBER_OF_STEPS_MESSAGE);
		}
		//Displays the entire recipe with all array contents 
		public void DisplayRecipe(List<string> allIngrediantNames, List<string> allSteps, List<int> allQuantities,
			List<string> allUnitsOfMeasures)
		{
			Console.WriteLine("Recipe:\n");

			Console.WriteLine("Ingrediants:");
			for (int i = 0; i < allIngrediantNames.Count; i++)
			{
				//Prints out all the ingrediants with their quantities and unit of measurements 
				Console.WriteLine(allIngrediantNames[i] + " " + allQuantities[i] + "" + allUnitsOfMeasures[i]);
			}
			Console.WriteLine("\nSteps:\n");
			for (int i = 0; i < allSteps.Count; i++)
			{
				//Prints out all steps in order 
				Console.WriteLine("Step " + (i + 1) + ": " + allSteps[i]);
			}
			Console.WriteLine("\n");
		}
		public void DisplayScaleRecipeMessage()
		{
			Console.WriteLine(RecipeConstants.SCALE_RECIPE_MESSAGE);
		}
		public void DisplayClearRecipeMessage()
		{
			Console.WriteLine(RecipeConstants.CLEAR_RECIPE_MESSAGE);
		}
		public void DisplayAmountOfIngrediantsMessage()
		{
			Console.WriteLine(RecipeConstants.AMOUNT_OF_INGREDIANTS_IN_RECIPE_MESSAGE);
		}
		public void DisplayIgrediantNameMessage()
		{
			Console.WriteLine(RecipeConstants.INGREDIANT_NAME_MESSAGE);
		}
		public void DisplayQuantityOfIngrediantMessage()
		{
			Console.WriteLine(RecipeConstants.QUANTITY_OF_INGREDIANT_MESSAGE);
		}
		public void DisplayUnitOfMeasurementMessage()
		{
			Console.WriteLine(RecipeConstants.UNIT_OF_MEASUREMENT_MESSAGE);
		}
		public string ReadLine()
		{
			return Console.ReadLine(); 
		}
	}
}
