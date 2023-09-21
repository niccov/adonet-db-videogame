using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_DB_Videogames
{
    public class Videogame
    {
        private long v1;
        private string v2;
        private string v3;
        private DateTime dateTime;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Overview { get; private set; }

        public string Date { get; private set; }

        public Videogame(int id,  string name, string overview, string date)
        {
            Id = id;
            Name = name;
            Overview = overview;
            Date = date;
        }

        public Videogame(long v1, string v2, string v3, DateTime dateTime)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.dateTime = dateTime;
        }
    }
}
