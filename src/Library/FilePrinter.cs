using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : PrintALL
    {
        public void PrintTicket(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}

