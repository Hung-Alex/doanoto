
namespace DoAn
{
    partial class fKhachHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView_khachhang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_inputcustomer = new System.Windows.Forms.TextBox();
            this.panel_editkhachhang = new System.Windows.Forms.Panel();
            this.label_MaKhachHang = new System.Windows.Forms.Label();
            this.textBox_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_scmnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.combobox_gioitinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_removeCustomer = new System.Windows.Forms.Button();
            this.btn_editCustomer = new System.Windows.Forms.Button();
            this.button_capnhatkh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel_editkhachhang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.listView_khachhang);
            this.panel2.Controls.Add(this.txt_inputcustomer);
            this.panel2.Location = new System.Drawing.Point(12, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 442);
            this.panel2.TabIndex = 2;
            // 
            // listView_khachhang
            // 
            this.listView_khachhang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_khachhang.FullRowSelect = true;
            this.listView_khachhang.GridLines = true;
            this.listView_khachhang.HideSelection = false;
            this.listView_khachhang.Location = new System.Drawing.Point(3, 74);
            this.listView_khachhang.Name = "listView_khachhang";
            this.listView_khachhang.Size = new System.Drawing.Size(981, 365);
            this.listView_khachhang.TabIndex = 15;
            this.listView_khachhang.UseCompatibleStateImageBehavior = false;
            this.listView_khachhang.View = System.Windows.Forms.View.Details;
            this.listView_khachhang.SelectedIndexChanged += new System.EventHandler(this.listView_khachhang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Khách Hàng";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Khách Hàng";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SCMND";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SĐT";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giới Tính";
            this.columnHeader6.Width = 75;
            // 
            // txt_inputcustomer
            // 
            this.txt_inputcustomer.Location = new System.Drawing.Point(124, 22);
            this.txt_inputcustomer.Name = "txt_inputcustomer";
            this.txt_inputcustomer.Size = new System.Drawing.Size(272, 22);
            this.txt_inputcustomer.TabIndex = 14;
            this.txt_inputcustomer.TextChanged += new System.EventHandler(this.txt_inputcustomer_TextChanged);
            // 
            // panel_editkhachhang
            // 
            this.panel_editkhachhang.Controls.Add(this.label_MaKhachHang);
            this.panel_editkhachhang.Controls.Add(this.textBox_MaKhachHang);
            this.panel_editkhachhang.Controls.Add(this.label1);
            this.panel_editkhachhang.Controls.Add(this.txt_scmnd);
            this.panel_editkhachhang.Controls.Add(this.label2);
            this.panel_editkhachhang.Controls.Add(this.txt_address);
            this.panel_editkhachhang.Controls.Add(this.txt_tenkhachhang);
            this.panel_editkhachhang.Controls.Add(this.label5);
            this.panel_editkhachhang.Controls.Add(this.label3);
            this.panel_editkhachhang.Controls.Add(this.txt_sdt);
            this.panel_editkhachhang.Controls.Add(this.combobox_gioitinh);
            this.panel_editkhachhang.Controls.Add(this.label4);
            this.panel_editkhachhang.Location = new System.Drawing.Point(3, 3);
            this.panel_editkhachhang.Name = "panel_editkhachhang";
            this.panel_editkhachhang.Size = new System.Drawing.Size(482, 343);
            this.panel_editkhachhang.TabIndex = 16;
            // 
            // label_MaKhachHang
            // 
            this.label_MaKhachHang.AutoSize = true;
            this.label_MaKhachHang.Location = new System.Drawing.Point(19, 36);
            this.label_MaKhachHang.Name = "label_MaKhachHang";
            this.label_MaKhachHang.Size = new System.Drawing.Size(109, 17);
            this.label_MaKhachHang.TabIndex = 14;
            this.label_MaKhachHang.Text = "Mã Khách Hàng";
            // 
            // textBox_MaKhachHang
            // 
            this.textBox_MaKhachHang.Enabled = false;
            this.textBox_MaKhachHang.Location = new System.Drawing.Point(140, 36);
            this.textBox_MaKhachHang.Name = "textBox_MaKhachHang";
            this.textBox_MaKhachHang.Size = new System.Drawing.Size(272, 22);
            this.textBox_MaKhachHang.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCMND";
            // 
            // txt_scmnd
            // 
            this.txt_scmnd.Location = new System.Drawing.Point(140, 137);
            this.txt_scmnd.Name = "txt_scmnd";
            this.txt_scmnd.Size = new System.Drawing.Size(272, 22);
            this.txt_scmnd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(140, 297);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(272, 22);
            this.txt_address.TabIndex = 9;
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(140, 92);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(272, 22);
            this.txt_tenkhachhang.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới Tính";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(140, 242);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(272, 22);
            this.txt_sdt.TabIndex = 7;
            // 
            // combobox_gioitinh
            // 
            this.combobox_gioitinh.FormattingEnabled = true;
            this.combobox_gioitinh.Location = new System.Drawing.Point(140, 184);
            this.combobox_gioitinh.Name = "combobox_gioitinh";
            this.combobox_gioitinh.Size = new System.Drawing.Size(115, 24);
            this.combobox_gioitinh.TabIndex = 5;
            this.combobox_gioitinh.Click += new System.EventHandler(this.combobox_gioitinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT";
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Location = new System.Drawing.Point(3, 375);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(103, 38);
            this.btn_addCustomer.TabIndex = 10;
            this.btn_addCustomer.Text = "Thêm";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_removeCustomer
            // 
            this.btn_removeCustomer.Location = new System.Drawing.Point(382, 375);
            this.btn_removeCustomer.Name = "btn_removeCustomer";
            this.btn_removeCustomer.Size = new System.Drawing.Size(103, 38);
            this.btn_removeCustomer.TabIndex = 11;
            this.btn_removeCustomer.Text = "Xóa";
            this.btn_removeCustomer.UseVisualStyleBackColor = true;
            this.btn_removeCustomer.Click += new System.EventHandler(this.btn_removeCustomer_Click);
            // 
            // btn_editCustomer
            // 
            this.btn_editCustomer.Location = new System.Drawing.Point(260, 375);
            this.btn_editCustomer.Name = "btn_editCustomer";
            this.btn_editCustomer.Size = new System.Drawing.Size(103, 38);
            this.btn_editCustomer.TabIndex = 12;
            this.btn_editCustomer.Text = "Sửa";
            this.btn_editCustomer.UseVisualStyleBackColor = true;
            this.btn_editCustomer.Click += new System.EventHandler(this.btn_editCustomer_Click);
            // 
            // button_capnhatkh
            // 
            this.button_capnhatkh.Location = new System.Drawing.Point(123, 375);
            this.button_capnhatkh.Name = "button_capnhatkh";
            this.button_capnhatkh.Size = new System.Drawing.Size(103, 38);
            this.button_capnhatkh.TabIndex = 16;
            this.button_capnhatkh.Text = "Cập Nhật";
            this.button_capnhatkh.UseVisualStyleBackColor = true;
            this.button_capnhatkh.Click += new System.EventHandler(this.button_capnhatkh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_editkhachhang);
            this.panel1.Controls.Add(this.button_capnhatkh);
            this.panel1.Controls.Add(this.btn_editCustomer);
            this.panel1.Controls.Add(this.btn_removeCustomer);
            this.panel1.Controls.Add(this.btn_addCustomer);
            this.panel1.Location = new System.Drawing.Point(1005, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 442);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fKhachHang";
            this.Text = "fKhachHang";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_editkhachhang.ResumeLayout(false);
            this.panel_editkhachhang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_inputcustomer;
        private System.Windows.Forms.Panel panel_editkhachhang;
        private System.Windows.Forms.Label label_MaKhachHang;
        private System.Windows.Forms.TextBox textBox_MaKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_scmnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.ComboBox combobox_gioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_removeCustomer;
        private System.Windows.Forms.Button btn_editCustomer;
        private System.Windows.Forms.Button button_capnhatkh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView_khachhang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
    }
}