using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Model
{
    public class Autor
    {
        public String idAutor { get; set; }
        public List<Jelo> jelaCijiJeAutor { get; set; }
        public String srednjaOcenaAutora { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String brojJela { get; set; }

        public String brojOcena { get; set; }
    }
}
