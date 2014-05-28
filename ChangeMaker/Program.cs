using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(4.17);
            Console.ReadKey();
        }
        static void ChangeMaker(double amount)
        {
            // Function will take an amount and divide into amount in coins.

            var quarter = 0;//how many quarters
            var dime = 0;//how many dimes
            var nickle = 0;//how many nickles
            var penney = 0;//how many pennies
            
            //Loop will continue to run until cannot remove 0.25 from amount
            while (amount >= 0.25)
            {
                quarter += 1;
                amount -= 0.25;
            }
            //Loop will continue to run until cannot remove 0.10 from amount
            while (amount >= 0.10)
            {
                dime += 1;
                amount -= 0.10;
            }
            //Loop will continue to run until cannot remove 0.05 from amount
            while (amount <= 0.05)
            {
                nickle += 1;
                amount -= 0.05;
            }
            //Loop will continue to run until cannot remove 0.01 from amount
            while (amount > 0.01)
            {
                penney += 1;
                amount -= 0.01;
            }
            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("Quarters: " + quarter); ;
            Console.WriteLine("Dimes: " + dime);
            Console.WriteLine("Nickles: " + nickle);
            Console.WriteLine("Pennies: " + penney);
        }
    }
}
