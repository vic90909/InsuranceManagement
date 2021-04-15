namespace Proiect_Asigurari
{
    partial class UserControlClienti
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNume.Location = new System.Drawing.Point(0, 20);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(186, 20);
            this.tbNume.TabIndex = 3;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epPrenume
            // 
            this.epPrenume.ContainerControl = this;
            // 
            // UserControlClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Name = "UserControlClienti";
            this.Size = new System.Drawing.Size(215, 42);
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ErrorProvider epNume;
        public System.Windows.Forms.ErrorProvider epPrenume;
    }
}
