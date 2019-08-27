using System;

namespace CSharpExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World
            Console.WriteLine("Hello World!");

            //Comments
            //single-line comment
            /*
             * multi-line comment
             */

            //Variables
            bool a;
            int b;
            double c;
            char d;
            string e;

            a = true;
            b = 6;
            c = 6.5;
            d = 'a';
            e = "string";

            Console.WriteLine("\nVariables");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            Console.WriteLine("e: " + e);

            //Min / Max values
            int f = int.MaxValue;
            int g = f + 1;

            Console.WriteLine("\nMin/Max values");
            Console.WriteLine("f: " + f);
            Console.WriteLine("g: " + g);

            //Implicit Types
            var h = false;
            var i = 10;
            var j = 11.56;
            var k = "implicit string";
            var l = 'k';

            
            Console.WriteLine("\nImplicit Types");
            Console.WriteLine("h: " + h);
            Console.WriteLine("i: " + i);
            Console.WriteLine("j: " + j);
            Console.WriteLine("k: " + k);
            Console.WriteLine("l: " + l);

            //Operators
            ///Assignments and Incremenet/Decrement
            int x, y;
            x = 15;
            y = 16;
            int z1 = x++;
            int z2 = ++y;
            Console.WriteLine("\nAssignments and Incremenet/Decrement");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z1: " + z1);
            Console.WriteLine("z2: " + z2);

            ///Math
            int x3 = 5;
            int y3 = 6;
            int z3 = 7;
            int a3 = y3 - x3;
            int b3 = x3 + z3;
            int c3 = x3 * y3;
            bool xtrue, ytrue;
            Console.WriteLine("\nMath");
            Console.WriteLine("x1: " + x3);
            Console.WriteLine("y1: " + y3);
            Console.WriteLine("z3: " + z3);
            Console.WriteLine("a1: " + a3);
            Console.WriteLine("b1: " + b3);
            Console.WriteLine("c1: " + c3);

            xtrue = (x3 % 2 == 0) ? true : false;
            Console.WriteLine("xtrue: " + xtrue);

            ytrue = (y3 % 3 == 0) ? true : false;
            Console.WriteLine("ytrue: " + ytrue);

            double d3 = 16.29155109;
            d3 = Math.Round(d3, 3);
            Console.WriteLine("d3: " + d3);

            //Type conversions
            int x4 = 10;
            int y4 = 11;
            int z4 = 14;
            double a4 = 15.161232;
            double b4 = 20.1512351;
            double c4 = 109.123412;
            double d4 = (double)x4 / z4;
            double e4 = (double)y4 / z4;
            double f4 = (double)z4 / x4;
            x4 = (int)a4;
            y4 = (int)b4;
            z4 = (int)c4;
            Console.WriteLine("\nType Conversions");
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("e4: " + e4);
            Console.WriteLine("f4: " + f4);
            Console.WriteLine("x4: " + x4);
            Console.WriteLine("y4: " + y4);
            Console.WriteLine("z4: " + z4);

            //Strings
            ///Escapes and Literals
            string string1 = "This string \nhas a line break. ";
            string string2 = "This string \\ has a backslash";
            Console.WriteLine("\nEscapes and Literals");
            Console.WriteLine("string1: " + string1);
            Console.WriteLine("string2: " + string2);

            //Concatenation
            string string3 = string1 + string2;
            Console.WriteLine("\nConcatenation");
            Console.WriteLine("string3: " + string3);

            //Indexing;
            string string4 = "Oddnumber";
            int string4Length = string4.Length;
            int string4Middle = (int) Math.Round((double)string4.Length / 2);

            char char1 = string4[0];
            char char2 = string4[string4Middle];
            char char3 = string4[string4Length - 1];
            
            char[] charArray = { char1, char2, char3 };
            string string5 = new string(charArray);
            Console.WriteLine("\nIndexing");
            Console.WriteLine("string4Length: " + string4Length);
            Console.WriteLine("string4Middle: " + string4Middle);
            Console.WriteLine("char1: " + char1);
            Console.WriteLine("char2: " + char2);
            Console.WriteLine("char3: " + char3);
            Console.WriteLine("string5: " + string5);

            //Changing Case
            
            Console.WriteLine("\nChanging Case");
            string stringToUpper = "stringtoupper";
            Console.WriteLine("stringToUpper (before): " + stringToUpper);
            stringToUpper = stringToUpper.ToUpper();
            Console.WriteLine("stringToUpper (after): " + stringToUpper);
            string stringToLower = "STRINGTOLOWER";
            Console.WriteLine("stringToLower (before): " + stringToLower);
            stringToLower = stringToLower.ToLower();
            Console.WriteLine("stringToLower (after): " + stringToLower);

            Console.ReadLine();
            
        }
    }
}
