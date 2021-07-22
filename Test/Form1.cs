using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmCauHinh : Form
    {
        ClsKetNoi clsKetNoi = new ClsKetNoi();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (clsKetNoi.kt)
                MessageBox.Show("Kết nối thành công!");
            else
                MessageBox.Show("Kết nối không thành công!");
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            //if(clsKetNoi.ketnoi(txtServer.Text, txtUser.Text, txtPass.Text, txtDatabase.Text))
            //    MessageBox.Show("Kết nối thành công!");
            //else
            //    MessageBox.Show("Kết nối không thành công!");
            if (clsKetNoi.ketnoi(txtServer.Text, txtUser.Text, txtPass.Text, txtDatabase.Text))
                MessageBox.Show("Kết nối thành công!");
            else
                MessageBox.Show("Kết nối không thành công!");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(XML.LuuXML("config.txt", txtServer.Text, txtUser.Text, txtPass.Text, txtDatabase.Text))
                MessageBox.Show("Lưu thành công!");
            else
                MessageBox.Show("Lưu không thành công!");
        }
    }
}
