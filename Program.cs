using System;
using System.Collections.Generic;


namespace NameGeneratorDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            var nameGenerator = new NameGenerator();

            Console.WriteLine($"Hello {nameGenerator.GenerateFullName()}");
        }
    }


}