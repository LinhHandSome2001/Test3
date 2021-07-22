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
    public partial class FrmPhongBan : Form
    {
        ClsPhongBan clsPhongBan = new ClsPhongBan();
        ClsUser clsUser = new ClsUser();
        string tenphong, maphong;
        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            DataTable tbPhongBan = new DataTable();
            tbPhongBan = clsPhongBan.DanhSachPhongBan_all();

            lstPhongBan.Items.Clear();
            for(int i =0; i<tbPhongBan.Rows.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = tbPhongBan.Rows[i]["TenPhong"].ToString();
                item.SubItems.Add(tbPhongBan.Rows[i]["idPhongBan"].ToString());
                DataTable tbUser = clsUser.DanhSachNhanVien_TheoPhongBan(tbPhongBan.Rows[i]["idPhongBan"].ToString());
                if(tbUser.Rows.Count >0)
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;
                lstPhongBan.Items.Add(item);
            }

            ////treeview
            //TreeNode root1 = new TreeNode();
            //root1.Text = "Cty1";
            //root1.Tag = 0;

            //TreeNode node1 = new TreeNode();
            //node1.Text = "Kế Toán";
            //node1.Tag = 1;

            //TreeNode node2 = new TreeNode();
            //node2.Text = "Hành chính";
            //node2.Tag = 2;
            //root1.Nodes.Add(node1);
            //root1.Nodes.Add(node2);

            //TreeNode root2 = new TreeNode();
            //root2.Text = "Cty2";
            //root2.Tag = 3;

            //treeView1.Nodes.Add(root1);
            //treeView1.Nodes.Add(root2);

            tbPhongBan = clsPhongBan.DanhSachPhongBan_Goc();
            if (tbPhongBan != null)
            {
                treeView1.Nodes.Clear();
                for (int i = 0; i < tbPhongBan.Rows.Count; i++)
                {
                    TreeNode root = new TreeNode();
                    root.Text = tbPhongBan.Rows[i]["TenPhong"].ToString();
                    root.Tag = tbPhongBan.Rows[i]["idPhongBan"].ToString();
                    treeView1.Nodes.Add(root);
                    AddNode(root, tbPhongBan.Rows[i]["idPhongBan"].ToString());
                }
            }
        }

        private void AddNode(TreeNode RootNode, string maphong_cha)
        {
            DataTable tbPhongCon = new DataTable();
            tbPhongCon = clsPhongBan.DanhSachPhongBan_Con(maphong_cha);
            if(tbPhongCon != null)
            {
                for(int i =0;i<tbPhongCon.Rows.Count;i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = tbPhongCon.Rows[i]["TenPhong"].ToString();
                    node.Tag = tbPhongCon.Rows[i]["idPhongBan"].ToString();
                    RootNode.Nodes.Add(node);
                    AddNode(node, tbPhongCon.Rows[i]["idPhongBan"].ToString());
                }
            }
        }

        private void lstPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPhongBan.FocusedItem.Index >= 0)
            {
                tenphong = lstPhongBan.FocusedItem.SubItems[0].Text;
                maphong = lstPhongBan.FocusedItem.SubItems[1].Text;
                DataTable tbUser = clsUser.DanhSachNhanVien_TheoPhongBan(lstPhongBan.FocusedItem.SubItems[1].Text);
                if (tbUser.Rows.Count > 0)
                    lstPhongBan.ContextMenuStrip = contextMenuStrip1;
                else
                    if (tbUser.Rows.Count == 0)
                    lstPhongBan.ContextMenuStrip = contextMenuStrip2;
            }
            //else
            //{
                
            //    lstPhongBan.ContextMenuStrip = contextMenuStrip3;
            //}
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn thêm nhân viên phong " + maphong + ", " + tenphong);
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn xem chi tiết phong "+ maphong + ", " + tenphong);
        }
    }
}
