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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (ClsKetNoi.OpenConection())
            {
                ClsUser clsUser = new ClsUser();
                FrmDangNhap frmDangNhap = null;
            cont:
                if(frmDangNhap == null || frmDangNhap.IsDisposed)
                {
                    frmDangNhap = new FrmDangNhap();
                    this.Hide();
                }
                if (frmDangNhap.ShowDialog() == DialogResult.OK)
                {
                    bool ketqua = clsUser.KiemTraUser(frmDangNhap.txtTenDangNhap.Text, frmDangNhap.txtMatKhau.Text);
                    if (ketqua)
                        this.Show();
                    else
                    {
                        MessageBox.Show("Người dùng này không tồn tại hoặc sai mật khẩu!");
                        goto cont;
                    }
                }
                else
                    this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Kết nối tới CSDL bị lỗi! Hãy kết nối lại CSDL!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    frmCauHinh frm = new frmCauHinh();
                    frm.ShowDialog();
                    FrmMain_Load(sender, e);
                }
                else
                    this.Close();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhânViên1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien1 frm = new FrmNhanVien1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongBan frm = new FrmPhongBan();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
