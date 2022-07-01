using System;
namespace Strings.Questions
{
    public class StringsQuestions
    {
        static void Main()
        {
            //Console.WriteLine("Input a string");
            //string a = Console.ReadLine(); /*Welcome, w3resource"*/
            //Console.WriteLine($"The string you have entered is : {a}");
            //Console.WriteLine($"The length of the string you have entered is : {a.Length}");
            //string a,b,c;
            //Console.WriteLine("Enter the three letters: ");
            //a= Console.ReadLine();
            //b = Console.ReadLine();
            //c = Console.ReadLine();
            //Console.WriteLine($"The reverse order is {c}, {b} ,{a}");

            //int a, width;
            //Console.WriteLine("Enter the number and width : ");
            //a = int.Parse(Console.ReadLine());
            //width = int.Parse(Console.ReadLine());

            //int height = width;
            //for( int i = 0; i < height; i++)
            //{
            //    for(int j= 0; j < width; j++)
            //    {
            //        Console.Write(a);
            //    }
            //    Console.WriteLine();
            //    width--;
            //}

            //string UserId = "Moyosore";
            //string Password = "123456";
            //Console.WriteLine("ENTER Your Username");
            //string InputID = Console.ReadLine();
            //Console.WriteLine("ENTER Your Password");
            //string InputPassword = Console.ReadLine();

            //if(UserId == InputID && Password == InputPassword)
            //{
            //    Console.WriteLine("Logged in Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Login details Incorrect");
            //}

            //int a, b;
            //char operation;

            //Console.WriteLine("Enter first number");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter operation");
            //operation = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //b = Convert.ToInt32(Console.ReadLine());

            //if(operation == '+')
            //{
            //    Console.WriteLine($"The addition of the two numbers is {a} and {b} is {a+b}");
            //}
            //else if(operation == '-')
            //{
            //    Console.WriteLine($"The subtraction of the two numbers is {a} and {b} is {a - b}");
            //}
            //else if(operation == '*' || operation == 'x')
            //{
            //    Console.WriteLine($"The multiplication of the two numbers is {a} and {b} is {a * b}");
            //}
            //else if(operation == '/')
            //{
            //    Console.WriteLine($"The division of the two numbers is {a} and {b} is {a / b}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator");
            //}

            //switch (operation)
            //{
            //    case '+' :
            //        Console.WriteLine($"The addition of the two numbers is {a} and {b} is {a + b}");
            //    break;
            //    case '-' :
            //        Console.WriteLine($"The subtraction of the two numbers is {a} and {b} is {a - b}");
            //    break;
            //    case '*':
            //    case 'x':
            //        Console.WriteLine($"The multiplication of the two numbers is {a} and {b} is {a * b}");
            //    break;
            //    case '/':
            //        Console.WriteLine($"The division of the two numbers is {a} and {b} is {a /b}");
            //    break;
            //    default:
            //        Console.WriteLine("Invalid Operator");
            //    break;
            //}

            //double radius,perimeter, area;
            //Console.WriteLine("Input the radius of the circle: ");
            //radius = Double.Parse(Console.ReadLine());
            //perimeter = 2 * Math.PI * radius;
            //area =  Math.PI * Math.Pow(radius,2);
            //Console.WriteLine($"The Perimeter is {perimeter} and Area is {area}");
            //Console.WriteLine(Math.PI);

            //int x,y;
            //for (y =-5; y<=5; y++)
            //{
            //    x = (y * y) + (2 * y) + 1;
            //    Console.WriteLine($"When y is {y} , x = y*y+2y+1 is {x}");
            //}

            //rerun:
            //Console.WriteLine("Enter Input in lowercase");
            //char input = Convert.ToChar(Console.ReadLine());
            //if(input == 'a' || input =='e' || input =='i' || input == 'o' || input == 'u')
            //{
            //    Console.WriteLine("It is a lowercase vowel");
            //}
            //else if(input >= '0' && input <= '9')
            //{
            //    Console.WriteLine("It's a digit");
            //}
            //else
            //{
            //    Console.WriteLine("It is not a vowel or a digit");
            //}
            //goto rerun;

            int a, b;
            bool bothEven;
            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());

            bothEven = (a % 2 == 0) && (b % 2 == 0) ? true : false;

            Console.WriteLine(bothEven ? $"{bothEven} The two numbers are even" : $"{bothEven} There's an odd number");









        }

    }
}
