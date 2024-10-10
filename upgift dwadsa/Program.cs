using System;
namespace Upgift_2_4
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket känar allihopa en efter en Bara siffror");
            string person1 = Console.ReadLine();
            int P1 = int .Parse(person1)
            string person2 = Console.ReadLine();
            int P2 = int .Parse(person2)
            string person3 = Console.ReadLine();
            int P3 = int .Parse(person3);
            int Sum = (P1 + P2 + P3);
            int medel = ( Sum / 3);
            Console.WriteLine("medel lönen i företaget är " + medel);
        }
     }
}
