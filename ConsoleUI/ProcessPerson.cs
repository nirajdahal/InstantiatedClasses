using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class ProcessPerson
    {


        public static void GreetPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName}");
            person.HasBeenGreeted = true;
        }


    }   
}
