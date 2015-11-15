using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedRockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance for an account == object
            var account = new Account();
            account.AccountNumber = 123;
            account.Name = "aavel Checking";
            account.Deposit(500);
            Console.WriteLine(account.Balance);

        }
    }
}
