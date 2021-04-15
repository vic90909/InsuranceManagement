using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Proiect_Asigurari
{
    public partial class ClientiForm : Form
    {
        Clienti local;
        List<Clienti> listaClienti = new List<Clienti>();
        private string connectionString = "Data Source=database.db";
        public ClientiForm()
        {
            InitializeComponent();
            
        }
        private void populareLV()
        {
            lvClienti.Items.Clear();

            foreach(Clienti each in listaClienti)
            {
                ListViewItem item =
                    new ListViewItem(new String[] {
                    each.Nume,
                    each.Prenume,
                    each.Adresa,
                    each.SerieBuletin,
                    each.CNP.ToString(),
                    each.Telefon,
                    each.DataNasterii});


                lvClienti.Items.Add(item);    
            }
            this.toolStatusNr.Text = "Numar Clienti: " + lvClienti.Items.Count.ToString();
        }
        private void btCurata_Click(object sender, EventArgs e)
        {
            this.uc1.tbNume.Clear();
            this.tbPrenume.Clear();
            this.tbAdresa.Clear();
            this.tbCNP.Clear();
            this.tbTelefon.Clear();
            this.tbSerieBuletin.Clear();
            dtpNastere.ResetText();

        }
        private void btAdauga_Click(object sender, EventArgs e)
        {
            bool OK = true;
            foreach(Clienti each in listaClienti)
            {
                if (each.CNP.ToString() == tbCNP.Text)
                    OK = false;
            }
            if (OK == true)
            {

                String nume = uc1.tbNume.Text;
                String prenume = tbPrenume.Text;
                String adresa = tbAdresa.Text;
                String serieBuletn = tbSerieBuletin.Text;
                long.TryParse(tbCNP.Text, out long CNP);
                String telefon = tbTelefon.Text;
                String dataNasterii = dtpNastere.Text;

                Clienti local = new Clienti(nume, prenume, adresa, CNP, serieBuletn, dataNasterii, telefon);
                var op = new Operation();
                var dition = new Addition();

                local.add += op.OnOperation;
                local.add += dition.OnOperation;

                local.OnOperation();

                //listaClienti.Add(local);
                AddClient(local);
                populareLV();
            }
            else
                MessageBox.Show("Clientul exista deja in lista", "Avertisment");

            
            
        }
        private void btStergeMultiple_Click(object sender, EventArgs e)
        {
            if (lvClienti.CheckedItems.Count != 0)
            {
                Console.Write(lvClienti.CheckedItems.Count);
                for (int i = lvClienti.Items.Count-1; i >=0;i--)
                {
                    if (lvClienti.Items[i].Checked)
                    {
                        listaClienti.RemoveAt(i);
                    }
                }

                populareLV();
            }
        }

        private void btEditare_Click(object sender, EventArgs e)
        {
            if (lvClienti.CheckedItems.Count != 1)
            {
                MessageBox.Show("Va rugam sa bifati doar o inregistrare", "Avertisment");

            }
            else
            {
                bool OK = false;
                while (OK == false)
                {
                    
                    Clienti client = listaClienti.ElementAt(lvClienti.CheckedIndices[0]);
                    EditareClientiForm editare = new EditareClientiForm(client);
                    editare.ShowDialog();
                    OK = true;
                    foreach (Clienti each in listaClienti)
                    {
                        if(each!=client)
                            if (each.CNP == client.CNP)
                                OK = false;
                    }

                    if (OK == true)
                    {
                        populareLV();
                    }
                    else
                    {
                        MessageBox.Show("CNP identic cu al altui client, va rugam modificati", "Avertisment");
                    }
                }
                
            }


        }

        private void btAsigurare_Click(object sender, EventArgs e)
        {
            

            if (lvClienti.CheckedItems.Count != 1)
            {
                MessageBox.Show("Va rugam sa bifati doar o inregistrare", "Avertisment");
            }
            else
            {
                Clienti client = listaClienti.ElementAt(lvClienti.CheckedIndices[0]);
                AsigurareForm asigurare = new AsigurareForm(client);
                asigurare.ShowDialog();

            }
        }
        
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Clienti>),new Type[] { typeof(Asigurari)});
                        
            System.IO.FileStream fs = File.Create("lista.xml");
            xmlSerializer.Serialize(fs, listaClienti);

            fs.Close();

            MessageBox.Show("Serializare cu succes in lista.xml");

            
            
            

        }

        private void coleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Clienti>));

            try
            {
                FileStream fs = File.OpenRead("lista.xml");
                listaClienti = xml.Deserialize(fs) as List<Clienti>;

                fs.Close();
                populareLV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            populareDB();
        }

        private void serializareJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();

            FileStream fs = File.Create("lista.json");
            TextWriter tw = new StreamWriter(fs);

            jsonSerializer.Serialize(tw, listaClienti);

            tw.Close();
            fs.Close();

            MessageBox.Show("Serializare cu succes in JSON", "Felicitari");
        }

        private void deserializareJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();

            FileStream fs = File.OpenRead("lista.json");
            TextReader tr = new StreamReader(fs);

            listaClienti = (List<Clienti>)jsonSerializer.Deserialize(tr, typeof(List<Clienti>));
            populareLV();

            tr.Close();
            fs.Close();
        }

        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fs = new FileStream("binary.dat", FileMode.Create);
            formatter.Serialize(fs, listaClienti);

            fs.Close();
        }

        private void binarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisier binar";
            ofd.Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                listaClienti = formatter.Deserialize(fs) as List<Clienti>;
                fs.Close();

                populareLV();
            }
        }

        private void toolStripBtExportTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza fisier TXT";
            sfd.Filter = "Fisiere txt (*.txt)|*.txt|Toate fisierele (*.*)|*.*";
            sfd.FilterIndex = 1;
            if (DialogResult.Cancel != sfd.ShowDialog())
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach(Clienti each in listaClienti)
                {
                    sw.Write(each.Nume + "  |  " + each.Prenume + "  |  " + each.SerieBuletin + "  |  " + each.Telefon + "  |  " +
                       each.Adresa + "  |  " + each.CNP.ToString() + "  |  " + each.DataNasterii);
                    sw.Write("\n{\n");
                    foreach(Asigurari each2 in each.listaAsigurari)
                    {
                        if(each2.tipAsigurare.ToString()=="Locuinta")
                        {
                            Locuinta local=each2 as Locuinta;
                            sw.Write(local.tipAsigurare.ToString() + "  |  " + local.denumireBun + "  |  " + local.numeAsigurator + "  |  " + local.sumaAsigurare.ToString() + "  |  " + local.locatieBun + "  |  " + local.dataPolitaInceput + "  |  " + local.dataPolitaSfarsit
                                + "  |  " + local.Adresa + "  |  " +local.tip.ToString() + "  |  " +local.numarNiveluri.ToString() + "  |  " +local.suprafataTotala.ToString() + "  |  " +local.suprafataUtilizabila.ToString() + "  |  " +local.numarCamere.ToString());
                            sw.Write("\n");
                        } else if(each2.tipAsigurare.ToString() == "Automobil")
                        {
                            Automobil local = each2 as Automobil;
                            sw.Write(local.tipAsigurare.ToString() + "  |  " + local.denumireBun + "  |  " + local.numeAsigurator + "  |  " + local.sumaAsigurare.ToString() + "  |  " + local.locatieBun + "  |  " + local.dataPolitaInceput + "  |  " + local.dataPolitaSfarsit
                                + "  |  " +local.marca + "  |  " + local.model + "  |  " + local.numarImatriculare + "  |  " + local.serieSasiu + "  |  " + local.capacitateCilindrica.ToString() + "  |  " + local.numarLocuri.ToString() + "  |  " + local.masaMaximaAdmisa.ToString());
                            sw.Write("\n");
                        }
                        else if(each2.tipAsigurare.ToString() == "Viata")
                        {
                            Viata local = each2 as Viata;
                            sw.Write(local.tipAsigurare.ToString() + "  |  " + local.denumireBun + "  |  " + local.numeAsigurator + "  |  " + local.sumaAsigurare.ToString() + "  |  " + local.locatieBun + "  |  " + local.dataPolitaInceput + "  |  " + local.dataPolitaSfarsit
                                + "  |  " + local.varsta + "  |  " + local.grupaSangvina + "  |  " + local.inaltime.ToString() + "  |  " + local.greutate.ToString() + "  |  " + local.gen.ToString() + "  |  " + local.stareCivila.ToString());
                            sw.Write("\n");
                        }
                        else
                        {
                            AlteBunuri local = each2 as AlteBunuri;
                            sw.Write(local.tipAsigurare.ToString() + "  |  " + local.denumireBun + "  |  " + local.numeAsigurator + "  |  " + local.sumaAsigurare.ToString() + "  |  " + local.locatieBun + "  |  " + local.dataPolitaInceput + "  |  " + local.dataPolitaSfarsit
                            + "  |  " + local.detaliiBun);
                            sw.Write("\n");
                        }
                    }
                    sw.Write("}\n");

                }
                sw.Close();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //alegere pensula
            Brush brush = Brushes.DarkBlue;
            Brush brushText = Brushes.Black;
            Brush brushTitlu = Brushes.DarkViolet;
            //alegere font
            Font font = new Font("Chaucer", 14);
            Font fontText = new Font("Ariel", 11);
            //alege pen
            Pen pen = new Pen(brush);

            //setare setari default
            PageSettings settings = printDocument.DefaultPageSettings;

            //calculare marime de desenare/scriere
            float latimeTotala = settings.PaperSize.Width-settings.Margins.Left - settings.Margins.Right;
            float inaltimeTotala = settings.PaperSize.Height - settings.Margins.Bottom - settings.Margins.Top;

            //setare marime celule
            float latimeCelula = latimeTotala / 4;
            float inaltimeCelula = 20;

            int x = settings.Margins.Left;
            int y = 100;

            //scriere titlu
            graphics.DrawString("Lista Clienti asigurati", font, brushText, inaltimeTotala / 3+20, y);

            y += 100;
            //desenare coloane;
            graphics.DrawRectangle(pen, x, y, latimeCelula, inaltimeCelula);
            graphics.DrawRectangle(pen, x+latimeCelula, y, latimeCelula, inaltimeCelula);
            graphics.DrawRectangle(pen, x+2*latimeCelula, y, latimeCelula, inaltimeCelula);
            graphics.DrawRectangle(pen, x+3*latimeCelula, y, latimeCelula, inaltimeCelula);

            //desenare titlu coloane
            graphics.DrawString("Nume", font, brushTitlu, x, y);
            graphics.DrawString("Prenume", font, brushTitlu, x+latimeCelula, y);
            graphics.DrawString("Suma de plata", font, brushTitlu, x+2*latimeCelula, y);
            graphics.DrawString("CNP", font, brushTitlu, x+3*latimeCelula, y);

            foreach(Clienti each in listaClienti)
            {
                y += 20;
                graphics.DrawRectangle(pen, x, y, latimeCelula, inaltimeCelula);
                graphics.DrawRectangle(pen, x + latimeCelula, y, latimeCelula, inaltimeCelula);
                graphics.DrawRectangle(pen, x + 2 * latimeCelula, y, latimeCelula, inaltimeCelula);
                graphics.DrawRectangle(pen, x + 3 * latimeCelula, y, latimeCelula, inaltimeCelula);

                //desenare titlu coloane
                graphics.DrawString(each.Nume, fontText, brushText, x, y);
                graphics.DrawString(each.Prenume, fontText, brushText, x + latimeCelula, y);
                graphics.DrawString(((float)each).ToString(), fontText, brushText, x + 2 * latimeCelula, y);
                graphics.DrawString(each.CNP.ToString(), fontText, brushText, x + 3 * latimeCelula, y);
            }
        }

        private void menuPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (DialogResult.OK == pageSetupDialog.ShowDialog())
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }

        }

        private void ClientiForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                toolStripBtExportTXT_Click(sender, e);
            }
        }

        private void lvClienti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                toolStripBtExportTXT_Click(sender, e);
            }
        }

        private void btTree_Click(object sender, EventArgs e)
        {
            TreeView form = new TreeView(listaClienti);
            form.ShowDialog();
            populareLV();
        }

        private void btPie_Click(object sender, EventArgs e)
        {
            Pie form = new Pie(listaClienti);
            form.ShowDialog();
        }

        private void menuExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza fisier CSV";
            sfd.Filter = "Fisier CSV(*.csv)|*.csv|All files(*.*)|*.*";
            sfd.FilterIndex = 1;
            if (DialogResult.OK == sfd.ShowDialog())
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);

                sw.Write("Nume/Tip Asigurare,Prenume/Denumire Bun," +
                    "Serie Buletin/Nume Asigurator," +
                    "Telefon/Suma Asigurare," +
                    "Adresa/Locatie Bun," +
                    "CNP/Data inceput," +
                    "Data Nasterii/Data Sfarsit," +
                    "Adresa/Marca/Varsta/Alte Detalii," +
                    "Tip Casa/Model/Grupa Sanguina," +
                    "Numar niveluri/Numar Inmatriculare/Inaltime," +
                    "Suprafata Totala/Serie Inmatriculare/Greutate," +
                    "Suprafata Utila/CC/Sex," +
                    "Numar Camere/Numar Locuri/Stare Civila," +
                    "Masa Maxima\n");
                foreach (Clienti each in listaClienti)
                {
                    sw.Write(each.Nume + "," + each.Prenume + "," + each.SerieBuletin + "," + each.Telefon + "," +
                       each.Adresa + "," + each.CNP.ToString() + "," + each.DataNasterii);
                    sw.Write("\n\n");
                    foreach (Asigurari each2 in each.listaAsigurari)
                    {
                        if (each2.tipAsigurare.ToString() == "Locuinta")
                        {
                            Locuinta local = each2 as Locuinta;
                            sw.Write(local.tipAsigurare.ToString() + "," + local.denumireBun + "," + local.numeAsigurator + "," + local.sumaAsigurare.ToString() + "," + local.locatieBun + "," + local.dataPolitaInceput + "," + local.dataPolitaSfarsit
                                + "," + local.Adresa + "," + local.tip.ToString() + "," + local.numarNiveluri.ToString() + "," + local.suprafataTotala.ToString() + "," + local.suprafataUtilizabila.ToString() + "," + local.numarCamere.ToString());
                           sw.Write("\n");
                        }
                        else if (each2.tipAsigurare.ToString() == "Automobil")
                        {
                            Automobil local = each2 as Automobil;
                            sw.Write(local.tipAsigurare.ToString() + "," + local.denumireBun + "," + local.numeAsigurator + "," + local.sumaAsigurare.ToString() + "," + local.locatieBun + "," + local.dataPolitaInceput + "," + local.dataPolitaSfarsit
                                + "," + local.marca + "," + local.model + "," + local.numarImatriculare + "," + local.serieSasiu + "," + local.capacitateCilindrica.ToString() + "," + local.numarLocuri.ToString() + "," + local.masaMaximaAdmisa.ToString());
                            sw.Write("\n");
                        }
                        else if (each2.tipAsigurare.ToString() == "Viata")
                        {
                            Viata local = each2 as Viata;
                            sw.Write(local.tipAsigurare.ToString() + "," + local.denumireBun + "," + local.numeAsigurator + "," + local.sumaAsigurare.ToString() + "," + local.locatieBun + "," + local.dataPolitaInceput + "," + local.dataPolitaSfarsit
                                + "," + local.varsta + "," + local.grupaSangvina + "," + local.inaltime.ToString() + "," + local.greutate.ToString() + "," + local.gen.ToString() + "," + local.stareCivila.ToString());
                           sw.Write("\n");
                        }
                        else if(each2.tipAsigurare.ToString()=="AlteBunuri")
                        {
                            AlteBunuri local = each2 as AlteBunuri;
                            sw.Write(local.tipAsigurare.ToString() + "," + local.denumireBun + "," + local.numeAsigurator + "," + local.sumaAsigurare.ToString() + "," + local.locatieBun + "," + local.dataPolitaInceput + "," + local.dataPolitaSfarsit
                            + "," + local.detaliiBun);
                            sw.Write("\n");
                        }
                        else
                        {
                            
                            sw.Write(each2.tipAsigurare.ToString() + "," + each2.denumireBun + "," + each2.numeAsigurator + "," + each2.sumaAsigurare.ToString() + "," + each2.locatieBun + "," + each2.dataPolitaInceput + "," + each2.dataPolitaSfarsit);
                        }
                    }
                   sw.Write("\n\n\n");

                }
                sw.Close();
            }
        }

        private void btLBPop_Click(object sender, EventArgs e)
        {
            foreach(Clienti each in listaClienti)
            {
                listBox.Items.Add(each.Nume + " " + each.Prenume + " " + each.Adresa + " " + each.CNP.ToString() + " " + each.Telefon + " " + each.DataNasterii);
            }
        }

        private void btLBSterge_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count != 0)
            {
                listaClienti.RemoveAt(listBox.SelectedIndices[0]);
                listBox.Items.Clear();
                foreach (Clienti each in listaClienti)
                {
                    listBox.Items.Add(each.Nume + " " + each.Prenume + " " + each.Adresa + " " + each.CNP.ToString() + " " + each.Telefon + " " + each.DataNasterii);
                }
            }
        }

        private void btLBsalveaza_Click(object sender, EventArgs e)
        {
            local.Nume = uc1.tbNume.Text;
            local.Prenume = tbPrenume.Text;
            local.Adresa = tbAdresa.Text;
            local.Telefon = tbTelefon.Text;
            local.DataNasterii = dtpNastere.Text;
            local.SerieBuletin = tbSerieBuletin.Text;
            long.TryParse(tbCNP.Text, out long cnp);
            local.CNP = cnp;
            listBox.Items.Clear();
            foreach (Clienti each in listaClienti)
            {
                listBox.Items.Add(each.Nume + " " + each.Prenume + " " + each.Adresa + " " + each.CNP.ToString() + " " + each.Telefon + " " + each.DataNasterii);
            }
            populareLV();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewClienti form = new DataGridViewClienti(listaClienti);
            if (form.ShowDialog() == DialogResult.OK)
            {
                populareLV();
            }
        }

        private void btLBEdit_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count != 0)
            {
                local = listaClienti.ElementAt(listBox.SelectedIndices[0]);
                uc1.tbNume.Text = local.Nume;
                tbPrenume.Text = local.Prenume;
                tbAdresa.Text = local.Adresa;
                tbTelefon.Text = local.Telefon;
                tbCNP.Text = local.CNP.ToString();
                dtpNastere.Text = local.DataNasterii;
                tbSerieBuletin.Text = local.SerieBuletin;


            }

        }

        #region ErrorProviders

        
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

        #endregion

       

        private void ClientiForm_Load(object sender, EventArgs e)
        {
            
            LoadClienti();
            populareLV();
            lvClienti.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza fisier TXT";
            sfd.Filter = "Fisiere txt (*.txt)|*.txt|Toate fisierele (*.*)|*.*";
            sfd.FilterIndex = 1;
            if (DialogResult.Cancel != sfd.ShowDialog())
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Clienti each in listaClienti)
                {
                    sw.Write(each.Nume + "  |  " + each.Prenume + "  |  " + each.SerieBuletin + "  |  " + each.Telefon + "  |  " +
                       each.Adresa + "  |  " + each.CNP.ToString() + "  |  " + each.DataNasterii+"\n");
                }

                sw.Close();

            }

        }
        #region DB

        private void populareDB()
        {
            foreach (Clienti clienti in listaClienti)
            {
                string sql = "INSERT INTO Clienti(Nume, Prenume, Adresa, SerieBuletin,CNP,Telefon,DataNasterii) "
               + " VALUES(@nume,@prenume,@adresa,@telefon,@cnp,@serieBuletin,@dataNasterii);" + " SELECT last_insert_rowid();";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {


                    var command = new SQLiteCommand(sql, connection);
                    command.Parameters.AddWithValue("@nume", clienti.Nume);
                    command.Parameters.AddWithValue("@prenume", clienti.Prenume);
                    command.Parameters.AddWithValue("@adresa", clienti.Adresa);
                    command.Parameters.AddWithValue("@telefon", clienti.Telefon);
                    command.Parameters.AddWithValue("@cnp", clienti.CNP);
                    command.Parameters.AddWithValue("@serieBuletin", clienti.SerieBuletin);
                    command.Parameters.AddWithValue("@dataNasterii", clienti.DataNasterii);

                    connection.Open();
                    long id = (long)command.ExecuteScalar();
                    clienti.ID = id;


                }
            }

        }
        private void AddClient(Clienti clienti)
        {
            string sql = "INSERT INTO Clienti(Nume, Prenume, Adresa, SerieBuletin,CNP,Telefon,DataNasterii) "
                + " VALUES(@nume,@prenume,@adresa,@telefon,@cnp,@serieBuletin,@dataNasterii);" + " SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@nume", clienti.Nume);
                command.Parameters.AddWithValue("@prenume", clienti.Prenume);
                command.Parameters.AddWithValue("@adresa", clienti.Adresa);
                command.Parameters.AddWithValue("@telefon", clienti.Telefon);
                command.Parameters.AddWithValue("@cnp", clienti.CNP);
                command.Parameters.AddWithValue("@serieBuletin", clienti.SerieBuletin);
                command.Parameters.AddWithValue("@dataNasterii", clienti.DataNasterii);

                connection.Open();
                long id=(long)command.ExecuteScalar();
                clienti.ID = id;

                try
                {
                    listaClienti.Add(clienti);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        
        }

        private void LoadClienti()
        {
            var query = "SELECT * FROM Clienti";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["ID"];
                        string nume = (string)reader["Nume"];
                        string prenume = (string)reader["Prenume"];
                        string telefon = (string)reader["Telefon"];
                        string adresa = (string)reader["Adresa"];
                        string serieBuletin = (string)reader["SerieBuletin"];
                        string dataNasterii = (string)reader["DataNasterii"];
                        String cnp = reader["CNP"].ToString() ;

                        long.TryParse(cnp, out long CNP);

                        Clienti local = new Clienti(id, nume, prenume, adresa, CNP, serieBuletin, dataNasterii, telefon);
                        listaClienti.Add(local);
                    }
                }
                    
            }
        }

        #endregion
    }
}
