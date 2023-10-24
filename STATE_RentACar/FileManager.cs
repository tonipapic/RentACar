using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    class FileManager
    {
        public string FilePath { get; set; }
        public FileManager(string filePath) 
        { 
            FilePath = filePath;
        }

        public void SaveToFile(Vozilo vozilo)
        {
            using (StreamWriter sw = new StreamWriter(FilePath,true))
            {
                    sw.WriteLine();
                    sw.WriteLine("Registracija:"+vozilo.Registracija+";");
                    sw.WriteLine("Vozilo:"+vozilo.Model+";");
                    sw.WriteLine("DatumRezervacije:"+vozilo.DatumRezervacije+";");
                    sw.WriteLine("DatumPredavanja:"+vozilo.DatumPredavanja+";");
                    sw.WriteLine("PregledNapravio:"+vozilo.PregledNapravio);


            }

        }

    }
}
