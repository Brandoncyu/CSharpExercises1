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
            Console.WriteLine("\nVariables");
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

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            Console.WriteLine("e: " + e);

            //Min / Max values
            Console.WriteLine("\nMin/Max values");
            int f = int.MaxValue;
            int g = f + 1;

            
            Console.WriteLine("f: " + f);
            Console.WriteLine("g: " + g);

            //Implicit Types
            Console.WriteLine("\nImplicit Types");
            var h = false;
            var i = 10;
            var j = 11.56;
            var k = "implicit string";
            var l = 'k';

            Console.WriteLine("h: " + h);
            Console.WriteLine("i: " + i);
            Console.WriteLine("j: " + j);
            Console.WriteLine("k: " + k);
            Console.WriteLine("l: " + l);

            //Operators
            ///Assignments and Incremenet/Decrement
            Console.WriteLine("\nAssignments and Incremenet/Decrement");
            int x, y;
            x = 15;
            y = 16;
            int z1 = x++;
            int z2 = ++y;
            
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z1: " + z1);
            Console.WriteLine("z2: " + z2);

            ///Math
            Console.WriteLine("\nMath");
            int x3 = 5;
            int y3 = 6;
            int z3 = 7;
            int a3 = y3 - x3;
            int b3 = x3 + z3;
            int c3 = x3 * y3;
            bool xtrue, ytrue;
            
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
            Console.WriteLine("\nType Conversions");
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
            
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("e4: " + e4);
            Console.WriteLine("f4: " + f4);
            Console.WriteLine("x4: " + x4);
            Console.WriteLine("y4: " + y4);
            Console.WriteLine("z4: " + z4);

            //Strings
            ///Escapes and Literals
            Console.WriteLine("\nEscapes and Literals");
            string string1 = "This string \nhas a line break. ";
            string string2 = "This string \\ has a backslash";
            
            Console.WriteLine("string1: " + string1);
            Console.WriteLine("string2: " + string2);

            ///Concatenation
            Console.WriteLine("\nConcatenation");
            string string3 = string1 + string2;
            
            Console.WriteLine("string3: " + string3);

            ///Indexing;
            Console.WriteLine("\nIndexing");
            string string4 = "Oddnumber";
            int string4Length = string4.Length;
            int string4Middle = (int) Math.Round((double)string4.Length / 2);

            char char1 = string4[0];
            char char2 = string4[string4Middle];
            char char3 = string4[string4Length - 1];
            
            char[] charArray = { char1, char2, char3 };
            string string5 = new string(charArray);
            
            Console.WriteLine("string4Length: " + string4Length);
            Console.WriteLine("string4Middle: " + string4Middle);
            Console.WriteLine("char1: " + char1);
            Console.WriteLine("char2: " + char2);
            Console.WriteLine("char3: " + char3);
            Console.WriteLine("string5: " + string5);

            ///Changing Case
            Console.WriteLine("\nChanging Case");
            string stringToUpper = "stringtoupper";
            Console.WriteLine("stringToUpper (before): " + stringToUpper);
            stringToUpper = stringToUpper.ToUpper();
            Console.WriteLine("stringToUpper (after): " + stringToUpper);
            string stringToLower = "STRINGTOLOWER";
            Console.WriteLine("stringToLower (before): " + stringToLower);
            stringToLower = stringToLower.ToLower();
            Console.WriteLine("stringToLower (after): " + stringToLower);

            ///Getting Parts of Strings
            Console.WriteLine("\nGetting Parts of Strings");
            string string6 = "fstringf";
            string string7 = string6.Substring(1, string6.Length - 2);
            Console.WriteLine("string7: " + string7);
            string string8 = string6.Remove(string6.Length - 1).Remove(0,1);
            Console.WriteLine("string8: " + string8);

            ///Searching
            Console.WriteLine("\nSearching");
            string x5 = "this is some string";
            char y5 = 's';
            int z5 = x5.IndexOf(y5);
            bool w5 = x5.Contains(y5);

            Console.WriteLine("z5: " + z5);
            Console.WriteLine("w5: " + w5);

            ///Splitting
            Console.WriteLine("\nSplitting");
            string x6 = "this is also some string";
            string[] y6 = x6.Split();
            Console.WriteLine("y6[0]: " + y6[0]);
            Console.WriteLine("y6[1]: " + y6[1]);
            Console.WriteLine("y6[2]: " + y6[2]);
            Console.WriteLine("y6[3]: " + y6[3]);
            Console.WriteLine("y6[4]: " + y6[4]);

            ///Formatting
            Console.WriteLine("\nFormatting");
            string formatStr = "Hello this is {0} {1}, hailing from {2}, {3}.";
            string firstName = "Brandon";
            string lastName = "Yu";
            string city = "Seattle";
            string state = "Washington";

            string string9 = string.Format(formatStr, firstName, lastName, city, state);
            Console.WriteLine("string 9: " + string9);

            ///Printing and Parsing
            Console.WriteLine("\nPrinting and Parsing");
            bool a7 = true;
            int b7 = 60;
            double c7 = 16.982;
            char d7 = 'd';

            string w7 = a7.ToString();
            string x7 = b7.ToString();
            string y7 = c7.ToString();
            string z7 = d7.ToString();

            bool e7 = bool.Parse(w7);
            int f7 = int.Parse(x7);
            double g7 = double.Parse(y7);
            char h7 = char.Parse(z7);
            Console.WriteLine("e7: " + e7);
            Console.WriteLine("f7: " + f7);
            Console.WriteLine("g7: " + g7);
            Console.WriteLine("h7: " + h7);

            //Enums
            Console.WriteLine("\nEnums");
            var newThing = Dunno.Who;
            Console.WriteLine("Enum name: " + newThing.ToString());
            Console.WriteLine("Enum value: " + (int)newThing);

            //Structs
            Console.WriteLine("\nStructs");
            var thingy1 = new Thingy();
            thingy1.stringThingy = "thingy1";
            thingy1.intThingy = 1;
            thingy1.boolThingy = true;

            var thingy2 = new Thingy();
            thingy2.stringThingy = "thingy2";
            thingy2.intThingy = 2;
            thingy2.boolThingy = false;

            thingy1.stringThingy = thingy2.stringThingy;
            thingy1.intThingy = thingy2.intThingy;
            thingy1.boolThingy = thingy2.boolThingy;

            Console.WriteLine("thingy1.stringThingy: " + thingy1.stringThingy);
            Console.WriteLine("thingy1.intThingy: " + thingy1.intThingy);
            Console.WriteLine("thingy1.boolThingy: " + thingy1.boolThingy);

            //Console I/O
            Console.WriteLine("\nConsole I/O");

            Console.WriteLine("Enter Your First Name:");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Enter Your Middle Name:");
            string middleName1 = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Hello {0} {1} {2}", firstName1, middleName1, lastName1);

            Console.ReadLine();


        }

        enum Dunno
        {
            Who = 4,
            Where = 8,
            What = 15,
            When = 16,
            Why = 23,
            How = 42
        }

        public struct Thingy
        {
            public string stringThingy;
            public int intThingy;
            public bool boolThingy;
        }
    }
}
