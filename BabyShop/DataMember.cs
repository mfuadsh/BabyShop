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
    public partial class DataMember : KryptonForm
    {
        public DataMember()
        {
            InitializeComponent();
        }

        private void DataMember_Load(object sender, EventArgs e)
        {
            MySqlClass sql = new MySqlClass();
            string query = "SELECT * FROM tb_member";

            DataTable dt = sql.GetData(query);

            DataMemberGrid.DataSource = dt;
            DataMemberGrid.Columns[0].HeaderText = "Kode Member";
            DataMemberGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataMemberGrid.Columns[1].HeaderText = "Nama Lengkap";
            DataMemberGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataMemberGrid.Columns[2].HeaderText = "Jenis Kelamin";
            DataMemberGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataMemberGrid.Columns[3].HeaderText = "Nomor HP";
            DataMemberGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataMemberGrid.Columns[4].HeaderText = "Alamat";
            DataMemberGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataMemberGrid.Columns[5].HeaderText = "Foto";
            DataMemberGrid.Columns[5].Visible = false;
        }
    }
}
