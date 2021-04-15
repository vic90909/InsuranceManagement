using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Asigurari
{
    [Serializable]

    public class Locuinta:Asigurari
    {
        public String Adresa { get; set; }
        public tipLocuinta tip { get; set; }
        public int numarNiveluri { get; set; }
        public float suprafataTotala { get; set; }
        public float suprafataUtilizabila { get; set; }
        public int numarCamere { get; set; }
        
        

        public Locuinta( String denumireBun, String numeAsigurator, String locatieBun, 
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit,String tipAsigurare,
            String adresa,tipLocuinta tip,int numarLvl, float sTotal,float sUtil,int nr)
            :base(denumireBun,numeAsigurator,locatieBun,sumaAsigurare,
                 dataPolitaInceput,dataPolitaSfarsit,tipAsigurare)
        {
            
            this.Adresa = adresa;
            this.tip = tip;
            this.numarNiveluri = numarLvl;
            this.suprafataTotala = sTotal;
            this.suprafataUtilizabila = sUtil;
            this.numarCamere = nr;

        }
        //constructor fara parametrii
        public Locuinta() : base()
        {

        }
        public Locuinta(String denumireBun, String numeAsigurator, String locatieBun,
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit, String tip) :
            base(denumireBun, numeAsigurator,
                locatieBun, sumaAsigurare,
                dataPolitaInceput, dataPolitaSfarsit, tip)
        {

        }
    }
}
