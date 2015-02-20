using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    public class BankAccount
    {
        // properties (Remember! They're our iVars! You're just making variables again!)
        // we're letting the compiler make our getters and setters.
        public String AcNo { get; set; }
        public String AcholderName { get; set; }
        public decimal AcBalance { get; set; }

        // constructor 1: blank!
        // the empty constructor the compiler makes if we don't have one (like in BankAccountV0).
        public BankAccount() { } 

        // Constructor method 2: when we create the instance, we also give the instance all its properties / iVars
        public BankAccount(String pAcNo, String pName, decimal pBalance)
        {
            this.AcNo = pAcNo;
            this.AcholderName = pName;
            this.AcBalance = pBalance;
        }

        //constructor method 3: demonstrating method overloading some more. creates an account with a starting balance of 0.
        public BankAccount(String pAcNo, String pName)
        {
            this.AcNo = pAcNo;
            this.AcholderName = pName;
            this.AcBalance = 0.0m; // we assume they enter a balance later.
        }

        // our withdrawl method!
        public int ProcessWithdrawal(decimal withdrawAmt)
        { // return 1 for success, 0 for failure
            if (this.AcBalance >= withdrawAmt)
            {
                this.AcBalance = this.AcBalance - withdrawAmt;
                return 1;
            }
            else
            {
                return 0; // failure
            }
        } // end withdrawl

        public override string ToString()
        {
            string myDescription = String.Format("Account Information: \nAcNo: {0} \nName: {1} \nBalance {2:C} \n",
                AcNo, AcholderName, AcBalance);
            return myDescription;
        } // end ToString() override.

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



    }
}
