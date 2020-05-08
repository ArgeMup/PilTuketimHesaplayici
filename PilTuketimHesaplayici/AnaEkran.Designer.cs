namespace PilTuketimHesaplayici
{
    partial class AnaEkran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.PilKapasitesi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PilVerimliliği = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.d_Akım = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_Etkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_Durgun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_Tüketim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_Açıklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesaplamaSonucu_süre = new System.Windows.Forms.Label();
            this.İpucu = new System.Windows.Forms.ToolTip(this.components);
            this.Liste_İşler = new System.Windows.Forms.ComboBox();
            this.EkleGüncelle = new System.Windows.Forms.Button();
            this.HesaplamaSonucu_tüketim = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_aA = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_aA_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_125 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_150 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_175 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_200 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PilKapasitesi
            // 
            this.PilKapasitesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PilKapasitesi.Location = new System.Drawing.Point(125, 412);
            this.PilKapasitesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PilKapasitesi.Name = "PilKapasitesi";
            this.PilKapasitesi.Size = new System.Drawing.Size(201, 22);
            this.PilKapasitesi.TabIndex = 0;
            this.PilKapasitesi.Text = "1000 mA";
            this.İpucu.SetToolTip(this.PilKapasitesi, "X,Y A mA uA nA");
            this.PilKapasitesi.TextChanged += new System.EventHandler(this.PilKapasitesi_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pil Kapasitesi";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pil Verimi";
            // 
            // PilVerimliliği
            // 
            this.PilVerimliliği.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PilVerimliliği.Location = new System.Drawing.Point(125, 438);
            this.PilVerimliliği.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PilVerimliliği.Name = "PilVerimliliği";
            this.PilVerimliliği.Size = new System.Drawing.Size(201, 22);
            this.PilVerimliliği.TabIndex = 13;
            this.PilVerimliliği.Text = "80";
            this.İpucu.SetToolTip(this.PilVerimliliği, "yüzde %");
            this.PilVerimliliği.TextChanged += new System.EventHandler(this.PilKapasitesi_TextChanged);
            // 
            // Liste
            // 
            this.Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Liste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d_Akım,
            this.d_Etkin,
            this.d_Durgun,
            this.d_Tüketim,
            this.d_Açıklama});
            this.Liste.Location = new System.Drawing.Point(12, 35);
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 25;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.ShowRowErrors = false;
            this.Liste.Size = new System.Drawing.Size(680, 373);
            this.Liste.TabIndex = 30;
            this.Liste.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellValueChanged);
            // 
            // d_Akım
            // 
            this.d_Akım.HeaderText = "Akım";
            this.d_Akım.MinimumWidth = 6;
            this.d_Akım.Name = "d_Akım";
            this.d_Akım.ToolTipText = "X,Y A mA uA nA";
            this.d_Akım.Width = 67;
            // 
            // d_Etkin
            // 
            this.d_Etkin.HeaderText = "Etkin";
            this.d_Etkin.MinimumWidth = 6;
            this.d_Etkin.Name = "d_Etkin";
            this.d_Etkin.ToolTipText = "X,Y sa dk sn msn usn nsn";
            this.d_Etkin.Width = 68;
            // 
            // d_Durgun
            // 
            this.d_Durgun.HeaderText = "Durgun";
            this.d_Durgun.MinimumWidth = 6;
            this.d_Durgun.Name = "d_Durgun";
            this.d_Durgun.ToolTipText = "X,Y sa dk sn msn usn nsn";
            this.d_Durgun.Width = 84;
            // 
            // d_Tüketim
            // 
            this.d_Tüketim.HeaderText = "Tüketim";
            this.d_Tüketim.MinimumWidth = 6;
            this.d_Tüketim.Name = "d_Tüketim";
            this.d_Tüketim.ReadOnly = true;
            this.d_Tüketim.Width = 87;
            // 
            // d_Açıklama
            // 
            this.d_Açıklama.HeaderText = "Açıklama";
            this.d_Açıklama.MinimumWidth = 6;
            this.d_Açıklama.Name = "d_Açıklama";
            this.d_Açıklama.Width = 93;
            // 
            // HesaplamaSonucu_süre
            // 
            this.HesaplamaSonucu_süre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HesaplamaSonucu_süre.AutoSize = true;
            this.HesaplamaSonucu_süre.Location = new System.Drawing.Point(332, 441);
            this.HesaplamaSonucu_süre.Name = "HesaplamaSonucu_süre";
            this.HesaplamaSonucu_süre.Size = new System.Drawing.Size(115, 17);
            this.HesaplamaSonucu_süre.TabIndex = 34;
            this.HesaplamaSonucu_süre.Text = " ... süre çalışabiir";
            // 
            // Liste_İşler
            // 
            this.Liste_İşler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_İşler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Liste_İşler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Liste_İşler.FormattingEnabled = true;
            this.Liste_İşler.Location = new System.Drawing.Point(12, 6);
            this.Liste_İşler.Name = "Liste_İşler";
            this.Liste_İşler.Size = new System.Drawing.Size(588, 24);
            this.Liste_İşler.Sorted = true;
            this.Liste_İşler.TabIndex = 38;
            this.İpucu.SetToolTip(this.Liste_İşler, "Kayıtlı Tanımlar");
            this.Liste_İşler.SelectedIndexChanged += new System.EventHandler(this.Liste_İşler_SelectedIndexChanged);
            this.Liste_İşler.TextChanged += new System.EventHandler(this.Liste_İşler_TextChanged);
            // 
            // EkleGüncelle
            // 
            this.EkleGüncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EkleGüncelle.Location = new System.Drawing.Point(606, 6);
            this.EkleGüncelle.Name = "EkleGüncelle";
            this.EkleGüncelle.Size = new System.Drawing.Size(86, 24);
            this.EkleGüncelle.TabIndex = 37;
            this.EkleGüncelle.Text = "Güncelle";
            this.EkleGüncelle.UseVisualStyleBackColor = true;
            this.EkleGüncelle.Click += new System.EventHandler(this.EkleGüncelle_Click);
            // 
            // HesaplamaSonucu_tüketim
            // 
            this.HesaplamaSonucu_tüketim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HesaplamaSonucu_tüketim.AutoSize = true;
            this.HesaplamaSonucu_tüketim.Location = new System.Drawing.Point(332, 415);
            this.HesaplamaSonucu_tüketim.Name = "HesaplamaSonucu_tüketim";
            this.HesaplamaSonucu_tüketim.Size = new System.Drawing.Size(119, 17);
            this.HesaplamaSonucu_tüketim.TabIndex = 39;
            this.HesaplamaSonucu_tüketim.Text = " ... toplam tüketim";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.Menu_aA});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 31);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 29);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "mup.arge@gmail.com";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // Menu_aA
            // 
            this.Menu_aA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Menu_aA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_aA_100,
            this.Menu_aA_125,
            this.Menu_aA_150,
            this.Menu_aA_175,
            this.Menu_aA_200});
            this.Menu_aA.Image = ((System.Drawing.Image)(resources.GetObject("Menu_aA.Image")));
            this.Menu_aA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_aA.Name = "Menu_aA";
            this.Menu_aA.Size = new System.Drawing.Size(47, 29);
            this.Menu_aA.Text = "a..A";
            // 
            // Menu_aA_100
            // 
            this.Menu_aA_100.Name = "Menu_aA_100";
            this.Menu_aA_100.Size = new System.Drawing.Size(132, 26);
            this.Menu_aA_100.Text = "% 100";
            this.Menu_aA_100.Click += new System.EventHandler(this.Menu_aA_100_Click);
            // 
            // Menu_aA_125
            // 
            this.Menu_aA_125.Name = "Menu_aA_125";
            this.Menu_aA_125.Size = new System.Drawing.Size(132, 26);
            this.Menu_aA_125.Text = "% 125";
            this.Menu_aA_125.Click += new System.EventHandler(this.Menu_aA_125_Click);
            // 
            // Menu_aA_150
            // 
            this.Menu_aA_150.Name = "Menu_aA_150";
            this.Menu_aA_150.Size = new System.Drawing.Size(132, 26);
            this.Menu_aA_150.Text = "% 150";
            this.Menu_aA_150.Click += new System.EventHandler(this.Menu_aA_150_Click);
            // 
            // Menu_aA_175
            // 
            this.Menu_aA_175.Name = "Menu_aA_175";
            this.Menu_aA_175.Size = new System.Drawing.Size(132, 26);
            this.Menu_aA_175.Text = "% 175";
            this.Menu_aA_175.Click += new System.EventHandler(this.Menu_aA_175_Click);
            // 
            // Menu_aA_200
            // 
            this.Menu_aA_200.Name = "Menu_aA_200";
            this.Menu_aA_200.Size = new System.Drawing.Size(132, 26);
            this.Menu_aA_200.Text = "% 200";
            this.Menu_aA_200.Click += new System.EventHandler(this.Menu_aA_200_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 500);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.HesaplamaSonucu_tüketim);
            this.Controls.Add(this.Liste_İşler);
            this.Controls.Add(this.EkleGüncelle);
            this.Controls.Add(this.HesaplamaSonucu_süre);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PilVerimliliği);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PilKapasitesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnaEkran";
            this.Text = "ArgeMup Pil Tüketimi Hesaplayıcı";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PilKapasitesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PilVerimliliği;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label HesaplamaSonucu_süre;
        private System.Windows.Forms.ToolTip İpucu;
        private System.Windows.Forms.Button EkleGüncelle;
        private System.Windows.Forms.ComboBox Liste_İşler;
        private System.Windows.Forms.Label HesaplamaSonucu_tüketim;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_Akım;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_Etkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_Durgun;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_Tüketim;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_Açıklama;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton Menu_aA;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_100;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_125;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_150;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_175;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_200;
    }
}

