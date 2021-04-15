using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Asigurari
{
    public partial class AsigurareAlteBunuriForm : Form
    {
        AlteBunuri local;
        public AsigurareAlteBunuriForm(Asigurari c)
        {
            InitializeComponent();
            local = c as AlteBunuri;
        }

        private void AsigurareAlteBunuriForm_Load(object sender, EventArgs e)
        {
            tbDetalii.Text = local.detaliiBun;
        }

        private void btRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCurata_Click(object sender, EventArgs e)
        {
            this.tbDetalii.Clear();
        }

        private void btFinalizare_Click(object sender, EventArgs e)
        {
            local.detaliiBun = tbDetalii.Text;
            this.Close();

        }

        private void tbDetalii_Validated(object sender, EventArgs e)
        {
            epDetalii.Clear();
        }

        private void tbDetalii_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbDetalii.Text) || String.IsNullOrWhiteSpace(tbDetalii.Text))
            {
                epDetalii.SetError(sender as Control, "Va rugam sa completati campul");
                e.Cancel = true;
            }
        }
    }
}
