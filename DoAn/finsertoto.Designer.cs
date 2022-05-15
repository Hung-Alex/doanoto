
namespace DoAn
{
    partial class finsertoto
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
            this.panel_editkhachhang = new System.Windows.Forms.Panel();
            this.txt_sochongoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hangxe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenxe = new System.Windows.Forms.TextBox();
            this.txt_biensoxe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn__insertoto = new System.Windows.Forms.Button();
            this.btn__resetoto = new System.Windows.Forms.Button();
            this.panel_editkhachhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_editkhachhang
            // 
            this.panel_editkhachhang.Controls.Add(this.txt_sochongoi);
            this.panel_editkhachhang.Controls.Add(this.label3);
            this.panel_editkhachhang.Controls.Add(this.label1);
            this.panel_editkhachhang.Controls.Add(this.txt_hangxe);
            this.panel_editkhachhang.Controls.Add(this.label2);
            this.panel_editkhachhang.Controls.Add(this.txt_tenxe);
            this.panel_editkhachhang.Controls.Add(this.txt_biensoxe);
            this.panel_editkhachhang.Controls.Add(this.label4);
            this.panel_editkhachhang.Location = new System.Drawing.Point(12, 12);
            this.panel_editkhachhang.Name = "panel_editkhachhang";
            this.panel_editkhachhang.Size = new System.Drawing.Size(482, 235);
            this.panel_editkhachhang.TabIndex = 17;
            // 
            // txt_sochongoi
            // 
            this.txt_sochongoi.Location = new System.Drawing.Point(125, 179);
            this.txt_sochongoi.Name = "txt_sochongoi";
            this.txt_sochongoi.Size = new System.Drawing.Size(67, 22);
            this.txt_sochongoi.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số Chỗ Ngồi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãng Xe";
            // 
            // txt_hangxe
            // 
            this.txt_hangxe.Location = new System.Drawing.Point(125, 79);
            this.txt_hangxe.Name = "txt_hangxe";
            this.txt_hangxe.Size = new System.Drawing.Size(272, 22);
            this.txt_hangxe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Xe";
            // 
            // txt_tenxe
            // 
            this.txt_tenxe.Location = new System.Drawing.Point(125, 31);
            this.txt_tenxe.Name = "txt_tenxe";
            this.txt_tenxe.Size = new System.Drawing.Size(272, 22);
            this.txt_tenxe.TabIndex = 3;
            // 
            // txt_biensoxe
            // 
            this.txt_biensoxe.Location = new System.Drawing.Point(125, 128);
            this.txt_biensoxe.Name = "txt_biensoxe";
            this.txt_biensoxe.Size = new System.Drawing.Size(272, 22);
            this.txt_biensoxe.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Biển Số Xe";
            // 
            // btn__insertoto
            // 
            this.btn__insertoto.Location = new System.Drawing.Point(19, 282);
            this.btn__insertoto.Name = "btn__insertoto";
            this.btn__insertoto.Size = new System.Drawing.Size(75, 23);
            this.btn__insertoto.TabIndex = 20;
            this.btn__insertoto.Text = "Thêm";
            this.btn__insertoto.UseVisualStyleBackColor = true;
            this.btn__insertoto.Click += new System.EventHandler(this.btn__insertoto_Click);
            // 
            // btn__resetoto
            // 
            this.btn__resetoto.Location = new System.Drawing.Point(129, 282);
            this.btn__resetoto.Name = "btn__resetoto";
            this.btn__resetoto.Size = new System.Drawing.Size(75, 23);
            this.btn__resetoto.TabIndex = 21;
            this.btn__resetoto.Text = "Reset";
            this.btn__resetoto.UseVisualStyleBackColor = true;
            this.btn__resetoto.Click += new System.EventHandler(this.btn__resetoto_Click);
            // 
            // finsertoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 334);
            this.Controls.Add(this.btn__resetoto);
            this.Controls.Add(this.btn__insertoto);
            this.Controls.Add(this.panel_editkhachhang);
            this.Name = "finsertoto";
            this.Text = "finsertoto";
            this.Load += new System.EventHandler(this.finsertoto_Load);
            this.panel_editkhachhang.ResumeLayout(false);
            this.panel_editkhachhang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_editkhachhang;
        private System.Windows.Forms.TextBox txt_sochongoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hangxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenxe;
        private System.Windows.Forms.TextBox txt_biensoxe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn__insertoto;
        private System.Windows.Forms.Button btn__resetoto;
    }
}