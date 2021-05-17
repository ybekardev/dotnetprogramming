using System;
using System.Collections.Generic;
using Student;

namespace dotnetprogramming {
   public static class SchoolTracker{
       
       public static void schoolClassA(){
        Console.WriteLine("How many students are in the class?");
        var studentCount = int.Parse(Console.ReadLine());
        var studentNames = new string[studentCount];
        var studentGrades = new int[studentCount];

        for ( int i = 0; i < studentCount; i++){
            Console.WriteLine("Student Name: ");
            studentNames[i] = Console.ReadLine();

            Console.WriteLine("Student Grade: ");
            studentGrades[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Student Name: {0}, Student Grade: {1} ", studentNames[i], studentGrades[i] );
        }
       }

      public static void schoolClassB(){
        Console.WriteLine("Enter the name and the grade of the student:");
        var studentNames = new List<String>();
        var studentGrades = new List<int>();

        var adding = true;

        while(adding){
            Console.WriteLine("Student Name: ");
            studentNames.Add(Console.ReadLine());

            Console.WriteLine("Student Grade: ");
            studentGrades.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Add another student? y/n");
            
            if(Console.ReadLine() != "y"){
                adding = false;
            }
        }
       for(int i = 0; i < studentNames.Count; i++){
           Console.WriteLine("Student Name: {0}, Student Grade: {1}", studentGrades[i], studentGrades[i]);
       }


       }

        public static void schoolClassC(){
            var listOfStudents = new List<Students>();
            var student = new Students();
            student.name = "Jame";
            student.grade = 98;
            student.address = "234 N Alice Ave";
            student.phone = "812 644 6454";
 
            Console.WriteLine("Name: {0}, Grade: {1}, Address: {2}, Phone: {3}", student.name, student.grade, student.address, student.phone);

            var newStudent = new Students();
            listOfStudents.Add(student);

         while(true){
             Console.WriteLine("Enter student's information; name, grade, address, phone");
             newStudent.name = Console.ReadLine();
             newStudent.grade = int.Parse(Console.ReadLine());
             newStudent.address = Console.ReadLine();
             newStudent.phone = Console.ReadLine();

             Console.WriteLine("Enter another? y/n");
             listOfStudents.Add(newStudent);
             student.count++;
             Console.WriteLine("Counter {0}", student.count);
             if(Console.ReadLine() != "y")
             break;
         }

        //Console.WriteLine("Name: {0}, Grade: {1}, Address: {2}, Phone: {3}", newStudent.name, newStudent.grade, newStudent.address, newStudent.phone);

         foreach(var eachStudent in listOfStudents){
         Console.WriteLine("Name: {0}, Grade: {1}, Address: {2}, Phone: {3}", eachStudent.name, eachStudent.grade, eachStudent.address, eachStudent.phone);
    }

       for(int i =0; i < listOfStudents.Count; i++){
         Console.WriteLine("Name: {0}, Grade: {1}, Address: {2}, Phone: {3}", listOfStudents[i].name, listOfStudents[i].grade, listOfStudents[i].address, listOfStudents[i].phone);
    }
    }
   }
   
}


    