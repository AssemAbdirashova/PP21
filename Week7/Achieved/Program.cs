using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Achieved

{
    public class Team
    {
        public List<Person> players;
        public string name;
        public Person coach;
        public Team(List<Person> players, string name, Person coach)
        {
            this.players = players;
            this.name = name;
            this.coach = coach;
        }
        public Team()
        {
        }

    }
    public class Person
    {
        public int age;
        public string country;
        public string name;
        public Person(int age, string country, string name)
        {
            this.age = age;
            this.country = country;
            this.name = name;
        }
        public Person()
        {

        }
    }
    [Serializable]
    public class Football
    {

        public Football(int n)
        {
        }
        public Football()
        {
        }

        public Team t1 = new Team();
        public Team t2 = new Team();
        public string stadium;
        public Person referee = new Person();

        public Football(Team t1, Team t2, string stadium, Person referee)
        {
            this.t1 = t1;
            this.t2 = t2;
            this.stadium = stadium;
            this.referee = referee;

        }
 /*       public override string ToString()
        {
            return String.Format("team 1: {0}, team 2: {1}, stadium: {3}", t1, t2, stadium);
        }  */
        class Program
        {
        static void Main(string[] args)
            {

                List<Person> Barcelona = new List<Person>();
                List<Person> RealMadrid = new List<Person>();
                Person referee = new Person(21, "Ast", "sar");
                Person coach = new Person(23, "Aydar", "Shymkent");
                Team t1 = new Team(Barcelona, "GGGGG", coach);
                Team t2 = new Team(RealMadrid, "asem", coach);
                Football foot =new Football(t1, t2, "Kazan Arena", referee);
                List<Football> football = new List<Football>();
                football.Add(foot);

                FileStream fs = new FileStream("football.txt", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(List<Football>));
                xs.Serialize(fs, football);
                fs.Close();
                FileStream fs1 = new FileStream("football.txt", FileMode.Open, FileAccess.Read);
                List<Football> list = (List<Football>)xs.Deserialize(fs1);
                fs1.Close();
                foreach (Football f in list)
                {
                    Console.WriteLine(f);
                }
               

            }
        }
    }
}