using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RentACar
{
    public class Vozilo
    {
        public string Registracija { get; set; }
        public string Model { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumPredavanja { get; set; }
        public string PregledNapravio { get; set; }

        public Vozilo(string registracija, string model)
        {
            Registracija = registracija;
            Model = model;
        }

        public void RezervirajVozilo(Button toDisable, Button toEnable)
        {
            DatumRezervacije = DateTime.Now;
            DisableAndEnable(toDisable, toEnable);
        }

        public void PredajVozilo(Button toDisable, Button toEnable)
        {
            DatumPredavanja = DateTime.Now;
            DisableAndEnable(toDisable, toEnable);
        }

        public void PregledajVozilo(string pregledNapravio, Button toDisable, Button toEnable)
        {
            PregledNapravio = pregledNapravio;
            DisableAndEnable(toDisable, toEnable);
        }

        public void AktivirajVozilo(Button toDisable, Button toEnable)
        {
            DisableAndEnable(toDisable, toEnable);
        }

        public void DeaktivirajVozilo(Button toDisable, Button toEnable)
        {
            DisableAndEnable(toDisable, toEnable);
        }

        public void UciniRaspolozivim(Button toDisable, Button toDisable2, Button toEnable,Button toEnable2)
        {

            DisableAndEnable(toDisable, toEnable);
            DisableAndEnable(toDisable2, toEnable2);
            PregledNapravio = null;
        }


        private void DisableAndEnable(Button toDisable, Button toEnable)
        {
            toDisable.Enabled = false;
            toEnable.Enabled = true;
        }
    }
}
