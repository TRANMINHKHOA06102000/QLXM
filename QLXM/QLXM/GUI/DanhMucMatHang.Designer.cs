namespace QLXM
{
    partial class DanhMucMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucMatHang));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_ttbh = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_nsx = new System.Windows.Forms.TextBox();
            this.txt_th = new System.Windows.Forms.TextBox();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.linkLabel1.Location = new System.Drawing.Point(63, 325);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(237, 29);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Danh Sách Mặt Hàng";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(62, 363);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(993, 278);
            this.dgv.TabIndex = 35;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(785, 180);
            this.txt_dvt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(270, 35);
            this.txt_dvt.TabIndex = 28;
            // 
            // txt_ttbh
            // 
            this.txt_ttbh.Location = new System.Drawing.Point(275, 175);
            this.txt_ttbh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ttbh.Name = "txt_ttbh";
            this.txt_ttbh.Size = new System.Drawing.Size(255, 35);
            this.txt_ttbh.TabIndex = 29;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(785, 122);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(270, 35);
            this.txt_sl.TabIndex = 30;
            // 
            // txt_nsx
            // 
            this.txt_nsx.Location = new System.Drawing.Point(275, 123);
            this.txt_nsx.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nsx.Name = "txt_nsx";
            this.txt_nsx.Size = new System.Drawing.Size(255, 35);
            this.txt_nsx.TabIndex = 31;
            // 
            // txt_th
            // 
            this.txt_th.Location = new System.Drawing.Point(785, 63);
            this.txt_th.Margin = new System.Windows.Forms.Padding(4);
            this.txt_th.Name = "txt_th";
            this.txt_th.Size = new System.Drawing.Size(270, 35);
            this.txt_th.TabIndex = 32;
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(275, 66);
            this.txt_mahang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(255, 35);
            this.txt_mahang.TabIndex = 33;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(574, 180);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(144, 27);
            this.Label7.TabIndex = 21;
            this.Label7.Text = "Đơn Vị Tính: ";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(21, 180);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(225, 27);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Thông Tin Bảo Hành: ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(574, 122);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(118, 27);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Số Lượng: ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(21, 128);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(158, 27);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Nhà Sản Xuất: ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(574, 63);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(118, 27);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Tên Hàng: ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(21, 66);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(113, 27);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Mã Hàng: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(408, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 36);
            this.label9.TabIndex = 27;
            this.label9.Text = "Danh Mục Mặt Hàng";
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.preview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview.Image = global::QLXM.Properties.Resources.chitiet;
            this.preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preview.Location = new System.Drawing.Point(902, 240);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(153, 43);
            this.preview.TabIndex = 37;
            this.preview.Text = "Preview";
            this.preview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preview.UseVisualStyleBackColor = false;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset.Location = new System.Drawing.Point(758, 240);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(123, 43);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Image = ((System.Drawing.Image)(resources.GetObject("xoa.Image")));
            this.xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa.Location = new System.Drawing.Point(598, 240);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(132, 43);
            this.xoa.TabIndex = 0;
            this.xoa.Text = "Xóa";
            this.xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Image = ((System.Drawing.Image)(resources.GetObject("sua.Image")));
            this.sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua.Location = new System.Drawing.Point(432, 240);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(134, 43);
            this.sua.TabIndex = 0;
            this.sua.Text = "Sửa";
            this.sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.show.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Image = ((System.Drawing.Image)(resources.GetObject("show.Image")));
            this.show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show.Location = new System.Drawing.Point(97, 240);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(149, 43);
            this.show.TabIndex = 0;
            this.show.Text = "Hiển Thị";
            this.show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Image = ((System.Drawing.Image)(resources.GetObject("them.Image")));
            this.them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them.Location = new System.Drawing.Point(275, 240);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(123, 43);
            this.them.TabIndex = 0;
            this.them.Text = "Thêm ";
            this.them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timkiem.Location = new System.Drawing.Point(930, 319);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(125, 35);
            this.timkiem.TabIndex = 38;
            this.timkiem.Text = "Tìm Kiếm";
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(713, 321);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(211, 35);
            this.txt_tk.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nhập mã hàng hoặc tên mặt hàng cần tìm kiếm: ";
            // 
            // DanhMucMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.show);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.txt_ttbh);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_nsx);
            this.Controls.Add(this.txt_th);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DanhMucMatHang";
            this.Text = "Quản Lý Mặt Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.Button show;
        internal System.Windows.Forms.TextBox txt_dvt;
        internal System.Windows.Forms.TextBox txt_ttbh;
        internal System.Windows.Forms.TextBox txt_sl;
        internal System.Windows.Forms.TextBox txt_nsx;
        internal System.Windows.Forms.TextBox txt_th;
        internal System.Windows.Forms.TextBox txt_mahang;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button them;
        internal System.Windows.Forms.Button xoa;
        internal System.Windows.Forms.Button sua;
        internal System.Windows.Forms.Button reset;
        internal System.Windows.Forms.Button preview;
        internal System.Windows.Forms.Button timkiem;
        internal System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label1;
    }
}

