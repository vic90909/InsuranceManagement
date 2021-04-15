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
    public partial class EditareAsigurareForm : Form
    {
        Asigurari local;
        public EditareAsigurareForm(Asigurari a)
        {
            InitializeComponent();
            local = a;
        }

        private void btRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCurata_Click(object sender, EventArgs e)
        {
            this.tbDenumire.Clear();
            this.tbLocatie.Clear();
            this.tbNume.Clear();
            this.tbSuma.Clear();
            this.dtpInceput.ResetText();
            this.dtpSfarsit.ResetText();
        }

        private void EditareAsigurareForm_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = local.denumireBun;
            tbLocatie.Text = local.locatieBun;
            tbSuma.Text = local.sumaAsigurare.ToString();
            tbNume.Text = local.numeAsigurator;
            dtpInceput.Text = local.dataPolitaInceput;
            dtpSfarsit.Text = local.dataPolitaSfarsit;

        }

        private void btFinalizare_Click(object sender, EventArgs e)
        {
            local.denumireBun = tbDenumire.Text;
            local.locatieBun = tbLocatie.Text;
            local.numeAsigurator = tbNume.Text;
            local.dataPolitaSfarsit = dtpSfarsit.Text;
            local.dataPolitaInceput = dtpInceput.Text;
            float.TryParse(tbSuma.Text, out float suma);
            local.sumaAsigurare = suma;

            this.Close();
        }

       
        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            epDenumire.Clear();
        }

        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbDenumire.Text) || String.IsNullOrWhiteSpace(tbDenumire.Text))
            {
                epDenumire.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbNume.Text) || String.IsNullOrWhiteSpace(tbNume.Text))
            {
                epAsigurator.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            epAsigurator.Clear();
        }

        private void tbLocatie_Validated(object sender, EventArgs e)
        {
            epAsigurator.Clear();
        }

        private void tbLocatie_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbLocatie.Text) || String.IsNullOrWhiteSpace(tbLocatie.Text))
            {
                epLocatie.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void dtpSfarsit_Validated(object sender, EventArgs e)
        {
            epSfarsit.Clear();
        }

        private void dtpSfarsit_Validating(object sender, CancelEventArgs e)
        {
            DateTime first = dtpInceput.Value;
            DateTime sfarsit = dtpSfarsit.Value;

            if (DateTime.Compare(first, sfarsit) > 0)
            {
                epSfarsit.SetError(sender as Control, "Va rugam alegeti data de sfarsit dupa cea cea de inceput");
                e.Cancel = true;
            }
        }

        private void tbSuma_Validated(object sender, EventArgs e)
        {
            epSuma.Clear();
        }

        private void tbSuma_Validating(object sender, CancelEventArgs e)
        {
            float.TryParse(tbSuma.Text, out float suma);

            if (String.IsNullOrEmpty(tbSuma.Text) || String.IsNullOrWhiteSpace(tbSuma.Text) || suma <= 0)
            {
                epSuma.SetError(sender as Control, "Va rugam completati campul / Alegeti o suma pozitiva");
                e.Cancel = true;
            }
        }
    }
}
