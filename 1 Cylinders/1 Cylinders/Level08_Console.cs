
namespace Cylinders
{
    class ConsoleClass
    {
        public static void Run()
        {
            Console.WriteLine("Press any key when you're ready to begin.");
            Console.ReadKey();

            Console.WriteLine("\nThe letter typed is visible, ReadKey(bool intercept) overload removes this letter.");
            Console.ReadKey(true);

            Console.WriteLine("The console colors will now be different after you press.");
            Console.ReadKey(true);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Pressing will clear the console and give a new title.");
            Console.ReadKey(true);
            Console.Clear();
            Console.Title = "Console class demonstration.";

            Console.WriteLine("Pressing will make a beep sound and revert background changes.\n");

            Console.ReadKey(true);
            Console.Beep();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine(@"\n = newline, \t = new tab, \r = carriage return, \\ = add backslashes, \"" = add quotation marks, Console.WriteLine(@"""") = verbatim string literal mode.");

            Console.WriteLine(@"c:\source\repos (this is where your code goes)");

            Console.WriteLine(@"Console.WriteLine($""""), interpolates strings with {variables}");

            Console.WriteLine("Give me two names.");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            Console.WriteLine($"#1: {name1, 20}\n#2: {name2, 20}\n\n 20 characters were reserved for the name" +
                $"s display.\n");

            Console.WriteLine($"Formatting with Interpolation\n\n{Math.PI:0.00}");

            Console.WriteLine($"42.1234 with interpolation: {42.1234:#.##}\n\n");

            float currentHealth = 4;
            float maxHealth = 9;
            Console.WriteLine($"Current Health: {currentHealth}\nMax Health: {maxHealth}\nPercentage of health remaining: {currentHealth / maxHealth:0.0%}"); // Displays "44.4%"

            Console.WriteLine("Pressing ends the program.");
            Console.ReadKey(true);



        }
    }
}