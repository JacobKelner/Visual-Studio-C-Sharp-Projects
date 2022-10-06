using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Becky";//creates string variable holding value 'Becky'
            Console.WriteLine("I greeted my boss " + name + ", by holding the door open and telling her \"Hello.\"");//Displays string to console, along with concatenating variable 'name' inside the string
            string one = "This is string one.";//creates string variable
            string two = " This is string number two.";//creates string variable
            string three = " And this final sentence is string number three.";//creates string variable
            Console.WriteLine(one + two + three);//concatenates three string variables in order to make them display in one line.
            string capitalize = "this string is an example of converting it to upper case!";//stores string inside variable
            capitalize = capitalize.ToUpper();//converts variable holding string value to all upper case lettering
            Console.WriteLine(capitalize);//displays string variable to console
            StringBuilder sb = new StringBuilder("This paragraph is made by using the Stringbuilder class. ", 500);//StringBuilder class creates string variable 'sb' to represent current STringBuilder
            sb.Append("This paragraph is built one sentence at a time. ");//Appends sentence to StringBuilder
            sb.Append("There are many different methods you can use with StringBuilder, but for now, we are using the \"Append\" method.");//Appends sentence to StringBuilder
            Console.WriteLine(sb);//displays stringbuilder 'sb'
            Console.ReadLine();//ensures console remains open
        }
    }
}
