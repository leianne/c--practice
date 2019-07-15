using System;

namespace TestApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            SayHi("Leianne");
            Console.WriteLine(Cubed(43));

            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static int Cubed(int num)
        {
            int result;
            result = (int)Math.Pow(num, 3);

            return result;
        }
    }
}
