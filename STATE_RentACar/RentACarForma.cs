using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RentACar
{
    public partial class RentACarForma : Form
    {
        private Vozilo _vozilo;
        string status;
        public RentACarForma()
        {
            InitializeComponent();
        }

        private void RentACarForma_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            IsRequiredEmpty();
            

            _vozilo.RezervirajVozilo(btnDeaktivirajVozilo, btnPredaj);
            txtDatumRezervacije.Text = _vozilo.DatumRezervacije.ToString();
            btnUciniRaspolozivim.Enabled = false;
            txtStatusVozila.Text=Status.Rezerviran.ToString();

        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            _vozilo.PredajVozilo(btnRezerviraj, btnPregledaj);
            txtDatumPredavanja.Text = _vozilo.DatumPredavanja.ToString();
            txtStatusVozila.Text = Status.UUporabi.ToString();

        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPregledNapravio.Text))
            {
                _vozilo.PregledajVozilo(txtPregledNapravio.Text, btnPredaj, btnUciniRaspolozivim);
                txtStatusVozila.Text = Status.NaPregledu.ToString();
            }
            else
                MessageBox.Show("Obavezno ispuniti tko je napravio pregled");
        }

        private void btnUciniRaspolozivim_Click(object sender, EventArgs e)
        {
        
            _vozilo.UciniRaspolozivim(btnPregledaj, btnUciniRaspolozivim, btnDeaktivirajVozilo, btnRezerviraj);
            txtStatusVozila.Text = Status.Raspoloziv.ToString();
            txtPregledNapravio.Text = _vozilo.PregledNapravio;


        }

        private void btnAktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.AktivirajVozilo(btnAktivirajVozilo, btnRezerviraj);
            txtStatusVozila.Text = Status.Raspoloziv.ToString();


        }

        private void btnDeaktivirajVozilo_Click(object sender, EventArgs e)
        {
            IsRequiredEmpty();            
            _vozilo.DeaktivirajVozilo(btnRezerviraj, btnAktivirajVozilo);
            txtStatusVozila.Text = Status.UKvaru.ToString();

        }
        
        private void IsRequiredEmpty()
        {
            if (string.IsNullOrEmpty(txtRegistracija.Text) || string.IsNullOrEmpty(txtOpisModela.Text))
            {
                MessageBox.Show("Ispunite registraciju i opis");
                return;
            }
            else
            {
                _vozilo=new Vozilo(txtRegistracija.Text,txtOpisModela.Text);
            }
        }
      
    }

    public enum Status
    {
        Raspoloziv,
        UKvaru,
        Rezerviran,
        UUporabi,
        NaPregledu
    }
}
    