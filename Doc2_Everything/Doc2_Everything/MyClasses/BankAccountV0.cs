using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    public class BankAccountV0
    {
        // properties (Remember! They're our iVars! You're just making variables again!)
        // we're letting the compiler make our getters and setters.

        public String AcNo { get; set; }
        public String AcholderName { get; set; }
        public decimal AcBalance { get; set; }

        // our deposit method.
        // we're only adding in the catch for negative deposits to keep it interesting.

        public int ProcessDeposit(decimal depositAmount)
        {
            int transCode = 0;
            if (depositAmount <= 0)
            {
                transCode = 0;
            }
            else
            { // change current balance
                this.AcBalance = this.AcBalance + depositAmount;
                transCode = 1;
            }
            return transCode;
        } // end processDeposit

    } // end BankAccount class
} // end namespace
