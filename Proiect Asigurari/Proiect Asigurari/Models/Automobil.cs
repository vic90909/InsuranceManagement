using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Asigurari
{
    [Serializable]
    public class Automobil:Asigurari
    {
        public String marca { get; set; }
        public String model { get; set; }
        public String numarImatriculare { get; set; }
        public String serieSasiu { get; set; }
        public int capacitateCilindrica { get; set; }
        public int numarLocuri { get; set; }
        public int masaMaximaAdmisa { get; set; }

        public Automobil( String denumireBun, String numeAsigurator, String locatieBun,
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit,String tip,
            String marca, String model, String numarInmatriculare, String serieSasiu, 
            int capacitate, int numar,int masa) 
            : base(denumireBun, numeAsigurator, locatieBun, 
                  sumaAsigurare, dataPolitaInceput, dataPolitaSfarsit,tip)
        {
            this.marca = marca;
            this.model = model;
            this.numarImatriculare = numarImatriculare;
            this.serieSasiu = serieSasiu;
            this.capacitateCilindrica = capacitate;
            this.numarLocuri = numar;
            this.masaMaximaAdmisa = masa;
        }

        public Automobil() : base()
        {

        }
        public Automobil(String denumireBun, String numeAsigurator, String locatieBun,
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit, String tip) :
            base(denumireBun, numeAsigurator,
                locatieBun, sumaAsigurare,
                dataPolitaInceput, dataPolitaSfarsit, tip)
        {

        }
    }
}
