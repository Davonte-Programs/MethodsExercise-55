namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
           Console.WriteLine("What is your Name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"$Welcome {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine($"What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine($"Cool, {favAnimal}'s are awesome!What about your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine($"Sick, I love {favBand}! They have some great songs.");
                
            
            Console.WriteLine($"I appreciate someone that wears a lot of {favColor}, especially if it has anything to do with {favBand}. But more than anything I love people that love {favAnimal}, they're just the best!");
 
            
        }
        
        public static int Add(int numOne, int numTwo)
         
        {
            return numOne + numTwo;
        }
        
        static void Main(string[] args)
        {
            Madlib();
        }
        
    }
}
