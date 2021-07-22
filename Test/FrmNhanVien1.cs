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
    public partial class FrmNhanVien1 : Form
    {
        ClsPhongBan clsPhongBan = new ClsPhongBan();
        ClsUser clsUser = new ClsUser();

        public FrmNhanVien1()
        {
            InitializeComponent();
        }

        private void FrmNhanVien1_Load(object sender, EventArgs e)
        {
            cmbPhongBan.DataSource = clsPhongBan.DanhSachPhongBan_all();
            cmbPhongBan.DisplayMember = "TenPhong";
            cmbPhongBan.ValueMember = "idPhongBan";

            cmbPhongBan.SelectedIndex = 1;
            cmbPhongBan.SelectedIndex = 0;
        }

        private void cmbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tbUser = clsUser.DanhSachNhanVien_TheoPhongBan(cmbPhongBan.SelectedValue.ToString());
                LoadListView(tbUser);
            }
            catch(Exception ex)
            {

            }
        }

        private void LoadListView(DataTable tbUser)
        {
            lstDSNhanVien.Items.Clear();
            
            for (int i = 0; i < tbUser.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = tbUser.Rows[i]["id"].ToString();
                item.SubItems.Add(tbUser.Rows[i]["hoten"].ToString());
                item.SubItems.Add(tbUser.Rows[i]["ngaysinh"].ToString());
                string gt;
                if (tbUser.Rows[i]["gioitinh"].ToString() == "True")
                    gt = "Nam";
                else
                    gt = "Nữ";
                item.SubItems.Add(gt);
                item.SubItems.Add(tbUser.Rows[i]["diachi"].ToString());
                item.SubItems.Add(tbUser.Rows[i]["username"].ToString());
                item.SubItems.Add(tbUser.Rows[i]["password"].ToString());
                item.SubItems.Add(tbUser.Rows[i]["idphongban"].ToString());
                lstDSNhanVien.Items.Add(item);
            }
            ClsUtilities.Change_ItemColor(lstDSNhanVien);
        }

        private void lstDSNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstDSNhanVien.FocusedItem.Index;
            if(lstDSNhanVien.Items.Count >0)
            {
                txtMaSV.Text = lstDSNhanVien.Items[index].SubItems[0].Text;
                txtTenNV.Text = lstDSNhanVien.Items[index].SubItems[1].Text;
                txtNgaySinh.Text = lstDSNhanVien.Items[index].SubItems[2].Text;
                if (lstDSNhanVien.Items[index].SubItems[3].Text == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                txtDiaChi.Text = lstDSNhanVien.Items[index].SubItems[4].Text;
                txtTenDangNhap.Text = lstDSNhanVien.Items[index].SubItems[5].Text;
                txtMatKhau.Text = lstDSNhanVien.Items[index].SubItems[6].Text;

            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tbUser = clsUser.DanhSachNhanVien_TheoPhongBan_TenNV(cmbPhongBan.SelectedValue.ToString(), txtTimKiem.Text);
                LoadListView(tbUser);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
