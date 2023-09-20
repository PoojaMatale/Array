using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /**public class Player
    {
        private int runs;
        private string name;

        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{runs}->{name}";
        }

        public class Team : IEnumerable
        {
            private Player[] players;
            public Team()
            {
                players = new Player[3]
                {
                   new Player(2000, "hardik"),
                   new Player(3000, "sachin"),
                   new Player(4000, "virat"),
                };
            }
            public IEnumerator GetEnumerator()
            {
                return players.GetEnumerator();
            }
        }
        public class program
        {
            static void Main(string[] args)
            {
                Team team = new Team();
                foreach(Player item in team)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }**/

}
