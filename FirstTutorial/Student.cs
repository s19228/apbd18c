using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTutorial
{
    public class Student
    {
        // settery i gettery 
        // prop

        public string FirstName { get; set; }

        // propfull

        public int Age { get; set; }

        public String ToString()
        {
            return FirstName + " " + Age;
        }

        public Student(String Name, int Age) 
        {
            this.FirstName = Name;
            this.Age = Age;
        
        }

        public Student()
        {
        
        }


    }
}
