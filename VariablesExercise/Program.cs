namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Agamemnon";
            char firstInitial = 'A';
            int dogAge = 3;
            bool isHungry = true;
            double dogWeight = 182.7;
            decimal dogHeight = 36.4m;

            Console.WriteLine($"My dog's name is {dogName}. His first initial is {firstInitial}. " +
                              $"He is {dogAge} years old and weighs {dogWeight} pounds. " +
                              $"He is {dogHeight} inches tall.");
            
            Console.WriteLine($"It is {isHungry} that he is always hungry.");


        }
    }
}
