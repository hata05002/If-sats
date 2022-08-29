using System;


class program{
    static void Main(string[]arg){
     Console.WriteLine("Är vädret fint?");
     string ask= Console.ReadLine();

     if (ask=="j" || ask=="J")
     Console.Write("Vi går på picknik!");

     else if(ask=="n" || ask== "N")
     Console.Write("Vi stannar inne och läser en bok");

     else
     Console.WriteLine("jag förstår inte");
    }
}