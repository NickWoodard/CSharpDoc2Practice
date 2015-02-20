using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doc2_Everything.MyClasses;
//add two more things
using System.Collections.Generic;
using System.Linq;

namespace Doc2_Everything
{
    class Program
    {
        static void Main(string[] args)
        {
            // list time
            // list<t> = list of a type
            List<BankAccount> Accounts = new List<BankAccount>()
            { // watch the syntax here, little different for lists.
                new BankAccount("A100", "Mister Big", 2000.00m),
                new BankAccount("A500", "Luna Buna", 1500.00m),
                new BankAccount("A200", "Meow Cat", 500.00m),
                new BankAccount("A175", "HONK", 15000.00m)
            };

            //how many are there?
            int count = Accounts.Count();
            Console.WriteLine("Number of accounts on the list is {0}.", count);

            // display back the list.
            foreach (BankAccount ac in Accounts)
            { // ^^ neat new loop thing ^^ 
                Console.WriteLine(ac.ToString());
            }

            // find a particular account, such as A200. We'll use LINQ Lamda expression here.
            String acToBeFound = "A200";
            BankAccount theAccount = Accounts.Find(x => x.AcNo == acToBeFound);
            if (theAccount == null)
            {
                Console.WriteLine("We didn't find that account.");
            }
            else
            {
                Console.WriteLine("The account has been found.");
                Console.WriteLine(theAccount.ToString());
            }

            // sort the List<T> using LINQ
            Accounts = Accounts.OrderBy(x => x.AcNo).ToList();
            Console.WriteLine("\nThe list has been sorted the sorted list is");
            foreach (BankAccount ac in Accounts)
            {
                Console.WriteLine(ac.ToString());
            }

            //display the top 2 accounts with the highest balance: (use LINQ)
            // also, C# doesn't recognize a line ending without a semicolon.
            // so you can do this so code is easier to read.
            var top2 = Accounts
                .OrderByDescending(x => x.AcBalance)
                .Take(2)
                .ToList();

            Console.WriteLine("\nTop 2 accounts with the highest balance is as follows:");
            foreach (var i in top2)
            {
                Console.WriteLine(i.ToString());
            }


            Console.ReadLine();

        } // end main
    } // end class
} // end namespace