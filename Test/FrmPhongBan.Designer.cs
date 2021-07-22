namespace Test
{
    partial class FrmPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongBan));
            this.lstPhongBan = new System.Windows.Forms.ListView();
            this.colTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPhongBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPhongBan
            // 
            this.lstPhongBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenPhong,
            this.colMaPhongBan});
            this.lstPhongBan.LargeImageList = this.imageList1;
            this.lstPhongBan.Location = new System.Drawing.Point(12, 12);
            this.lstPhongBan.Name = "lstPhongBan";
            this.lstPhongBan.Size = new System.Drawing.Size(455, 412);
            this.lstPhongBan.SmallImageList = this.imageList1;
            this.lstPhongBan.TabIndex = 0;
            this.lstPhongBan.UseCompatibleStateImageBehavior = false;
            this.lstPhongBan.SelectedIndexChanged += new System.EventHandler(this.lstPhongBan_SelectedIndexChanged);
            // 
            // colTenPhong
            // 
            this.colTenPhong.DisplayIndex = 1;
            this.colTenPhong.Text = "Tên Phòng";
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.DisplayIndex = 0;
            this.colMaPhongBan.Text = "Mã Phòng Ban";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images.jpg");
            this.imageList1.Images.SetKeyName(1, "images1.jpg");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem Chi Tiết";
            this.xemChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhânViênToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(163, 26);
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            this.thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            this.thêmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.thêmNhânViênToolStripMenuItem.Text = "Thêm Nhân Viên";
            this.thêmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(504, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(340, 340);
            this.treeView1.TabIndex = 3;
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 436);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lstPhongBan);
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPhongBan;
        private System.Windows.Forms.ColumnHeader colTenPhong;
        private System.Windows.Forms.ColumnHeader colMaPhongBan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.TreeView treeView1;
    }
}