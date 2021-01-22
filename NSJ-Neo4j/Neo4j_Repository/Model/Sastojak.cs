using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.Model
{
    public class Sastojak
    {
        public String idSastojak { get; set; }
        public String naziv { get; set; }

       public String rateHranljivosti { get; set; }
        public Jelo jelo { get; set; }
    }
}
