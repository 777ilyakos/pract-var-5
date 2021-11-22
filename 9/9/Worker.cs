using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
    public struct Worker
    {
        public Worker(
                string FirstName,
                string SecondName,
                string LastName,
                string Gender,
                string Post,
                int WorkExperieence,
                int Salary
                     )
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Gender = Gender;
            this.Post = Post;
            this.WorkExperience = WorkExperieence;
            this.Salary = Salary;
        }
        public Worker(int nugna)
        {
            FirstName = "И";
            SecondName = "О";
            LastName = "Ф";
            Gender = "М/Ж";
            Post = "важный";
            WorkExperience = 1000000;
            Salary = 1000000;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Post { get; set; }
        public int WorkExperience { get; set; }
        public int Salary { get; set; }
    }

}
