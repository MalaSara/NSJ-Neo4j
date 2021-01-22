using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Neo4J_Repository.Model;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace Neo4J_Repository
{
    public partial class Form1 : Form
    {
        private GraphClient client;

        //relationships:SASTOJAK
        
        int counterjela = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sara - autentifikacija
            // kate - edukacija
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "nadjisuperjelo");


            try
            {
                client.Connect();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnDodajAutore_Click(object sender, EventArgs e)
        {
            var queryid = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Autor) and exists(n.idAutor) return max(n.idAutor)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);
            
            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(queryid).ToList().FirstOrDefault();
            int mId = Int32.Parse(maxId);
            
            Autor autor = new Autor();

            autor.idAutor = (++mId).ToString();
            autor.jelaCijiJeAutor = new List<Jelo>();
            autor.srednjaOcenaAutora = "0";
            autor.ime = "Andjela";
            autor.prezime = "Mladenovic";
            autor.brojJela = "0";
            autor.brojOcena = "0";
            //}

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("idAutor", autor.idAutor);
            //queryDict.Add("jelaCijiJeAutor", autor.jelaCijiJeAutor);
            queryDict.Add("srednjaOcenaAutora", autor.srednjaOcenaAutora);
            queryDict.Add("ime", autor.ime);
            queryDict.Add("prezime", autor.prezime);
            queryDict.Add("brojJela", autor.brojJela);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Autor {idAutor:'" + autor.idAutor +
                "', srednjaOcenaAutora:'" + autor.srednjaOcenaAutora + "', ime:'" + autor.ime + "', prezime:'" +
                autor.prezime + "', brojJela:'" + autor.brojJela + "', brojOcena:'" + autor.brojOcena + "'}) return n",
                queryDict, CypherResultMode.Set);

            
            List<Autor> autori = ((IRawGraphClient)client).ExecuteGetCypherResults<Autor>(query).ToList();

            foreach (Autor a in autori)
                MessageBox.Show(a.ime);

            this.Close();
        }

        private void btnObrisiAutora_Click(object sender, EventArgs e)
        {
            string unos = nudIdAutora.Value.ToString();

            if (unos != "0")
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("idAutor", unos);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where " +
                    "(n:Autor) and exists(n.idAutor) and n.idAutor ='"+unos+"' detach delete n",
                     queryDict, CypherResultMode.Projection);

                List<Autor> autori = ((IRawGraphClient)client).ExecuteGetCypherResults<Autor>(query).ToList();

                foreach (Autor a in autori)
                {
                    MessageBox.Show(a.idAutor + "\t" + a.ime);
                }
            }
            else
                MessageBox.Show("Niste uneli ispravan id!");
        }

        private void btnIzmeniAutora_Click(object sender, EventArgs e)
        {
            string idAutor = nudIdAutoraZaOcenjivanje.Value.ToString();
            string srednjaOcenaAutora = numOcena.Value.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("idAutor", idAutor);
            queryDict.Add("srednjaOcenaAutora", srednjaOcenaAutora);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Autor) and exists(n.idAutor) and n.idAutor ='"+idAutor+"' set n.srednjaOcenaAutora = '"+srednjaOcenaAutora+"'   return n",
                                       new Dictionary<string, object>(), CypherResultMode.Set);

            List < Autor> autori = ((IRawGraphClient)client).ExecuteGetCypherResults<Autor>(query).ToList();

            foreach (Autor a in autori)
            {
                MessageBox.Show("Srednja ocena: " + a.srednjaOcenaAutora);
            }
        }

        private void btnPronadjiAutoraPoImenu_Click(object sender, EventArgs e)
        {
            string imeAutora = ".*" + txtGetAutori.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", imeAutora);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Autor) and exists(n.ime) and " +
                "n.ime =~ {ime} return n", queryDict, CypherResultMode.Set);

            List<Autor> autori = ((IRawGraphClient)client).ExecuteGetCypherResults<Autor>(query).ToList();

            foreach (Autor a in autori)
            {
                //DateTime bday = a.getBirthday();
                MessageBox.Show(a.ime + a.prezime + a.srednjaOcenaAutora);
            }
        }

        private void DodajJela_Click(object sender, EventArgs e)
        {
            var queryid = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Jelo) and exists(n.idJelo) return max(n.idJelo)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(queryid).ToList().FirstOrDefault();
            int mId = Int32.Parse(maxId);

            Jelo jelo = new Jelo();
            Autor au = new Autor();
            au.idAutor = "2";
            
            Sastojak sas = new Sastojak();
            sas.naziv = "visnje";

            jelo.idJelo = (++mId).ToString();
            //jelo.autor = au;
            jelo.nazivJela = "Pita sa visnjama";
            jelo.nacinPripreme = "kuvanje";
            jelo.Sastojci = new List<Sastojak>();
            jelo.Sastojci.Add(sas);
            jelo.ocenaJela = "9";
            jelo.brojOcenaJela = "3";
            jelo.kategorija = "rucak";



            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("idJelo", jelo.idJelo);
            queryDict.Add("autor", jelo.autor);
            queryDict.Add("nazivJela", jelo.nazivJela);
            queryDict.Add("nacinPripreme", jelo.nacinPripreme);
            queryDict.Add("Sastojci", jelo.Sastojci);
            queryDict.Add("ocenaJela", jelo.ocenaJela);
            queryDict.Add("brojOcenaJela", jelo.brojOcenaJela);
            queryDict.Add("kategorija", jelo.kategorija);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n: Jelo {idJelo:'" + jelo.idJelo +
                  "', nazivJela:'" + jelo.nazivJela + "', nacinPripreme:'" +
                jelo.nacinPripreme  +"', Sastojci:'" +sas.naziv +"', ocenaJela:'"+ jelo.ocenaJela + "', brojOcenaJela:'" + jelo.brojOcenaJela +
                 "', kategorija:'" +jelo.kategorija+  "'}) return n",
                queryDict, CypherResultMode.Set);

            List<Jelo> jela = ((IRawGraphClient)client).ExecuteGetCypherResults<Jelo>(query).ToList();
            
            foreach (Jelo j in jela)
                MessageBox.Show(j.nazivJela);

            var queryaut = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Autor) and exists(n.idAutor) and n.idAutor ='" + au.idAutor + "'    return n",
                                      new Dictionary<string, object>(), CypherResultMode.Set);


            List<Autor> autori= ((IRawGraphClient)client).ExecuteGetCypherResults<Autor>(queryaut).ToList();
            foreach (Jelo j in jela)
            {
                foreach (Autor aut in autori)
                {
                    if (aut.idAutor == au.idAutor)
                    {
                        //aut.jelaCijiJeAutor.Add(j);
                        j.autor = aut;
                        MessageBox.Show(aut.ime + " je autor" + j.nazivJela);
                        var queryy = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Jelo) and exists(n.idJelo) and n.idJelo ='" + j.idJelo+"' set n.autor = '"+j.autor +"'   return n",
                                       new Dictionary<string, object>(), CypherResultMode.Set);
                    }
                    else { MessageBox.Show("Nepostoji autor sa tim id-em"); }
                }
            }


            this.Close();

        }

        private void ObrisiJela_Click(object sender, EventArgs e)
        {
            string unos = tboxIdJela.Value.ToString();

            if (unos != "0")
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("idJelo", unos);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where " +
                    "(n:Jelo) and exists(n.idJelo) and n.idJelo = '"+unos+"' detach delete n",
                     queryDict, CypherResultMode.Projection);

                List<Jelo> jela = ((IRawGraphClient)client).ExecuteGetCypherResults<Jelo>(query).ToList();

                foreach (Jelo jelo in jela)
                {
                    MessageBox.Show(jelo.nazivJela);
                }
            }
            else
                MessageBox.Show("Niste uneli ispravan id!");
        }

        private void IzmeniJelo_Click(object sender, EventArgs e)
        {

            string idJelo = tboxIdZaPromenu.Value.ToString();
            string nacinpripreme = tboxnacinpripreme.ToString();

            /*Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("idAutor", idAutor);
            queryDict.Add("srednjaOcenaAutora", srednjaOcenaAutora);*/


            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Jelo) and exists(n.idJelo) and n.idJelo ='"+idJelo+"' set n.nacinPripreme = '"+nacinpripreme +"'   return n",
                                       new Dictionary<string, object>(), CypherResultMode.Set);

            List<Jelo> jela = ((IRawGraphClient)client).ExecuteGetCypherResults<Jelo>(query).ToList();

            foreach (Jelo j in jela)
            {
                MessageBox.Show("Novi nacin pripreme: " + j.nacinPripreme);
            }
        }

        private void PronadjiJeloPoSastojku_Click(object sender, EventArgs e)
        {
            
                string sastojak = ".*" + tboxNadjiJelo.Text + ".*";

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("Sastojak", sastojak);

                var query = new Neo4jClient.Cypher.CypherQuery("start n = node(*) match(n) < -[r: SASTOJAK] - (a)where exists(n.naziv) and n.naziv ='" + sastojak +"' return a"
                   , queryDict, CypherResultMode.Set);

                List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

                foreach (Sastojak sas in sastojci)
                {
                    MessageBox.Show(sas.naziv);
                }
            
        }

        
    }
}

