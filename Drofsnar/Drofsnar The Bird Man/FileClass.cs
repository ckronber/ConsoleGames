using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class FileClass
    {
        public string[] readCSV()
        {
            try
            {
                string text = File.ReadAllText(@"C:\Users\ckron\Desktop\ElevenFiftyProjects\gold_badge\Drofsnar\Bird.csv");
                string[] words = text.Split(',');
                int num = words.Length;
                return words;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return null;
        }
    }
}
