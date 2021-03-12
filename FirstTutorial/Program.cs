using System;
using System.Collections.Generic;

namespace FirstTutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // tego w javie nie ma ale można stosować konstuktory jak w javie
            Student stud = new Student
            {
                FirstName = "Daniel",
                Age = 12 
            };

            var stud2 = new Student("Janek", 23);
             

            //snipet cw
            //konkatenacja stringów tzw interpolacja stringa $
            Console.WriteLine($"Imie studenta to: {stud.FirstName} i ma {stud.Age} lat");

            Console.WriteLine(stud2.ToString());

            //ICollection - możemy coś wstawiać
            //INumerable - tylko iterowanie

            var list = new List<string> {"Ala", "ma", "kota"};

            foreach (var wrt in list)
            {
                Console.WriteLine(wrt);
            }


 

        }
    }
}
