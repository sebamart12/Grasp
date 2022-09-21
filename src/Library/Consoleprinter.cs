using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Full_GRASP_And_SOLID.Library
{
    public class Consoleprinter: PrintALL
    {
    public void PrintTicket(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }
        
    }
}