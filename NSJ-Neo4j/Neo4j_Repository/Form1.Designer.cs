namespace Neo4J_Repository
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxAutor = new System.Windows.Forms.GroupBox();
            this.btnPronadjiAutoraPoImenu = new System.Windows.Forms.Button();
            this.txtGetAutori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numOcena = new System.Windows.Forms.NumericUpDown();
            this.nudIdAutoraZaOcenjivanje = new System.Windows.Forms.NumericUpDown();
            this.btnIzmeniAutora = new System.Windows.Forms.Button();
            this.nudIdAutora = new System.Windows.Forms.NumericUpDown();
            this.btnObrisiAutora = new System.Windows.Forms.Button();
            this.btnDodajAutore = new System.Windows.Forms.Button();
            this.Jela = new System.Windows.Forms.GroupBox();
            this.tboxnacinpripreme = new System.Windows.Forms.TextBox();
            this.PronadjiJeloPoSastojku = new System.Windows.Forms.Button();
            this.tboxNadjiJelo = new System.Windows.Forms.TextBox();
            this.IzmeniJelo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxIdZaPromenu = new System.Windows.Forms.NumericUpDown();
            this.ObrisiJela = new System.Windows.Forms.Button();
            this.tboxIdJela = new System.Windows.Forms.NumericUpDown();
            this.DodajJela = new System.Windows.Forms.Button();
            this.Sastojak = new System.Windows.Forms.GroupBox();
            this.lblstring = new System.Windows.Forms.Label();
            this.lblDodajS = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.tbNazivSastojka = new System.Windows.Forms.TextBox();
            this.upDownIDPromena = new System.Windows.Forms.NumericUpDown();
            this.btnIzmeniSastojak = new System.Windows.Forms.Button();
            this.btnDodajSastojke = new System.Windows.Forms.Button();
            this.btnPretraziSastojak = new System.Windows.Forms.Button();
            this.upDownObrisiSastojak = new System.Windows.Forms.NumericUpDown();
            this.btnObrisiSastojak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNazivKategorije = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.upDownKategorija = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.upDownIdBrisiKat = new System.Windows.Forms.NumericUpDown();
            this.btnPretraziKat = new System.Windows.Forms.Button();
            this.btnIzmeniKategoriju = new System.Windows.Forms.Button();
            this.btnBrisiKategoriju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.grpboxAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAutoraZaOcenjivanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAutora)).BeginInit();
            this.Jela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxIdZaPromenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxIdJela)).BeginInit();
            this.Sastojak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownIDPromena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownObrisiSastojak)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownKategorija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownIdBrisiKat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxAutor
            // 
            this.grpboxAutor.Controls.Add(this.btnPronadjiAutoraPoImenu);
            this.grpboxAutor.Controls.Add(this.txtGetAutori);
            this.grpboxAutor.Controls.Add(this.label2);
            this.grpboxAutor.Controls.Add(this.label1);
            this.grpboxAutor.Controls.Add(this.numOcena);
            this.grpboxAutor.Controls.Add(this.nudIdAutoraZaOcenjivanje);
            this.grpboxAutor.Controls.Add(this.btnIzmeniAutora);
            this.grpboxAutor.Controls.Add(this.nudIdAutora);
            this.grpboxAutor.Controls.Add(this.btnObrisiAutora);
            this.grpboxAutor.Controls.Add(this.btnDodajAutore);
            this.grpboxAutor.Location = new System.Drawing.Point(23, 23);
            this.grpboxAutor.Name = "grpboxAutor";
            this.grpboxAutor.Size = new System.Drawing.Size(288, 243);
            this.grpboxAutor.TabIndex = 14;
            this.grpboxAutor.TabStop = false;
            this.grpboxAutor.Text = "Autor";
            // 
            // btnPronadjiAutoraPoImenu
            // 
            this.btnPronadjiAutoraPoImenu.Location = new System.Drawing.Point(143, 165);
            this.btnPronadjiAutoraPoImenu.Name = "btnPronadjiAutoraPoImenu";
            this.btnPronadjiAutoraPoImenu.Size = new System.Drawing.Size(139, 23);
            this.btnPronadjiAutoraPoImenu.TabIndex = 10;
            this.btnPronadjiAutoraPoImenu.Text = "Pronadji Autora po imenu";
            this.btnPronadjiAutoraPoImenu.UseVisualStyleBackColor = true;
            this.btnPronadjiAutoraPoImenu.Click += new System.EventHandler(this.btnPronadjiAutoraPoImenu_Click);
            // 
            // txtGetAutori
            // 
            this.txtGetAutori.Location = new System.Drawing.Point(6, 168);
            this.txtGetAutori.Name = "txtGetAutori";
            this.txtGetAutori.Size = new System.Drawing.Size(131, 20);
            this.txtGetAutori.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ocena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id za ocenu:";
            // 
            // numOcena
            // 
            this.numOcena.Location = new System.Drawing.Point(80, 127);
            this.numOcena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOcena.Name = "numOcena";
            this.numOcena.Size = new System.Drawing.Size(57, 20);
            this.numOcena.TabIndex = 5;
            this.numOcena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudIdAutoraZaOcenjivanje
            // 
            this.nudIdAutoraZaOcenjivanje.Location = new System.Drawing.Point(80, 103);
            this.nudIdAutoraZaOcenjivanje.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIdAutoraZaOcenjivanje.Name = "nudIdAutoraZaOcenjivanje";
            this.nudIdAutoraZaOcenjivanje.Size = new System.Drawing.Size(57, 20);
            this.nudIdAutoraZaOcenjivanje.TabIndex = 4;
            // 
            // btnIzmeniAutora
            // 
            this.btnIzmeniAutora.Location = new System.Drawing.Point(143, 113);
            this.btnIzmeniAutora.Name = "btnIzmeniAutora";
            this.btnIzmeniAutora.Size = new System.Drawing.Size(139, 23);
            this.btnIzmeniAutora.TabIndex = 3;
            this.btnIzmeniAutora.Text = "Izmeni/Oceni Autora";
            this.btnIzmeniAutora.UseVisualStyleBackColor = true;
            this.btnIzmeniAutora.Click += new System.EventHandler(this.btnIzmeniAutora_Click);
            // 
            // nudIdAutora
            // 
            this.nudIdAutora.Location = new System.Drawing.Point(0, 66);
            this.nudIdAutora.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudIdAutora.Name = "nudIdAutora";
            this.nudIdAutora.Size = new System.Drawing.Size(131, 20);
            this.nudIdAutora.TabIndex = 2;
            // 
            // btnObrisiAutora
            // 
            this.btnObrisiAutora.Location = new System.Drawing.Point(143, 63);
            this.btnObrisiAutora.Name = "btnObrisiAutora";
            this.btnObrisiAutora.Size = new System.Drawing.Size(139, 23);
            this.btnObrisiAutora.TabIndex = 1;
            this.btnObrisiAutora.Text = "Obrisi Autora";
            this.btnObrisiAutora.UseVisualStyleBackColor = true;
            this.btnObrisiAutora.Click += new System.EventHandler(this.btnObrisiAutora_Click);
            // 
            // btnDodajAutore
            // 
            this.btnDodajAutore.Location = new System.Drawing.Point(6, 19);
            this.btnDodajAutore.Name = "btnDodajAutore";
            this.btnDodajAutore.Size = new System.Drawing.Size(131, 23);
            this.btnDodajAutore.TabIndex = 1;
            this.btnDodajAutore.Text = "Dodaj Autore";
            this.btnDodajAutore.UseVisualStyleBackColor = true;
            this.btnDodajAutore.Click += new System.EventHandler(this.btnDodajAutore_Click);
            // 
            // Jela
            // 
            this.Jela.Controls.Add(this.tboxnacinpripreme);
            this.Jela.Controls.Add(this.PronadjiJeloPoSastojku);
            this.Jela.Controls.Add(this.tboxNadjiJelo);
            this.Jela.Controls.Add(this.IzmeniJelo);
            this.Jela.Controls.Add(this.label4);
            this.Jela.Controls.Add(this.label3);
            this.Jela.Controls.Add(this.tboxIdZaPromenu);
            this.Jela.Controls.Add(this.ObrisiJela);
            this.Jela.Controls.Add(this.tboxIdJela);
            this.Jela.Controls.Add(this.DodajJela);
            this.Jela.Location = new System.Drawing.Point(336, 23);
            this.Jela.Name = "Jela";
            this.Jela.Size = new System.Drawing.Size(326, 243);
            this.Jela.TabIndex = 15;
            this.Jela.TabStop = false;
            this.Jela.Text = "Jela";
            // 
            // tboxnacinpripreme
            // 
            this.tboxnacinpripreme.Location = new System.Drawing.Point(95, 135);
            this.tboxnacinpripreme.Name = "tboxnacinpripreme";
            this.tboxnacinpripreme.Size = new System.Drawing.Size(131, 20);
            this.tboxnacinpripreme.TabIndex = 12;
            // 
            // PronadjiJeloPoSastojku
            // 
            this.PronadjiJeloPoSastojku.Location = new System.Drawing.Point(159, 177);
            this.PronadjiJeloPoSastojku.Name = "PronadjiJeloPoSastojku";
            this.PronadjiJeloPoSastojku.Size = new System.Drawing.Size(139, 23);
            this.PronadjiJeloPoSastojku.TabIndex = 11;
            this.PronadjiJeloPoSastojku.Text = "Pronadji Jelo po sastojku";
            this.PronadjiJeloPoSastojku.UseVisualStyleBackColor = true;
            this.PronadjiJeloPoSastojku.Click += new System.EventHandler(this.PronadjiJeloPoSastojku_Click);
            // 
            // tboxNadjiJelo
            // 
            this.tboxNadjiJelo.Location = new System.Drawing.Point(21, 177);
            this.tboxNadjiJelo.Name = "tboxNadjiJelo";
            this.tboxNadjiJelo.Size = new System.Drawing.Size(131, 20);
            this.tboxNadjiJelo.TabIndex = 11;
            // 
            // IzmeniJelo
            // 
            this.IzmeniJelo.Location = new System.Drawing.Point(242, 99);
            this.IzmeniJelo.Name = "IzmeniJelo";
            this.IzmeniJelo.Size = new System.Drawing.Size(56, 51);
            this.IzmeniJelo.TabIndex = 11;
            this.IzmeniJelo.Text = "IzmeniJelo";
            this.IzmeniJelo.UseVisualStyleBackColor = true;
            this.IzmeniJelo.Click += new System.EventHandler(this.IzmeniJelo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nacin pripreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id za promenu:";
            // 
            // tboxIdZaPromenu
            // 
            this.tboxIdZaPromenu.Location = new System.Drawing.Point(95, 103);
            this.tboxIdZaPromenu.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.tboxIdZaPromenu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tboxIdZaPromenu.Name = "tboxIdZaPromenu";
            this.tboxIdZaPromenu.Size = new System.Drawing.Size(57, 20);
            this.tboxIdZaPromenu.TabIndex = 11;
            this.tboxIdZaPromenu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ObrisiJela
            // 
            this.ObrisiJela.Location = new System.Drawing.Point(159, 63);
            this.ObrisiJela.Name = "ObrisiJela";
            this.ObrisiJela.Size = new System.Drawing.Size(139, 23);
            this.ObrisiJela.TabIndex = 11;
            this.ObrisiJela.Text = "Obrisi Jela";
            this.ObrisiJela.UseVisualStyleBackColor = true;
            this.ObrisiJela.Click += new System.EventHandler(this.ObrisiJela_Click);
            // 
            // tboxIdJela
            // 
            this.tboxIdJela.Location = new System.Drawing.Point(21, 66);
            this.tboxIdJela.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.tboxIdJela.Name = "tboxIdJela";
            this.tboxIdJela.Size = new System.Drawing.Size(131, 20);
            this.tboxIdJela.TabIndex = 11;
            // 
            // DodajJela
            // 
            this.DodajJela.Location = new System.Drawing.Point(38, 19);
            this.DodajJela.Name = "DodajJela";
            this.DodajJela.Size = new System.Drawing.Size(131, 23);
            this.DodajJela.TabIndex = 11;
            this.DodajJela.Text = "Dodaj Jela";
            this.DodajJela.UseVisualStyleBackColor = true;
            this.DodajJela.Click += new System.EventHandler(this.DodajJela_Click);
            // 
            // Sastojak
            // 
            this.Sastojak.Controls.Add(this.lblstring);
            this.Sastojak.Controls.Add(this.lblDodajS);
            this.Sastojak.Controls.Add(this.lblid);
            this.Sastojak.Controls.Add(this.tbNazivSastojka);
            this.Sastojak.Controls.Add(this.upDownIDPromena);
            this.Sastojak.Controls.Add(this.btnIzmeniSastojak);
            this.Sastojak.Controls.Add(this.btnDodajSastojke);
            this.Sastojak.Controls.Add(this.btnPretraziSastojak);
            this.Sastojak.Controls.Add(this.upDownObrisiSastojak);
            this.Sastojak.Controls.Add(this.btnObrisiSastojak);
            this.Sastojak.Location = new System.Drawing.Point(12, 287);
            this.Sastojak.Name = "Sastojak";
            this.Sastojak.Size = new System.Drawing.Size(334, 236);
            this.Sastojak.TabIndex = 16;
            this.Sastojak.TabStop = false;
            this.Sastojak.Text = "Sastojak";
            // 
            // lblstring
            // 
            this.lblstring.AutoSize = true;
            this.lblstring.Location = new System.Drawing.Point(148, 147);
            this.lblstring.Name = "lblstring";
            this.lblstring.Size = new System.Drawing.Size(79, 13);
            this.lblstring.TabIndex = 14;
            this.lblstring.Text = "Naziv sastojka:";
            // 
            // lblDodajS
            // 
            this.lblDodajS.AutoSize = true;
            this.lblDodajS.Location = new System.Drawing.Point(12, 74);
            this.lblDodajS.Name = "lblDodajS";
            this.lblDodajS.Size = new System.Drawing.Size(63, 13);
            this.lblDodajS.TabIndex = 13;
            this.lblDodajS.Text = "ID sastojka:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 147);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(63, 13);
            this.lblid.TabIndex = 13;
            this.lblid.Text = "ID sastojka:";
            // 
            // tbNazivSastojka
            // 
            this.tbNazivSastojka.Location = new System.Drawing.Point(151, 172);
            this.tbNazivSastojka.Name = "tbNazivSastojka";
            this.tbNazivSastojka.Size = new System.Drawing.Size(162, 20);
            this.tbNazivSastojka.TabIndex = 17;
            // 
            // upDownIDPromena
            // 
            this.upDownIDPromena.Location = new System.Drawing.Point(6, 172);
            this.upDownIDPromena.Name = "upDownIDPromena";
            this.upDownIDPromena.Size = new System.Drawing.Size(120, 20);
            this.upDownIDPromena.TabIndex = 18;
            // 
            // btnIzmeniSastojak
            // 
            this.btnIzmeniSastojak.Location = new System.Drawing.Point(6, 207);
            this.btnIzmeniSastojak.Name = "btnIzmeniSastojak";
            this.btnIzmeniSastojak.Size = new System.Drawing.Size(120, 23);
            this.btnIzmeniSastojak.TabIndex = 15;
            this.btnIzmeniSastojak.Text = "Izmeni sastojak";
            this.btnIzmeniSastojak.UseVisualStyleBackColor = true;
            this.btnIzmeniSastojak.Click += new System.EventHandler(this.btnIzmeniSastojak_Click);
            // 
            // btnDodajSastojke
            // 
            this.btnDodajSastojke.Location = new System.Drawing.Point(6, 34);
            this.btnDodajSastojke.Name = "btnDodajSastojke";
            this.btnDodajSastojke.Size = new System.Drawing.Size(131, 23);
            this.btnDodajSastojke.TabIndex = 13;
            this.btnDodajSastojke.Text = "Dodaj sastojke";
            this.btnDodajSastojke.UseVisualStyleBackColor = true;
            this.btnDodajSastojke.Click += new System.EventHandler(this.btnDodajSastojke_Click);
            // 
            // btnPretraziSastojak
            // 
            this.btnPretraziSastojak.Location = new System.Drawing.Point(151, 207);
            this.btnPretraziSastojak.Name = "btnPretraziSastojak";
            this.btnPretraziSastojak.Size = new System.Drawing.Size(162, 23);
            this.btnPretraziSastojak.TabIndex = 16;
            this.btnPretraziSastojak.Text = "Pretrazi sastojak po nazivu";
            this.btnPretraziSastojak.UseVisualStyleBackColor = true;
            this.btnPretraziSastojak.Click += new System.EventHandler(this.btnPretraziSastojak_Click);
            // 
            // upDownObrisiSastojak
            // 
            this.upDownObrisiSastojak.Location = new System.Drawing.Point(79, 72);
            this.upDownObrisiSastojak.Name = "upDownObrisiSastojak";
            this.upDownObrisiSastojak.Size = new System.Drawing.Size(58, 20);
            this.upDownObrisiSastojak.TabIndex = 17;
            // 
            // btnObrisiSastojak
            // 
            this.btnObrisiSastojak.Location = new System.Drawing.Point(143, 69);
            this.btnObrisiSastojak.Name = "btnObrisiSastojak";
            this.btnObrisiSastojak.Size = new System.Drawing.Size(139, 23);
            this.btnObrisiSastojak.TabIndex = 14;
            this.btnObrisiSastojak.Text = "Obrisi sastojak";
            this.btnObrisiSastojak.UseVisualStyleBackColor = true;
            this.btnObrisiSastojak.Click += new System.EventHandler(this.btnObrisiSastojak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbNazivKategorije);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.upDownKategorija);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.upDownIdBrisiKat);
            this.groupBox1.Controls.Add(this.btnPretraziKat);
            this.groupBox1.Controls.Add(this.btnIzmeniKategoriju);
            this.groupBox1.Controls.Add(this.btnBrisiKategoriju);
            this.groupBox1.Controls.Add(this.btnDodajKategoriju);
            this.groupBox1.Location = new System.Drawing.Point(400, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 236);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorija";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Naziv kategorije:";
            // 
            // tbNazivKategorije
            // 
            this.tbNazivKategorije.Location = new System.Drawing.Point(135, 172);
            this.tbNazivKategorije.Name = "tbNazivKategorije";
            this.tbNazivKategorije.Size = new System.Drawing.Size(148, 20);
            this.tbNazivKategorije.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID kategorije:";
            // 
            // upDownKategorija
            // 
            this.upDownKategorija.Location = new System.Drawing.Point(16, 172);
            this.upDownKategorija.Name = "upDownKategorija";
            this.upDownKategorija.Size = new System.Drawing.Size(84, 20);
            this.upDownKategorija.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID kategorije:";
            // 
            // upDownIdBrisiKat
            // 
            this.upDownIdBrisiKat.Location = new System.Drawing.Point(88, 67);
            this.upDownIdBrisiKat.Name = "upDownIdBrisiKat";
            this.upDownIdBrisiKat.Size = new System.Drawing.Size(61, 20);
            this.upDownIdBrisiKat.TabIndex = 4;
            // 
            // btnPretraziKat
            // 
            this.btnPretraziKat.Location = new System.Drawing.Point(135, 207);
            this.btnPretraziKat.Name = "btnPretraziKat";
            this.btnPretraziKat.Size = new System.Drawing.Size(150, 23);
            this.btnPretraziKat.TabIndex = 3;
            this.btnPretraziKat.Text = "Pretrazi kategoriju po nazivu";
            this.btnPretraziKat.UseVisualStyleBackColor = true;
            this.btnPretraziKat.Click += new System.EventHandler(this.btnPretraziKat_Click);
            // 
            // btnIzmeniKategoriju
            // 
            this.btnIzmeniKategoriju.Location = new System.Drawing.Point(16, 207);
            this.btnIzmeniKategoriju.Name = "btnIzmeniKategoriju";
            this.btnIzmeniKategoriju.Size = new System.Drawing.Size(112, 23);
            this.btnIzmeniKategoriju.TabIndex = 2;
            this.btnIzmeniKategoriju.Text = "Izmeni kategoriju";
            this.btnIzmeniKategoriju.UseVisualStyleBackColor = true;
            this.btnIzmeniKategoriju.Click += new System.EventHandler(this.btnIzmeniKategoriju_Click);
            // 
            // btnBrisiKategoriju
            // 
            this.btnBrisiKategoriju.Location = new System.Drawing.Point(155, 64);
            this.btnBrisiKategoriju.Name = "btnBrisiKategoriju";
            this.btnBrisiKategoriju.Size = new System.Drawing.Size(113, 23);
            this.btnBrisiKategoriju.TabIndex = 1;
            this.btnBrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnBrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnBrisiKategoriju.Click += new System.EventHandler(this.btnBrisiKategoriju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Location = new System.Drawing.Point(6, 19);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(111, 23);
            this.btnDodajKategoriju.TabIndex = 0;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sastojak);
            this.Controls.Add(this.Jela);
            this.Controls.Add(this.grpboxAutor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxAutor.ResumeLayout(false);
            this.grpboxAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAutoraZaOcenjivanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAutora)).EndInit();
            this.Jela.ResumeLayout(false);
            this.Jela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxIdZaPromenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxIdJela)).EndInit();
            this.Sastojak.ResumeLayout(false);
            this.Sastojak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownIDPromena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownObrisiSastojak)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownKategorija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownIdBrisiKat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxAutor;
        private System.Windows.Forms.Button btnPronadjiAutoraPoImenu;
        private System.Windows.Forms.TextBox txtGetAutori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOcena;
        private System.Windows.Forms.NumericUpDown nudIdAutoraZaOcenjivanje;
        private System.Windows.Forms.Button btnIzmeniAutora;
        private System.Windows.Forms.NumericUpDown nudIdAutora;
        private System.Windows.Forms.Button btnObrisiAutora;
        private System.Windows.Forms.Button btnDodajAutore;
        private System.Windows.Forms.GroupBox Jela;
        private System.Windows.Forms.Button PronadjiJeloPoSastojku;
        private System.Windows.Forms.TextBox tboxNadjiJelo;
        private System.Windows.Forms.Button IzmeniJelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tboxIdZaPromenu;
        private System.Windows.Forms.Button ObrisiJela;
        private System.Windows.Forms.NumericUpDown tboxIdJela;
        private System.Windows.Forms.Button DodajJela;
        private System.Windows.Forms.TextBox tboxnacinpripreme;
        private System.Windows.Forms.GroupBox Sastojak;
        private System.Windows.Forms.Label lblstring;
        private System.Windows.Forms.Label lblDodajS;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox tbNazivSastojka;
        private System.Windows.Forms.NumericUpDown upDownIDPromena;
        private System.Windows.Forms.Button btnIzmeniSastojak;
        private System.Windows.Forms.Button btnDodajSastojke;
        private System.Windows.Forms.Button btnPretraziSastojak;
        private System.Windows.Forms.NumericUpDown upDownObrisiSastojak;
        private System.Windows.Forms.Button btnObrisiSastojak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNazivKategorije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown upDownKategorija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown upDownIdBrisiKat;
        private System.Windows.Forms.Button btnPretraziKat;
        private System.Windows.Forms.Button btnIzmeniKategoriju;
        private System.Windows.Forms.Button btnBrisiKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
    }
}

