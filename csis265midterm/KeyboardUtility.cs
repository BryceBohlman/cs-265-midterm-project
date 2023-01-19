using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265midterm
{
    public class KeyboardUtility
    {
        public static int GetValidInteger(string message)
        {
            int value = 0;
            bool errorOccurred = false;


            do
            {
                System.Console.Write(message);

                try
                {
                    errorOccurred = false;
                    value = Convert.ToInt32(System.Console.ReadLine());
                }
                catch (Exception ex)
                {
                    errorOccurred = true;
                    System.Console.WriteLine(ex.Message);
                    System.Console.WriteLine("Please try again...");
                }
            } while (errorOccurred);



            return value;
        }
        public static double GetValidDouble(string message)
        {
            double value = 0;
            bool errorOccurred = false;


            do
            {
                System.Console.Write(message);

                try
                {
                    errorOccurred = false;
                    value = Convert.ToDouble(System.Console.ReadLine());
                }
                catch (Exception ex)
                {
                    errorOccurred = true;
                    System.Console.WriteLine(ex.Message);
                    System.Console.WriteLine("Please try again...");
                }
            } while (errorOccurred);

            return value;
        }

        public static string GetValidString(string message)
        {
            string value = string.Empty;
            System.Console.Write(message);
            int length = 0;

            do
            {
                value = System.Console.ReadLine();
                length = value.Trim().Length;

                if (length == 0)
                {
                    System.Console.WriteLine("Please enter a valid string");
                }
            } while (length == 0);

            return value;
        }
    }
}
