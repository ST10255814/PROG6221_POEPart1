namespace poePart1
{
    internal class Recipe
    {
        static void Main(string[] args)
        {
            List<string> allIngrediants = new List<string>();
            List<string> allSteps = new List<string>();

            Methods mt = new Methods();

            Console.WriteLine("Welcome! Please select one of the following options to create your recipe: " +
                "\n1: Add Ingrediants\n2: Add steps\n3: Display recipe\n4: Scale recipe\n5: Reset Scale\n 6: Clear recipe\n7: Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            choice--;

            switch (choice)
            {
                case 0:
                    mt.addIngrediants(allIngrediants);
                    break;

                case 1:
                    mt.addSteps(allSteps);
                    break;

                case 2:
                    mt.displayRecipe(allIngrediants, allSteps);
                    break;

                case 3:
                    mt.scaleRecipe();
                    break;

                case 4:
                    mt.resetScale();
                    break;

            }
        }
    }
}
