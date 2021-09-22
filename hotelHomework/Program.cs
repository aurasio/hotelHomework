using System;

namespace hotelHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayInput;
            string bedInput;
            string numInput;
            bool validInput;
            bool isNumeric;
            double roomPrice = 0;
            do
            {
                validInput = false;
                Console.WriteLine("what day of the week would you like the price of?");
                dayInput = Console.ReadLine().ToUpper();
                Console.WriteLine("Is the room a double (D), or a family room (F)?");
                bedInput = Console.ReadLine().ToUpper();
                Console.WriteLine("How many rooms would you like to book?");
                numInput = Console.ReadLine();
                isNumeric = Microsoft.VisualBasic.Information.IsNumeric(numInput);
                if ((dayInput.Contains("MO") || dayInput.Contains("SU")) && (bedInput.Contains("D") || bedInput.Contains("F")) && (isNumeric == true))
                {
                    if (bedInput.Contains("D"))
                    {
                        roomPrice = 60;
                    }
                    else
                    {
                        roomPrice = 90;
                    }
                    validInput = true;
                }
                else if ((dayInput.Contains("TU") || dayInput.Contains("WE") || dayInput.Contains("TH")) && (bedInput.Contains("D") || bedInput.Contains("F")) && (isNumeric == true))
                {
                    if (bedInput.Contains("D"))
                    {
                        roomPrice = 40;
                    }
                    else
                    {
                        roomPrice = 45;
                    }

                    validInput = true;
                }
                else if ((dayInput.Contains("FR") || dayInput.Contains("SA")) && (bedInput.Contains("D") || bedInput.Contains("F")) && (isNumeric == true))
                {
                    if (bedInput.Contains("D"))
                    {
                        roomPrice = 90;
                    }
                    else
                    {
                        roomPrice = 179;
                    }
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("this isnt a valid input");
                }
            }
            while (validInput == false);
            Console.WriteLine("the price per room is £{0:0.00}", roomPrice);
            if (Convert.ToInt32(numInput) > 1)
            {
                Console.WriteLine("pre discount the price is £{0:0.00}", roomPrice * Convert.ToDouble(numInput));
                Console.WriteLine("the discount amount is £{0:0.00}", roomPrice * Convert.ToDouble(numInput) * 0.1);
                Console.WriteLine("post discount the price is £{0:0.00}", roomPrice * Convert.ToDouble(numInput) * 0.9);
            }
        }

    }
}
