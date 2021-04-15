namespace Proiect_Asigurari
{
    partial class AsigurariLocuintaForm
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
            this.btFinalizare = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipLocuinta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSUtil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNrNiveluri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumarCamere = new System.Windows.Forms.TextBox();
            this.epAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNiveluri = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUtil = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCamere = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTip = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNiveluri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCamere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).BeginInit();
            this.SuspendLayout();
            // 
            // btFinalizare
            // 
            this.btFinalizare.Location = new System.Drawing.Point(39, 357);
            this.btFinalizare.Name = "btFinalizare";
            this.btFinalizare.Size = new System.Drawing.Size(228, 40);
            this.btFinalizare.TabIndex = 51;
            this.btFinalizare.Text = "Confirmare";
            this.btFinalizare.UseVisualStyleBackColor = true;
            this.btFinalizare.Click += new System.EventHandler(this.btFinalizare_Click);
            // 
            // btCurata
            // 
            this.btCurata.Location = new System.Drawing.Point(156, 311);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(149, 40);
            this.btCurata.TabIndex = 50;
            this.btCurata.Text = "Curata";
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.Location = new System.Drawing.Point(1, 311);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(149, 40);
            this.btRenunta.TabIndex = 49;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.UseVisualStyleBackColor = true;
            this.btRenunta.Click += new System.EventHandler(this.btRenunta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tip Locuinta";
            // 
            // cbTipLocuinta
            // 
            this.cbTipLocuinta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTipLocuinta.FormattingEnabled = true;
            this.cbTipLocuinta.Items.AddRange(new object[] {
            "casa",
            "apartament"});
            this.cbTipLocuinta.Location = new System.Drawing.Point(86, 274);
            this.cbTipLocuinta.Name = "cbTipLocuinta";
            this.cbTipLocuinta.Size = new System.Drawing.Size(121, 21);
            this.cbTipLocuinta.TabIndex = 47;
            this.cbTipLocuinta.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipLocuinta_Validating);
            this.cbTipLocuinta.Validated += new System.EventHandler(this.cbTipLocuinta_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Numar camere";
            // 
            // tbSUtil
            // 
            this.tbSUtil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSUtil.Location = new System.Drawing.Point(85, 188);
            this.tbSUtil.Name = "tbSUtil";
            this.tbSUtil.Size = new System.Drawing.Size(122, 20);
            this.tbSUtil.TabIndex = 44;
            this.tbSUtil.Validating += new System.ComponentModel.CancelEventHandler(this.tbSUtil_Validating);
            this.tbSUtil.Validated += new System.EventHandler(this.tbSUtil_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Suprafata Utilizabila";
            // 
            // tbSTotal
            // 
            this.tbSTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSTotal.Location = new System.Drawing.Point(85, 148);
            this.tbSTotal.Name = "tbSTotal";
            this.tbSTotal.Size = new System.Drawing.Size(122, 20);
            this.tbSTotal.TabIndex = 42;
            this.tbSTotal.Validating += new System.ComponentModel.CancelEventHandler(this.tbSTotal_Validating);
            this.tbSTotal.Validated += new System.EventHandler(this.tbSTotal_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Suprafata Totala";
            // 
            // tbNrNiveluri
            // 
            this.tbNrNiveluri.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNrNiveluri.Location = new System.Drawing.Point(85, 108);
            this.tbNrNiveluri.Name = "tbNrNiveluri";
            this.tbNrNiveluri.Size = new System.Drawing.Size(122, 20);
            this.tbNrNiveluri.TabIndex = 40;
            this.tbNrNiveluri.Validating += new System.ComponentModel.CancelEventHandler(this.tbNrNiveluri_Validating);
            this.tbNrNiveluri.Validated += new System.EventHandler(this.tbNrNiveluri_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Numar Niveluri";
            // 
            // tbAdresa
            // 
            this.tbAdresa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbAdresa.Location = new System.Drawing.Point(86, 68);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(121, 20);
            this.tbAdresa.TabIndex = 38;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            this.tbAdresa.Validated += new System.EventHandler(this.tbAdresa_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Adresa";
            // 
            // tbNumarCamere
            // 
            this.tbNumarCamere.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNumarCamere.Location = new System.Drawing.Point(86, 232);
            this.tbNumarCamere.Name = "tbNumarCamere";
            this.tbNumarCamere.Size = new System.Drawing.Size(121, 20);
            this.tbNumarCamere.TabIndex = 52;
            this.tbNumarCamere.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumarCamere_Validating);
            this.tbNumarCamere.Validated += new System.EventHandler(this.tbNumarCamere_Validated);
            // 
            // epAdresa
            // 
            this.epAdresa.ContainerControl = this;
            // 
            // epNiveluri
            // 
            this.epNiveluri.ContainerControl = this;
            // 
            // epTotal
            // 
            this.epTotal.ContainerControl = this;
            // 
            // epUtil
            // 
            this.epUtil.ContainerControl = this;
            // 
            // epCamere
            // 
            this.epCamere.ContainerControl = this;
            // 
            // epTip
            // 
            this.epTip.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 31);
            this.label7.TabIndex = 53;
            this.label7.Text = "Asigurare Locuinta";
            // 
            // AsigurariLocuintaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 407);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumarCamere);
            this.Controls.Add(this.btFinalizare);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btRenunta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipLocuinta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSUtil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNrNiveluri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AsigurariLocuintaForm";
            this.Text = "AsigurareLocuintaForm";
            this.Load += new System.EventHandler(this.AsigurareLocuintaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNiveluri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCamere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFinalizare;
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipLocuinta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSUtil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNrNiveluri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumarCamere;
        private System.Windows.Forms.ErrorProvider epAdresa;
        private System.Windows.Forms.ErrorProvider epNiveluri;
        private System.Windows.Forms.ErrorProvider epTotal;
        private System.Windows.Forms.ErrorProvider epUtil;
        private System.Windows.Forms.ErrorProvider epCamere;
        private System.Windows.Forms.ErrorProvider epTip;
        private System.Windows.Forms.Label label7;
    }
}