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
    public partial class AsigurariLocuintaForm : Form
    {
        Locuinta local;
        public AsigurariLocuintaForm(Asigurari a)
        {
            InitializeComponent();
            local = a as Locuinta;
        }

        private void btRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCurata_Click(object sender, EventArgs e)
        {
            this.tbAdresa.Clear();
            this.tbNrNiveluri.Clear();
            this.tbNumarCamere.Clear();
            this.tbSTotal.Clear();
            this.tbSUtil.Clear();
            this.cbTipLocuinta.ResetText();
        }

        private void btFinalizare_Click(object sender, EventArgs e)
        {
            local.Adresa = tbAdresa.Text;

            int.TryParse(tbNrNiveluri.Text, out int nr);
            local.numarNiveluri = nr;

            int.TryParse(tbNumarCamere.Text, out int nrc);
            local.numarCamere = nrc;

            float.TryParse(tbSUtil.Text, out float sU);
            local.suprafataUtilizabila = sU;

            float.TryParse(tbSTotal.Text, out float sT);
            local.suprafataTotala = sT;

            Enum.TryParse(cbTipLocuinta.Text, out tipLocuinta tip);
            local.tip = tip;

            this.Close();
        }

        private void AsigurareLocuintaForm_Load(object sender, EventArgs e)
        {
            tbAdresa.Text = local.Adresa;
            tbNumarCamere.Text = local.numarCamere.ToString();
            tbNrNiveluri.Text = local.numarNiveluri.ToString();
            tbSUtil.Text = local.suprafataUtilizabila.ToString();
            tbSTotal.Text = local.suprafataTotala.ToString();
            cbTipLocuinta.Text = local.tip.ToString();
        }

        private void tbAdresa_Validated(object sender, EventArgs e)
        {
            epAdresa.Clear();
        }

        private void tbNrNiveluri_Validated(object sender, EventArgs e)
        {
            epNiveluri.Clear();
        }

        private void tbSTotal_Validated(object sender, EventArgs e)
        {
            epTotal.Clear();
        }

        private void tbSUtil_Validated(object sender, EventArgs e)
        {
            epUtil.Clear();
        }

        private void tbNumarCamere_Validated(object sender, EventArgs e)
        {
            epCamere.Clear();
        }

        private void cbTipLocuinta_Validated(object sender, EventArgs e)
        {
            epTip.Clear();
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbAdresa.Text) || String.IsNullOrWhiteSpace(tbAdresa.Text))
            {
                epAdresa.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbNrNiveluri_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbNrNiveluri.Text,out int niveluri);
            if (String.IsNullOrEmpty(tbNrNiveluri.Text) || String.IsNullOrWhiteSpace(tbNrNiveluri.Text)||niveluri<=0)
            {
                epNiveluri.SetError(sender as Control, "Va rugam completati campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }

        private void tbSTotal_Validating(object sender, CancelEventArgs e)
        {
            float.TryParse(tbSTotal.Text, out float ST);
            if (String.IsNullOrEmpty(tbSTotal.Text) || String.IsNullOrWhiteSpace(tbSTotal.Text) || ST <= 0)
            {
                epTotal.SetError(sender as Control, "Va rugam completati campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }

        private void tbSUtil_Validating(object sender, CancelEventArgs e)
        {
            float.TryParse(tbSUtil.Text, out float ST);
            if (String.IsNullOrEmpty(tbSUtil.Text) || String.IsNullOrWhiteSpace(tbSUtil.Text) || ST <= 0)
            {
                epUtil.SetError(sender as Control, "Va rugam completati campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }

        private void tbNumarCamere_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbNumarCamere.Text, out int niveluri);
            if (String.IsNullOrEmpty(tbNumarCamere.Text) || String.IsNullOrWhiteSpace(tbNumarCamere.Text) || niveluri <= 0)
            {
                epCamere.SetError(sender as Control, "Va rugam completati campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }

        private void cbTipLocuinta_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbTipLocuinta.Text) || String.IsNullOrWhiteSpace(cbTipLocuinta.Text))
            {
                epTip.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }
    }
}
