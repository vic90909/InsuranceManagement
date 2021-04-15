namespace Proiect_Asigurari
{
    partial class AsigurareAutomobilForm
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
            this.tbCapacitateCilindrica = new System.Windows.Forms.TextBox();
            this.btFinalizare = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSerieSasiu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNrInmatriculare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMasaMaxima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumarLocuri = new System.Windows.Forms.TextBox();
            this.epModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNumar = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSerie = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCC = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLocuri = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMasa = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLocuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMasa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCapacitateCilindrica
            // 
            this.tbCapacitateCilindrica.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCapacitateCilindrica.Location = new System.Drawing.Point(90, 256);
            this.tbCapacitateCilindrica.Name = "tbCapacitateCilindrica";
            this.tbCapacitateCilindrica.Size = new System.Drawing.Size(121, 20);
            this.tbCapacitateCilindrica.TabIndex = 66;
            this.tbCapacitateCilindrica.Validating += new System.ComponentModel.CancelEventHandler(this.tbCapacitateCilindrica_Validating);
            this.tbCapacitateCilindrica.Validated += new System.EventHandler(this.tbCapacitateCilindrica_Validated);
            // 
            // btFinalizare
            // 
            this.btFinalizare.Location = new System.Drawing.Point(43, 418);
            this.btFinalizare.Name = "btFinalizare";
            this.btFinalizare.Size = new System.Drawing.Size(228, 40);
            this.btFinalizare.TabIndex = 65;
            this.btFinalizare.Text = "Confirmare";
            this.btFinalizare.UseVisualStyleBackColor = true;
            this.btFinalizare.Click += new System.EventHandler(this.btFinalizare_Click);
            // 
            // btCurata
            // 
            this.btCurata.Location = new System.Drawing.Point(160, 372);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(149, 40);
            this.btCurata.TabIndex = 64;
            this.btCurata.Text = "Curata";
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.Location = new System.Drawing.Point(5, 372);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(149, 40);
            this.btRenunta.TabIndex = 63;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.UseVisualStyleBackColor = true;
            this.btRenunta.Click += new System.EventHandler(this.btRenunta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Numar Locuri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Capacitate cilindrica";
            // 
            // tbSerieSasiu
            // 
            this.tbSerieSasiu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSerieSasiu.Location = new System.Drawing.Point(89, 212);
            this.tbSerieSasiu.Name = "tbSerieSasiu";
            this.tbSerieSasiu.Size = new System.Drawing.Size(122, 20);
            this.tbSerieSasiu.TabIndex = 59;
            this.tbSerieSasiu.Validating += new System.ComponentModel.CancelEventHandler(this.tbSerieSasiu_Validating);
            this.tbSerieSasiu.Validated += new System.EventHandler(this.tbSerieSasiu_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Serie Sasiu";
            // 
            // tbNrInmatriculare
            // 
            this.tbNrInmatriculare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNrInmatriculare.Location = new System.Drawing.Point(89, 172);
            this.tbNrInmatriculare.Name = "tbNrInmatriculare";
            this.tbNrInmatriculare.Size = new System.Drawing.Size(122, 20);
            this.tbNrInmatriculare.TabIndex = 57;
            this.tbNrInmatriculare.Validating += new System.ComponentModel.CancelEventHandler(this.tbNrInmatriculare_Validating);
            this.tbNrInmatriculare.Validated += new System.EventHandler(this.tbNrInmatriculare_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Numar Inmatriculare";
            // 
            // tbModel
            // 
            this.tbModel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbModel.Location = new System.Drawing.Point(89, 132);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(122, 20);
            this.tbModel.TabIndex = 55;
            this.tbModel.Validating += new System.ComponentModel.CancelEventHandler(this.tbModel_Validating);
            this.tbModel.Validated += new System.EventHandler(this.tbModel_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Model";
            // 
            // tbMarca
            // 
            this.tbMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMarca.Location = new System.Drawing.Point(90, 92);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(121, 20);
            this.tbMarca.TabIndex = 53;
            this.tbMarca.Validating += new System.ComponentModel.CancelEventHandler(this.tbMarca_Validating);
            this.tbMarca.Validated += new System.EventHandler(this.tbMarca_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Marca";
            // 
            // tbMasaMaxima
            // 
            this.tbMasaMaxima.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMasaMaxima.Location = new System.Drawing.Point(90, 346);
            this.tbMasaMaxima.Name = "tbMasaMaxima";
            this.tbMasaMaxima.Size = new System.Drawing.Size(121, 20);
            this.tbMasaMaxima.TabIndex = 69;
            this.tbMasaMaxima.Validating += new System.ComponentModel.CancelEventHandler(this.tbMasaMaxima_Validating);
            this.tbMasaMaxima.Validated += new System.EventHandler(this.tbMasaMaxima_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Masa Maxima";
            // 
            // tbNumarLocuri
            // 
            this.tbNumarLocuri.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNumarLocuri.Location = new System.Drawing.Point(89, 298);
            this.tbNumarLocuri.Name = "tbNumarLocuri";
            this.tbNumarLocuri.Size = new System.Drawing.Size(121, 20);
            this.tbNumarLocuri.TabIndex = 70;
            this.tbNumarLocuri.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumarLocuri_Validating);
            this.tbNumarLocuri.Validated += new System.EventHandler(this.tbNumarLocuri_Validated);
            // 
            // epModel
            // 
            this.epModel.ContainerControl = this;
            // 
            // epNumar
            // 
            this.epNumar.ContainerControl = this;
            // 
            // epSerie
            // 
            this.epSerie.ContainerControl = this;
            // 
            // epCC
            // 
            this.epCC.ContainerControl = this;
            // 
            // epLocuri
            // 
            this.epLocuri.ContainerControl = this;
            // 
            // epMarca
            // 
            this.epMarca.ContainerControl = this;
            // 
            // epMasa
            // 
            this.epMasa.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 31);
            this.label8.TabIndex = 71;
            this.label8.Text = "Asigurare Automobil";
            // 
            // AsigurareAutomobilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 462);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNumarLocuri);
            this.Controls.Add(this.tbMasaMaxima);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCapacitateCilindrica);
            this.Controls.Add(this.btFinalizare);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btRenunta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSerieSasiu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNrInmatriculare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMarca);
            this.Name = "AsigurareAutomobilForm";
            this.Text = "AsigurareAutomobilForm";
            this.Load += new System.EventHandler(this.AsigurareAutomobilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLocuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCapacitateCilindrica;
        private System.Windows.Forms.Button btFinalizare;
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSerieSasiu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNrInmatriculare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMasaMaxima;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumarLocuri;
        private System.Windows.Forms.ErrorProvider epModel;
        private System.Windows.Forms.ErrorProvider epNumar;
        private System.Windows.Forms.ErrorProvider epSerie;
        private System.Windows.Forms.ErrorProvider epCC;
        private System.Windows.Forms.ErrorProvider epLocuri;
        private System.Windows.Forms.ErrorProvider epMarca;
        private System.Windows.Forms.ErrorProvider epMasa;
        private System.Windows.Forms.Label label8;
    }
}