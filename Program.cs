using System;

<<<<<<< Updated upstream
namespace iPole_01
=======
namespace iPole_01 // do u see this. Yes 
>>>>>>> Stashed changes
{ // jubii 

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
    //I can play this game too
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Cecilie", 21);


            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age); // hehehe
           
        }
    }
}
<<<<<<< Updated upstream
=======

// hello
>>>>>>> Stashed changes
