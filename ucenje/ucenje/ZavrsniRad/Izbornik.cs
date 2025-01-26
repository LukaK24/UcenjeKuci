using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ucenje.ZavrsniRad
{
    class Izbornik
    {
        public Igrac Igrac { get; set; }
        public Klub Klub { get; set; }
        public Trener Trener { get; set; }
        public Utakmica Utakmica { get; set; }
        public object JsonConvert { get; private set; }

        public Izbornik()
        {
            Igrac = new Igrac();
            Klub = new Klub();
            Trener = new Trener();
            Utakmica = new Utakmica();
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        // Existing code...

        private void UcitajPodatke()
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path.Combine(docpath, "Igraci.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docpath, "Igraci.json"));
                //Igrac.Igraci = JsonConvert.DeserializeObject<List<Smjer>>(file.ReadToEnd());
                file.Close();
            }
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("Dobrodosli u aplikaciju za vodenje nogometnih klubova");
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1.grac");
            Console.WriteLine("2.Klub");
            Console.WriteLine("3.Trener");
            Console.WriteLine("4.Utakmica");
        }       
    }
}
