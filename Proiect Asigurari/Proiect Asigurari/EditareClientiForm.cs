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
    public partial class EditareClientiForm : Form
    {
        Clienti local;
        public EditareClientiForm(Clienti c)
        {
            InitializeComponent();
            local = c;

        }

        private void EditareClientiForm_Load(object sender, EventArgs e)
        {
            uc1.tbNume.Text = local.Nume;
            tbPrenume.Text = local.Prenume;
            tbAdresa.Text = local.Adresa;
            tbSerieBuletin.Text = local.SerieBuletin;
            tbTelefon.Text = local.Telefon;
            tbCNP.Text = local.CNP.ToString();
            dtpNastere.Text = local.DataNasterii;
        }

        private void btRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCurata_Click(object sender, EventArgs e)
        {
            uc1.tbNume.Clear();
            this.tbPrenume.Clear();
            this.tbAdresa.Clear();
            this.tbCNP.Clear();
            this.tbTelefon.Clear();
            this.tbSerieBuletin.Clear();
            dtpNastere.ResetText();
        }

        private void btFinalizare_Click(object sender, EventArgs e)
        {
            local.Nume = uc1.tbNume.Text;
            local.Prenume = tbPrenume.Text;
            local.Adresa = tbAdresa.Text;
            local.Telefon = tbTelefon.Text;
            local.DataNasterii = dtpNastere.Text;
            local.SerieBuletin = tbSerieBuletin.Text;
            long.TryParse(tbCNP.Text, out long cnp);
            local.CNP = cnp;
            this.Close();
        }
        

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            epPrenume.Clear();
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPrenume.Text) || String.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                epPrenume.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbAdresa_Validated(object sender, EventArgs e)
        {
            epAdresa.Clear();
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbAdresa.Text) || String.IsNullOrWhiteSpace(tbAdresa.Text))
            {
                epAdresa.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbSerieBuletin_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbSerieBuletin.Text) || String.IsNullOrWhiteSpace(tbSerieBuletin.Text))
            {
                epSerieB.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }
        private void tbSerieBuletin_Validated(object sender, EventArgs e)
        {
            epSerieB.Clear();
        }
        private void tbCNP_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbCNP.Text) || String.IsNullOrWhiteSpace(tbCNP.Text) || tbCNP.Text.Length != 13)
            {
                epCNP.SetError(sender as Control, "Va rugam completati campul/CNP-ul trebuie sa aiba 13 caractere");
                e.Cancel = true;
            }
        }

        private void tbCNP_Validated(object sender, EventArgs e)
        {
            epCNP.Clear();
        }

        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            epTelefon.Clear();
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbTelefon.Text) || String.IsNullOrWhiteSpace(tbTelefon.Text) || tbTelefon.Text.Length != 10)
            {
                epTelefon.SetError(sender as Control, "Va rugam completati campul/Telefonul trebuie sa aiba 10 caractere");
                e.Cancel = true;
            }
        }

        private void dtpNastere_Validated(object sender, EventArgs e)
        {
            epData.Clear();
        }

        private void dtpNastere_Validating(object sender, CancelEventArgs e)
        {
            int an = dtpNastere.Value.Year;
            if (DateTime.Now.Year - an < 12)
            {
                epData.SetError(sender as Control, "Asiguratul trebuie sa aiba minim 12 ani");
                e.Cancel = true;
            }
        }

        
    }
}
