using System;
namespace dotnetprogramming {
    class Survey{
        static void Main(string[] args) {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);

            if(name == "Alen"){
                Console.WriteLine("Can enter");
            } else {
                Console.WriteLine("Can't enter!");
            }
        }
    }
}