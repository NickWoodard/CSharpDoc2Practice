using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    public interface iCountAndActionable
    {
        int MaxCount { get; set; } // property

        void WhatToDo(); // empty mehtod that must be implemented by the subclass.
    }

}
