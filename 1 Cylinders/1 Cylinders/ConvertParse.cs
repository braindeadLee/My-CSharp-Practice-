
namespace Cylinders
{
    class ConvertParse
    {
        public static void Run()
        {
            string thisString = "123";
            int thisNum = Convert.ToInt32(thisString);

            //Parse is only for strings
            thisNum = int.Parse(thisString);

            float thisFloat = float.Parse(thisString);

            bool truth = int.Equals(thisNum, thisNum);
        }
    }
}