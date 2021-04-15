using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Asigurari
{
    public partial class DataGridViewClienti : Form
    {
        List<Clienti> localList;
        public DataGridViewClienti(List<Clienti>lista)
        {
            InitializeComponent();
            localList = lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Clienti each in localList)
            {
                dataGridView1.Rows.Add(new String[] {
                    each.Nume,
                each.Prenume,
                each.Adresa,
                each.Telefon,
                each.CNP.ToString(),
                each.SerieBuletin,
                each.DataNasterii
                });
            }
        }

        private void btSalveaza_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Clienti each in localList)
            {
                each.Nume = dataGridView1[0,i].Value.ToString();
                each.Prenume = dataGridView1[1, i].Value.ToString();
                each.Adresa = dataGridView1[2, i].Value.ToString();
                each.Telefon= dataGridView1[3, i].Value.ToString();
                long.TryParse(dataGridView1[4, i].Value.ToString(), out long cnp);
                each.CNP = cnp;
                each.SerieBuletin= dataGridView1[5, i].Value.ToString();
                each.DataNasterii= dataGridView1[6, i].Value.ToString();
                i++;
            }
            this.Close();
        }

        private void btSalvezaLocal_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Clienti each in localList)
            {
                each.Nume = dataGridView1[0, i].Value.ToString();
                each.Prenume = dataGridView1[1, i].Value.ToString();
                each.Adresa = dataGridView1[2, i].Value.ToString();
                each.Telefon = dataGridView1[3, i].Value.ToString();
                long.TryParse(dataGridView1[4, i].Value.ToString(), out long cnp);
                each.CNP = cnp;
                each.SerieBuletin = dataGridView1[5, i].Value.ToString();
                each.DataNasterii = dataGridView1[6, i].Value.ToString();
                i++;
            }

            Form1_Load(sender, e);
            
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePath = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            foreach(String path in filePath)
            {
                string[] content = File.ReadAllLines(path);

                localList.Clear();
                foreach(String line in content)
                {
                    string[] token = line.Split(new String[] { "  |  " }, StringSplitOptions.None);

                    Clienti local = new Clienti();

                    local.Nume = token[0];
                    local.Prenume = token[1];
                    local.SerieBuletin = token[2];
                    local.Telefon = token[3];
                    local.Adresa = token[4];
                    long.TryParse(token[5], out long cnp);
                    local.CNP = cnp;
                    local.DataNasterii = token[6];
                    
                    
                    localList.Add(local);

                }
                dataGridView1.Rows.Clear();
                foreach (Clienti each in localList)
                {
                    dataGridView1.Rows.Add(new String[] {
                    each.Nume,
                each.Prenume,
                each.Adresa,
                each.Telefon,
                each.CNP.ToString(),
                each.SerieBuletin,
                each.DataNasterii
                });
                }
            }

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
