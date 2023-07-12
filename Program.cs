using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Convert string to integer using TryParse
            string intStr = "Viya";
            int convertedInt;
            if (int.TryParse(intStr, out convertedInt))
            {
                Console.WriteLine("Converted integer: " + convertedInt);
            }
            else
            {
                Console.WriteLine("Error occured!");
            }

            // Convert string to double using Convert
            string doubleStr = "10.55";
            try
            {
                double convertedDouble = Convert.ToDouble(doubleStr);
                Console.WriteLine("Converted double: " + convertedDouble);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error occured!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Double value is too large or too small");
            }

            // Convert string to decimal using Parse
            string decimalStr = "2.59";
            try
            {
                decimal convertedDecimal = decimal.Parse(decimalStr);
                Console.WriteLine("Converted decimal: " + convertedDecimal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error ocured!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Decimal value is too large or too small");

            }
        }
    }
}
