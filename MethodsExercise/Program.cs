using Microsoft.VisualBasic;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        
        {

            MyMessage();

            
            
            
        }
        


        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int multiply(int num1, int num2)
        { 
            return num1 * num2; 
        
        }
        public static void MyMessage()
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your Favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"{name} has a favorite color which is {color}.  He is fond of {animal}." +
                $"{name} and {animal} like to listen to {band} on the radio.  Maybe {name} should paint " +
                $"the {animal} {color} and name it {band}.");

            Console.WriteLine("Give me a number to add.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the last input.");
            int b = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            Console.WriteLine($"The sum is:{sum}");


            Console.WriteLine("Give me a number to multiply.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the last input.");
            int num2 = int.Parse(Console.ReadLine());

            int product = multiply(num1, num2);
            Console.WriteLine($"The answer is:{product}");
            Console.ReadLine();
        }
    }
}

