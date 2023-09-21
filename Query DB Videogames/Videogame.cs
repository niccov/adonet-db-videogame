using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_DB_Videogames
{
    public class Videogame
    {
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
    }
}
