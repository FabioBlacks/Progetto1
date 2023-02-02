using System;

namespace Training
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(new DateTime(1987, 6, 2));
            Animal animal1 = new Animal("uccello", "aquila", "carnivoro");
            Console.WriteLine("{0} ,{1} ,{2}", animal1.Category, animal1.Alimentation, animal1.Name); 

            //Console.WriteLine(person.Birthdate); 
        }
    }
}
