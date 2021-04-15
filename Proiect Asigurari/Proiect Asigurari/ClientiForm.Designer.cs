namespace Proiect_Asigurari
{
    partial class ClientiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientiForm));
            this.lvClienti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuExportTXT = new System.Windows.Forms.ToolStripButton();
            this.menuPrint = new System.Windows.Forms.ToolStripButton();
            this.menuExportCSV = new System.Windows.Forms.ToolStripButton();
            this.menuExportClienti = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatusNr = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btLBPop = new System.Windows.Forms.Button();
            this.btLBSterge = new System.Windows.Forms.Button();
            this.btLBTot = new System.Windows.Forms.Button();
            this.btLBsalveaza = new System.Windows.Forms.Button();
            this.btDataGRid = new System.Windows.Forms.Button();
            this.btLBEdit = new System.Windows.Forms.Button();
            this.epData = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSerieB = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSerieBuletin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.dtpNastere = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btPie = new System.Windows.Forms.Button();
            this.btTree = new System.Windows.Forms.Button();
            this.btAsigurare = new System.Windows.Forms.Button();
            this.btEditare = new System.Windows.Forms.Button();
            this.btStergeMultiple = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btAdauga = new System.Windows.Forms.Button();
            this.uc1 = new Proiect_Asigurari.UserControlClienti();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSerieB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            this.SuspendLayout();
            // 
            // lvClienti
            // 
            this.lvClienti.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvClienti.CheckBoxes = true;
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvClienti.HideSelection = false;
            this.lvClienti.Location = new System.Drawing.Point(233, 115);
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(508, 279);
            this.lvClienti.TabIndex = 14;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            this.lvClienti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvClienti_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Serie Buletin";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CNP";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefon";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data Nasterii";
            this.columnHeader7.Width = 108;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.serializareJSON});
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.serializareToolStripMenuItem.Text = "Serializare";
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.binarToolStripMenuItem.Text = "Binar";
            this.binarToolStripMenuItem.Click += new System.EventHandler(this.binarToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // serializareJSON
            // 
            this.serializareJSON.Name = "serializareJSON";
            this.serializareJSON.Size = new System.Drawing.Size(102, 22);
            this.serializareJSON.Text = "JSON";
            this.serializareJSON.Click += new System.EventHandler(this.serializareJSON_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem1,
            this.coleToolStripMenuItem,
            this.deserializareJSON});
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            // 
            // binarToolStripMenuItem1
            // 
            this.binarToolStripMenuItem1.Name = "binarToolStripMenuItem1";
            this.binarToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.binarToolStripMenuItem1.Text = "Binar";
            this.binarToolStripMenuItem1.Click += new System.EventHandler(this.binarToolStripMenuItem1_Click);
            // 
            // coleToolStripMenuItem
            // 
            this.coleToolStripMenuItem.Name = "coleToolStripMenuItem";
            this.coleToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.coleToolStripMenuItem.Text = "XML";
            this.coleToolStripMenuItem.Click += new System.EventHandler(this.coleToolStripMenuItem_Click);
            // 
            // deserializareJSON
            // 
            this.deserializareJSON.Name = "deserializareJSON";
            this.deserializareJSON.Size = new System.Drawing.Size(102, 22);
            this.deserializareJSON.Text = "JSON";
            this.deserializareJSON.Click += new System.EventHandler(this.deserializareJSON_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExportTXT,
            this.menuPrint,
            this.menuExportCSV,
            this.menuExportClienti});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuExportTXT
            // 
            this.menuExportTXT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuExportTXT.Image = global::Proiect_Asigurari.Properties.Resources.txt;
            this.menuExportTXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuExportTXT.Name = "menuExportTXT";
            this.menuExportTXT.Size = new System.Drawing.Size(23, 22);
            this.menuExportTXT.Text = "Export TXT ALL";
            this.menuExportTXT.Click += new System.EventHandler(this.toolStripBtExportTXT_Click);
            // 
            // menuPrint
            // 
            this.menuPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuPrint.Image = global::Proiect_Asigurari.Properties.Resources.print;
            this.menuPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(23, 22);
            this.menuPrint.Text = "Print";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // menuExportCSV
            // 
            this.menuExportCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuExportCSV.Image = global::Proiect_Asigurari.Properties.Resources.csv;
            this.menuExportCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuExportCSV.Name = "menuExportCSV";
            this.menuExportCSV.Size = new System.Drawing.Size(23, 22);
            this.menuExportCSV.Text = "Export CSV All";
            this.menuExportCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuExportCSV.Click += new System.EventHandler(this.menuExportCSV_Click);
            // 
            // menuExportClienti
            // 
            this.menuExportClienti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuExportClienti.Image = ((System.Drawing.Image)(resources.GetObject("menuExportClienti.Image")));
            this.menuExportClienti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuExportClienti.Name = "menuExportClienti";
            this.menuExportClienti.Size = new System.Drawing.Size(23, 22);
            this.menuExportClienti.Text = "Export Clienti TXT";
            this.menuExportClienti.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusNr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatusNr
            // 
            this.toolStatusNr.Name = "toolStatusNr";
            this.toolStatusNr.Size = new System.Drawing.Size(93, 17);
            this.toolStatusNr.Text = "Numar Clienti: 0";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(932, 273);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 25;
            // 
            // btLBPop
            // 
            this.btLBPop.Location = new System.Drawing.Point(784, 273);
            this.btLBPop.Name = "btLBPop";
            this.btLBPop.Size = new System.Drawing.Size(75, 23);
            this.btLBPop.TabIndex = 26;
            this.btLBPop.Text = "Populare";
            this.btLBPop.UseVisualStyleBackColor = true;
            this.btLBPop.Click += new System.EventHandler(this.btLBPop_Click);
            // 
            // btLBSterge
            // 
            this.btLBSterge.Location = new System.Drawing.Point(784, 308);
            this.btLBSterge.Name = "btLBSterge";
            this.btLBSterge.Size = new System.Drawing.Size(75, 23);
            this.btLBSterge.TabIndex = 27;
            this.btLBSterge.Text = "Sterge";
            this.btLBSterge.UseVisualStyleBackColor = true;
            this.btLBSterge.Click += new System.EventHandler(this.btLBSterge_Click);
            // 
            // btLBTot
            // 
            this.btLBTot.Location = new System.Drawing.Point(784, 337);
            this.btLBTot.Name = "btLBTot";
            this.btLBTot.Size = new System.Drawing.Size(75, 23);
            this.btLBTot.TabIndex = 28;
            this.btLBTot.Text = "Sterge Tot";
            this.btLBTot.UseVisualStyleBackColor = true;
            // 
            // btLBsalveaza
            // 
            this.btLBsalveaza.Location = new System.Drawing.Point(784, 370);
            this.btLBsalveaza.Name = "btLBsalveaza";
            this.btLBsalveaza.Size = new System.Drawing.Size(75, 23);
            this.btLBsalveaza.TabIndex = 29;
            this.btLBsalveaza.Text = "Salveaza";
            this.btLBsalveaza.UseVisualStyleBackColor = true;
            this.btLBsalveaza.Click += new System.EventHandler(this.btLBsalveaza_Click);
            // 
            // btDataGRid
            // 
            this.btDataGRid.Location = new System.Drawing.Point(906, 438);
            this.btDataGRid.Name = "btDataGRid";
            this.btDataGRid.Size = new System.Drawing.Size(129, 57);
            this.btDataGRid.TabIndex = 30;
            this.btDataGRid.Text = "Data Grid View";
            this.btDataGRid.UseVisualStyleBackColor = true;
            this.btDataGRid.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLBEdit
            // 
            this.btLBEdit.Location = new System.Drawing.Point(784, 400);
            this.btLBEdit.Name = "btLBEdit";
            this.btLBEdit.Size = new System.Drawing.Size(75, 23);
            this.btLBEdit.TabIndex = 31;
            this.btLBEdit.Text = "Editeaza";
            this.btLBEdit.UseVisualStyleBackColor = true;
            this.btLBEdit.Click += new System.EventHandler(this.btLBEdit_Click);
            // 
            // epData
            // 
            this.epData.ContainerControl = this;
            // 
            // epTelefon
            // 
            this.epTelefon.ContainerControl = this;
            // 
            // epCNP
            // 
            this.epCNP.ContainerControl = this;
            // 
            // epSerieB
            // 
            this.epSerieB.ContainerControl = this;
            // 
            // epAdresa
            // 
            this.epAdresa.ContainerControl = this;
            // 
            // epPrenume
            // 
            this.epPrenume.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume";
            // 
            // tbPrenume
            // 
            this.tbPrenume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrenume.Location = new System.Drawing.Point(11, 157);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(187, 20);
            this.tbPrenume.TabIndex = 3;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbAdresa.Location = new System.Drawing.Point(11, 201);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(187, 20);
            this.tbAdresa.TabIndex = 5;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            this.tbAdresa.Validated += new System.EventHandler(this.tbAdresa_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Serie Buletin";
            // 
            // tbSerieBuletin
            // 
            this.tbSerieBuletin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSerieBuletin.Location = new System.Drawing.Point(11, 244);
            this.tbSerieBuletin.Name = "tbSerieBuletin";
            this.tbSerieBuletin.Size = new System.Drawing.Size(187, 20);
            this.tbSerieBuletin.TabIndex = 7;
            this.tbSerieBuletin.Validating += new System.ComponentModel.CancelEventHandler(this.tbSerieBuletin_Validating);
            this.tbSerieBuletin.Validated += new System.EventHandler(this.tbSerieBuletin_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CNP";
            // 
            // tbCNP
            // 
            this.tbCNP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCNP.Location = new System.Drawing.Point(10, 286);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(188, 20);
            this.tbCNP.TabIndex = 9;
            this.tbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNP_Validating);
            this.tbCNP.Validated += new System.EventHandler(this.tbCNP_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefon";
            // 
            // tbTelefon
            // 
            this.tbTelefon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTelefon.Location = new System.Drawing.Point(10, 330);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(188, 20);
            this.tbTelefon.TabIndex = 11;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // dtpNastere
            // 
            this.dtpNastere.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpNastere.Checked = false;
            this.dtpNastere.CustomFormat = "dd.MM.yyyy";
            this.dtpNastere.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNastere.Location = new System.Drawing.Point(10, 374);
            this.dtpNastere.Name = "dtpNastere";
            this.dtpNastere.Size = new System.Drawing.Size(188, 20);
            this.dtpNastere.TabIndex = 12;
            this.dtpNastere.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNastere_Validating);
            this.dtpNastere.Validated += new System.EventHandler(this.dtpNastere_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data Nasterii";
            // 
            // btPie
            // 
            this.btPie.Image = global::Proiect_Asigurari.Properties.Resources.pie1;
            this.btPie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPie.Location = new System.Drawing.Point(747, 178);
            this.btPie.Name = "btPie";
            this.btPie.Size = new System.Drawing.Size(129, 62);
            this.btPie.TabIndex = 24;
            this.btPie.Text = "Afisare Pie";
            this.btPie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPie.UseVisualStyleBackColor = true;
            this.btPie.Click += new System.EventHandler(this.btPie_Click);
            // 
            // btTree
            // 
            this.btTree.Image = global::Proiect_Asigurari.Properties.Resources.tree2;
            this.btTree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTree.Location = new System.Drawing.Point(747, 115);
            this.btTree.Name = "btTree";
            this.btTree.Size = new System.Drawing.Size(129, 62);
            this.btTree.TabIndex = 23;
            this.btTree.Text = "Afisare TreeView";
            this.btTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTree.UseVisualStyleBackColor = true;
            this.btTree.Click += new System.EventHandler(this.btTree_Click);
            // 
            // btAsigurare
            // 
            this.btAsigurare.Image = global::Proiect_Asigurari.Properties.Resources.Add_Folder_icon;
            this.btAsigurare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAsigurare.Location = new System.Drawing.Point(289, 407);
            this.btAsigurare.Name = "btAsigurare";
            this.btAsigurare.Size = new System.Drawing.Size(193, 69);
            this.btAsigurare.TabIndex = 19;
            this.btAsigurare.Text = "Adauga Asigurare";
            this.btAsigurare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAsigurare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAsigurare.UseVisualStyleBackColor = true;
            this.btAsigurare.Click += new System.EventHandler(this.btAsigurare_Click);
            // 
            // btEditare
            // 
            this.btEditare.Image = global::Proiect_Asigurari.Properties.Resources.edit24px;
            this.btEditare.Location = new System.Drawing.Point(631, 421);
            this.btEditare.Name = "btEditare";
            this.btEditare.Size = new System.Drawing.Size(120, 40);
            this.btEditare.TabIndex = 18;
            this.btEditare.Text = "Editare";
            this.btEditare.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btEditare.UseVisualStyleBackColor = true;
            this.btEditare.Click += new System.EventHandler(this.btEditare_Click);
            // 
            // btStergeMultiple
            // 
            this.btStergeMultiple.Image = global::Proiect_Asigurari.Properties.Resources.delete24px;
            this.btStergeMultiple.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btStergeMultiple.Location = new System.Drawing.Point(492, 421);
            this.btStergeMultiple.Name = "btStergeMultiple";
            this.btStergeMultiple.Size = new System.Drawing.Size(121, 40);
            this.btStergeMultiple.TabIndex = 17;
            this.btStergeMultiple.Text = "Sterge Inregistrari";
            this.btStergeMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStergeMultiple.UseVisualStyleBackColor = true;
            this.btStergeMultiple.Click += new System.EventHandler(this.btStergeMultiple_Click);
            // 
            // btCurata
            // 
            this.btCurata.Image = global::Proiect_Asigurari.Properties.Resources.clear24px;
            this.btCurata.Location = new System.Drawing.Point(153, 421);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(121, 40);
            this.btCurata.TabIndex = 16;
            this.btCurata.Text = "Curata";
            this.btCurata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btAdauga
            // 
            this.btAdauga.Image = global::Proiect_Asigurari.Properties.Resources.addClient16px;
            this.btAdauga.Location = new System.Drawing.Point(11, 421);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(121, 40);
            this.btAdauga.TabIndex = 15;
            this.btAdauga.Text = "Adauga";
            this.btAdauga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // uc1
            // 
            this.uc1.Location = new System.Drawing.Point(10, 97);
            this.uc1.Name = "uc1";
            this.uc1.Size = new System.Drawing.Size(217, 40);
            this.uc1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Clienti";
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1072, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc1);
            this.Controls.Add(this.btLBEdit);
            this.Controls.Add(this.btDataGRid);
            this.Controls.Add(this.btLBsalveaza);
            this.Controls.Add(this.btLBTot);
            this.Controls.Add(this.btLBSterge);
            this.Controls.Add(this.btLBPop);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btPie);
            this.Controls.Add(this.btTree);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btAsigurare);
            this.Controls.Add(this.btEditare);
            this.Controls.Add(this.btStergeMultiple);
            this.Controls.Add(this.btCurata);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.lvClienti);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientiForm";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.ClientiForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientiForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSerieB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btStergeMultiple;
        private System.Windows.Forms.Button btEditare;
        private System.Windows.Forms.Button btAsigurare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareJSON;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem coleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareJSON;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuExportTXT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusNr;
        private System.Windows.Forms.ToolStripButton menuPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Button btTree;
        private System.Windows.Forms.Button btPie;
        private System.Windows.Forms.ToolStripButton menuExportCSV;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btLBPop;
        private System.Windows.Forms.Button btLBSterge;
        private System.Windows.Forms.Button btLBTot;
        private System.Windows.Forms.Button btLBsalveaza;
        private System.Windows.Forms.Button btDataGRid;
        private System.Windows.Forms.Button btLBEdit;
        private System.Windows.Forms.ErrorProvider epData;
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
        private System.Windows.Forms.ErrorProvider epTelefon;
        private System.Windows.Forms.ErrorProvider epCNP;
        private System.Windows.Forms.ErrorProvider epSerieB;
        private System.Windows.Forms.ErrorProvider epAdresa;
        private System.Windows.Forms.ErrorProvider epPrenume;
        private UserControlClienti uc1;
        private System.Windows.Forms.ToolStripButton menuExportClienti;
        private System.Windows.Forms.Label label1;
    }
}

