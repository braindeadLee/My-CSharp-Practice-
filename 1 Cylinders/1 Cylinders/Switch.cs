
namespace Cylinders
{
    class Switch
    {
        public static void Run()
        {
            //Normal switch
            Console.WriteLine("Give number from 1-4: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ye rest and recover your health.");
                    break;
                case 2:
                    Console.WriteLine("Raiding the port town get ye 50 gold doubloons.");
                    break;
                case 3:
                    Console.WriteLine("The wind is at your back; the open horizon ahead.");
                    break;
                case 4:
                    Console.WriteLine("'Tis but a baby Kraken, but still eats toy boats.");
                    break;
                default:
                    Console.WriteLine("Apologies. I do not know that one.");
                    break;

            }

            Console.WriteLine("Give number from 1-3: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                //Inputting 1 and 2 will both be the same condition
                case 1:
                case 2:
                    Console.WriteLine("That's a good choice!");
                    break;

                //3 and anything else is the same condition
                case 3:
                default:
                    Console.WriteLine("Yes.");
                    break;
            }

            //Switches work with any type
            Console.WriteLine("Give me a fruit: ");
            string word = Console.ReadLine();

            switch (word)
            {
                case "Apple":
                    Console.WriteLine(" I know this fruit.");
                    break;
                default:
                    Console.WriteLine("Iunno...");
                    break;
            }

            //Switch expressions
            Console.WriteLine("Give number from 1-3: ");
            choice = int.Parse(Console.ReadLine());

            string response = choice switch
            {
                1 => "Ye rest and recover your health.",
                2 => "Raiding the port town get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizon ahead.",
                4 => "'Tis but a baby Kraken, but still eats toy boats.",
                _ => "Apologies. I do not know that one."
            };
            Console.WriteLine(response);


        }
    }
}