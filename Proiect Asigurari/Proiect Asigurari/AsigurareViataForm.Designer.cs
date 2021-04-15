namespace Proiect_Asigurari
{
    partial class AsigurareViataForm
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
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbGrupa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInaltime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGreutate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStareCivila = new System.Windows.Forms.ComboBox();
            this.btFinalizare = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.epGrupa = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInaltime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGreutate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGen = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStare = new System.Windows.Forms.ErrorProvider(this.components);
            this.epvarsta = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epGrupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInaltime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGreutate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvarsta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varsta (ani)";
            // 
            // tbVarsta
            // 
            this.tbVarsta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbVarsta.Location = new System.Drawing.Point(93, 89);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(121, 20);
            this.tbVarsta.TabIndex = 1;
            this.tbVarsta.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarsta_Validating);
            this.tbVarsta.Validated += new System.EventHandler(this.tbVarsta_Validated);
            // 
            // tbGrupa
            // 
            this.tbGrupa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbGrupa.Location = new System.Drawing.Point(92, 129);
            this.tbGrupa.Name = "tbGrupa";
            this.tbGrupa.Size = new System.Drawing.Size(122, 20);
            this.tbGrupa.TabIndex = 3;
            this.tbGrupa.Validating += new System.ComponentModel.CancelEventHandler(this.tbGrupa_Validating);
            this.tbGrupa.Validated += new System.EventHandler(this.tbGrupa_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupa Sangvina";
            // 
            // tbInaltime
            // 
            this.tbInaltime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbInaltime.Location = new System.Drawing.Point(92, 169);
            this.tbInaltime.Name = "tbInaltime";
            this.tbInaltime.Size = new System.Drawing.Size(122, 20);
            this.tbInaltime.TabIndex = 5;
            this.tbInaltime.Validating += new System.ComponentModel.CancelEventHandler(this.tbInaltime_Validating);
            this.tbInaltime.Validated += new System.EventHandler(this.tbInaltime_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inaltime (cm)";
            // 
            // tbGreutate
            // 
            this.tbGreutate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbGreutate.Location = new System.Drawing.Point(92, 209);
            this.tbGreutate.Name = "tbGreutate";
            this.tbGreutate.Size = new System.Drawing.Size(122, 20);
            this.tbGreutate.TabIndex = 7;
            this.tbGreutate.Validating += new System.ComponentModel.CancelEventHandler(this.tbGreutate_Validating);
            this.tbGreutate.Validated += new System.EventHandler(this.tbGreutate_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Greutate (kg)";
            // 
            // cbGen
            // 
            this.cbGen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbGen.FormattingEnabled = true;
            this.cbGen.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Altul"});
            this.cbGen.Location = new System.Drawing.Point(93, 250);
            this.cbGen.Name = "cbGen";
            this.cbGen.Size = new System.Drawing.Size(121, 21);
            this.cbGen.TabIndex = 8;
            this.cbGen.Validating += new System.ComponentModel.CancelEventHandler(this.cbGen_Validating);
            this.cbGen.Validated += new System.EventHandler(this.cbGen_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "StareCivila";
            // 
            // cbStareCivila
            // 
            this.cbStareCivila.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbStareCivila.FormattingEnabled = true;
            this.cbStareCivila.Items.AddRange(new object[] {
            "Casatorit",
            "Necasatorit"});
            this.cbStareCivila.Location = new System.Drawing.Point(93, 295);
            this.cbStareCivila.Name = "cbStareCivila";
            this.cbStareCivila.Size = new System.Drawing.Size(121, 21);
            this.cbStareCivila.TabIndex = 10;
            this.cbStareCivila.Validating += new System.ComponentModel.CancelEventHandler(this.cbStareCivila_Validating);
            this.cbStareCivila.Validated += new System.EventHandler(this.cbStareCivila_Validated);
            // 
            // btFinalizare
            // 
            this.btFinalizare.Location = new System.Drawing.Point(46, 378);
            this.btFinalizare.Name = "btFinalizare";
            this.btFinalizare.Size = new System.Drawing.Size(228, 40);
            this.btFinalizare.TabIndex = 36;
            this.btFinalizare.Text = "Confirmare";
            this.btFinalizare.UseVisualStyleBackColor = true;
            this.btFinalizare.Click += new System.EventHandler(this.btFinalizare_Click);
            // 
            // btCurata
            // 
            this.btCurata.Location = new System.Drawing.Point(163, 332);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(149, 40);
            this.btCurata.TabIndex = 35;
            this.btCurata.Text = "Curata";
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.Location = new System.Drawing.Point(8, 332);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(149, 40);
            this.btRenunta.TabIndex = 34;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.UseVisualStyleBackColor = true;
            this.btRenunta.Click += new System.EventHandler(this.btRenunta_Click);
            // 
            // epGrupa
            // 
            this.epGrupa.ContainerControl = this;
            // 
            // epInaltime
            // 
            this.epInaltime.ContainerControl = this;
            // 
            // epGreutate
            // 
            this.epGreutate.ContainerControl = this;
            // 
            // epGen
            // 
            this.epGen.ContainerControl = this;
            // 
            // epStare
            // 
            this.epStare.ContainerControl = this;
            // 
            // epvarsta
            // 
            this.epvarsta.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "Asigurare Viata";
            // 
            // AsigurareViataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 421);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btFinalizare);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btRenunta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStareCivila);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGen);
            this.Controls.Add(this.tbGreutate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbInaltime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGrupa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AsigurareViataForm";
            this.Text = "AsigurareViataForm";
            this.Load += new System.EventHandler(this.AsigurareViataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epGrupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInaltime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGreutate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvarsta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbGrupa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInaltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGreutate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStareCivila;
        private System.Windows.Forms.Button btFinalizare;
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.ErrorProvider epGrupa;
        private System.Windows.Forms.ErrorProvider epInaltime;
        private System.Windows.Forms.ErrorProvider epGreutate;
        private System.Windows.Forms.ErrorProvider epGen;
        private System.Windows.Forms.ErrorProvider epStare;
        private System.Windows.Forms.ErrorProvider epvarsta;
        private System.Windows.Forms.Label label7;
    }
}