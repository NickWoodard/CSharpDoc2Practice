using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    class Doctor : iHelloable // remember, Doctor is now extending iHelloable
    {
        public string SSN { get; set; }
        public string Name { get; set; }

        public string SecondLanguage { get; set; }

        //constructor
        public Doctor(String pSSN, string pName, string pLanguage)
        {
            SSN = pSSN;
            Name = pName;
            SecondLanguage = pLanguage;
        }

        public string SayHelloWorld()
        {
            string Hello;
            switch (SecondLanguage)
            {
                case "Spanish":
                    Hello = "Hola!";
                    break;
                case "French":
                    Hello = "Bonjour!";
                    break;
                case "Japanese":
                    Hello = "Konichiwa!";
                    break;
                default:
                    Hello = "Hello!";
                    break;
            } // end switch
            return Hello;
        } // end SayHello

        public string SayBye()
        {
            string Bye;
            if (SecondLanguage == "Spanish")
                Bye = "Adios!";
            else if (SecondLanguage == "French")
                Bye = "Salut";
            else if (SecondLanguage == "Japanese")
                Bye = "Sayonara";
            else
                Bye = "Bye";

            return Bye;
        } // end of SayBye()

    } // end class
} // end namespace
