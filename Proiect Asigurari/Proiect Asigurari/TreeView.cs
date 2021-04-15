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
    public partial class TreeView : Form
    {
        List<Clienti> localList;
        public TreeView(List<Clienti> lista)
        {
            InitializeComponent();
            /* foreach(Clienti each in lista)
             {
                 localList.Add(each.Clone()as Clienti);
             }*/
            localList = lista;
        }
        private void populareTV()
        {
            treeViewClienti.Nodes.Clear();
            int nr = 0;
            TreeNode Radacina = new TreeNode("Clienti");
            treeViewClienti.Nodes.Add(Radacina);
            foreach (Clienti each in localList)
            {
                nr++;
                TreeNode root = new TreeNode(nr + " @ " + each.Nume + " @ " + each.Prenume);
                Radacina.Nodes.Add(root);

                TreeNode telefon = new TreeNode(each.Telefon);
                root.Nodes.Add(telefon);
                TreeNode adresa = new TreeNode(each.Adresa);
                root.Nodes.Add(adresa);
                TreeNode serie = new TreeNode(each.SerieBuletin);
                root.Nodes.Add(serie);
                TreeNode CNP = new TreeNode(each.CNP.ToString());
                root.Nodes.Add(CNP);
                TreeNode data = new TreeNode(each.DataNasterii);
                root.Nodes.Add(data);

            }
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            populareTV();
        }

        private void treeViewClienti_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //String Nodutul=treeViewClienti.Nodes[0]..Text.ToString();
            // Console.WriteLine(Nodutul);
            if (e.Node.Text != "Clienti" && e.Node.Nodes.Count!=0)
            {
                String Nodutul = e.Node.Text;
                
                String[] linie = Nodutul.Split(new String[] { " @ "},StringSplitOptions.None);
                String nr = linie[0];
                tbNrNod.Text = nr;
                String nume = linie[1];
                String prenume = linie[2];
                tbNume.Text = nume;
                tbPrenume.Text = prenume;

                String adresa = e.Node.Nodes[1].Text;
                String telefon = e.Node.Nodes[0].Text;
                String serie = e.Node.Nodes[2].Text;
                String cnp = e.Node.Nodes[3].Text;
                int.TryParse(cnp,out int CNP);
                String dataNas = e.Node.Nodes[4].Text;

                tbAdresa.Text = adresa;
                tbTelefon.Text = telefon;
                dtpNastere.Text = dataNas;
                tbCNP.Text = cnp;
                tbSerieBuletin.Text = serie;
            }
            
        }

        private void btSalveaza_Click(object sender, EventArgs e)
        {
            int.TryParse(tbNrNod.Text, out int loc);
            Clienti local = localList.ElementAt(loc-1);
            local.Adresa = tbAdresa.Text;
            local.Nume = tbNume.Text;
            local.Prenume = tbPrenume.Text;
            local.SerieBuletin = tbSerieBuletin.Text;
            local.Telefon = tbTelefon.Text;
            long.TryParse(tbCNP.Text, out long CNP);
            local.CNP = CNP;
            
            populareTV();
            
        }

        private void btRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
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
