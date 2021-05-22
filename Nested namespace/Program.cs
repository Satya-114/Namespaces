
    using System;
    using CustomNameSpace.Nested;

    namespace program
    {
        class Program
        {
            static void Main(string[] args)
            {
                Welcome w = new Welcome();
                w.GreetMessage();
                Console.WriteLine("Press Any Key to Exit..");
                Console.ReadLine();
            }
        }
    }
    namespace CustomNameSpace
    {
        namespace Nested
        {
            class Welcome
            {
                public void GreetMessage()
                {
                    Console.WriteLine("Welcome to task2");
                }
            }
        }
    }


