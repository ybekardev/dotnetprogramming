using System;

namespace Employees {

    interface Employee {
         public static void pay() {
            Console.WriteLine("Comes from Interface");
        }
    }

    class Person : Employee {
        void pay(){

        }
    }
}