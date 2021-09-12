using System;

class Program {
  public static void Main (string[] args) {
      //single line comment

      /* multi line comment
      fsdfsd
      fsdfsd
      fsdfsd
      */
    Console.WriteLine("Enter your name ");//Prompt for name
    var name = Console.ReadLine();//Get name and store it in a variable
    Console.WriteLine("Your name is ");
    Console.WriteLine(name);

    /*age of a person
    int, double, float, decimal
    int = whole number like 5
    double = decimal like 5.46
    */

    //age of a person
    int age;//declaring a variable

    //salary
    double salary = 64000.56;//declaring and intiializing a variable
    
    age = 6;
    salary = 0;

    //string datatype
    string address = "1111 Main st, Cleveland OH";

    //bool = true or false?
    bool isUnderAge = false;



    
  }
}