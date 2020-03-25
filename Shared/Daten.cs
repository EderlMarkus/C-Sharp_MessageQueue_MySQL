using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Daten
    {
        public List<string> namen;
        public List<string> superkraft;
        private Random random = new Random();



        public Daten()
        {
             namen = getDaten(@"..\..\..\Vornamen.csv");
             superkraft = getDaten(@"..\..\..\Superkraft.csv");

        }

        /// <summary>
        /// Creates a List from Entrys in a File (e.g. txt or csv)
        /// </summary>
        /// <param name="pathToData">string path to where the file is located</param>
        /// <returns>List<string> of all Values found in that file</string></returns>
        private List<string> getDaten(string pathToData)
        {
            List<string> retList = new List<string>();

            using (var reader = new StreamReader(pathToData))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    retList.Add(values[0]);
                }
            }

            return retList;
        }

        /// <summary>
        /// Returns a random item from a List<string>
        /// </summary>
        /// <param name="list">The List you want a random parameter from</param>
        /// <returns></returns>
        private string getRandom(List<string> mylist)
        {
            //between 1 and mylist.Count because 0 is headline
            int randIndex = random.Next(1, mylist.Count);
            return mylist[randIndex];

        }


        /// <summary>
        /// Returns a random Name from the Name-List
        /// </summary>
        /// <returns>string</returns>
        public string getRandomNamen()
        {
            return getRandom(this.namen);
        }

        /// <summary>
        /// Returns a random Superpower from the Superkraft-List
        /// </summary>
        /// <returns>string</returns>
        public string getRandomSuperkraft()
        {
            return getRandom(this.superkraft);
        }


        /// <summary>
        /// Returns a random Int between min and max
        /// </summary>
        /// <param name="min">int, minimum value to be returned</param>
        /// <param name="max">int, maximum value to be returned</param>
        /// <returns>int</returns>
        public int getRandomAlter(int min, int max)
        {
            return random.Next(min, max);

        }
        
    }
}
