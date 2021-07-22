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
    public partial class FrmNhanVien : Form
    {
        ClsUser clsUser = new ClsUser();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            grdNhanVien.DataSource = clsUser.DanhSachNhanVien_all();
            grdThongTin.Enabled = false;
        }

        private void grdNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = grdNhanVien.CurrentCell.RowIndex;
                txtMaSV.Text = grdNhanVien.Rows[index].Cells[0].Value.ToString();
                txtTenNV.Text = grdNhanVien.Rows[index].Cells[1].Value.ToString();
                txtNgaySinh.Text = grdNhanVien.Rows[index].Cells[2].Value.ToString();
                if (grdNhanVien.Rows[index].Cells[3].Value.ToString() == "True")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                txtDiaChi.Text = grdNhanVien.Rows[index].Cells[4].Value.ToString();
                txtTenDangNhap.Text = grdNhanVien.Rows[index].Cells[5].Value.ToString();
                txtMatKhau.Text = grdNhanVien.Rows[index].Cells[6].Value.ToString();
            }
            catch(Exception ex) { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                grdThongTin.Enabled = true;
                txtMaSV.Text = txtTenNV.Text = txtDiaChi.Text = txtTenDangNhap.Text = txtMatKhau.Text = "";
                btnThem.Text = "Lưu";
                btnSua.Text = "Hũy";
                btnXoa.Enabled = false;
            }
            else // lưu
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn thêm dữ liệu nhân viên này hay không?", "Thông báo", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    bool gt;
                    if (rdNam.Checked)
                        gt = true;
                    else
                        gt = false;
                    //string ngay, thang, nam, ngaysinh;
                    //ngay = txtNgaySinh.Value.Day.ToString();
                    //thang = txtNgaySinh.Value.Month.ToString();
                    //nam = txtNgaySinh.Value.Year.ToString();
                    //ngaysinh = nam + "-" + thang + "-" + ngay; //2021-07-16

                    if (clsUser.InsertNhanVien(txtTenNV.Text, txtNgaySinh.Text, gt, txtDiaChi.Text, txtTenDangNhap.Text, txtMatKhau.Text))
                    {
                        MessageBox.Show("Thêm nhân viên này thành công!");
                        btnSua_Click(sender, e);

                    }
                    else
                        MessageBox.Show("Thêm nhân viên này không thành công!");
                }
                else
                {
                    btnSua_Click(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(btnSua.Text == "Hũy")
            {
                FrmNhanVien_Load(sender, e);
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;
            }
            else //Sua
            {

            }
        }
    }
}
