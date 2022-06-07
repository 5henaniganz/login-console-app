using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class SuccessfulLogin
    {
        public void mainMenu(string username)
        {
            Console.WriteLine($"Welcome to your account: {username}");
            Console.WriteLine("Select Option");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Funds");
            Console.WriteLine("3. Withdraw funds");

            string menuSelection = Console.ReadLine();

        }
    }
}
