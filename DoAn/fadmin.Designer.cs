
namespace DoAn
{
    partial class fadmin
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_view_bill = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tenxe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_hieuxe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_insertOto = new System.Windows.Forms.Button();
            this.btn_removeOto = new System.Windows.Forms.Button();
            this.btn_editOto = new System.Windows.Forms.Button();
            this.btn_resetOto = new System.Windows.Forms.Button();
            this.txt_biensoxe = new System.Windows.Forms.TextBox();
            this.comboBox_sochongoi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MaXe = new System.Windows.Forms.TextBox();
            this.dataGridView_oto = new System.Windows.Forms.DataGridView();
            this.btn_findoto = new System.Windows.Forms.Button();
            this.txt_inputoto = new System.Windows.Forms.TextBox();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh Thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lsvHoaDon);
            this.panel4.Location = new System.Drawing.Point(6, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1038, 446);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.btn_view_bill);
            this.panel3.Controls.Add(this.dateTimePickerEnd);
            this.panel3.Controls.Add(this.dateTimePickerStart);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 53);
            this.panel3.TabIndex = 1;
            // 
            // btn_view_bill
            // 
            this.btn_view_bill.Location = new System.Drawing.Point(308, 14);
            this.btn_view_bill.Name = "btn_view_bill";
            this.btn_view_bill.Size = new System.Drawing.Size(133, 26);
            this.btn_view_bill.TabIndex = 2;
            this.btn_view_bill.Text = "Thống kê";
            this.btn_view_bill.UseVisualStyleBackColor = true;
            this.btn_view_bill.Click += new System.EventHandler(this.btn_view_bill_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(533, 14);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(15, 14);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 0;
            // 
            // txt_tenxe
            // 
            this.txt_tenxe.Location = new System.Drawing.Point(123, 76);
            this.txt_tenxe.Name = "txt_tenxe";
            this.txt_tenxe.Size = new System.Drawing.Size(272, 22);
            this.txt_tenxe.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 2;
            // 
            // txt_hieuxe
            // 
            this.txt_hieuxe.Location = new System.Drawing.Point(123, 125);
            this.txt_hieuxe.Name = "txt_hieuxe";
            this.txt_hieuxe.Size = new System.Drawing.Size(272, 22);
            this.txt_hieuxe.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 6;
            // 
            // btn_insertOto
            // 
            this.btn_insertOto.Location = new System.Drawing.Point(3, 341);
            this.btn_insertOto.Name = "btn_insertOto";
            this.btn_insertOto.Size = new System.Drawing.Size(103, 38);
            this.btn_insertOto.TabIndex = 10;
            this.btn_insertOto.Text = "Thêm";
            this.btn_insertOto.UseVisualStyleBackColor = true;
            // 
            // btn_removeOto
            // 
            this.btn_removeOto.Location = new System.Drawing.Point(123, 341);
            this.btn_removeOto.Name = "btn_removeOto";
            this.btn_removeOto.Size = new System.Drawing.Size(103, 38);
            this.btn_removeOto.TabIndex = 11;
            this.btn_removeOto.Text = "Xóa";
            this.btn_removeOto.UseVisualStyleBackColor = true;
            // 
            // btn_editOto
            // 
            this.btn_editOto.Location = new System.Drawing.Point(232, 341);
            this.btn_editOto.Name = "btn_editOto";
            this.btn_editOto.Size = new System.Drawing.Size(103, 38);
            this.btn_editOto.TabIndex = 12;
            this.btn_editOto.Text = "Sửa";
            this.btn_editOto.UseVisualStyleBackColor = true;
            // 
            // btn_resetOto
            // 
            this.btn_resetOto.Location = new System.Drawing.Point(3, 401);
            this.btn_resetOto.Name = "btn_resetOto";
            this.btn_resetOto.Size = new System.Drawing.Size(103, 38);
            this.btn_resetOto.TabIndex = 13;
            this.btn_resetOto.Text = "Xem";
            this.btn_resetOto.UseVisualStyleBackColor = true;
            // 
            // txt_biensoxe
            // 
            this.txt_biensoxe.Location = new System.Drawing.Point(123, 171);
            this.txt_biensoxe.Name = "txt_biensoxe";
            this.txt_biensoxe.Size = new System.Drawing.Size(272, 22);
            this.txt_biensoxe.TabIndex = 14;
            // 
            // comboBox_sochongoi
            // 
            this.comboBox_sochongoi.FormattingEnabled = true;
            this.comboBox_sochongoi.Location = new System.Drawing.Point(123, 229);
            this.comboBox_sochongoi.Name = "comboBox_sochongoi";
            this.comboBox_sochongoi.Size = new System.Drawing.Size(140, 25);
            this.comboBox_sochongoi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 16;
            // 
            // textBox_MaXe
            // 
            this.textBox_MaXe.Enabled = false;
            this.textBox_MaXe.Location = new System.Drawing.Point(123, 23);
            this.textBox_MaXe.Name = "textBox_MaXe";
            this.textBox_MaXe.Size = new System.Drawing.Size(272, 22);
            this.textBox_MaXe.TabIndex = 17;
            // 
            // dataGridView_oto
            // 
            this.dataGridView_oto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_oto.Location = new System.Drawing.Point(3, 76);
            this.dataGridView_oto.Name = "dataGridView_oto";
            this.dataGridView_oto.RowHeadersWidth = 51;
            this.dataGridView_oto.RowTemplate.Height = 24;
            this.dataGridView_oto.Size = new System.Drawing.Size(523, 383);
            this.dataGridView_oto.TabIndex = 0;
            // 
            // btn_findoto
            // 
            this.btn_findoto.Location = new System.Drawing.Point(307, 16);
            this.btn_findoto.Name = "btn_findoto";
            this.btn_findoto.Size = new System.Drawing.Size(89, 37);
            this.btn_findoto.TabIndex = 2;
            this.btn_findoto.Text = "Tìm Kiếm";
            this.btn_findoto.UseVisualStyleBackColor = true;
            // 
            // txt_inputoto
            // 
            this.txt_inputoto.Location = new System.Drawing.Point(6, 23);
            this.txt_inputoto.Name = "txt_inputoto";
            this.txt_inputoto.Size = new System.Drawing.Size(272, 22);
            this.txt_inputoto.TabIndex = 14;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(1032, 440);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hóa Đơn";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Hợp Đồng";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Khách Hàng";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Khách Hàng";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SCMND";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Xe";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên Xe";
            this.columnHeader7.Width = 172;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hãng Xe";
            this.columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày Lập Hóa Đơn";
            this.columnHeader9.Width = 121;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(840, 14);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(195, 22);
            this.txtTongTien.TabIndex = 3;
            this.txtTongTien.Text = "0 đ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng Tiền";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tiền Thuê";
            // 
            // fadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "fadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_view_bill;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tenxe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_hieuxe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_insertOto;
        private System.Windows.Forms.Button btn_removeOto;
        private System.Windows.Forms.Button btn_editOto;
        private System.Windows.Forms.Button btn_resetOto;
        private System.Windows.Forms.TextBox txt_biensoxe;
        private System.Windows.Forms.ComboBox comboBox_sochongoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_MaXe;
        private System.Windows.Forms.DataGridView dataGridView_oto;
        private System.Windows.Forms.Button btn_findoto;
        private System.Windows.Forms.TextBox txt_inputoto;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}