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
    public partial class AsigurareViataForm : Form
    {
        Viata local;
        public AsigurareViataForm(Asigurari a)
        {
            InitializeComponent();
            local = a as Viata;
        }

        private void AsigurareViataForm_Load(object sender, EventArgs e)
        {
            tbGreutate.Text = local.greutate.ToString();
            tbInaltime.Text = local.inaltime.ToString();
            tbVarsta.Text = local.varsta.ToString();
            tbGrupa.Text = local.grupaSangvina;
            cbGen.Text = local.gen.ToString();
            cbStareCivila.Text = local.stareCivila.ToString();
        }

        private void btRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCurata_Click(object sender, EventArgs e)
        {
            this.tbVarsta.Clear();
            this.tbGreutate.Clear();
            this.tbGrupa.Clear();
            this.tbInaltime.Clear();
            this.cbGen.ResetText();
            this.cbStareCivila.ResetText();
        }

        private void btFinalizare_Click(object sender, EventArgs e)
        {
            float.TryParse(tbGreutate.Text, out float greutate);
            local.greutate = greutate;
            float.TryParse(tbInaltime.Text, out float inaltime);
            local.inaltime = inaltime;
            int.TryParse(tbVarsta.Text, out int varsta);
            local.varsta = varsta;
            local.grupaSangvina = tbGrupa.Text;
            Enum.TryParse(cbGen.Text, out Gen gen);
            local.gen = gen;
            Enum.TryParse(cbStareCivila.Text, out StareCivila stare);
            local.stareCivila = stare;

            this.Close();
        }

        private void tbVarsta_Validated(object sender, EventArgs e)
        {
            epvarsta.Clear();
        }

        private void tbGrupa_Validated(object sender, EventArgs e)
        {
            epGrupa.Clear();
        }

        private void tbInaltime_Validated(object sender, EventArgs e)
        {
            epInaltime.Clear();
        }

        private void tbGreutate_Validated(object sender, EventArgs e)
        {
            epGreutate.Clear();
        }

        private void cbGen_Validated(object sender, EventArgs e)
        {
            epGen.Clear();
        }

        private void cbStareCivila_Validated(object sender, EventArgs e)
        {
            epStare.Clear();
        }

        private void tbVarsta_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbVarsta.Text, out int x);

            if (String.IsNullOrEmpty(tbVarsta.Text) || String.IsNullOrWhiteSpace(tbVarsta.Text) || x <= 0)
            {
                epvarsta.SetError(sender as Control,"Va rugam campul / Introduceti o valoare pozitiva" );
                e.Cancel = true;
            }
        }

        private void tbGrupa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbGrupa.Text) || String.IsNullOrWhiteSpace(tbGrupa.Text))
            {
                epGrupa.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void tbInaltime_Validating(object sender, CancelEventArgs e)
        {
            float.TryParse(tbInaltime.Text, out float x);

            if (String.IsNullOrEmpty(tbInaltime.Text) || String.IsNullOrWhiteSpace(tbInaltime.Text) || x <= 0)
            {
                epvarsta.SetError(sender as Control, "Va rugam campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }

        private void tbGreutate_Validating(object sender, CancelEventArgs e)
        {
            float.TryParse(tbGreutate.Text, out float x);

            if (String.IsNullOrEmpty(tbGreutate.Text) || String.IsNullOrWhiteSpace(tbGreutate.Text) || x <= 0)
            {
                epvarsta.SetError(sender as Control, "Va rugam campul / Introduceti o valoare pozitiva");
                e.Cancel = true;
            }
        }

        private void cbGen_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbGen.Text) || String.IsNullOrWhiteSpace(cbGen.Text))
            {
                epGen.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }

        private void cbStareCivila_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbStareCivila.Text) || String.IsNullOrWhiteSpace(cbStareCivila.Text))
            {
                epStare.SetError(sender as Control, "Va rugam completati campul");
                e.Cancel = true;
            }
        }
    }
}
