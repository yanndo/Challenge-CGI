using System;

namespace Challenge1
{
    public class Menu
    {
        public string FirstMethod;
        public string SecondMethod;
        public string ThirdMethod;
        public string Leave;

        public void Choice()

        {
            Console.WriteLine("method 1: " + FirstMethod);
            Console.WriteLine("method 2: " + SecondMethod);
            Console.WriteLine("method 3: " + ThirdMethod);
            Console.WriteLine(Leave + ":    4");
            Console.ReadLine();

        }
    }
}