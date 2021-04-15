namespace Proiect_Asigurari
{
    partial class TreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewClienti = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNastere = new System.Windows.Forms.DateTimePicker();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSerieBuletin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalveaza = new System.Windows.Forms.Button();
            this.tbNrNod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btRenunta = new System.Windows.Forms.Button();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSerieB = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epData = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSerieB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewClienti
            // 
            this.treeViewClienti.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewClienti.Location = new System.Drawing.Point(12, 12);
            this.treeViewClienti.Name = "treeViewClienti";
            this.treeViewClienti.Size = new System.Drawing.Size(161, 426);
            this.treeViewClienti.TabIndex = 0;
            this.treeViewClienti.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewClienti_AfterSelect);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data Nasterii";
            // 
            // dtpNastere
            // 
            this.dtpNastere.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpNastere.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtpNastere.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtpNastere.CustomFormat = "";
            this.dtpNastere.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNastere.Location = new System.Drawing.Point(177, 288);
            this.dtpNastere.Name = "dtpNastere";
            this.dtpNastere.Size = new System.Drawing.Size(188, 20);
            this.dtpNastere.TabIndex = 26;
            this.dtpNastere.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNastere_Validating);
            this.dtpNastere.Validated += new System.EventHandler(this.dtpNastere_Validated);
            // 
            // tbTelefon
            // 
            this.tbTelefon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTelefon.Location = new System.Drawing.Point(177, 244);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(188, 20);
            this.tbTelefon.TabIndex = 25;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefon";
            // 
            // tbCNP
            // 
            this.tbCNP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCNP.Location = new System.Drawing.Point(177, 200);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(188, 20);
            this.tbCNP.TabIndex = 23;
            this.tbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNP_Validating);
            this.tbCNP.Validated += new System.EventHandler(this.tbCNP_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "CNP";
            // 
            // tbSerieBuletin
            // 
            this.tbSerieBuletin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSerieBuletin.Location = new System.Drawing.Point(178, 158);
            this.tbSerieBuletin.Name = "tbSerieBuletin";
            this.tbSerieBuletin.Size = new System.Drawing.Size(187, 20);
            this.tbSerieBuletin.TabIndex = 21;
            this.tbSerieBuletin.Validating += new System.ComponentModel.CancelEventHandler(this.tbSerieBuletin_Validating);
            this.tbSerieBuletin.Validated += new System.EventHandler(this.tbSerieBuletin_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Serie Buletin";
            // 
            // tbAdresa
            // 
            this.tbAdresa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbAdresa.Location = new System.Drawing.Point(178, 115);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(187, 20);
            this.tbAdresa.TabIndex = 19;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            this.tbAdresa.Validated += new System.EventHandler(this.tbAdresa_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adresa";
            // 
            // tbPrenume
            // 
            this.tbPrenume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrenume.Location = new System.Drawing.Point(178, 71);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(187, 20);
            this.tbPrenume.TabIndex = 17;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNume.Location = new System.Drawing.Point(179, 29);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(186, 20);
            this.tbNume.TabIndex = 15;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nume";
            // 
            // btSalveaza
            // 
            this.btSalveaza.Location = new System.Drawing.Point(182, 408);
            this.btSalveaza.Name = "btSalveaza";
            this.btSalveaza.Size = new System.Drawing.Size(185, 30);
            this.btSalveaza.TabIndex = 28;
            this.btSalveaza.Text = "Salveaza";
            this.btSalveaza.UseVisualStyleBackColor = true;
            this.btSalveaza.Click += new System.EventHandler(this.btSalveaza_Click);
            // 
            // tbNrNod
            // 
            this.tbNrNod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNrNod.Location = new System.Drawing.Point(257, 327);
            this.tbNrNod.Name = "tbNrNod";
            this.tbNrNod.Size = new System.Drawing.Size(18, 20);
            this.tbNrNod.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Numar Nod";
            // 
            // btRenunta
            // 
            this.btRenunta.Location = new System.Drawing.Point(182, 372);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(185, 30);
            this.btRenunta.TabIndex = 32;
            this.btRenunta.Text = "Inchide";
            this.btRenunta.UseVisualStyleBackColor = true;
            this.btRenunta.Click += new System.EventHandler(this.btRenunta_Click);
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epPrenume
            // 
            this.epPrenume.ContainerControl = this;
            // 
            // epAdresa
            // 
            this.epAdresa.ContainerControl = this;
            // 
            // epSerieB
            // 
            this.epSerieB.ContainerControl = this;
            // 
            // epCNP
            // 
            this.epCNP.ContainerControl = this;
            // 
            // epTelefon
            // 
            this.epTelefon.ContainerControl = this;
            // 
            // epData
            // 
            this.epData.ContainerControl = this;
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 457);
            this.Controls.Add(this.btRenunta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNrNod);
            this.Controls.Add(this.btSalveaza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNastere);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSerieBuletin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewClienti);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSerieB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewClienti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNastere;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSerieBuletin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalveaza;
        private System.Windows.Forms.TextBox tbNrNod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epPrenume;
        private System.Windows.Forms.ErrorProvider epAdresa;
        private System.Windows.Forms.ErrorProvider epSerieB;
        private System.Windows.Forms.ErrorProvider epCNP;
        private System.Windows.Forms.ErrorProvider epTelefon;
        private System.Windows.Forms.ErrorProvider epData;
    }
}