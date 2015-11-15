using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedRockBank
{
    class Account
    {
        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The unique number for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// The account balance
        /// </summary>
        public decimal Balance { get; set; }
        #endregion
        #region Method
        /// <summary>
        /// Money deposited in the account
        /// </summary>
        /// <param name="amount">Money depositted</param>
        /// <returns>New balance</returns>
        public decimal Deposit(decimal amount)
        {
           // Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }
        public decimal Withdraw (decimal amount)
        { Balance -= amount;
        return Balance;
        }
        #endregion
    }
    

}
