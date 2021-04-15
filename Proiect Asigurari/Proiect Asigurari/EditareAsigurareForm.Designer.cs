namespace Proiect_Asigurari
{
    partial class EditareAsigurareForm
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
            this.dtpSfarsit = new System.Windows.Forms.DateTimePicker();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFinalizare = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.epSfarsit = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInceput = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuma = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLocatie = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAsigurator = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epSfarsit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInceput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLocatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAsigurator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSfarsit
            // 
            this.dtpSfarsit.CustomFormat = "dd.MM.yyyy";
            this.dtpSfarsit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSfarsit.Location = new System.Drawing.Point(12, 305);
            this.dtpSfarsit.Name = "dtpSfarsit";
            this.dtpSfarsit.Size = new System.Drawing.Size(200, 20);
            this.dtpSfarsit.TabIndex = 24;
            this.dtpSfarsit.Validating += new System.ComponentModel.CancelEventHandler(this.dtpSfarsit_Validating);
            this.dtpSfarsit.Validated += new System.EventHandler(this.dtpSfarsit_Validated);
            // 
            // dtpInceput
            // 
            this.dtpInceput.CustomFormat = "dd.MM.yyyy";
            this.dtpInceput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInceput.Location = new System.Drawing.Point(12, 265);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(200, 20);
            this.dtpInceput.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data Polita Sfarsit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data Polita Inceput";
            // 
            // tbSuma
            // 
            this.tbSuma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSuma.Location = new System.Drawing.Point(12, 225);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(200, 20);
            this.tbSuma.TabIndex = 20;
            this.tbSuma.Validating += new System.ComponentModel.CancelEventHandler(this.tbSuma_Validating);
            this.tbSuma.Validated += new System.EventHandler(this.tbSuma_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Suma Asigurare";
            // 
            // tbLocatie
            // 
            this.tbLocatie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLocatie.Location = new System.Drawing.Point(12, 185);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(200, 20);
            this.tbLocatie.TabIndex = 18;
            this.tbLocatie.Validating += new System.ComponentModel.CancelEventHandler(this.tbLocatie_Validating);
            this.tbLocatie.Validated += new System.EventHandler(this.tbLocatie_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Locatie Bun";
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNume.Location = new System.Drawing.Point(12, 145);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(200, 20);
            this.tbNume.TabIndex = 16;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nume Asigurator";
            // 
            // tbDenumire
            // 
            this.tbDenumire.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDenumire.Location = new System.Drawing.Point(12, 105);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(200, 20);
            this.tbDenumire.TabIndex = 14;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Denumire Bun";
            // 
            // btFinalizare
            // 
            this.btFinalizare.Location = new System.Drawing.Point(3, 415);
            this.btFinalizare.Name = "btFinalizare";
            this.btFinalizare.Size = new System.Drawing.Size(228, 40);
            this.btFinalizare.TabIndex = 33;
            this.btFinalizare.Text = "Confirmare";
            this.btFinalizare.UseVisualStyleBackColor = true;
            this.btFinalizare.Click += new System.EventHandler(this.btFinalizare_Click);
            // 
            // btCurata
            // 
            this.btCurata.Location = new System.Drawing.Point(120, 369);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(111, 40);
            this.btCurata.TabIndex = 32;
            this.btCurata.Text = "Curata";
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.Location = new System.Drawing.Point(3, 369);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(111, 40);
            this.btRenunta.TabIndex = 31;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.UseVisualStyleBackColor = true;
            this.btRenunta.Click += new System.EventHandler(this.btRenunta_Click);
            // 
            // epSfarsit
            // 
            this.epSfarsit.ContainerControl = this;
            // 
            // epInceput
            // 
            this.epInceput.ContainerControl = this;
            // 
            // epSuma
            // 
            this.epSuma.ContainerControl = this;
            // 
            // epLocatie
            // 
            this.epLocatie.ContainerControl = this;
            // 
            // epAsigurator
            // 
            this.epAsigurator.ContainerControl = this;
            // 
            // epDenumire
            // 
            this.epDenumire.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 58);
            this.label7.TabIndex = 34;
            this.label7.Text = "  Editare\r\nAsigurare\r\n";
            // 
            // EditareAsigurareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 465);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btFinalizare);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btRenunta);
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
            this.Name = "EditareAsigurareForm";
            this.Text = "EditareAsigurareForm";
            this.Load += new System.EventHandler(this.EditareAsigurareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epSfarsit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInceput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLocatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAsigurator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSfarsit;
        private System.Windows.Forms.DateTimePicker dtpInceput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFinalizare;
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.ErrorProvider epSfarsit;
        private System.Windows.Forms.ErrorProvider epInceput;
        private System.Windows.Forms.ErrorProvider epSuma;
        private System.Windows.Forms.ErrorProvider epLocatie;
        private System.Windows.Forms.ErrorProvider epAsigurator;
        private System.Windows.Forms.ErrorProvider epDenumire;
        private System.Windows.Forms.Label label7;
    }
}