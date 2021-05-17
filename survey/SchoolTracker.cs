using System;
using System.Collections.Generic;

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
    }

}