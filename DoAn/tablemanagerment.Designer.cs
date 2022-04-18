
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_AddHD = new System.Windows.Forms.Button();
            this.btn_EditHD = new System.Windows.Forms.Button();
            this.btn_RemoveHD = new System.Windows.Forms.Button();
            this.btn_ThanhToanHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_mahopdong = new System.Windows.Forms.TextBox();
            this.textBox_makhachhang = new System.Windows.Forms.TextBox();
            this.comboBox_tenkhachhang = new System.Windows.Forms.ComboBox();
            this.textBox_maxe = new System.Windows.Forms.TextBox();
            this.comboBox_tenxe = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ThueStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_thueend = new System.Windows.Forms.DateTimePicker();
            this.textBox_tienthue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1167, 28);
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
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.otoToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ThanhToanHD);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_RemoveHD);
            this.panel1.Controls.Add(this.btn_EditHD);
            this.panel1.Controls.Add(this.Btn_AddHD);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 530);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_tienthue);
            this.panel2.Controls.Add(this.dateTimePicker_thueend);
            this.panel2.Controls.Add(this.dateTimePicker_ThueStart);
            this.panel2.Controls.Add(this.comboBox_tenxe);
            this.panel2.Controls.Add(this.textBox_maxe);
            this.panel2.Controls.Add(this.comboBox_tenkhachhang);
            this.panel2.Controls.Add(this.textBox_makhachhang);
            this.panel2.Controls.Add(this.textBox_mahopdong);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(711, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 369);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 471);
            this.panel3.TabIndex = 1;
            // 
            // Btn_AddHD
            // 
            this.Btn_AddHD.Location = new System.Drawing.Point(711, 390);
            this.Btn_AddHD.Name = "Btn_AddHD";
            this.Btn_AddHD.Size = new System.Drawing.Size(88, 52);
            this.Btn_AddHD.TabIndex = 2;
            this.Btn_AddHD.Text = "Tạo";
            this.Btn_AddHD.UseVisualStyleBackColor = true;
            // 
            // btn_EditHD
            // 
            this.btn_EditHD.Location = new System.Drawing.Point(805, 390);
            this.btn_EditHD.Name = "btn_EditHD";
            this.btn_EditHD.Size = new System.Drawing.Size(90, 52);
            this.btn_EditHD.TabIndex = 3;
            this.btn_EditHD.Text = "Chỉnh Sửa";
            this.btn_EditHD.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveHD
            // 
            this.btn_RemoveHD.Location = new System.Drawing.Point(901, 390);
            this.btn_RemoveHD.Name = "btn_RemoveHD";
            this.btn_RemoveHD.Size = new System.Drawing.Size(113, 52);
            this.btn_RemoveHD.TabIndex = 4;
            this.btn_RemoveHD.Text = "Xóa Hợp Đồng";
            this.btn_RemoveHD.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToanHD
            // 
            this.btn_ThanhToanHD.Location = new System.Drawing.Point(1020, 390);
            this.btn_ThanhToanHD.Name = "btn_ThanhToanHD";
            this.btn_ThanhToanHD.Size = new System.Drawing.Size(107, 52);
            this.btn_ThanhToanHD.TabIndex = 5;
            this.btn_ThanhToanHD.Text = "Thanh Toán";
            this.btn_ThanhToanHD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Thuê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiền Thuê";
            // 
            // textBox_mahopdong
            // 
            this.textBox_mahopdong.Location = new System.Drawing.Point(165, 39);
            this.textBox_mahopdong.Name = "textBox_mahopdong";
            this.textBox_mahopdong.Size = new System.Drawing.Size(251, 22);
            this.textBox_mahopdong.TabIndex = 8;
            // 
            // textBox_makhachhang
            // 
            this.textBox_makhachhang.Location = new System.Drawing.Point(165, 78);
            this.textBox_makhachhang.Name = "textBox_makhachhang";
            this.textBox_makhachhang.Size = new System.Drawing.Size(251, 22);
            this.textBox_makhachhang.TabIndex = 9;
            // 
            // comboBox_tenkhachhang
            // 
            this.comboBox_tenkhachhang.FormattingEnabled = true;
            this.comboBox_tenkhachhang.Location = new System.Drawing.Point(165, 115);
            this.comboBox_tenkhachhang.Name = "comboBox_tenkhachhang";
            this.comboBox_tenkhachhang.Size = new System.Drawing.Size(251, 24);
            this.comboBox_tenkhachhang.TabIndex = 10;
            // 
            // textBox_maxe
            // 
            this.textBox_maxe.Location = new System.Drawing.Point(165, 156);
            this.textBox_maxe.Name = "textBox_maxe";
            this.textBox_maxe.Size = new System.Drawing.Size(251, 22);
            this.textBox_maxe.TabIndex = 11;
            // 
            // comboBox_tenxe
            // 
            this.comboBox_tenxe.FormattingEnabled = true;
            this.comboBox_tenxe.Location = new System.Drawing.Point(165, 194);
            this.comboBox_tenxe.Name = "comboBox_tenxe";
            this.comboBox_tenxe.Size = new System.Drawing.Size(251, 24);
            this.comboBox_tenxe.TabIndex = 12;
            // 
            // dateTimePicker_ThueStart
            // 
            this.dateTimePicker_ThueStart.Location = new System.Drawing.Point(165, 236);
            this.dateTimePicker_ThueStart.Name = "dateTimePicker_ThueStart";
            this.dateTimePicker_ThueStart.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker_ThueStart.TabIndex = 13;
            // 
            // dateTimePicker_thueend
            // 
            this.dateTimePicker_thueend.Location = new System.Drawing.Point(165, 275);
            this.dateTimePicker_thueend.Name = "dateTimePicker_thueend";
            this.dateTimePicker_thueend.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker_thueend.TabIndex = 14;
            // 
            // textBox_tienthue
            // 
            this.textBox_tienthue.Location = new System.Drawing.Point(165, 320);
            this.textBox_tienthue.Name = "textBox_tienthue";
            this.textBox_tienthue.Size = new System.Drawing.Size(251, 22);
            this.textBox_tienthue.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // otoToolStripMenuItem
            // 
            this.otoToolStripMenuItem.Name = "otoToolStripMenuItem";
            this.otoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.otoToolStripMenuItem.Text = "Oto";
            // 
            // tablemanagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tablemanagerment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm Mềm Quản Lý Dịch Vụ Cho Thuê Xe Oto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btn_ThanhToanHD;
        private System.Windows.Forms.Button btn_RemoveHD;
        private System.Windows.Forms.Button btn_EditHD;
        private System.Windows.Forms.Button Btn_AddHD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_tienthue;
        private System.Windows.Forms.DateTimePicker dateTimePicker_thueend;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ThueStart;
        private System.Windows.Forms.ComboBox comboBox_tenxe;
        private System.Windows.Forms.TextBox textBox_maxe;
        private System.Windows.Forms.ComboBox comboBox_tenkhachhang;
        private System.Windows.Forms.TextBox textBox_makhachhang;
        private System.Windows.Forms.TextBox textBox_mahopdong;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoToolStripMenuItem;
    }
}