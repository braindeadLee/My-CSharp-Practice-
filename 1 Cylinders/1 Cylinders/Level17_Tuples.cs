
namespace Cylinders
{
    class Tuples
    {
        //tuples combine multiple pieces into a single element

        (string, int, int) score;

        public static void Run()
        {
        (string, int, int) score1 = ("Name", 1, 2);

        //same but with var
        var score2 = ("Name", 1, 2);
        Console.WriteLine($"Name:{score1.Item1} Level:{score2.Item2}");

        //same but with names
        (string Name, int Points, int Level) score3 =("Name", 12420, 15);

        Console.WriteLine($"Name:{score3.Name} Level:{score3.Level} Score:{score3.Points}");

        //same but not all get a name
        (string Name, int, int) score4 = ("R2-D2", 12420, 15);
        Console.WriteLine($"Name:{score4.Name} Level:{score4.Item3} Score:{score4.Item2}");

        //same but you name them via var (only works when declaring with var)
        var score5 = (Name: "R2-D2", Points: 12420, Level: 15);
        Console.WriteLine($"Name:{score5.Name} Level:{score5.Level} Score:{score5.Points}");

        var score6 = GetScore();

        Console.WriteLine($"Name:{score6.Name} Level:{score6.Level} Score:{score6.Points}");
        
        //deconstructing a tuple
        (string name, int points, int level) = score6;
        //or
        var (name2, points2, level2) = score6;

        //Tuple deconsturction demands that the variables match on the left match the tuple in count and types

        name += " the Droid";
        points += 500;
        level += 1;

        //selective deconstruction through discards
        //This will ignore "points"
        (string name3, _, int level3) = score6;
        //Tuples are considred equal if they have the same number of items, the corresponding items are the same types, and if each item is equal to the corresponding item in the other tuple

        (int, int) a = (1, 2);
        (int, int) b = (1, 2);

        Console.WriteLine(a == b);
        }
        //same but as a method
        static (string Name, int Points, int Level) GetScore() => ("R2-D2", 12420, 15);
    }
}