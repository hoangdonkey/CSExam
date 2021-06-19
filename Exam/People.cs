using System;
namespace Exam
{
    public class People
    {
        String sGender = "";

        public People() { }

        public String Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public void addPeople(String Name, bool Gender, int Age)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
            if (Gender == true)
            {
                sGender = "Male";
            }
            else
            {
                sGender = "Female";
            }
        }

        public void Increment()
        {
            Age += 10;
            System.Console.WriteLine("Person information after increment: Name: " + Name + "\tGender: " + sGender + "\tAge: " + Age);
        }

        public String display()
        {
            return "Person information: Name: " + Name + "\tGender: " + sGender + "\tAge: " + Age;
        }
    }
}