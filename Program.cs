using System;

<<<<<<< Updated upstream
namespace iPole_01
=======
namespace iPole_01 // do u see this. Yes 
>>>>>>> Stashed changes
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Cecilie", 21);


            Console.WriteLine(person.Name);
           
        }
    }
}
<<<<<<< Updated upstream
=======

// hello
>>>>>>> Stashed changes
