namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your Favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{name} has a favorite color which is {color}.  He is fond of {animal}. {name} and {animal} like to listen to {band} on the radio.  Maybe {name} should paint the {animal} {color} and name it {band}.");



        }
        public static int Sum(int a, int b)
    {
            int sum = a + b;
            return sum;
            
}       
     
        public static int multiply(int num1, int num2)
        { return num1 * num2; }

    }
}
