using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(string textToPrint)
        {
            File.WriteAllText("Recipe.txt", textToPrint);
        }
    }
}
