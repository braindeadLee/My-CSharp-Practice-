
namespace Cylinders
{
    class FloatingTypes
    {
        public static void Run()
        {
            Console.WriteLine("Floating-point data types have different levels of precision.\nfloat variables have 6 to 7 digits of precision. ");
            float float1 = 10000f;
            float float2 = 10000.001f;
            float float3 = 10000.0001f;
            float float4 = 10000.01f;
            float float5 = 1f;
            float float6 = 1.001f;
            float float7 = 1.000001f;
            float float8 = 1.000000001f;

            compare(float1, float2);
            compare(float1, float3);
            compare(float1, float4);
            compare(float2, float2);

            compare(float5, float6);
            compare(float5, float7);
            compare(float5, float8);
            compare(float5, float5);
            compare(float8, float8);


            Console.WriteLine("\nAfter the 6-7th place, it becomes innaccurate. Doubles make up for this innaccuracy as they have 15-16 digits of precision. Decimals are 29.\n");

            double double1 = 1.0000001f;
            double double2 = 1.0000000001f;
            double double3 = 1.000000000000001f; //15 digits
            double double4 = 1.0000000000000001f; //16 digits
            double double5 = 1.00000000000000001f; //17 digits
            double double6 = 1.00000000000001f; //1 digits


            compare(double1, double2);
            compare(double1, double6);

            compare(double3, double4);
            compare(double4, double5);
            compare(double3, double6);

            Console.WriteLine("10000.001f vs 10000.002f");

            float1 = 10000.001f;
            float2 = 10000.002f;

            compare(float1, float2); 
            
            Console.WriteLine("10000.000001f vs 10000.000002f");

            float1 = 10000.000001f;
            float2 = 10000.000002f;

            compare(float1, float2);

            Console.WriteLine("Doubles 10000.000001 vs 10000.000002 ");

            double1 = 10000.000001;
            double2 = 10000.000002;

            compare(double1, double2);



        }

        private static void compare(float float1, float float2)
        {
            Console.WriteLine($"Is {float1.ToString("F8")} equal to {float2.ToString("F8")} ? ");


            if (float1 == float2) Console.Out.WriteLine(true);
            else Console.WriteLine(false);
        }

        private static void compare(double double1, double double2)
        {
            Console.WriteLine($"Is {double1.ToString("F16")} equal to {double2.ToString("F16")} ? ");


            if (double1 == double2) Console.Out.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}