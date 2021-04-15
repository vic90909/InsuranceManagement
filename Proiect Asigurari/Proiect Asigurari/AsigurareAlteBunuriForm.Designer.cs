namespace Proiect_Asigurari
{
    partial class AsigurareAlteBunuriForm
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
            this.tbDetalii = new System.Windows.Forms.TextBox();
            this.epDetalii = new System.Windows.Forms.ErrorProvider(this.components);
            this.btFinalizare = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epDetalii)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalii Bun";
            // 
            // tbDetalii
            // 
            this.tbDetalii.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDetalii.Location = new System.Drawing.Point(13, 109);
            this.tbDetalii.Multiline = true;
            this.tbDetalii.Name = "tbDetalii";
            this.tbDetalii.Size = new System.Drawing.Size(402, 160);
            this.tbDetalii.TabIndex = 1;
            this.tbDetalii.Validating += new System.ComponentModel.CancelEventHandler(this.tbDetalii_Validating);
            this.tbDetalii.Validated += new System.EventHandler(this.tbDetalii_Validated);
            // 
            // epDetalii
            // 
            this.epDetalii.ContainerControl = this;
            // 
            // btFinalizare
            // 
            this.btFinalizare.Image = global::Proiect_Asigurari.Properties.Resources.add_24;
            this.btFinalizare.Location = new System.Drawing.Point(97, 332);
            this.btFinalizare.Name = "btFinalizare";
            this.btFinalizare.Size = new System.Drawing.Size(228, 40);
            this.btFinalizare.TabIndex = 33;
            this.btFinalizare.Text = "Confirmare";
            this.btFinalizare.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btFinalizare.UseVisualStyleBackColor = true;
            this.btFinalizare.Click += new System.EventHandler(this.btFinalizare_Click);
            // 
            // btCurata
            // 
            this.btCurata.Image = global::Proiect_Asigurari.Properties.Resources.clear24px;
            this.btCurata.Location = new System.Drawing.Point(214, 286);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(201, 40);
            this.btCurata.TabIndex = 32;
            this.btCurata.Text = "Curata";
            this.btCurata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCurata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.Image = global::Proiect_Asigurari.Properties.Resources.delete24px;
            this.btRenunta.Location = new System.Drawing.Point(16, 286);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(192, 40);
            this.btRenunta.TabIndex = 31;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRenunta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btRenunta.UseVisualStyleBackColor = true;
            this.btRenunta.Click += new System.EventHandler(this.btRenunta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Asigurare A. Bunuri";
            // 
            // AsigurareAlteBunuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFinalizare);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btRenunta);
            this.Controls.Add(this.tbDetalii);
            this.Controls.Add(this.label1);
            this.Name = "AsigurareAlteBunuriForm";
            this.Text = "AsigurareAlteBunuriForm";
            this.Load += new System.EventHandler(this.AsigurareAlteBunuriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epDetalii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDetalii;
        private System.Windows.Forms.Button btFinalizare;
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.ErrorProvider epDetalii;
        private System.Windows.Forms.Label label2;
    }
}