using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { };
            List<Person> people = new List<Person>();
            Console.WriteLine("How many clients would you like to add to the list?");
            int numberOfClients = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfClients; i++)
            {               
                DataEntry(people, person);
            }
            foreach (Person aPerson in people)
            {
                Console.WriteLine(aPerson);
            }
            Console.WriteLine("If you want to know the total amount on the account of all clients, enter 1\n" +
                "To display information on a client with a minimum amount on the account, enter 2\n" +
                    "To search by ID enter 3\n" +
                        "To search by full name enter 4\n" +
                            "To select visitors with an amount below the specified enter 5\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: TotalSum(people);
                    break;
                case 2: MinSum(people, person);
                    break;
                case 3: SearchByID(people, person);
                    break;
                case 4: SearchByName(people, person);
                    break;
                case 5: Selection(people, person);
                    break;
            }
        }

        static void DataEntry(List<Person> people, Person person)
        {
            Console.WriteLine("Enter name:");
            person.FullName = Console.ReadLine();
            Console.WriteLine("Enter the amount on the account:");
            person.Money = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter ID:");
            person.ID = Convert.ToInt32(Console.ReadLine());
            if (people.Contains(new Person { ID = person.ID }))
            {
                Console.WriteLine("A person with this ID already exists!");
            }
            else
            {
                people.Add(new Person() { FullName = person.FullName, Money = person.Money, ID = person.ID });
            }
        }

        static void TotalSum(List<Person> people)
        {
            decimal totalSum = people.Sum(prs => prs.Money);
            Console.WriteLine("The total sum is: {0}", totalSum); 
        }

        static void MinSum(List<Person> people, Person person)
        {
            Console.WriteLine("Account data with a minimum balance: " + people.Find(x => x.Money == people.Min(prs => prs.Money)));                   
        }

        static void SearchByID(List<Person> people, Person person)
        {
            Console.WriteLine("Search by ID:");
            int idPerson = Convert.ToInt32(Console.ReadLine());
            if (people.Find(x => x.ID == idPerson) == null)
            {
                Console.WriteLine("This client is not on the list");
            }
            else
            {
                Console.WriteLine("Search results: " + people.Find(x => x.ID == idPerson));
            }
        }

        static void SearchByName(List<Person> people, Person person)
        {
            Console.WriteLine("Search by full name:");
            string name = Console.ReadLine();
            if (people.Find(x => x.FullName == name) == null)
            {
                Console.WriteLine("This client is not on the list");
            }
            else
            {
                List<Person> names = people.FindAll(x => x.FullName == name);
                foreach (Person aPerson in names)
                    Console.WriteLine(aPerson);
            }
        }

        static void Selection(List<Person> people, Person person)
        {
            Console.WriteLine("Enter the amount to search:");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            if (people.Find(x => x.Money <= sum) == null)
            {
                Console.WriteLine("This client is not on the list");
            }
            else
            {
                List<Person> amountBelow = people.FindAll(x => x.Money <= sum);
                foreach (Person aPerson in amountBelow)
                    Console.WriteLine(aPerson);
            }
 
        }
    }
}
