using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiply;//classifies variable as an integer
            int userInput;//classifies variable as an integer
            multiply = 50;//gives variable value;

            //Getting user input
            Console.WriteLine("Your number is: ");//allows for user input
            userInput = int.Parse(Console.ReadLine());//allows user input to be saved to a variable
            int userTimes50 = multiply * userInput;//creates variable that executes desired operation with user input from variable
            Console.WriteLine("Your number times 50 equals: " + userTimes50);//prints string with completed operation concatenated to the end
            Console.ReadLine();//allows for console to stay open

            int add;//classifies variable as an integer
            int input;//classifies variable as an integer
            add = 25;//gives variable value;
            Console.WriteLine("Your number is: ");//allows for user input
            input = int.Parse(Console.ReadLine());//allows user input to be saved to a variable
            int userPlus25 = add + input;//creates integer variable that executes desired operation with user input from variable with a variable that has an existing value
            Console.WriteLine("Your number plus 25 equals: " + userPlus25);//prints string with completed operation concatenated to the end
            Console.ReadLine();

            float divide;
            int user;
            divide = 12.5f;
            Console.WriteLine("Please input a number: ");//allows for user input
            user = int.Parse(Console.ReadLine());//allows user input to be saved to a variable
            float userDividedBy12half = user / divide;//creates float variable that executes desired operation with user input from variable
            Console.WriteLine("Your number divided by 12.5 equals: " + userDividedBy12half);//prints string with completed operation concatenated to the end
            Console.ReadLine();

            int use;
            Console.WriteLine("Please input a number to check if it is greater than 50");//allows for user input
            use = int.Parse(Console.ReadLine());//allows user input to be saved to a variable
            bool trueOrFalse = use > 50;//creates bool variable based on operation output
            Console.Write(trueOrFalse.ToString());//prints bool value based on previous operation
            Console.ReadLine();

            int you;
            Console.WriteLine("Please give us a number, which we will divide by 7, and print the remainder");//allows for user input
            you = int.Parse(Console.ReadLine());//allows user input to be saved to a variable
            int remainder = 7 % you;//creates variable that executes desired operation with user input from variable
            Console.WriteLine("The remainder of your number divided by 7 is " + remainder);//prints string with completed operation concatenated to the end
            Console.ReadLine();


        }
    }
}
