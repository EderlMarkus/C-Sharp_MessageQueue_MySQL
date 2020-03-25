using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MessageQueueHandler;
using Shared;

namespace MessageConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler<Person> myHandler = new Handler<Person>("mypersonqueue");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myHandler.Read());

            }

            Console.ReadLine();

        }
    }
}
