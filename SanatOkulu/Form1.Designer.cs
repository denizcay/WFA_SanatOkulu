
namespace SanatOkulu
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
            }
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.pboYeniSanatci = new System.Windows.Forms.PictureBox();
            this.pboResim = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.mtbYil = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSanatci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lvwEserler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSanatcilar = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            this.cboGorunum = new System.Windows.Forms.ComboBox();
            this.cmsEserler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tsmiResmiYeniPenceredeAc = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYeniSanatci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.cmsEserler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.pboYeniSanatci);
            this.groupBox1.Controls.Add(this.pboResim);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.mtbYil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboSanatci);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sanat Eseri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Resim Eklemek Icin Tiklayin)";
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(87, 458);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(81, 32);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "IPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // pboYeniSanatci
            // 
            this.pboYeniSanatci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboYeniSanatci.Image = global::SanatOkulu.Properties.Resources.plus;
            this.pboYeniSanatci.Location = new System.Drawing.Point(252, 358);
            this.pboYeniSanatci.Name = "pboYeniSanatci";
            this.pboYeniSanatci.Size = new System.Drawing.Size(28, 28);
            this.pboYeniSanatci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboYeniSanatci.TabIndex = 7;
            this.pboYeniSanatci.TabStop = false;
            this.pboYeniSanatci.Click += new System.EventHandler(this.pboYeniSanatci_Click);
            // 
            // pboResim
            // 
            this.pboResim.BackColor = System.Drawing.Color.Silver;
            this.pboResim.Location = new System.Drawing.Point(4, 29);
            this.pboResim.Name = "pboResim";
            this.pboResim.Size = new System.Drawing.Size(272, 217);
            this.pboResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboResim.TabIndex = 4;
            this.pboResim.TabStop = false;
            this.pboResim.Click += new System.EventHandler(this.pboResim_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(174, 458);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 32);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mtbYil
            // 
            this.mtbYil.HidePromptOnLeave = true;
            this.mtbYil.Location = new System.Drawing.Point(14, 422);
            this.mtbYil.Mask = "####";
            this.mtbYil.Name = "mtbYil";
            this.mtbYil.Size = new System.Drawing.Size(104, 30);
            this.mtbYil.TabIndex = 5;
            this.mtbYil.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yapıldığı Yıl";
            // 
            // cboSanatci
            // 
            this.cboSanatci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanatci.FormattingEnabled = true;
            this.cboSanatci.Location = new System.Drawing.Point(8, 358);
            this.cboSanatci.Name = "cboSanatci";
            this.cboSanatci.Size = new System.Drawing.Size(238, 33);
            this.cboSanatci.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sanatçısı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(4, 297);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(272, 30);
            this.txtAd.TabIndex = 1;
            // 
            // lvwEserler
            // 
            this.lvwEserler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwEserler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwEserler.ContextMenuStrip = this.cmsEserler;
            this.lvwEserler.FullRowSelect = true;
            this.lvwEserler.HideSelection = false;
            this.lvwEserler.Location = new System.Drawing.Point(298, 83);
            this.lvwEserler.Name = "lvwEserler";
            this.lvwEserler.Size = new System.Drawing.Size(570, 448);
            this.lvwEserler.TabIndex = 2;
            this.lvwEserler.UseCompatibleStateImageBehavior = false;
            this.lvwEserler.View = System.Windows.Forms.View.Details;
            this.lvwEserler.SelectedIndexChanged += new System.EventHandler(this.lvwEserler_SelectedIndexChanged);
            this.lvwEserler.DoubleClick += new System.EventHandler(this.lvwEserler_DoubleClick);
            this.lvwEserler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwEserler_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sanatçı";
            this.columnHeader2.Width = 236;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yıl";
            this.columnHeader3.Width = 129;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSanatcilar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSanatcilar
            // 
            this.tsmiSanatcilar.Name = "tsmiSanatcilar";
            this.tsmiSanatcilar.Size = new System.Drawing.Size(88, 24);
            this.tsmiSanatcilar.Text = "Sanatçılar";
            this.tsmiSanatcilar.Click += new System.EventHandler(this.tsmiSanatcilar_Click);
            // 
            // cboGorunum
            // 
            this.cboGorunum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGorunum.FormattingEnabled = true;
            this.cboGorunum.Items.AddRange(new object[] {
            "Büyük Simgeler",
            "Küçük Simgeler",
            "Listele ",
            "Ayrıntılar",
            "Döşemeler"});
            this.cboGorunum.Location = new System.Drawing.Point(730, 44);
            this.cboGorunum.Name = "cboGorunum";
            this.cboGorunum.Size = new System.Drawing.Size(138, 33);
            this.cboGorunum.TabIndex = 4;
            this.cboGorunum.SelectedIndexChanged += new System.EventHandler(this.cboGorunum_SelectedIndexChanged);
            // 
            // cmsEserler
            // 
            this.cmsEserler.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEserler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiResmiYeniPenceredeAc});
            this.cmsEserler.Name = "cmsEserler";
            this.cmsEserler.Size = new System.Drawing.Size(243, 56);
            this.cmsEserler.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEserler_Opening);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Görünüm";
            // 
            // tsmiResmiYeniPenceredeAc
            // 
            this.tsmiResmiYeniPenceredeAc.Name = "tsmiResmiYeniPenceredeAc";
            this.tsmiResmiYeniPenceredeAc.Size = new System.Drawing.Size(242, 24);
            this.tsmiResmiYeniPenceredeAc.Text = "Resmi Yeni Pencerede Ac";
            this.tsmiResmiYeniPenceredeAc.Click += new System.EventHandler(this.tsmiResmiYeniPenceredeAc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 555);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboGorunum);
            this.Controls.Add(this.lvwEserler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sanat Okulu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYeniSanatci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsEserler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSanatci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mtbYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboYeniSanatci;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lvwEserler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanatcilar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.PictureBox pboResim;
        private System.Windows.Forms.OpenFileDialog ofdResim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGorunum;
        private System.Windows.Forms.ContextMenuStrip cmsEserler;
        private System.Windows.Forms.ToolStripMenuItem tsmiResmiYeniPenceredeAc;
        private System.Windows.Forms.Label label5;
    }
}

