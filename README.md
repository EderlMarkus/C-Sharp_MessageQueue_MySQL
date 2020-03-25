# People with Superpowers

## Message Queue and MySQL Connection with C

Little Side-Project with C#.
Basically just playing around, creating Objects (in this case Persons with Superpowers and Age), then having 2 console applications, one Provider that creates and adds Objects to a Message-Queue and saves them in a MySQL-Database, and one Consumer that reads the Queue.

Thats basically it, just for reference, if I ever need one of those things in the future again.

## How it works:

### before Executing

Message Queue
![alt text](images/Message_Queue_vor_ausführen.PNG)

MySQL Table
![alt text](images/MySQL_Tabelle_vor_auführen.PNG)

### executing

First start Provider
![alt text](images/Message_Provider_Console.PNG)

This will add to the Message Queue:
![alt text](images/Message_Provider_Console.PNG)

And to the Database:
![alt text](images/MySQL_Tabelle_nach_Provider.PNG)

Then start the Consumer:
![alt text](images/Message_Consumer_Console.PNG)

After this, Message Queue is empty again:
![alt text](images/Message_Queue_vor_ausführen.PNG)

Magic, i tell you!
