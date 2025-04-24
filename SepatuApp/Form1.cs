using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SepatuApp
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;database=sepatu_db;uid=root;pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSepatu.Columns.Add("Merk", "Merk");
            dgvSepatu.Columns.Add("Warna", "Warna");
            dgvSepatu.Columns.Add("Ukuran", "Ukuran");
            dgvSepatu.Columns.Add("Stok", "Stok");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Koneksi berhasil ke database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            dgvSepatu.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM sepatu";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvSepatu.Rows.Add(reader["merk"], reader["warna"], reader["ukuran"], reader["stok"]);
                }
            }
        }

        private void ClearForm()
        {
            txtMerk.Text = "";
            txtWarna.Text = "";
            txtUkuran.Text = "";
            txtStok.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtMerk.Text == "" || txtWarna.Text == "" || txtUkuran.Text == "" || txtStok.Text == "")
            {
                MessageBox.Show("Harap lengkapi semua data!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO sepatu (merk, warna, ukuran, stok) VALUES (@merk, @warna, @ukuran, @stok)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                cmd.Parameters.AddWithValue("@warna", txtWarna.Text);
                cmd.Parameters.AddWithValue("@ukuran", txtUkuran.Text);
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                cmd.ExecuteNonQuery();
            }

            LoadData();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSepatu.CurrentRow == null || dgvSepatu.CurrentRow.Index < 0)
            {
                MessageBox.Show("Pilih baris yang ingin diedit.");
                return;
            }

            string oldMerk = dgvSepatu.CurrentRow.Cells[0].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE sepatu SET merk=@merk, warna=@warna, ukuran=@ukuran, stok=@stok WHERE merk=@oldMerk";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                cmd.Parameters.AddWithValue("@warna", txtWarna.Text);
                cmd.Parameters.AddWithValue("@ukuran", txtUkuran.Text);
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@oldMerk", oldMerk);
                cmd.ExecuteNonQuery();
            }

            LoadData();
            ClearForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvSepatu.CurrentRow == null || dgvSepatu.CurrentRow.Index < 0)
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.");
                return;
            }

            string merkToDelete = dgvSepatu.CurrentRow.Cells[0].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM sepatu WHERE merk=@merk";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@merk", merkToDelete);
                cmd.ExecuteNonQuery();
            }

            LoadData();
            ClearForm();
        }

        private void dgvSepatu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMerk.Text = dgvSepatu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtWarna.Text = dgvSepatu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUkuran.Text = dgvSepatu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStok.Text = dgvSepatu.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
