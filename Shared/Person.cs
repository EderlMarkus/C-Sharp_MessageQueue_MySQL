using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Shared
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }
        public string Superkraft { get; set; }

        public Person(string Vorname, string Nachname, int Alter, string Superkraft)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Alter = Alter;
            this.Superkraft = Superkraft;

        }

        public Person()
        {

        }


        public void savePersonInDataBase()
        {


            string myConnectionString = "Database=personsampledb;Data Source=localhost;User Id=root;Password=";

            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myInsertQuery = "INSERT INTO personen (vorname, nachname, age, superkraft) VALUES ('" + Vorname + "', '" + Nachname + "', '" + Alter + "','" + Superkraft + "')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();



        }
        public override string ToString()
        {
            return "Die Person heißt " + Vorname + ", ist " + Alter + "Jahre alt und kann " + Superkraft;
        }
    }
}
