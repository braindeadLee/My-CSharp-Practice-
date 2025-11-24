using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //signed types and their max -/+ value
            sbyte varSbyte = -128;
            varSbyte = 127;
            short varShort = -32768;
            varShort = 32767;
            int varInt = -2147483648;
            varInt = 2147483647;
            long varLong = -9223372036854775808;
            varLong = 9223372036854775807;

            //unsigned types and their max positive value;
            byte varByte = 0;
            varByte = 255;
            ushort varUshort = 0;
            varUshort = 65535;
            uint varUint = 0;
            varUint = 4294967295;
            ulong varUlong = 0;
            varUlong = 18446744073709551615L;

            char favoriteLetter = 't';
            favoriteLetter = 'b';

            //code automatically assumes decimals are doubles
            double pi = 3.141592653589;
            float anotherPi = 3.14f;
            decimal yetAnotherPi = 3.1415926M;

            bool truth = true;

            string message = "Hello World!";

            //Scientific notation
            double avogadrosNumber = 6.022e23;

            //Binary literals
            int thirteen = 0b00001101;

            //Hexadecimal literals
            int theColorMagenta = 0xFF00FF;
            //Normal, binary & hexadecimal literals are treated as int.

            //Digit separator
            int a = 12345679;
            int b = 123_456_789;
            long x = 0b0010010_00100110_00001101_01011111;

            // COMPILER ERRORS WITH THE DIGIT SEPARATOR!
            //int a = _1; // Can't start with an underscore.
            //int b = 1_; // Can't end with an underscore.
            //int c = 0_b_10101; // Can't place an underscore before or after the 'b' in a binary literal...
            //int d = 0_xFFDDA0; // ... or the 'x' in a hex literal.
            //double e = 1_e3; // Can't place one before or after the 'e' in exponential notation.
            //float f = 3.14_f; // Or around the characters used to mark the type, like the 'f' here...
            //ulong g = 1_U_L; // ... or the U or L here.
            //double h = 1_.3; // Can't place an underscore immediately before or after the decimal point

            //Type inference
            var statement = "Hello World!";
            //statement is recognized as string

            var number = 123;
            //number is recognized as int

            Console.WriteLine(statement + number);

            //ReadLine() returns strings
            statement = Console.ReadLine();

            


        }
    }
}