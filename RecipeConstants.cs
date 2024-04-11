using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poePart1
{
	public class RecipeConstants
	{
		public const string WELCOME_MESSAGE = "Welcome! Please select one of the following options to create your recipe: " +
				"\n0: Add Ingrediants\n1: Add steps\n2: Display recipe\n3: Scale recipe\n4: Reset Scale\n5: Clear recipe\n6: Exit";

		public const string CHOICE_MESSAGE = "Enter choice: ";

		public const string INVALID_OPTION_MESSAGE = "Please select a valid option.";

		public const string CLEAR_RECIPE_MESSAGE = "Recipe cleared";

		public const string NUMBER_OF_STEPS_MESSAGE = "How many steps are there? ";

		public const string STEP_DESCRIPTION_MESSAGE = "What is the description of step ";

		public const string SCALE_RECIPE_MESSAGE = "What factor would you like to scale the recipe by? E.g 3";

		public const string AMOUNT_OF_INGREDIANTS_IN_RECIPE_MESSAGE = "How many ingrediants does the recipe contain? ";

		public const string INGREDIANT_NAME_MESSAGE = "Enter ingrediant name: ";

		public const string QUANTITY_OF_INGREDIANT_MESSAGE = "How much of the ingrediant is needed? ";

		public const string UNIT_OF_MEASUREMENT_MESSAGE = "What is the unit of measurement?";

	}
}
