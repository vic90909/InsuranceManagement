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
    public partial class AsigurareAutomobilForm : Form
    {
        Automobil local;
        public AsigurareAutomobilForm(Asigurari a)
        {
            InitializeComponent();
            local = a as Automobil;
        }

        private void btRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCurata_Click(object sender, EventArgs e)
        {
            this.tbMarca.Clear();
            this.tbModel.Clear();
            this.tbNrInmatriculare.Clear();
            this.tbSerieSasiu.Clear();
            this.tbNumarLocuri.Clear();
            this.tbCapacitateCilindrica.Clear();
            this.tbMasaMaxima.Clear();

        }

        private void btFinalizare_Click(object sender, EventArgs e)
        {
            local.marca = tbMarca.Text;
            local.model = tbModel.Text;
            local.serieSasiu = tbSerieSasiu.Text;
            local.numarImatriculare = tbNrInmatriculare.Text;
            int.TryParse(tbMasaMaxima.Text, out int masa);
            int.TryParse(tbCapacitateCilindrica.Text, out int cc);
            int.TryParse(tbNumarLocuri.Text, out int nrL);
            local.masaMaximaAdmisa = masa;
            local.capacitateCilindrica = cc;
            local.numarLocuri = nrL;
            this.Close();

        }

        private void AsigurareAutomobilForm_Load(object sender, EventArgs e)
        {
            tbMarca.Text = local.marca;
            tbModel.Text = local.model;
            tbNrInmatriculare.Text = local.numarImatriculare;
            tbSerieSasiu.Text = local.serieSasiu;
            tbMasaMaxima.Text = local.masaMaximaAdmisa.ToString();
            tbNumarLocuri.Text = local.numarLocuri.ToString();
            tbCapacitateCilindrica.Text = local.capacitateCilindrica.ToString();
        }

        private void tbMarca_Validated(object sender, EventArgs e)
        {
            epMarca.Clear();
        }

        private void tbModel_Validated(object sender, EventArgs e)
        {
            epModel.Clear();
        }

        private void tbNrInmatriculare_Validated(object sender, EventArgs e)
        {
            epNumar.Clear();
        }

        private void tbSerieSasiu_Validated(object sender, EventArgs e)
        {
            epSerie.Clear();
        }

        private void tbCapacitateCilindrica_Validated(object sender, EventArgs e)
        {
            epCC.Clear();
        }

        private void tbNumarLocuri_Validated(object sender, EventArgs e)
        {
            epLocuri.Clear();
        }

        private void tbMasaMaxima_Validated(object sender, EventArgs e)
        {
            epMasa.Clear();
        }

        private void tbMarca_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbMarca.Text) || String.IsNullOrWhiteSpace(tbMarca.Text))
            {
                epMarca.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbModel.Text) || String.IsNullOrWhiteSpace(tbModel.Text))
            {
                epModel.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbNrInmatriculare_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbNrInmatriculare.Text) || String.IsNullOrWhiteSpace(tbNrInmatriculare.Text))
            {
                epNumar.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbSerieSasiu_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbSerieSasiu.Text) || String.IsNullOrWhiteSpace(tbSerieSasiu.Text))
            {
                epSerie.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbCapacitateCilindrica_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbCapacitateCilindrica.Text, out int cc);

            if (String.IsNullOrEmpty(tbCapacitateCilindrica.Text) || String.IsNullOrWhiteSpace(tbCapacitateCilindrica.Text)||cc<=0)
            {
                epCC.SetError(sender as Control, "Va rugam completati campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }

        }

        private void tbNumarLocuri_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbNumarLocuri.Text, out int numar);

            if (String.IsNullOrEmpty(tbNumarLocuri.Text) || String.IsNullOrWhiteSpace(tbNumarLocuri.Text) || numar <= 0)
            {
                epLocuri.SetError(sender as Control, "Va rugam completati campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }

        private void tbMasaMaxima_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbMasaMaxima.Text, out int masa);

            if (String.IsNullOrEmpty(tbMasaMaxima.Text) || String.IsNullOrWhiteSpace(tbMasaMaxima.Text) || masa <= 0)
            {
                epMasa.SetError(sender as Control, "Va rugam completati campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }
    }
}
