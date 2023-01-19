using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265midterm
{
    public class Man
    {
        private string[] bodyParts = new string[7];

        public Man()
        {
            bodyParts[0] = " O\n";
            bodyParts[1] = "\\";
            bodyParts[2] = "|";
            bodyParts[3] = "/\n"; 
            bodyParts[4] = " |\n";
            bodyParts[5] = "/";
            bodyParts[6] = " \\";
        }

        public void DisplayMan(int wrongGuessCount)
        {
            System.Console.WriteLine("\n\n");
            for (int i = 0; i < wrongGuessCount; i++)
            {
                System.Console.Write(bodyParts[i]);
            }
            System.Console.WriteLine("\n\n");
        }
    }
}
