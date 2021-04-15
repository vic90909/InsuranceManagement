using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_Asigurari;

namespace Proiect_Asigurari
{
    [Serializable]
    public class AlteBunuri:Asigurari
    {
        public String detaliiBun { get; set; }

        //constructor cu parametrii pentru parinte si copil
        public AlteBunuri( String denumireBun, String numeAsigurator, String locatieBun,
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit,String tip,
            String detalii) 
            : base(denumireBun, numeAsigurator, locatieBun, sumaAsigurare, dataPolitaInceput, dataPolitaSfarsit,tip)
        {
            this.detaliiBun = detalii;
        }
        public AlteBunuri() : base()
        {

        }
        //constructor cu parametrii pentru parinte
        public AlteBunuri(String denumireBun, String numeAsigurator, String locatieBun,
            float sumaAsigurare, String dataPolitaInceput, String dataPolitaSfarsit, String tip)
            : base(denumireBun, numeAsigurator, locatieBun, sumaAsigurare, dataPolitaInceput, dataPolitaSfarsit,tip)
        {
            
        }

        public AlteBunuri(Asigurari a):base(a)
        {
            
        }
    }
}
