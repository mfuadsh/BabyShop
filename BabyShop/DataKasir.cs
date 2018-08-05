using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace BabyShop
{
    public partial class DataKasir : KryptonForm
    {
        public DataKasir()
        {
            InitializeComponent();
        }

        private void InputKasir_Load(object sender, EventArgs e)
        {
            MySqlClass sql = new MySqlClass();
            string query = "SELECT * FROM tb_kasir";

            DataTable dt = sql.GetData(query);

            DataKasirGrid.DataSource = dt;
            DataKasirGrid.Columns[0].HeaderText = "Kode Kasir";
            DataKasirGrid.Columns[0].Visible = false;
            DataKasirGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataKasirGrid.Columns[1].HeaderText = "Username";
            DataKasirGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataKasirGrid.Columns[2].Visible = false;
            DataKasirGrid.Columns[2].HeaderText = "Password";
            DataKasirGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataKasirGrid.Columns[3].HeaderText = "Nama Kasir";
            DataKasirGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataKasirGrid.Columns[4].HeaderText = "Jenis Kelamin";
            DataKasirGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataKasirGrid.Columns[5].HeaderText = "Nomor HP";
            DataKasirGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataKasirGrid.Columns[6].HeaderText = "Alamat";
            DataKasirGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
