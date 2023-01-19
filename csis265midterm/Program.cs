using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265midterm
{
    public class Program
    {
        public static void Main()
        {
            
            GameOverseer gameOverseer = new GameOverseer();

            gameOverseer.RunGame();

            System.Console.ReadLine();
        }
    }
}
