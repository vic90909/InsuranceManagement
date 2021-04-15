using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Asigurari
{
    public partial class AsigurareForm : Form
    {
        Clienti local;
        public AsigurareForm(Clienti c)
        {
            InitializeComponent();
            local = c;
            populareListViewAsigurari();
            
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            String denumireBun = tbDenumire.Text;
            String locatie = tbLocatie.Text;
            String nume = tbNume.Text;
            float.TryParse(tbSuma.Text, out float suma);
            String dataI = dtpInceput.Text;
            String dataS = dtpSfarsit.Text;
            String tipAsigurare = cbTip.Text;
            if (tipAsigurare == "AlteBunuri")
            {
                AlteBunuri asigurare = new AlteBunuri(denumireBun, nume, locatie, suma, dataI, dataS, tipAsigurare);
                local.listaAsigurari.Add(asigurare);
            }
            else 
            if (tipAsigurare == "Viata")
            {
                Viata asigurare = new Viata(denumireBun, nume, locatie, suma, dataI, dataS, tipAsigurare);
                local.listaAsigurari.Add(asigurare);
            }
            else 
            if (tipAsigurare == "Locuinta")
            {
                Locuinta asigurare = new Locuinta(denumireBun, nume, locatie, suma, dataI, dataS, tipAsigurare);
                local.listaAsigurari.Add(asigurare);
            }
            else             
            {
                Automobil asigurare = new Automobil(denumireBun, nume, locatie, suma, dataI, dataS, tipAsigurare);
                local.listaAsigurari.Add(asigurare);
            }

                
                populareListViewAsigurari();
        }

        private void populareListViewAsigurari()
        {
            lvAsigurari.Items.Clear();

            foreach(Asigurari each in local.listaAsigurari)
            {
                ListViewItem item = new ListViewItem(new String[]
                {
                    each.denumireBun,
                    each.numeAsigurator,
                    each.locatieBun,
                    each.sumaAsigurare.ToString(),
                    each.dataPolitaInceput,
                    each.dataPolitaSfarsit,
                    each.tipAsigurare
                    
                });
                lvAsigurari.Items.Add(item);
            }
            this.toolStatusNrAs.Text= "Numar Asigurari ai clientului " + local.Nume + " " + local.Prenume + " : "+this.lvAsigurari.Items.Count;
            this.toolStatusSuma.Text = "Suma Totala a asigurarilor este de " + (float)local + " lei";
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

        private void btStergeMultiple_Click(object sender, EventArgs e)
        {
            if (lvAsigurari.CheckedItems.Count != 0)
            {
                for(int i = lvAsigurari.Items.Count-1; i >= 0; i--)
                {
                    if (lvAsigurari.Items[i].Checked)
                    {
                        local.listaAsigurari.RemoveAt(i);
                    }
                }
                populareListViewAsigurari();
            }
        }

        private void btEditare_Click(object sender, EventArgs e)
        {
            if (lvAsigurari.CheckedItems.Count != 1)
            {

            }
            else
            {
                Asigurari edit = local.listaAsigurari.ElementAt(lvAsigurari.CheckedIndices[0]);
                EditareAsigurareForm editare = new EditareAsigurareForm(edit);
                editare.ShowDialog();

                populareListViewAsigurari();
            }
        }

        private void btAdaugaDetalii_Click(object sender, EventArgs e)
        {
            if (lvAsigurari.CheckedItems.Count != 1)
            {


            }
            else
            {
                Console.Write(lvAsigurari.Items[lvAsigurari.CheckedIndices[0]].SubItems[6].Text);
                if (lvAsigurari.Items[lvAsigurari.CheckedIndices[0]].SubItems[6].Text == "Viata")
                {
                    Viata item = local.listaAsigurari.ElementAt(lvAsigurari.CheckedIndices[0]) as Viata;
                    AsigurareViataForm form = new AsigurareViataForm(item);
                    form.ShowDialog();
                    
                }
                else
                if (lvAsigurari.Items[lvAsigurari.CheckedIndices[0]].SubItems[6].Text == "AlteBunuri")
                {


                    AlteBunuri item = local.listaAsigurari.ElementAt(lvAsigurari.CheckedIndices[0]) as AlteBunuri;                                   
                    AsigurareAlteBunuriForm form = new AsigurareAlteBunuriForm(item);
                    form.ShowDialog();
                               
                }
                else 
                if (lvAsigurari.Items[lvAsigurari.CheckedIndices[0]].SubItems[6].Text == "Locuinta")
                {
                   Locuinta item = local.listaAsigurari.ElementAt(lvAsigurari.CheckedIndices[0]) as Locuinta;
                    AsigurariLocuintaForm form = new AsigurariLocuintaForm(item);
                    form.ShowDialog();


                }
                else 
                if (lvAsigurari.Items[lvAsigurari.CheckedIndices[0]].SubItems[6].Text == "Automobil")
                {
                    Automobil item = local.listaAsigurari.ElementAt(lvAsigurari.CheckedIndices[0]) as Automobil;
                    AsigurareAutomobilForm form = new AsigurareAutomobilForm(item);
                    form.ShowDialog();



                }
            }
        }

        private void AsigurareForm_Load(object sender, EventArgs e)
        {
            this.toolStatusNrAs.Text = "Numar Asigurari ai clientului " + local.Nume + " " + local.Prenume + " : " + this.lvAsigurari.Items.Count;
            this.toolStatusSuma.Text = "Suma Totala a asigurarilor este de " + (float)local + " lei";
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

        private void cbTip_Validated(object sender, EventArgs e)
        {
            epTip.Clear();
        }

        private void cbTip_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbTip.Text) || String.IsNullOrWhiteSpace(cbTip.Text))
            {
                epTip.SetError(sender as Control, "Va rugam alegeti un tip");
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
