using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Model
{
    public class Jelo
    {
        public String idJelo { get; set; }

        public String nazivJela { get; set; }
        public String ocenaJela { get; set; }
        public Autor autor { get; set; }

        public String nacinPripreme { get; set; }

        public String brojOcenaJela { get; set; }
        public String kategorija { get; set; }
        
        //
        public List<Sastojak> Sastojci { get; set; }

    }
}
