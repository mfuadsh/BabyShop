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
    public partial class FormLogin : KryptonForm
    {
        public Point MouseLocation;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Point MOusePose = Control.MousePosition;
                MOusePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = MOusePose;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
