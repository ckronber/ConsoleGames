using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class Program
    {
        static void Main(string[] args)
        {
            //bring Fileclass object in Program class
            FileClass readFile = new FileClass();
            Drofsnar Drofsnar1 = new Drofsnar();
            string[] birds = readFile.readCSV();
            var Ibirds = new List<IBird>();

            for(int i = 0;i<birds.Length;i++)
               
            foreach(string bird in birds)
            {Drofsnar1.Encounter(bird)}    
            
            
        }
    }
}
