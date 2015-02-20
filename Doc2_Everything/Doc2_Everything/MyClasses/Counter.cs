using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    public class Counter
    {
        public iCountAndActionable MyCntAndAction { get; set; } // a reference to the interface

        // constructor
        // the caller must implement the interface!
        public Counter( iCountAndActionable pCountAndActionable)
        {
            MyCntAndAction = pCountAndActionable;
        }

        // a method
        public void countAndTakeAction()
        {
            for (int i = 0; i < MyCntAndAction.MaxCount; i++)
            {
                Console.WriteLine("Counting " + i);
            }
            Console.WriteLine("From Counter: I am good in counting! I can also");
            Console.WriteLine("execute a method named 'What to Do' if you");
            Console.WriteLine("implement that method yourself.");

            MyCntAndAction.WhatToDo(); // fire the caller's implemented function

        }

    }
}
