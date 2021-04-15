using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proiect_Asigurari
{
    [Serializable]

    public class Clienti : IComparable,ICloneable
    {

        //PK
        private static long i = 0;
        public long ID { get; set; }
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public String Adresa { get; set; }
        public long CNP { get; set; }
        public String SerieBuletin { get; set; }
        public String DataNasterii { get; set; }
        public String Telefon { get; set; }
        public List<Asigurari> listaAsigurari { get; set; }

        public Clienti(String nume, String prenume, String adresa, long cnp, String serie, String data, String telefon, List<Asigurari> lista)
        {
            
            this.Nume = nume;
            this.Prenume = prenume;
            this.Adresa = adresa;
            this.CNP = cnp;
            this.SerieBuletin = serie;
            this.DataNasterii = data;
            this.Telefon = telefon;
            this.listaAsigurari = lista;
        }

        public Clienti(String nume, String prenume, String adresa, long cnp, String serie, String data, String telefon)
        {
           
            this.Nume = nume;
            this.Prenume = prenume;
            this.Adresa = adresa;
            this.CNP = cnp;
            this.SerieBuletin = serie;
            this.DataNasterii = data;
            this.Telefon = telefon;
            this.listaAsigurari = new List<Asigurari>();
        }

        public Clienti(long id,String nume, String prenume, String adresa, long cnp, String serie, String data, String telefon)
        {

            ID = id;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Adresa = adresa;
            this.CNP = cnp;
            this.SerieBuletin = serie;
            this.DataNasterii = data;
            this.Telefon = telefon;
            this.listaAsigurari = new List<Asigurari>();
        }

        public Clienti()
        {
            
            this.Nume = "";
            this.Prenume = "";
            this.Adresa = "";
            this.SerieBuletin = "";
            this.DataNasterii = "";
            this.CNP = 0;
            this.Telefon = "";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            else
            {
                Clienti persoana = obj as Clienti;
                if (persoana.Nume != null)
                {
                    return this.Nume.CompareTo(persoana.Nume);
                }
                else
                {
                    throw new ArgumentException("Object ul nu este client");
                }
            }
        }
        public static explicit operator float(Clienti c1)
        {
            float suma = 0;
            foreach (Asigurari each in c1.listaAsigurari)
                suma += each.sumaAsigurare;
            return suma;
                
        }
        public static Clienti operator+(Clienti c, String s)
        {
            c.Prenume += " " + s;
            return c;
        }

        public Asigurari this[int index]
        {
            get { return this.listaAsigurari[index]; }
            set { this.listaAsigurari[index] = value; }
        }

        public object Clone()
        {
            Clienti c = new Clienti();
            c.Nume = this.Nume;
            c.Prenume = this.Prenume;
            c.SerieBuletin = this.SerieBuletin;
            c.DataNasterii = this.DataNasterii;
            c.CNP = this.CNP;
            c.Telefon = this.Telefon;
            c.listaAsigurari = new List<Asigurari>();
            c.Adresa = this.Adresa;
            foreach(Asigurari each in this.listaAsigurari)
            {
                c.listaAsigurari.Add(each);
            }

            return c;
        }

        public event OperationEventHandler add;
        
        public void OnOperation()
        {
            if (add != null)
                add(this);
        }
    }

    public delegate void OperationEventHandler(Clienti c);
    
    public class Operation
    {
        public void OnOperation(Clienti clienti)
        {
            Console.WriteLine("Clientul "+clienti.Nume + " " + clienti.Prenume + " se asigura");
            Console.WriteLine("Please wait...");
            Thread.Sleep(3000);
        }
    }

    public class Addition
    {
        public void OnOperation(Clienti clienti)
        {
            Console.WriteLine("Clientul "+clienti.ID+" "+clienti.Nume+" "+clienti.Prenume+" a fost asigurat\n");
        }
    }
}
