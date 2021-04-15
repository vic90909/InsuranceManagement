using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Asigurari
{
    public partial class UserControlClienti : UserControl
    {
        public UserControlClienti()
        {
            InitializeComponent();
        }
        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbNume.Text) || String.IsNullOrWhiteSpace(tbNume.Text))
            { 
                epNume.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }
    }
}
