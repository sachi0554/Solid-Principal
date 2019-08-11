using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal
{
    public class Message
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Single Responsbilty Demo in S of (SOLID)");
        }


        public static void EndMessage()
        {
            Console.ReadLine(); 
        }
        
        public static void validateErrorMessage(string fieldname)
        {
            Console.WriteLine($"you did't give me valid {fieldname}");
        }

       


    }   
}
