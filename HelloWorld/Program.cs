//for console related
using HelloWorld.Fundamentals;
using System;
//for list and collections
using System.Collections.Generic;
//for connecting to the databases
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public enum shippingMethod
    {
        registeredShipping = 2,
        registeredAirMail = 3,
        expressMail
// if (value is not set then 1st member is set to zero then incremented
// enum has to intialised at namespace level
//by default enum is int
//its always recommended to intialise value to enum
         
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            var shippingType = shippingMethod.registeredAirMail;
            Console.WriteLine(shippingType.ToString());
            var methodId = 4;
            Console.WriteLine((shippingMethod)methodId);
            //calling enum when we got the value from outside as input is given by user anbd we call the correspondiung enum based on that
            var shippingObject = Enum.Parse(typeof(shippingMethod), shippingType.ToString());
            Console.WriteLine(shippingObject.ToString());

            Variables test = new Variables();
            var personObject = new person();
            personObject.firstName = "Sam";
            personObject.lastName = "Manekshaw";
            var fullName = string.Format("{0} {1}", personObject.firstName, personObject.lastName);
            Console.WriteLine(fullName);
            personObject.age = 29;
            personObject.introduction();
            person.introduct(personObject.firstName, personObject.lastName);
            var cSharp =new cSsharp();
            cSharp.message = "Hello bitch";
            cSharp.printMessage();

            var objVariables = new Variables();
            //class obj can be declared using var
            //if method is statiuc we do not need to create an object
            //console method is static method define in system as we are just calling it by the class name
            int [] practise = new int[10];
            var practise1 = new int[2] {0, 1};
            string list  = string.Join(",", practise1);
            Console.WriteLine(list);
            Console.WriteLine(practise);
            var path = "c:\\users\\saurabh\\folder";
            Console.WriteLine(path);
            var path1 = @"c:\users\saurabh\folder";
            // in ordewr to avoid putting backslash
            // this is verbatin string
            Console.WriteLine(path1);

            var paths = @"Hi Sam
Look at the following paths
"+path1;
            Console.WriteLine(paths);
            //without using /n we are printing in different lines

            // if (we dont declarer value of array it by defaults takes the value as 0
            // bool array is initial;ise to false

            var flags = new bool[2];
            flags[0] = true;
            var z = Variables.addition(1105, 15);
            Console.WriteLine(z);
            string b = "25";
            var d = 292;
            byte e = (byte)d;
            double a = Convert.ToDouble(test.fuckC);
            //convert to just change the data type
            decimal c = decimal.Parse(b);
            //parse takes input as string and convert to umber datatype
            Console.WriteLine(a);
            Console.WriteLine(e);
            Console.WriteLine(b);
            var f = ++d;
            Console.WriteLine(f);
            Console.WriteLine(++d);
            Console.WriteLine(c);
            Console.WriteLine(test.Calculation(2, 3));
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("My name is {0} {1}", int.MinValue, int.MaxValue);
            //Console.WriteLine("Hello World!");
            //Console.ReadKey(true);
            try {
                var strat = "true";
                bool bat = Convert.ToBoolean(strat);
                Console.WriteLine(bat);
            }
            catch (Exception) 
            {
                Console.WriteLine("Fuck you");
                    }
        }
    }
}
