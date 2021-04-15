using Proiect_Asigurari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_Asigurari
{
    [Serializable]

    public class Viata:Asigurari
    {
        public int varsta { get; set; }
        public String grupaSangvina { get; set; }
        public float inaltime { get; set; }
        public float greutate { get; set; }
        public Gen gen { get; set; }
        public StareCivila stareCivila { get; set; }

       public Viata(String denumireBun, String numeAsigurator, String locatieBun,
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit,String tip,
            int varsta, String grupa, float inaltime, float greutate,Gen gen,StareCivila stare)
            :base(denumireBun, numeAsigurator, locatieBun, sumaAsigurare,
                 dataPolitaInceput, dataPolitaSfarsit,tip)
        {
            this.varsta = varsta;
            this.grupaSangvina = grupa;
            this.inaltime = inaltime;
            this.greutate = greutate;
            this.gen = gen;
            this.stareCivila = stare;
        }

        public Viata() : base()
        {

        }

        public Viata(String denumireBun, String numeAsigurator, String locatieBun,
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit, String tip) : 
            base(denumireBun, numeAsigurator, 
                locatieBun, sumaAsigurare, 
                dataPolitaInceput, dataPolitaSfarsit, tip)
        {

        }
        
    }
}
