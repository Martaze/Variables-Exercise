namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Martaze";
            int myAge = 24;
            char myInitial = 'M';
            bool myAnswer = true;
            double myMoney = 5.50;
            decimal myInvestment = 55.50m;

            Console.WriteLine($"Hello, my name is {myName}, and I am {myAge} years old.");
            Console.WriteLine($"Of course my favorite letter is {myInitial}, it's literally the first letter of my name!");
            Console.WriteLine($"{myAnswer} as that may be, it also starts the word money! I had to deposit {myMoney} extra dollars into my cashapp yesterday.");
            Console.WriteLine($"I really don't like having to use cashapp. I had to deposit {myInvestment} because cashapp takes a percentage of what you deposit, and I had to make sure that it was an even amount.");
        }
    }
}
