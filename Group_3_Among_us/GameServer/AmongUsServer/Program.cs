using System;

namespace AmongUsServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Among Us Server";

            Server.Start(50, 23190);

            while (Console.ReadLine() != "exit")
            {
            }
        }
    }
}
