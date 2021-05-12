using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    public class ProgramUI
    {
        private bool _foundExit = false;
        string _ExitCode = "";
        Dictionary<string, int> solutionToSafe = new Dictionary<string, int> { };

        public void Run()
        {
            Console.WriteLine("The Program has started\n" +
                "Press any key to continue");
            Console.ReadKey();
        }
    }
}
