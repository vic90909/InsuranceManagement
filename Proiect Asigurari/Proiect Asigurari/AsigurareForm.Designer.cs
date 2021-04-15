namespace Proiect_Asigurari
{
    partial class AsigurareForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.dtpSfarsit = new System.Windows.Forms.DateTimePicker();
            this.lvAsigurari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEditare = new System.Windows.Forms.Button();
            this.btStergeMultiple = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btAdauga = new System.Windows.Forms.Button();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btAdaugaDetalii = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatusNrAs = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStatusSuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.epDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAsigurator = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLocatie = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuma = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInceput = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSfarsit = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTip = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAsigurator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLocatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInceput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSfarsit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire Bun";
            // 
            // tbDenumire
            // 
            this.tbDenumire.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDenumire.Location = new System.Drawing.Point(4, 81);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(200, 20);
            this.tbDenumire.TabIndex = 1;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated);
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNume.Location = new System.Drawing.Point(4, 121);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(200, 20);
            this.tbNume.TabIndex = 3;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume Asigurator";
            // 
            // tbLocatie
            // 
            this.tbLocatie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLocatie.Location = new System.Drawing.Point(4, 161);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(200, 20);
            this.tbLocatie.TabIndex = 5;
            this.tbLocatie.Validating += new System.ComponentModel.CancelEventHandler(this.tbLocatie_Validating);
            this.tbLocatie.Validated += new System.EventHandler(this.tbLocatie_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Locatie Bun";
            // 
            // tbSuma
            // 
            this.tbSuma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSuma.Location = new System.Drawing.Point(4, 201);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(200, 20);
            this.tbSuma.TabIndex = 7;
            this.tbSuma.Validating += new System.ComponentModel.CancelEventHandler(this.tbSuma_Validating);
            this.tbSuma.Validated += new System.EventHandler(this.tbSuma_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Suma Asigurare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Polita Inceput";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Polita Sfarsit";
            // 
            // dtpInceput
            // 
            this.dtpInceput.CustomFormat = "dd.MM.yyyy";
            this.dtpInceput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInceput.Location = new System.Drawing.Point(4, 241);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(200, 20);
            this.dtpInceput.TabIndex = 11;
            // 
            // dtpSfarsit
            // 
            this.dtpSfarsit.CustomFormat = "dd.MM.yyyy";
            this.dtpSfarsit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSfarsit.Location = new System.Drawing.Point(4, 281);
            this.dtpSfarsit.Name = "dtpSfarsit";
            this.dtpSfarsit.Size = new System.Drawing.Size(200, 20);
            this.dtpSfarsit.TabIndex = 12;
            this.dtpSfarsit.Validating += new System.ComponentModel.CancelEventHandler(this.dtpSfarsit_Validating);
            this.dtpSfarsit.Validated += new System.EventHandler(this.dtpSfarsit_Validated);
            // 
            // lvAsigurari
            // 
            this.lvAsigurari.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvAsigurari.CheckBoxes = true;
            this.lvAsigurari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvAsigurari.HideSelection = false;
            this.lvAsigurari.Location = new System.Drawing.Point(252, 81);
            this.lvAsigurari.Name = "lvAsigurari";
            this.lvAsigurari.Size = new System.Drawing.Size(536, 264);
            this.lvAsigurari.TabIndex = 13;
            this.lvAsigurari.UseCompatibleStateImageBehavior = false;
            this.lvAsigurari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Denumire";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume Asig.";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Locatie";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Suma";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data Polita Inceput";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data Polita Sfarsit";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip Asigurare";
            this.columnHeader7.Width = 72;
            // 
            // btEditare
            // 
            this.btEditare.Image = global::Proiect_Asigurari.Properties.Resources.edit24px;
            this.btEditare.Location = new System.Drawing.Point(679, 374);
            this.btEditare.Name = "btEditare";
            this.btEditare.Size = new System.Drawing.Size(110, 40);
            this.btEditare.TabIndex = 22;
            this.btEditare.Text = "Editare";
            this.btEditare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditare.UseVisualStyleBackColor = true;
            this.btEditare.Click += new System.EventHandler(this.btEditare_Click);
            // 
            // btStergeMultiple
            // 
            this.btStergeMultiple.Image = global::Proiect_Asigurari.Properties.Resources.delete24px;
            this.btStergeMultiple.Location = new System.Drawing.Point(552, 374);
            this.btStergeMultiple.Name = "btStergeMultiple";
            this.btStergeMultiple.Size = new System.Drawing.Size(111, 40);
            this.btStergeMultiple.TabIndex = 21;
            this.btStergeMultiple.Text = "Sterge Inregistrari";
            this.btStergeMultiple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btStergeMultiple.UseVisualStyleBackColor = true;
            this.btStergeMultiple.Click += new System.EventHandler(this.btStergeMultiple_Click);
            // 
            // btCurata
            // 
            this.btCurata.Image = global::Proiect_Asigurari.Properties.Resources.clear24px;
            this.btCurata.Location = new System.Drawing.Point(121, 374);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(111, 40);
            this.btCurata.TabIndex = 20;
            this.btCurata.Text = "Curata";
            this.btCurata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCurata.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btAdauga
            // 
            this.btAdauga.Image = global::Proiect_Asigurari.Properties.Resources.add_24;
            this.btAdauga.Location = new System.Drawing.Point(4, 374);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(111, 40);
            this.btAdauga.TabIndex = 19;
            this.btAdauga.Text = "Adauga";
            this.btAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdauga.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // cbTip
            // 
            this.cbTip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Locuinta",
            "Automobil",
            "Viata",
            "AlteBunuri"});
            this.cbTip.Location = new System.Drawing.Point(4, 324);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(200, 21);
            this.cbTip.TabIndex = 23;
            this.cbTip.Validating += new System.ComponentModel.CancelEventHandler(this.cbTip_Validating);
            this.cbTip.Validated += new System.EventHandler(this.cbTip_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tip Asigurare";
            // 
            // btAdaugaDetalii
            // 
            this.btAdaugaDetalii.Image = global::Proiect_Asigurari.Properties.Resources.Add_Folder_icon;
            this.btAdaugaDetalii.Location = new System.Drawing.Point(252, 351);
            this.btAdaugaDetalii.Name = "btAdaugaDetalii";
            this.btAdaugaDetalii.Size = new System.Drawing.Size(275, 65);
            this.btAdaugaDetalii.TabIndex = 25;
            this.btAdaugaDetalii.Text = "Adauga Detalii Asigurare";
            this.btAdaugaDetalii.UseVisualStyleBackColor = true;
            this.btAdaugaDetalii.Click += new System.EventHandler(this.btAdaugaDetalii_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusNrAs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatusNrAs
            // 
            this.toolStatusNrAs.Name = "toolStatusNrAs";
            this.toolStatusNrAs.Size = new System.Drawing.Size(44, 17);
            this.toolStatusNrAs.Text = "Numar";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusSuma});
            this.statusStrip2.Location = new System.Drawing.Point(0, 421);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(802, 22);
            this.statusStrip2.TabIndex = 27;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStatusSuma
            // 
            this.toolStatusSuma.Name = "toolStatusSuma";
            this.toolStatusSuma.Size = new System.Drawing.Size(37, 17);
            this.toolStatusSuma.Text = "Suma";
            // 
            // epDenumire
            // 
            this.epDenumire.ContainerControl = this;
            // 
            // epAsigurator
            // 
            this.epAsigurator.ContainerControl = this;
            // 
            // epLocatie
            // 
            this.epLocatie.ContainerControl = this;
            // 
            // epSuma
            // 
            this.epSuma.ContainerControl = this;
            // 
            // epInceput
            // 
            this.epInceput.ContainerControl = this;
            // 
            // epSfarsit
            // 
            this.epSfarsit.ContainerControl = this;
            // 
            // epTip
            // 
            this.epTip.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 31);
            this.label8.TabIndex = 28;
            this.label8.Text = "Asigurari";
            // 
            // AsigurareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btAdaugaDetalii);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.btEditare);
            this.Controls.Add(this.btStergeMultiple);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.lvAsigurari);
            this.Controls.Add(this.dtpSfarsit);
            this.Controls.Add(this.dtpInceput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label1);
            this.Name = "AsigurareForm";
            this.Text = "AsigurareForm";
            this.Load += new System.EventHandler(this.AsigurareForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAsigurator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLocatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInceput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSfarsit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInceput;
        private System.Windows.Forms.DateTimePicker dtpSfarsit;
        private System.Windows.Forms.ListView lvAsigurari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btEditare;
        private System.Windows.Forms.Button btStergeMultiple;
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAdaugaDetalii;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusNrAs;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusSuma;
        private System.Windows.Forms.ErrorProvider epDenumire;
        private System.Windows.Forms.ErrorProvider epAsigurator;
        private System.Windows.Forms.ErrorProvider epLocatie;
        private System.Windows.Forms.ErrorProvider epSuma;
        private System.Windows.Forms.ErrorProvider epInceput;
        private System.Windows.Forms.ErrorProvider epSfarsit;
        private System.Windows.Forms.ErrorProvider epTip;
        private System.Windows.Forms.Label label8;
    }
}