using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Asigurari.Models
{
    public class Graphic
    {
        public String Label { get; set; }
        public float Value { get; set; }

        public Graphic(String label,float value)
        {
            Label = label;
            Value = value;
        }



    }
}
