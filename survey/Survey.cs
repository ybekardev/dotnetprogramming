using System;
using System.Collections.Generic;
using Student;

namespace dotnetprogramming {
    class Survey{
        static void Main(string[] args) {
            /*Console.WriteLine("What is your name?");
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
    */        SchoolTracker.schoolClassC();

           loops();
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
    
     static void loops(){
        var lists = new List<String>();
           lists.Add("Adam");
           lists.Add("Jim");
           lists.Add("Jimmy");
            foreach(var list in lists){
                Console.WriteLine(list);
            }

           var listOfStudents = new List<Students>();
           var student1 = new Students();
           student1.name = "Adam";
           student1.address = "323 Apt 43";
           student1.grade = 43;
           student1.phone = "432 232 2332";
           
           listOfStudents.Add(student1);
           
           var student2 = new Students();

           student2.name = "Jim";
           student2.address = "43 Apt 43";
           student2.grade = 65;
           student2.phone = "232 45 45434";

           listOfStudents.Add(student2);
            var student = new Students();

            foreach(var list in listOfStudents){
            Console.WriteLine("Name: {0}, Grade: {1}, Address: {2}, Phone: {3}", list.name, list.grade, list.address, list.phone);
            student.count++;
            Console.WriteLine("Counter {0}", student.count);
            }
    }
}
}