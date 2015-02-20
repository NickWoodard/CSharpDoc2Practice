using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    // the saving account class with inherit all the methods and properties of the bank account class.
    // it's the child of the BankAccount class! It'll be able to create accounts, has the overriden ToString, etc.
    public class SavingAccount : BankAccount
    {
        // setting up another property, for savings accounts!
        public decimal InterestRate { get; set; }

        //constructoors
        // we have to call the base class so we can use the constructor
        // this goes in the signature of the constructor method
        // remember, we're getting all 4 properties from the constructor!
        public SavingAccount(String pAcNo, String pName, decimal pBalance, decimal pInterestRate)
            :base(pAcNo, pName, pBalance)
        {
            InterestRate = pInterestRate;
        } // end of savings account constructor

        // Add the Compute Monthly interest amount
        public decimal ComputeInterest()
        {
            decimal monthlyInterestAmt = this.AcBalance * this.InterestRate / 12;
            return monthlyInterestAmt;
        }

        // override the inherited ToString method
        public override string ToString()
        {
            string myDes = String.Format("Account Info: \nAcNo:{0} \nName: {1} \nBalance: {2:C} " +
                "\nInterestRate: {3:F2}\n", AcNo, AcholderName, AcBalance, InterestRate);
            return myDes;
        }// end of ToString()
    } // end of SavingAccount  class
} // end of namespace
