using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Proiect_Asigurari;

namespace Proiect_Asigurari
{
    [Serializable]
    [XmlInclude(typeof(Automobil))]
    [XmlInclude(typeof(Viata))]
    [XmlInclude(typeof(AlteBunuri))]
    [XmlInclude(typeof(Locuinta))]
  
    public abstract class Asigurari
    {
        //atribute cu AutoProperties
        public int IDClient { get; set; }
        public int ID { get; set; }
        public String denumireBun { get; set; }
        public String numeAsigurator { get; set; }
        public String locatieBun { get; set; }
        public float sumaAsigurare { get; set; }
        public String dataPolitaInceput { get; set; }
        public String dataPolitaSfarsit { get; set; }
        public String tipAsigurare { get; set; }

        //constructor cu parametrii
        public Asigurari(String denumireBun,String numeAsigurator,String locatieBun,
            float sumaAsigurare,String dataPolitaInceput,String dataPolitaSfarsit,String tipAsigurare)
        {
            
            this.denumireBun = denumireBun;
            this.numeAsigurator = numeAsigurator;
            this.locatieBun = locatieBun;
            this.sumaAsigurare = sumaAsigurare;
            this.dataPolitaInceput = dataPolitaInceput;
            this.dataPolitaSfarsit = dataPolitaSfarsit;
            this.tipAsigurare = tipAsigurare;
        }
        //constructor fara parametrii
        public Asigurari()
        {

        }

        protected Asigurari(Asigurari a)
        {
            this.denumireBun = a.denumireBun;
            this.numeAsigurator = a.numeAsigurator;
            this.locatieBun = a.locatieBun;
            this.sumaAsigurare = a.sumaAsigurare;
            this.dataPolitaInceput = a.dataPolitaInceput;
            this.dataPolitaSfarsit = a.dataPolitaSfarsit;
        }
    }
}
