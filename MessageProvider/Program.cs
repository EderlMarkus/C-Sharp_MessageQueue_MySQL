using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MessageQueueHandler;
using Shared;

namespace MessageProvider
{
    class Program
    {

        static void Main(string[] args)
        {

            Daten daten = new Daten();
            Handler<Person> queueHandler = new Handler<Person>("mypersonqueue");


            for (int i = 0; i < 5; i++)
            {
                Person person1 = new Person(daten.getRandomNamen(), "Nachname", daten.getRandomAlter(18, 99), daten.getRandomSuperkraft());

                if (person1.Alter > 30)
                {
                    //Add to Queue
                    queueHandler.Send(person1);
                    Console.WriteLine("Person " + person1.Vorname + " im Alter von " + person1.Alter + " wurde zur Queue hinzugefügt.");

                    //Add to Database
                    person1.savePersonInDataBase();
                    Console.WriteLine("Person " + person1.Vorname + " im Alter von " + person1.Alter + " wurde zur Datenbank hinzugefügt.");

                }

            }

            Console.ReadLine();
        }
    }
}
