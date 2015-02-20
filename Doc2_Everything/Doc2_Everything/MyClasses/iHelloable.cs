using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{

    //why would we use an interface?
    // a class can only extend ONE class
    // and interface lets a class "plug in" to more than one class and inherit things!
    //this does come with special rules, though!

    //an interface consists of methods, properties, events, indexers, or any combination of those 4.
    // NO constants, fields, operators, instance constructors, destructors, or types!
    // NO static members!
    // AUTOMATICALLY public! Cannot include access modifiers!
    interface iHelloable
    {
        // a property that must be implemented
        string SecondLanguage { get; set; }

        string SayHelloWorld(); // empty signature
        string SayBye(); // empty signature

        // what we'll do in develop two classes by extending iHelloable! We could normally only do one
        // class at once with inheritance, but we'll change that here!

    }
}
