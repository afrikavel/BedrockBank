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
    }
    

}
