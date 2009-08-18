namespace Kalibrasi
{
    partial class mdiKalibrasi
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepartemen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLokasi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPIC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJadwal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKalibrasi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLengkap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDaftarInduk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserBaru = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUbahPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGantiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKeluar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaster,
            this.mnuTransaksi,
            this.mnuLaporan,
            this.mnuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMaster
            // 
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlat,
            this.mnuDepartemen,
            this.mnuLokasi,
            this.mnuPIC});
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(52, 20);
            this.mnuMaster.Text = "Master";
            // 
            // mnuAlat
            // 
            this.mnuAlat.Name = "mnuAlat";
            this.mnuAlat.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAlat.Size = new System.Drawing.Size(163, 22);
            this.mnuAlat.Text = "Alat";
            this.mnuAlat.Click += new System.EventHandler(this.mnuAlat_Click);
            // 
            // mnuDepartemen
            // 
            this.mnuDepartemen.Name = "mnuDepartemen";
            this.mnuDepartemen.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuDepartemen.Size = new System.Drawing.Size(163, 22);
            this.mnuDepartemen.Text = "Departemen";
            this.mnuDepartemen.Click += new System.EventHandler(this.mnuDepartemen_Click);
            // 
            // mnuLokasi
            // 
            this.mnuLokasi.Name = "mnuLokasi";
            this.mnuLokasi.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuLokasi.Size = new System.Drawing.Size(163, 22);
            this.mnuLokasi.Text = "Lokasi";
            // 
            // mnuPIC
            // 
            this.mnuPIC.Name = "mnuPIC";
            this.mnuPIC.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuPIC.Size = new System.Drawing.Size(163, 22);
            this.mnuPIC.Text = "PIC";
            // 
            // mnuTransaksi
            // 
            this.mnuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuJadwal});
            this.mnuTransaksi.Name = "mnuTransaksi";
            this.mnuTransaksi.Size = new System.Drawing.Size(64, 20);
            this.mnuTransaksi.Text = "Transaksi";
            // 
            // mnuJadwal
            // 
            this.mnuJadwal.Name = "mnuJadwal";
            this.mnuJadwal.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuJadwal.Size = new System.Drawing.Size(137, 22);
            this.mnuJadwal.Text = "Jadwal";
            // 
            // mnuLaporan
            // 
            this.mnuLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKalibrasi,
            this.mnuLengkap,
            this.mnuDaftarInduk});
            this.mnuLaporan.Name = "mnuLaporan";
            this.mnuLaporan.Size = new System.Drawing.Size(58, 20);
            this.mnuLaporan.Text = "Laporan";
            // 
            // mnuKalibrasi
            // 
            this.mnuKalibrasi.Name = "mnuKalibrasi";
            this.mnuKalibrasi.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuKalibrasi.Size = new System.Drawing.Size(227, 22);
            this.mnuKalibrasi.Text = "Alat Yang Akan Dikalibrasi";
            // 
            // mnuLengkap
            // 
            this.mnuLengkap.Name = "mnuLengkap";
            this.mnuLengkap.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mnuLengkap.Size = new System.Drawing.Size(227, 22);
            this.mnuLengkap.Text = "Lengkap Kalibrasi";
            // 
            // mnuDaftarInduk
            // 
            this.mnuDaftarInduk.Name = "mnuDaftarInduk";
            this.mnuDaftarInduk.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.mnuDaftarInduk.Size = new System.Drawing.Size(227, 22);
            this.mnuDaftarInduk.Text = "Daftar Induk";
            this.mnuDaftarInduk.Click += new System.EventHandler(this.mnuDaftarInduk_Click);
            // 
            // mnuUtility
            // 
            this.mnuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserBaru,
            this.mnuUbahPassword,
            this.mnuGantiUser,
            this.mnuKeluar});
            this.mnuUtility.Name = "mnuUtility";
            this.mnuUtility.Size = new System.Drawing.Size(46, 20);
            this.mnuUtility.Text = "Utility";
            // 
            // mnuUserBaru
            // 
            this.mnuUserBaru.Name = "mnuUserBaru";
            this.mnuUserBaru.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mnuUserBaru.Size = new System.Drawing.Size(192, 22);
            this.mnuUserBaru.Text = "Tambah User Baru";
            // 
            // mnuUbahPassword
            // 
            this.mnuUbahPassword.Name = "mnuUbahPassword";
            this.mnuUbahPassword.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuUbahPassword.Size = new System.Drawing.Size(192, 22);
            this.mnuUbahPassword.Text = "Ubah Password";
            // 
            // mnuGantiUser
            // 
            this.mnuGantiUser.Name = "mnuGantiUser";
            this.mnuGantiUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuGantiUser.Size = new System.Drawing.Size(192, 22);
            this.mnuGantiUser.Text = "Ganti User";
            this.mnuGantiUser.Click += new System.EventHandler(this.mnuGantiUser_Click);
            // 
            // mnuKeluar
            // 
            this.mnuKeluar.Name = "mnuKeluar";
            this.mnuKeluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuKeluar.Size = new System.Drawing.Size(192, 22);
            this.mnuKeluar.Text = "Keluar";
            this.mnuKeluar.Click += new System.EventHandler(this.mnuKeluar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 548);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(237, 22);
            this.toolStripLabel2.Text = "PT. NOVELL PHARMACEUTICAL LABORATORIES";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mdiKalibrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdiKalibrasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calibration Schedule System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiKalibrasi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMaster;
        private System.Windows.Forms.ToolStripMenuItem mnuAlat;
        private System.Windows.Forms.ToolStripMenuItem mnuDepartemen;
        private System.Windows.Forms.ToolStripMenuItem mnuLokasi;
        private System.Windows.Forms.ToolStripMenuItem mnuPIC;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksi;
        private System.Windows.Forms.ToolStripMenuItem mnuJadwal;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporan;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuKalibrasi;
        private System.Windows.Forms.ToolStripMenuItem mnuLengkap;
        private System.Windows.Forms.ToolStripMenuItem mnuDaftarInduk;
        private System.Windows.Forms.ToolStripMenuItem mnuUserBaru;
        private System.Windows.Forms.ToolStripMenuItem mnuUbahPassword;
        private System.Windows.Forms.ToolStripMenuItem mnuGantiUser;
        private System.Windows.Forms.ToolStripMenuItem mnuKeluar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Timer timer1;

    }
}

