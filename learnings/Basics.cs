namespace learnings
{
    public class Basics
    {
        // This is a comment
        /*
         * This is a multiline comments
         */
        static int Sum(int a, int b)
        {
            return a + b;
        }
        private static void Main(string[] args){
            // Beginning
            Console.WriteLine("Hello, World!");
            Console.Write("Hello");
            Console.ReadLine();
            Console.Read();
            // Variables
            // int-> 4 bytes
            // float -> 4 bytes
            // char -> 2 bytes
            // bool -> 1 bit
            // double -> 8 bytes
            // long -> 8 bytes
            int a = 34;
            string b = "Hello";
            const bool c = false;
            var d = 'A';
            float e;
            e = 1.2f;
            long f = 129292929;
            double g;
            g = 1.3;
            Console.Write(a+" "+b+" "+c+" "+d+" "+e+" "+f+" "+g);
            // Typecasting
            int h = (int)4.5;
            Console.Write(h);
            Console.Write(Convert.ToInt32(3.4));
            // Maths
            Console.Write(Math.Max(1, 2));
            Console.Write(Math.Min(1, 2));
            Console.Write(Math.Pow(1, 2));
            Console.Write(Math.Sqrt(13));
            // String
            Console.Write("Hello".Length);
            Console.Write("Hello".Split("")[0]);
            Console.Write("Hello".Concat("Hey I am a boss"));
            Console.Write("Hello".Substring(0,3));
            Console.Write($"Hello Boolean is {c}");
            Console.Write("Hello"[1]);
            Console.Write("Hello".IndexOf("Hello"));
            // Conditionals
            Console.Write("Please enter the age");
            Console.Read();
            string? exp = Console.ReadLine();
            int age = Convert.ToInt32(exp);
            if (age>23)
            {
                Console.Write("HEY");
            }else if (age!=23)
            {
                Console.Write("HELLO");
            }
            else
            {
                Console.Write("ELSE");
            }
            // Loops
            do
            {
                Console.Write(a--);
            } while (a>0);

            for (int i = 1; i < 10; i++)
            {
                Console.Write(i);
            }

            while (g>1)
            {
                Console.Write(g-=0.1);
            }
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
                Console.WriteLine(i);
            }
            // Switch
            switch (age)
            {
                case 23:
                    Console.WriteLine("Hey it is 23");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            // Functions
            Console.WriteLine(Sum(1,2));
            // OOPS
            Oops oops = new Oops(1, 2);
            Console.Write(oops.A);
            oops.A = 3;
            Inherit inherit = new Inherit();
            Console.Write(inherit.GetOopsMin());
            // Enums
            Enums enums = Enums.Male;
            Console.Write(enums);
            // File
            FileHandling fileHandling = new FileHandling();
            fileHandling.CreateFile();
        }
    }
}
