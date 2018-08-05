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
    public partial class DataBarang : KryptonForm
    {
        public DataBarang()
        {
            InitializeComponent();
        }

        private void DataBarang_Load(object sender, EventArgs e)
        {
            MySqlClass sql = new MySqlClass();
            string query = "SELECT * FROM tb_barang";

            DataTable dt = sql.GetData(query);

            var provider = new System.Globalization.CultureInfo("id-ID");

            DataBarangGrid.DataSource = dt;
            DataBarangGrid.Columns[0].HeaderText = "Kode Barang";
            DataBarangGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataBarangGrid.Columns[1].HeaderText = "Nama Barang";
            DataBarangGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataBarangGrid.Columns[2].HeaderText = "Jenis Barang";
            DataBarangGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataBarangGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataBarangGrid.Columns[3].DefaultCellStyle.FormatProvider = provider;
            DataBarangGrid.Columns[3].DefaultCellStyle.Format = "C";
            DataBarangGrid.Columns[3].HeaderText = "Harga Barang";
            DataBarangGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataBarangGrid.Columns[4].HeaderText = "Satuan";
            DataBarangGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataBarangGrid.Columns[5].HeaderText = "Stok";
        }
    }
}
