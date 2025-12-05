
namespace Cylinders
{
    class Enum
    {
        //enum is a type whose choices are one of a small list possible options

        //it is ocmmon to use UpperCamelCase for type names
        enum Season {
            Winter, //the first item you list is the default value
            Spring, 
            Summer, 
            Fall
        }
        public static void Run()
        {
            Season current = Season.Summer;

            if (current == Season.Summer || current == Season.Winter)
                Console.WriteLine("Happy solstice!");
            else
                Console.WriteLine("Happy equinox!");

            
        }
    }
}