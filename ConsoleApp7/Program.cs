using InOutTextFile.BL;
using System;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = Console.ReadLine();

            string  message =     TextIO.WriteTextToTXT(writePath, "привет" +
                "мир" +
                "!" +
                "");

            Console.WriteLine(message);
            Console.WriteLine(TextIO.ReadTextInTXT(writePath));

        }
    }
}
