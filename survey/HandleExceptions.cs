using System;

namespace HandleExceptions {
class Exceptions {
    public static void except(){
        var a = 5;
        var b = 0;
        var c = a / b;
        Console.WriteLine("Result: {0}", c);
    }

    public static void tryCatch(){
        int a  = 98;
        int b = 2;
        try{
        int c  = a / b;
        Console.WriteLine("Response: {0}", c);
        int d  = a / 0;
        Console.WriteLine("Response: {0}", d);
        }catch(Exception){
            Console.WriteLine("Error, dividing by zero!");
        }

    }
}

}