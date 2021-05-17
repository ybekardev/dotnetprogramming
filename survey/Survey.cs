using System;
namespace dotnetprogramming {
    class Survey{
        static void Main(string[] args) {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
           
            Console.WriteLine("What is your age?");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);

            if (age == 40) {
                Console.WriteLine("You are 40 years old!");
            }

            Console.WriteLine(condition(name));

            var numbers = new int[] {1,2,3,4,5};
            foreach(var num in numbers){
                Console.WriteLine(num);
            }

            SchoolTracker.schoolClassA();
            SchoolTracker.schoolClassB();
        }

        static string condition(string name){
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
              if(name == "Alen"){
                Console.WriteLine("Can enter");
            } else {
                Console.WriteLine("Can't enter!");
                while(name !=  "Alen"){
                    Console.WriteLine("Enter your name: ");
                    var again = Console.ReadLine();
                    if(again.Equals("Alen")){
                    break;
                    }
                }
            }
            return name;
        }
    }
}