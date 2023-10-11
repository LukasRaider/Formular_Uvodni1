namespace DU
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btEsc = new System.Windows.Forms.Button();
            this.cbBarva = new System.Windows.Forms.ComboBox();
            this.pbCas = new System.Windows.Forms.ProgressBar();
            this.tbObsah = new System.Windows.Forms.TextBox();
            this.cBdelsi = new System.Windows.Forms.CheckBox();
            this.cBvyssi = new System.Windows.Forms.CheckBox();
            this.cBhlubsi = new System.Windows.Forms.CheckBox();
            this.textBA = new System.Windows.Forms.TextBox();
            this.textBB = new System.Windows.Forms.TextBox();
            this.lSoucet = new System.Windows.Forms.Label();
            this.traBaNas = new System.Windows.Forms.TrackBar();
            this.lbS = new System.Windows.Forms.Label();
            this.BtPic = new System.Windows.Forms.Button();
            this.laSoucet = new System.Windows.Forms.Label();
            this.LbDelsi = new System.Windows.Forms.Label();
            this.lbvyssi = new System.Windows.Forms.Label();
            this.lbhlubsi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.traBaNas)).BeginInit();
            this.SuspendLayout();
            // 
            // btEsc
            // 
            this.btEsc.Location = new System.Drawing.Point(650, 218);
            this.btEsc.Name = "btEsc";
            this.btEsc.Size = new System.Drawing.Size(124, 75);
            this.btEsc.TabIndex = 0;
            this.btEsc.Text = "Esc = konec";
            this.btEsc.UseVisualStyleBackColor = true;
            this.btEsc.Click += new System.EventHandler(this.btEsc_Click);
            // 
            // cbBarva
            // 
            this.cbBarva.FormattingEnabled = true;
            this.cbBarva.Items.AddRange(new object[] {
            "hnědá",
            "červená",
            "fialová",
            "zelená",
            "modrá"});
            this.cbBarva.Location = new System.Drawing.Point(68, 205);
            this.cbBarva.Name = "cbBarva";
            this.cbBarva.Size = new System.Drawing.Size(222, 21);
            this.cbBarva.TabIndex = 1;
            this.cbBarva.SelectedIndexChanged += new System.EventHandler(this.cbBarva_SelectedIndexChanged);
            // 
            // pbCas
            // 
            this.pbCas.Location = new System.Drawing.Point(69, 320);
            this.pbCas.Name = "pbCas";
            this.pbCas.Size = new System.Drawing.Size(518, 43);
            this.pbCas.TabIndex = 2;
            // 
            // tbObsah
            // 
            this.tbObsah.Location = new System.Drawing.Point(429, 26);
            this.tbObsah.Name = "tbObsah";
            this.tbObsah.Size = new System.Drawing.Size(344, 20);
            this.tbObsah.TabIndex = 3;
            this.tbObsah.Text = "OBSAH SOUBORU\r\nToto je obsah souboru načtený tlačítkem Open.\r\nMá víc řádků a lze " +
    "ho pozměnit a opět uložit tlačítkem Save.";
            // 
            // cBdelsi
            // 
            this.cBdelsi.AutoSize = true;
            this.cBdelsi.Location = new System.Drawing.Point(360, 194);
            this.cBdelsi.Name = "cBdelsi";
            this.cBdelsi.Size = new System.Drawing.Size(49, 17);
            this.cBdelsi.TabIndex = 4;
            this.cBdelsi.Text = "delší";
            this.cBdelsi.UseVisualStyleBackColor = true;
            this.cBdelsi.CheckedChanged += new System.EventHandler(this.cBdelsi_CheckedChanged);
            // 
            // cBvyssi
            // 
            this.cBvyssi.AutoSize = true;
            this.cBvyssi.Location = new System.Drawing.Point(360, 218);
            this.cBvyssi.Name = "cBvyssi";
            this.cBvyssi.Size = new System.Drawing.Size(51, 17);
            this.cBvyssi.TabIndex = 5;
            this.cBvyssi.Text = "vyšší";
            this.cBvyssi.UseVisualStyleBackColor = true;
            this.cBvyssi.CheckedChanged += new System.EventHandler(this.cBvyssi_CheckedChanged);
            // 
            // cBhlubsi
            // 
            this.cBhlubsi.AutoSize = true;
            this.cBhlubsi.Location = new System.Drawing.Point(360, 241);
            this.cBhlubsi.Name = "cBhlubsi";
            this.cBhlubsi.Size = new System.Drawing.Size(55, 17);
            this.cBhlubsi.TabIndex = 6;
            this.cBhlubsi.Text = "hlubší";
            this.cBhlubsi.UseVisualStyleBackColor = true;
            this.cBhlubsi.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBA
            // 
            this.textBA.Location = new System.Drawing.Point(92, 66);
            this.textBA.Name = "textBA";
            this.textBA.Size = new System.Drawing.Size(47, 20);
            this.textBA.TabIndex = 7;
            this.textBA.TextChanged += new System.EventHandler(this.textBA_TextChanged);
            // 
            // textBB
            // 
            this.textBB.Location = new System.Drawing.Point(164, 66);
            this.textBB.Name = "textBB";
            this.textBB.Size = new System.Drawing.Size(44, 20);
            this.textBB.TabIndex = 8;
            // 
            // lSoucet
            // 
            this.lSoucet.AutoSize = true;
            this.lSoucet.Location = new System.Drawing.Point(92, 134);
            this.lSoucet.Name = "lSoucet";
            this.lSoucet.Size = new System.Drawing.Size(0, 13);
            this.lSoucet.TabIndex = 9;
            // 
            // traBaNas
            // 
            this.traBaNas.Location = new System.Drawing.Point(80, 123);
            this.traBaNas.Minimum = 1;
            this.traBaNas.Name = "traBaNas";
            this.traBaNas.Size = new System.Drawing.Size(197, 45);
            this.traBaNas.TabIndex = 10;
            this.traBaNas.Value = 1;
            this.traBaNas.Scroll += new System.EventHandler(this.traBaNas_Scroll);
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Location = new System.Drawing.Point(111, 178);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(135, 13);
            this.lbS.TabIndex = 11;
            this.lbS.Text = "Posuvníkem nastaveno:  1\r\n";
            this.lbS.Click += new System.EventHandler(this.lbS_Click);
            // 
            // BtPic
            // 
            this.BtPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtPic.BackgroundImage")));
            this.BtPic.Location = new System.Drawing.Point(657, 323);
            this.BtPic.Name = "BtPic";
            this.BtPic.Size = new System.Drawing.Size(115, 39);
            this.BtPic.TabIndex = 12;
            this.BtPic.UseVisualStyleBackColor = false;
            // 
            // laSoucet
            // 
            this.laSoucet.AutoSize = true;
            this.laSoucet.Location = new System.Drawing.Point(100, 107);
            this.laSoucet.Name = "laSoucet";
            this.laSoucet.Size = new System.Drawing.Size(47, 13);
            this.laSoucet.TabIndex = 13;
            this.laSoucet.Text = "Soucet: ";
            this.laSoucet.Click += new System.EventHandler(this.laSoucet_Click);
            // 
            // LbDelsi
            // 
            this.LbDelsi.AutoSize = true;
            this.LbDelsi.Location = new System.Drawing.Point(247, 278);
            this.LbDelsi.Name = "LbDelsi";
            this.LbDelsi.Size = new System.Drawing.Size(30, 13);
            this.LbDelsi.TabIndex = 14;
            this.LbDelsi.Text = "Delsi";
            this.LbDelsi.Visible = false;
            // 
            // lbvyssi
            // 
            this.lbvyssi.AutoSize = true;
            this.lbvyssi.Location = new System.Drawing.Point(292, 278);
            this.lbvyssi.Name = "lbvyssi";
            this.lbvyssi.Size = new System.Drawing.Size(30, 13);
            this.lbvyssi.TabIndex = 15;
            this.lbvyssi.Text = "vyssi";
            this.lbvyssi.Visible = false;
            // 
            // lbhlubsi
            // 
            this.lbhlubsi.AutoSize = true;
            this.lbhlubsi.Location = new System.Drawing.Point(348, 275);
            this.lbhlubsi.Name = "lbhlubsi";
            this.lbhlubsi.Size = new System.Drawing.Size(34, 13);
            this.lbhlubsi.TabIndex = 16;
            this.lbhlubsi.Text = "hlubsi";
            this.lbhlubsi.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtPic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbhlubsi);
            this.Controls.Add(this.lbvyssi);
            this.Controls.Add(this.LbDelsi);
            this.Controls.Add(this.laSoucet);
            this.Controls.Add(this.BtPic);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.traBaNas);
            this.Controls.Add(this.lSoucet);
            this.Controls.Add(this.textBB);
            this.Controls.Add(this.textBA);
            this.Controls.Add(this.cBhlubsi);
            this.Controls.Add(this.cBvyssi);
            this.Controls.Add(this.cBdelsi);
            this.Controls.Add(this.tbObsah);
            this.Controls.Add(this.pbCas);
            this.Controls.Add(this.cbBarva);
            this.Controls.Add(this.btEsc);
            this.Name = "Form1";
            this.Text = "4";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.traBaNas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEsc;
        private System.Windows.Forms.ComboBox cbBarva;
        private System.Windows.Forms.ProgressBar pbCas;
        private System.Windows.Forms.TextBox tbObsah;
        private System.Windows.Forms.CheckBox cBdelsi;
        private System.Windows.Forms.CheckBox cBvyssi;
        private System.Windows.Forms.CheckBox cBhlubsi;
        private System.Windows.Forms.TextBox textBA;
        private System.Windows.Forms.TextBox textBB;
        private System.Windows.Forms.Label lSoucet;
        private System.Windows.Forms.TrackBar traBaNas;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Button BtPic;
        private System.Windows.Forms.Label laSoucet;
        private System.Windows.Forms.Label LbDelsi;
        private System.Windows.Forms.Label lbvyssi;
        private System.Windows.Forms.Label lbhlubsi;
    }
}

