using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    public class AlarmClock : iCountAndActionable
    {
        public Counter MyCounter { get; set; }
        public int MaxCount { get; set; } // from interface

        // constructor
        public AlarmClock(int pHowLong)
        {
            MaxCount = pHowLong;
            //instantiate myCounter
            MyCounter = new Counter(this);
        }

        // own method
        public void doMyStuff()
        {
            Console.WriteLine("I am drom doMyStuff of Alarm Clock");
            MyCounter.countAndTakeAction();
        }

        // the following method is to satisfy the interface contract
        // ... nice way to put it 
        public void WhatToDo()
        {
            Console.WriteLine("Ring ring wake up");
        }

    }// end alarm clock class
} // end namespace
