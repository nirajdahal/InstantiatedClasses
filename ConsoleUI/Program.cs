using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            /*We are building houseNumber-2 with that blue print
           
            PersonModel personOne = new PersonModel()
            { 
              firstName = "Niraj",
            lastName = "Dal",
              age = 21

            };*/

            /*We are building houseNumber-2 with that blue print
            PersonModel personTwo = new PersonModel()
            {
               firstName = "Nirjala",
              lastName = "Dahal",
              age = 24

            };*/

            /*List<PersonModel> personList = new List<PersonModel>()
            {
                 new PersonModel() {
            firstName = "Niraj",
               lastName = "Dahal",
                 age = 21
                },
                 new PersonModel() {
                 firstName = "Niraj1",
                lastName = "Dahal2",
                age = 22

            //// }

            //// };*/


            ////foreach (PersonModel per in personList)
            ////{
            ////    Console.WriteLine(person.age);
            ////};


            /*List<PersonModel> personList2 = new List<PersonModel>();

                PersonModel person = new PersonModel();
            person.firstName = "Niraj";

            
            personList2.Add(person); */

            /*When we overwrite person creating new person model it doesnot mean that
            the person with firstname niraj was removed. We have created another 
            personModel using the same variable name. Vari
            */


            /*person = new PersonModel();

            person.firstName = "Nirjala";

            personList2.Add(person);

            foreach (PersonModel per in personList2)
            {
                Console.WriteLine(per.firstName);
            }*/


            /*List<PersonModel> people = new List<PersonModel>();
            string firstName;



            //varibale holds addresss to new house not the house itself
             do
             {
                 Console.WriteLine("Hello what is your name");
                 firstName = Console.ReadLine();
                 if (firstName.ToLower() != "exit")
                 {
                     PersonModel person = new PersonModel();
                     person.FirstName = firstName;
                     people.Add(person);
                     //At this point the person variable gets blown away so we 
                     //are able instantiate new persson model with same vairable
                 }


             } while (firstName.ToLower() !="exit");

             foreach (PersonModel person in people)
             {
                 Console.WriteLine(person.FirstName);
             }
            */


            PersonModel person = new PersonModel();
            person.FirstName = "Niraj";
            ProcessPerson.GreetPerson(person);

        }
    }
}
