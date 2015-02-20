using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    class Robot
    {
        int RobotID { get; set; }
        public string RobotName { get; set; }
        public string Battery { get; set; }

        public string SecondLanguage { get; set; }

        public Robot(int pID, string pName, string pBattery, string pLanguage)
        {
            RobotID = pID;
            RobotName = pName;
            Battery = pBattery;
            SecondLanguage = pLanguage;
        }

        public string SayHelloWorld()
        {
            string HelloWorld;

            switch (SecondLanguage)
            {
                case "Spanish":
                    HelloWorld = "Hola!";
                    break;
                case "French":
                    HelloWorld = "Bonjour!";
                    break;
                case "Japanese":
                    HelloWorld = "Konnichiwa~";
                    break;
                default:
                    HelloWorld = "Unknown, hi I guess";
                    break;
            } // end switch

            return HelloWorld;

        }// end SayHelloWorld()

        public string SayBye()
        {
            string Bye;
            switch (SecondLanguage)
            {
                case "Spanish":
                    Bye = "Adios";
                    break;
                case "French":
                    Bye = "Salut";
                    break;
                case "Japanese":
                    Bye = "Sayonara";
                    break;
                default:
                    Bye = "Unknown, later nerd";
                    break;
            } // end switch

            return Bye;

        } // end of SayBye()

    } // end class
} // end namespace
