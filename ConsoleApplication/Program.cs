using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a new Visual C# Console App using .NET Framework project and name it "ConsoleApplication."
// more notes to save

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Store two variables: Your name   Your location(state or country)
            var myName = "Ryan Harris";
            var location = "LaJara, CO";
             
            //(My name is ... , I am from ...) using String Interpolation. ---> Console.WriteLine($"My name is : {myName}");
            Console.WriteLine("My name is: " + myName + "I am from  location " + location);
            Console.WriteLine("Please enter your name: ");
            var yourName = Console.ReadLine();

            // 3. Output two WriteLine statements that display those two variables with proper labels 
            //(My name is ... , I am from ...) using String Interpolation.
            Console.WriteLine("Hi " + yourName + "!");

            // 4. Output the current date but not the current time.
            Console.Write("Current Date and Time is : ");
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
     
            Console.WriteLine(dateAndTime);

            // 5. Output the number of days until Christmas this year and, of course, apply an appropriate label to that output.
            Console.Write("Days Until Christmas: ");
            var christmas = new DateTime(date.Year, 12, 25);
            var daysBetween = christmas - date;

            Console.WriteLine(daysBetween);

            // 6. Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
            //using System;
            /* 7.  Add these requirements to the code:
            - Provide appropriate text labels when requesting dimensional input.
            - Cause the program to pause in the console so that the application does not automatically terminate when launched from the 
            Visual Studio run debugger tool. Hint: Consider Console.ReadKey()
            - You do NOT need to add any sort of input validation. */

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Enter the Width of the window pane");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter the height of the window pane");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
        
//8&9 Push & Sumbit


    
 

