namespace Proiect_Asigurari
{
    partial class EditareClientiForm
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
            this.btCurata = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.btFinalizare = new System.Windows.Forms.Button();
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSerieB = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epData = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.uc1 = new Proiect_Asigurari.UserControlClienti();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSerieB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data Nasterii";
            // 
            // dtpNastere
            // 
            this.dtpNastere.CustomFormat = "dd.MM.yyyy";
            this.dtpNastere.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNastere.Location = new System.Drawing.Point(15, 336);
            this.dtpNastere.Name = "dtpNastere";
            this.dtpNastere.Size = new System.Drawing.Size(188, 20);
            this.dtpNastere.TabIndex = 26;
            this.dtpNastere.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNastere_Validating);
            this.dtpNastere.Validated += new System.EventHandler(this.dtpNastere_Validated);
            // 
            // tbTelefon
            // 
            this.tbTelefon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTelefon.Location = new System.Drawing.Point(15, 292);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(188, 20);
            this.tbTelefon.TabIndex = 25;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefon";
            // 
            // tbCNP
            // 
            this.tbCNP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCNP.Location = new System.Drawing.Point(15, 248);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(188, 20);
            this.tbCNP.TabIndex = 23;
            this.tbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNP_Validating);
            this.tbCNP.Validated += new System.EventHandler(this.tbCNP_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "CNP";
            // 
            // tbSerieBuletin
            // 
            this.tbSerieBuletin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSerieBuletin.Location = new System.Drawing.Point(16, 206);
            this.tbSerieBuletin.Name = "tbSerieBuletin";
            this.tbSerieBuletin.Size = new System.Drawing.Size(187, 20);
            this.tbSerieBuletin.TabIndex = 21;
            this.tbSerieBuletin.Validating += new System.ComponentModel.CancelEventHandler(this.tbSerieBuletin_Validating);
            this.tbSerieBuletin.Validated += new System.EventHandler(this.tbSerieBuletin_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Serie Buletin";
            // 
            // tbAdresa
            // 
            this.tbAdresa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbAdresa.Location = new System.Drawing.Point(16, 163);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(187, 20);
            this.tbAdresa.TabIndex = 19;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            this.tbAdresa.Validated += new System.EventHandler(this.tbAdresa_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adresa";
            // 
            // tbPrenume
            // 
            this.tbPrenume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrenume.Location = new System.Drawing.Point(16, 119);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(187, 20);
            this.tbPrenume.TabIndex = 17;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // btCurata
            // 
            this.btCurata.Location = new System.Drawing.Point(118, 383);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(111, 40);
            this.btCurata.TabIndex = 29;
            this.btCurata.Text = "Curata";
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.Location = new System.Drawing.Point(1, 383);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(111, 40);
            this.btRenunta.TabIndex = 28;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.UseVisualStyleBackColor = true;
            this.btRenunta.Click += new System.EventHandler(this.btRenunta_Click);
            // 
            // btFinalizare
            // 
            this.btFinalizare.Location = new System.Drawing.Point(1, 429);
            this.btFinalizare.Name = "btFinalizare";
            this.btFinalizare.Size = new System.Drawing.Size(228, 40);
            this.btFinalizare.TabIndex = 30;
            this.btFinalizare.Text = "Confirmare";
            this.btFinalizare.UseVisualStyleBackColor = true;
            this.btFinalizare.Click += new System.EventHandler(this.btFinalizare_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prenume";
            // 
            // uc1
            // 
            this.uc1.Location = new System.Drawing.Point(16, 57);
            this.uc1.Name = "uc1";
            this.uc1.Size = new System.Drawing.Size(215, 42);
            this.uc1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Editare Clienti";
            // 
            // EditareClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc1);
            this.Controls.Add(this.btFinalizare);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btRenunta);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditareClientiForm";
            this.Text = "EditareClientiForm";
            this.Load += new System.EventHandler(this.EditareClientiForm_Load);
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
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.Button btFinalizare;
        private System.Windows.Forms.ErrorProvider epPrenume;
        private System.Windows.Forms.ErrorProvider epAdresa;
        private System.Windows.Forms.ErrorProvider epSerieB;
        private System.Windows.Forms.ErrorProvider epCNP;
        private System.Windows.Forms.ErrorProvider epTelefon;
        private System.Windows.Forms.ErrorProvider epData;
        private UserControlClienti uc1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}