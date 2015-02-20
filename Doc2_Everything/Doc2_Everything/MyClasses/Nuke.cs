using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    public class Nuke: iCountAndActionable
    {
        public Counter MyCounter { get; set; }
        public int MaxCount { get; set; } // from instance

        // constructor
        public Nuke(int pHowLong)
        {
            MaxCount = pHowLong;
            // instantiate myCounter
            MyCounter = new Counter(this);
        }

        // own mehtod 
        public void doMyStuff()
        {
            Console.WriteLine("I am from doMyStuff of Nuke");
            MyCounter.countAndTakeAction();
        }

        public void WhatToDo()
        {
            Console.WriteLine("BOOOOOOOOOOOOM");
        }
      
    }
}
