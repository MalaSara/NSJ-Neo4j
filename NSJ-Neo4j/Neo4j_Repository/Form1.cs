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



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    "(n:Autor) and exists(n.idAutor) and n.idAutor ={idAutor} detach delete n",
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

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Autor) and exists(n.idAutor) and n.idAutor =~{idAutor} set n.srednjaOcenaAutora = {srednjaOcenaAutora}  return n",
                                       new Dictionary<string, object>(), CypherResultMode.Set);


            MessageBox.Show("Srednja ocena: " + srednjaOcenaAutora);

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
            

            jelo.idJelo = (++mId).ToString();
            jelo.nazivJela = "Pita sa visnjama";
            jelo.nacinPripreme = "pecenje";
            jelo.ocenaJela = "9";
            jelo.brojOcenaJela = "3";
            jelo.kategorija = "rucak";



            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("idJelo", jelo.idJelo);
            queryDict.Add("nazivJela", jelo.nazivJela);
            queryDict.Add("nacinPripreme", jelo.nacinPripreme);
            queryDict.Add("ocenaJela", jelo.ocenaJela);
            queryDict.Add("brojOcenaJela", jelo.brojOcenaJela);
            queryDict.Add("kategorija", jelo.kategorija);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n: Jelo {idJelo:'" + jelo.idJelo +
                  "', nazivJela:'" + jelo.nazivJela + "', nacinPripreme:'" +
                jelo.nacinPripreme + "', Sastojci:  , ocenaJela:'" + jelo.ocenaJela + "', brojOcenaJela:'" + jelo.brojOcenaJela +
                 "', kategorija:'" + jelo.kategorija + "'}) return n",
                queryDict, CypherResultMode.Set);

            List<Jelo> jela = ((IRawGraphClient)client).ExecuteGetCypherResults<Jelo>(query).ToList();

            foreach (Jelo j in jela)
                MessageBox.Show(j.nazivJela);



            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Autor), (p:Jela) " +
                                                            "WHERE n.idAutor = '2' AND p.idJelo = {idJelo}" +
                                                            "CREATE (n)-[r:SADRZI]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);

            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Autor), (p:Jela) " +
                                                            "WHERE n.idJelo = '1' AND p.idJelo = {idJelo}" +
                                                            "CREATE (p)-[r:JE_SADRZAN]->(n)", new Dictionary<string, object>(), CypherResultMode.Set);


            MessageBox.Show("Autor ciji je ID-1 je autor jela: " + jelo.nazivJela);
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
                    "(n:Jelo) and exists(n.idJelo) and n.idJelo = {idJelo} detach delete n",
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
            string nacinPripreme = tboxnacinpripreme.Text.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("idJelo", idJelo);
            queryDict.Add("nacinpripreme", nacinPripreme);


            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Jelo) and exists(n.idJelo) and n.idJelo =~ {idJelo}  set n.nacinPripreme = {nacinpripreme}   return n",
                                       new Dictionary<string, object>(), CypherResultMode.Projection);


            MessageBox.Show("Novi nacin pripreme: " + nacinPripreme);

        }

        private void PronadjiJeloPoSastojku_Click(object sender, EventArgs e)
        {

            string sastojak = ".*" + tboxNadjiJelo.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("Sastojak", sastojak);

            var query = new Neo4jClient.Cypher.CypherQuery("start n = node(*) match(n) < -[r: SASTOJAK] - (a)where exists(n.naziv) and n.naziv ='" + sastojak + "' return a"
               , queryDict, CypherResultMode.Set);



            List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

            foreach (Sastojak sas in sastojci)
            {
                MessageBox.Show(sas.naziv);
            }

        }

        private void btnDodajSastojke_Click(object sender, EventArgs e)
        {
            Sastojak sastojak = new Sastojak();
            sastojak.idSastojak = "1";
            sastojak.naziv = "Brasno";
            sastojak.rateHranljivosti = "7";

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("idSastojak", sastojak.idSastojak);
            queryDict1.Add("naziv", sastojak.naziv);
            queryDict1.Add("rateHranljivosti", sastojak.rateHranljivosti);

            

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n: Sastojak {idSastojak:'" + sastojak.idSastojak +
                    "', naziv:'" + sastojak.naziv + ", rateHranljivosti:'" + sastojak.rateHranljivosti + "}) return n",
                    queryDict1, CypherResultMode.Set);



            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Jelo), (p:Sastojak) " +
                                                            "WHERE n.idJelo = '1' AND p.idSastojak = '1'" +
                                                            "CREATE (n)-[r:SADRZI]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);

            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Jelo), (p:Sastojak) " +
                                                            "WHERE n.idJelo = '1' AND p.idSastojak = '1'" +
                                                            "CREATE (p)-[r:JE_SADRZAN]->(n)", new Dictionary<string, object>(), CypherResultMode.Set);

            MessageBox.Show(sastojak.naziv);
        }

        private void btnObrisiSastojak_Click(object sender, EventArgs e)
        {
            string idS = upDownObrisiSastojak.Value.ToString();

            if (idS != "0")
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("idSastojak", idS);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where " +
                    "(n:Sastojak) and exists(n.idSastojak) and n.idSastojak =~ {idSastojak} detach delete n",
                     queryDict, CypherResultMode.Projection);
            }
            else
                MessageBox.Show("Pogresan ID!");
        }

        private void btnIzmeniSastojak_Click(object sender, EventArgs e)
        {
            string idSastojak = upDownIDPromena.Value.ToString();
            string naziv = tbNazivSastojka.Text;

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("idSastojak", idSastojak);
            queryDict1.Add("naziv", naziv);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Sastojak) and has(n.idSastojak) and n.idSastojak =~ {idSastojak} " +
                "set n.naziv = {naziv} return n", queryDict1, CypherResultMode.Projection);


        }

        private void btnPretraziSastojak_Click(object sender, EventArgs e)
        {
            string naziv = ".*" + tbNazivSastojka + ".*";
            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("naziv", naziv);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Sastojak) and exists(n.naziv) and n.naziv =~ {naziv} return n",
                                                      queryDict1, CypherResultMode.Set);

            List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();


            foreach (Sastojak s in sastojci)
            {
                MessageBox.Show(s.naziv);
            }
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = new Kategorija();
            kategorija.idKategorija = "1";
            kategorija.naziv = "Predjelo";

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("idKategorija", kategorija.idKategorija);
            queryDict1.Add("naziv", kategorija.naziv);


            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Kategorija {idKategorija:'" + kategorija.idKategorija +
                    "', naziv:" + kategorija.naziv + "}) return n",
                    queryDict1, CypherResultMode.Set);

            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Jelo), (p:Kategorija) " +
                                                            "WHERE n.idJelo = '1' AND p.idKategorija = '1'" +
                                                            "CREATE (n)-[r:SPADA_U]->(p)", new Dictionary<string, object>(), CypherResultMode.Set);

            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Jelo), (p:Kategorija) " +
                                                            "WHERE n.idJelo = '1' AND p.idKategorija = '1'" +
                                                            "CREATE (p)-[r:PRIPADA]->(n)", new Dictionary<string, object>(), CypherResultMode.Set);
            MessageBox.Show(kategorija.naziv);
        
        }

        private void btnBrisiKategoriju_Click(object sender, EventArgs e)
        {
            string idK = upDownIdBrisiKat.Value.ToString();

            if (idK != "0")
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("idKategorija", idK);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where " +
                    "(n:Kategorija) and exists(n.idKategorija) and n.idKategorija =~ {idKategorija} detach delete n",
                     queryDict, CypherResultMode.Projection);
            }
            else
                MessageBox.Show("Pogresan ID!");
        }

        private void btnIzmeniKategoriju_Click(object sender, EventArgs e)
        {
            string idKategorija = upDownKategorija.Value.ToString();
            string naziv = tbNazivKategorije.Text;

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("idKategorija", idKategorija);
            queryDict1.Add("naziv", naziv);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Kategorija) and has(n.idKategorija) and n.idKategorija =~ {idKategorija} " +
                "set n.naziv = {naziv} return n", queryDict1, CypherResultMode.Projection);


        }

        private void btnPretraziKat_Click(object sender, EventArgs e)
        {
            string naziv = ".*" + tbNazivKategorije + ".*";
            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("naziv", naziv);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Kategorija) and exists(n.naziv) and n.naziv =~ {naziv} return n",
                                                      queryDict1, CypherResultMode.Set);

            List<Kategorija> kategorije = ((IRawGraphClient)client).ExecuteGetCypherResults<Kategorija>(query).ToList();


            foreach (Kategorija k in kategorije)
            {
                MessageBox.Show(k.naziv);
            }

        }
    }
}




