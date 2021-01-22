using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Model
{
    public class Kategorija
    {
        

        public string idKategorija { get; set; }
        public string naziv { get; internal set; }
    }
}
