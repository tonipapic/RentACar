﻿namespace STATE_RentACar
{
    partial class RentACarForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtDatumRezervacije = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPredaj = new System.Windows.Forms.Button();
            this.txtDatumPredavanja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPregledaj = new System.Windows.Forms.Button();
            this.txtPregledNapravio = new System.Windows.Forms.TextBox();
            this.btnUciniRaspolozivim = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAktivirajVozilo = new System.Windows.Forms.Button();
            this.btnDeaktivirajVozilo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStatusVozila = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpisModela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRezerviraj);
            this.groupBox1.Controls.Add(this.txtDatumRezervacije);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(157, 99);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacija:";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(46, 59);
            this.btnRezerviraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(96, 20);
            this.btnRezerviraj.TabIndex = 7;
            this.btnRezerviraj.Text = "Rezerviraj vozilo";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtDatumRezervacije
            // 
            this.txtDatumRezervacije.Enabled = false;
            this.txtDatumRezervacije.Location = new System.Drawing.Point(14, 38);
            this.txtDatumRezervacije.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatumRezervacije.Name = "txtDatumRezervacije";
            this.txtDatumRezervacije.Size = new System.Drawing.Size(130, 20);
            this.txtDatumRezervacije.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rezervacije:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPredaj);
            this.groupBox2.Controls.Add(this.txtDatumPredavanja);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(176, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(158, 99);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predavanje vozila klijentu:";
            // 
            // btnPredaj
            // 
            this.btnPredaj.Enabled = false;
            this.btnPredaj.Location = new System.Drawing.Point(38, 59);
            this.btnPredaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnPredaj.Name = "btnPredaj";
            this.btnPredaj.Size = new System.Drawing.Size(105, 20);
            this.btnPredaj.TabIndex = 7;
            this.btnPredaj.Text = "Predaj vozilo";
            this.btnPredaj.UseVisualStyleBackColor = true;
            this.btnPredaj.Click += new System.EventHandler(this.btnPredaj_Click);
            // 
            // txtDatumPredavanja
            // 
            this.txtDatumPredavanja.Enabled = false;
            this.txtDatumPredavanja.Location = new System.Drawing.Point(14, 38);
            this.txtDatumPredavanja.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatumPredavanja.Name = "txtDatumPredavanja";
            this.txtDatumPredavanja.Size = new System.Drawing.Size(130, 20);
            this.txtDatumPredavanja.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum predavanja:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnPregledaj);
            this.groupBox3.Controls.Add(this.txtPregledNapravio);
            this.groupBox3.Location = new System.Drawing.Point(338, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(166, 99);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pregled vozila:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pregled napravio:";
            // 
            // btnPregledaj
            // 
            this.btnPregledaj.Enabled = false;
            this.btnPregledaj.Location = new System.Drawing.Point(44, 59);
            this.btnPregledaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnPregledaj.Name = "btnPregledaj";
            this.btnPregledaj.Size = new System.Drawing.Size(105, 20);
            this.btnPregledaj.TabIndex = 7;
            this.btnPregledaj.Text = "Pregledaj vozilo";
            this.btnPregledaj.UseVisualStyleBackColor = true;
            this.btnPregledaj.Click += new System.EventHandler(this.btnPregledaj_Click);
            // 
            // txtPregledNapravio
            // 
            this.txtPregledNapravio.Location = new System.Drawing.Point(20, 38);
            this.txtPregledNapravio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPregledNapravio.Name = "txtPregledNapravio";
            this.txtPregledNapravio.Size = new System.Drawing.Size(130, 20);
            this.txtPregledNapravio.TabIndex = 6;
            // 
            // btnUciniRaspolozivim
            // 
            this.btnUciniRaspolozivim.Enabled = false;
            this.btnUciniRaspolozivim.Location = new System.Drawing.Point(67, 32);
            this.btnUciniRaspolozivim.Margin = new System.Windows.Forms.Padding(2);
            this.btnUciniRaspolozivim.Name = "btnUciniRaspolozivim";
            this.btnUciniRaspolozivim.Size = new System.Drawing.Size(105, 40);
            this.btnUciniRaspolozivim.TabIndex = 7;
            this.btnUciniRaspolozivim.Text = "Učini raspoloživim";
            this.btnUciniRaspolozivim.UseVisualStyleBackColor = true;
            this.btnUciniRaspolozivim.Click += new System.EventHandler(this.btnUciniRaspolozivim_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUciniRaspolozivim);
            this.groupBox5.Controls.Add(this.btnAktivirajVozilo);
            this.groupBox5.Controls.Add(this.btnDeaktivirajVozilo);
            this.groupBox5.Location = new System.Drawing.Point(14, 231);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(490, 101);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Funkcija vozila:";
            // 
            // btnAktivirajVozilo
            // 
            this.btnAktivirajVozilo.Enabled = false;
            this.btnAktivirajVozilo.Location = new System.Drawing.Point(176, 32);
            this.btnAktivirajVozilo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAktivirajVozilo.Name = "btnAktivirajVozilo";
            this.btnAktivirajVozilo.Size = new System.Drawing.Size(105, 41);
            this.btnAktivirajVozilo.TabIndex = 8;
            this.btnAktivirajVozilo.Text = "Aktiviraj vozilo";
            this.btnAktivirajVozilo.UseVisualStyleBackColor = true;
            this.btnAktivirajVozilo.Click += new System.EventHandler(this.btnAktivirajVozilo_Click);
            // 
            // btnDeaktivirajVozilo
            // 
            this.btnDeaktivirajVozilo.Location = new System.Drawing.Point(286, 32);
            this.btnDeaktivirajVozilo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeaktivirajVozilo.Name = "btnDeaktivirajVozilo";
            this.btnDeaktivirajVozilo.Size = new System.Drawing.Size(105, 41);
            this.btnDeaktivirajVozilo.TabIndex = 7;
            this.btnDeaktivirajVozilo.Text = "Deaktiviraj vozilo";
            this.btnDeaktivirajVozilo.UseVisualStyleBackColor = true;
            this.btnDeaktivirajVozilo.Click += new System.EventHandler(this.btnDeaktivirajVozilo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStatusVozila);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtOpisModela);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtRegistracija);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(14, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(490, 115);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Podaci o vozilu:";
            // 
            // txtStatusVozila
            // 
            this.txtStatusVozila.Enabled = false;
            this.txtStatusVozila.Location = new System.Drawing.Point(292, 20);
            this.txtStatusVozila.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatusVozila.Name = "txtStatusVozila";
            this.txtStatusVozila.Size = new System.Drawing.Size(93, 20);
            this.txtStatusVozila.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status vozila:";
            // 
            // txtOpisModela
            // 
            this.txtOpisModela.Location = new System.Drawing.Point(96, 51);
            this.txtOpisModela.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpisModela.Multiline = true;
            this.txtOpisModela.Name = "txtOpisModela";
            this.txtOpisModela.Size = new System.Drawing.Size(378, 46);
            this.txtOpisModela.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Opis modela:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(96, 20);
            this.txtRegistracija.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(93, 20);
            this.txtRegistracija.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registracija:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDirectory);
            this.groupBox6.Location = new System.Drawing.Point(14, 346);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(490, 100);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Postavke programa";
            // 
            // btnDirectory
            // 
            this.btnDirectory.Enabled = false;
            this.btnDirectory.Location = new System.Drawing.Point(67, 33);
            this.btnDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(105, 40);
            this.btnDirectory.TabIndex = 7;
            this.btnDirectory.Text = "Direktorij za spremanje";
            this.btnDirectory.UseVisualStyleBackColor = true;
            // 
            // RentACarForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 483);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RentACarForma";
            this.Text = "RentACar";
            this.Load += new System.EventHandler(this.RentACarForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtDatumRezervacije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPredaj;
        private System.Windows.Forms.TextBox txtDatumPredavanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPregledaj;
        private System.Windows.Forms.TextBox txtPregledNapravio;
        private System.Windows.Forms.Button btnUciniRaspolozivim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAktivirajVozilo;
        private System.Windows.Forms.Button btnDeaktivirajVozilo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStatusVozila;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOpisModela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDirectory;
    }
}

