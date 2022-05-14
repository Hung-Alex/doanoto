
namespace DoAn
{
    partial class tablemanagerment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_hopdong_xemtatca = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_categorybySochoNgoi = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_HopDOng = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TienThueHopDong = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgayTraHD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayThueHD = new System.Windows.Forms.DateTimePicker();
            this.listView_HopDong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1_scmnd_hopdong = new System.Windows.Forms.TextBox();
            this.Btn_AddHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1_HopDong_Khachang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themKH = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTToolStripMenuItem
            // 
            this.thôngTinTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTToolStripMenuItem.Name = "thôngTinTToolStripMenuItem";
            this.thôngTinTToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.thôngTinTToolStripMenuItem.Text = " Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.otoToolStripMenuItem,
            this.hợpĐồngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // otoToolStripMenuItem
            // 
            this.otoToolStripMenuItem.Name = "otoToolStripMenuItem";
            this.otoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.otoToolStripMenuItem.Text = "Oto";
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp Đồng";
            this.hợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_hopdong_xemtatca);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox_categorybySochoNgoi);
            this.panel1.Controls.Add(this.flowLayoutPanel_HopDOng);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 561);
            this.panel1.TabIndex = 1;
            // 
            // button_hopdong_xemtatca
            // 
            this.button_hopdong_xemtatca.Location = new System.Drawing.Point(303, 18);
            this.button_hopdong_xemtatca.Name = "button_hopdong_xemtatca";
            this.button_hopdong_xemtatca.Size = new System.Drawing.Size(89, 28);
            this.button_hopdong_xemtatca.TabIndex = 9;
            this.button_hopdong_xemtatca.Text = "Tất cả";
            this.button_hopdong_xemtatca.UseVisualStyleBackColor = true;
            this.button_hopdong_xemtatca.Click += new System.EventHandler(this.button_hopdong_xemtatca_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số chỗ ngồi";
            // 
            // comboBox_categorybySochoNgoi
            // 
            this.comboBox_categorybySochoNgoi.FormattingEnabled = true;
            this.comboBox_categorybySochoNgoi.Location = new System.Drawing.Point(122, 17);
            this.comboBox_categorybySochoNgoi.Name = "comboBox_categorybySochoNgoi";
            this.comboBox_categorybySochoNgoi.Size = new System.Drawing.Size(121, 24);
            this.comboBox_categorybySochoNgoi.TabIndex = 7;
            this.comboBox_categorybySochoNgoi.SelectedValueChanged += new System.EventHandler(this.comboBox_categorybySochoNgoi_SelectedValueChanged);
            // 
            // flowLayoutPanel_HopDOng
            // 
            this.flowLayoutPanel_HopDOng.AutoScroll = true;
            this.flowLayoutPanel_HopDOng.Location = new System.Drawing.Point(3, 56);
            this.flowLayoutPanel_HopDOng.Name = "flowLayoutPanel_HopDOng";
            this.flowLayoutPanel_HopDOng.Size = new System.Drawing.Size(668, 503);
            this.flowLayoutPanel_HopDOng.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_themKH);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_TienThueHopDong);
            this.panel2.Controls.Add(this.dateTimePicker_NgayTraHD);
            this.panel2.Controls.Add(this.dateTimePicker_NgayThueHD);
            this.panel2.Controls.Add(this.listView_HopDong);
            this.panel2.Controls.Add(this.textBox1_scmnd_hopdong);
            this.panel2.Controls.Add(this.Btn_AddHD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1_HopDong_Khachang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(687, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 556);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tiền Thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày Thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Trả";
            // 
            // textBox_TienThueHopDong
            // 
            this.textBox_TienThueHopDong.Location = new System.Drawing.Point(216, 191);
            this.textBox_TienThueHopDong.Name = "textBox_TienThueHopDong";
            this.textBox_TienThueHopDong.Size = new System.Drawing.Size(309, 22);
            this.textBox_TienThueHopDong.TabIndex = 9;
            // 
            // dateTimePicker_NgayTraHD
            // 
            this.dateTimePicker_NgayTraHD.CustomFormat = "ddd/dd/MM/yyyy";
            this.dateTimePicker_NgayTraHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayTraHD.Location = new System.Drawing.Point(216, 148);
            this.dateTimePicker_NgayTraHD.Name = "dateTimePicker_NgayTraHD";
            this.dateTimePicker_NgayTraHD.Size = new System.Drawing.Size(309, 22);
            this.dateTimePicker_NgayTraHD.TabIndex = 8;
            // 
            // dateTimePicker_NgayThueHD
            // 
            this.dateTimePicker_NgayThueHD.CustomFormat = "ddd/dd/MM/yyyy";
            this.dateTimePicker_NgayThueHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayThueHD.Location = new System.Drawing.Point(216, 105);
            this.dateTimePicker_NgayThueHD.Name = "dateTimePicker_NgayThueHD";
            this.dateTimePicker_NgayThueHD.Size = new System.Drawing.Size(309, 22);
            this.dateTimePicker_NgayThueHD.TabIndex = 7;
            // 
            // listView_HopDong
            // 
            this.listView_HopDong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_HopDong.GridLines = true;
            this.listView_HopDong.HideSelection = false;
            this.listView_HopDong.Location = new System.Drawing.Point(3, 247);
            this.listView_HopDong.Name = "listView_HopDong";
            this.listView_HopDong.Size = new System.Drawing.Size(687, 210);
            this.listView_HopDong.TabIndex = 6;
            this.listView_HopDong.UseCompatibleStateImageBehavior = false;
            this.listView_HopDong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Xe";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Xe";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hãng Xe";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Biển Số Xe";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Chỗ Ngồi";
            this.columnHeader5.Width = 100;
            // 
            // textBox1_scmnd_hopdong
            // 
            this.textBox1_scmnd_hopdong.Location = new System.Drawing.Point(216, 64);
            this.textBox1_scmnd_hopdong.Name = "textBox1_scmnd_hopdong";
            this.textBox1_scmnd_hopdong.ReadOnly = true;
            this.textBox1_scmnd_hopdong.Size = new System.Drawing.Size(309, 22);
            this.textBox1_scmnd_hopdong.TabIndex = 3;
            // 
            // Btn_AddHD
            // 
            this.Btn_AddHD.Location = new System.Drawing.Point(3, 480);
            this.Btn_AddHD.Name = "Btn_AddHD";
            this.Btn_AddHD.Size = new System.Drawing.Size(88, 52);
            this.Btn_AddHD.TabIndex = 2;
            this.Btn_AddHD.Text = "Tạo";
            this.Btn_AddHD.UseVisualStyleBackColor = true;
            this.Btn_AddHD.Click += new System.EventHandler(this.Btn_AddHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Chứng Minh Nhân Dân";
            // 
            // comboBox1_HopDong_Khachang
            // 
            this.comboBox1_HopDong_Khachang.FormattingEnabled = true;
            this.comboBox1_HopDong_Khachang.Location = new System.Drawing.Point(216, 18);
            this.comboBox1_HopDong_Khachang.Name = "comboBox1_HopDong_Khachang";
            this.comboBox1_HopDong_Khachang.Size = new System.Drawing.Size(309, 24);
            this.comboBox1_HopDong_Khachang.TabIndex = 1;
            this.comboBox1_HopDong_Khachang.SelectedValueChanged += new System.EventHandler(this.comboBox1_HopDong_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // btn_themKH
            // 
            this.btn_themKH.Location = new System.Drawing.Point(541, 12);
            this.btn_themKH.Name = "btn_themKH";
            this.btn_themKH.Size = new System.Drawing.Size(140, 42);
            this.btn_themKH.TabIndex = 13;
            this.btn_themKH.Text = "Thêm Khách Hàng";
            this.btn_themKH.UseVisualStyleBackColor = true;
            this.btn_themKH.Click += new System.EventHandler(this.btn_themKH_Click);
            // 
            // tablemanagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tablemanagerment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm Mềm Quản Lý Dịch Vụ Cho Thuê Xe Oto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1_scmnd_hopdong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1_HopDong_Khachang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_HopDOng;
        private System.Windows.Forms.ListView listView_HopDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TienThueHopDong;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayTraHD;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayThueHD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_categorybySochoNgoi;
        private System.Windows.Forms.Button button_hopdong_xemtatca;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.Button btn_themKH;
    }
}