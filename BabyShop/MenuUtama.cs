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
using ComponentFactory.Krypton.Navigator;

namespace BabyShop
{
    public partial class MenuUtama : KryptonForm
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void btnlblDataBarang_MouseClick(object sender, MouseEventArgs e)
        {
            int index = tabcontrolkrypton.Pages.Count;
            DataBarang frm = new DataBarang();
            
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            KryptonPage kp = new KryptonPage("Data Barang");
            tabcontrolkrypton.Pages.Add(kp);
            tabcontrolkrypton.Pages[index].Controls.Add(frm);
            tabcontrolkrypton.SelectedIndex = index;
            
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            panelcalculator.Visible = false;
            this.MaximizeBox = false;
        }

        private void btnlblCalculator_MouseClick(object sender, MouseEventArgs e)
        {
            panelcalculator.Visible = true;
        }

        private void kryptonLabel4_MouseClick(object sender, MouseEventArgs e)
        {
            panelcalculator.Visible = false;
        }

        private void kryptonRibbonGroupButton2_Click(object sender, EventArgs e)
        {
            int index = tabcontrolkrypton.Pages.Count;
            DataKasir frm = new DataKasir();
            
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            KryptonPage kp = new KryptonPage("Data Kasir");
            tabcontrolkrypton.Pages.Add(kp);
            tabcontrolkrypton.Pages[index].Controls.Add(frm);
            tabcontrolkrypton.SelectedIndex = index;
        }

        private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
        {
            int index = tabcontrolkrypton.Pages.Count;
            DataMember frm = new DataMember();

            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            KryptonPage kp = new KryptonPage("Data Member");
            tabcontrolkrypton.Pages.Add(kp);
            tabcontrolkrypton.Pages[index].Controls.Add(frm);
            tabcontrolkrypton.SelectedIndex = index;
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            int index = tabcontrolkrypton.Pages.Count;
            DataBarang frm = new DataBarang();

            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            KryptonPage kp = new KryptonPage("Data Barang");
            tabcontrolkrypton.Pages.Add(kp);
            tabcontrolkrypton.Pages[index].Controls.Add(frm);
            tabcontrolkrypton.SelectedIndex = index;
        }
    }
}
