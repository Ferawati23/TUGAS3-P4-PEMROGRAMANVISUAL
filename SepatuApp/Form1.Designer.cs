namespace SepatuApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.TextBox txtUkuran;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvSepatu;

        private System.Windows.Forms.Label lblMerk;
        private System.Windows.Forms.Label lblWarna;
        private System.Windows.Forms.Label lblUkuran;
        private System.Windows.Forms.Label lblStok;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.txtUkuran = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvSepatu = new System.Windows.Forms.DataGridView();

            this.lblMerk = new System.Windows.Forms.Label();
            this.lblWarna = new System.Windows.Forms.Label();
            this.lblUkuran = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSepatu)).BeginInit();
            this.SuspendLayout();

            // Label Merk
            this.lblMerk.AutoSize = true;
            this.lblMerk.Text = "Merk Sepatu";
            this.lblMerk.Location = new System.Drawing.Point(30, 10);

            // Label Warna
            this.lblWarna.AutoSize = true;
            this.lblWarna.Text = "Warna";
            this.lblWarna.Location = new System.Drawing.Point(30, 55);

            // Label Ukuran
            this.lblUkuran.AutoSize = true;
            this.lblUkuran.Text = "Ukuran";
            this.lblUkuran.Location = new System.Drawing.Point(30, 100);

            // Label Stok
            this.lblStok.AutoSize = true;
            this.lblStok.Text = "Stok";
            this.lblStok.Location = new System.Drawing.Point(30, 145);

            // TextBox Merk
            this.txtMerk.Location = new System.Drawing.Point(30, 30);
            this.txtMerk.Size = new System.Drawing.Size(150, 22);

            // TextBox Warna
            this.txtWarna.Location = new System.Drawing.Point(30, 75);
            this.txtWarna.Size = new System.Drawing.Size(150, 22);

            // TextBox Ukuran
            this.txtUkuran.Location = new System.Drawing.Point(30, 120);
            this.txtUkuran.Size = new System.Drawing.Size(150, 22);

            // TextBox Stok
            this.txtStok.Location = new System.Drawing.Point(30, 165);
            this.txtStok.Size = new System.Drawing.Size(150, 22);

            // Button Tambah
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Location = new System.Drawing.Point(200, 30);
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // Button Edit
            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(200, 70);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // Button Hapus
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Location = new System.Drawing.Point(200, 110);
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // DataGridView Sepatu
            this.dgvSepatu.Location = new System.Drawing.Point(30, 210);
            this.dgvSepatu.Size = new System.Drawing.Size(500, 200);
            this.dgvSepatu.AllowUserToAddRows = false;
            this.dgvSepatu.RowHeadersVisible = false;
            this.dgvSepatu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSepatu.MultiSelect = false;
            this.dgvSepatu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepatu_CellClick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.lblMerk);
            this.Controls.Add(this.lblWarna);
            this.Controls.Add(this.lblUkuran);
            this.Controls.Add(this.lblStok);

            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.txtWarna);
            this.Controls.Add(this.txtUkuran);
            this.Controls.Add(this.txtStok);

            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);

            this.Controls.Add(this.dgvSepatu);
            this.Text = "Aplikasi Data Sepatu";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvSepatu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
