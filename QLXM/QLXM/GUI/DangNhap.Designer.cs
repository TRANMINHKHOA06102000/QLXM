namespace QLXM
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.matkhau = new System.Windows.Forms.TextBox();
            this.tendn = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thoat = new System.Windows.Forms.Button();
            this.dn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(393, 166);
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(241, 35);
            this.matkhau.TabIndex = 7;
            // 
            // tendn
            // 
            this.tendn.Location = new System.Drawing.Point(393, 83);
            this.tendn.Name = "tendn";
            this.tendn.Size = new System.Drawing.Size(241, 35);
            this.tendn.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(254, 169);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(123, 26);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "PassWord:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(254, 92);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(133, 26);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "UserName: ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(191, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(470, 36);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Mời bạn đăng nhập vào hệ thống";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLXM.Properties.Resources.avatardangnhap;
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 279);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.White;
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Image = ((System.Drawing.Image)(resources.GetObject("thoat.Image")));
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(456, 245);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(117, 39);
            this.thoat.TabIndex = 9;
            this.thoat.Text = "Exit";
            this.thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // dn
            // 
            this.dn.BackColor = System.Drawing.Color.White;
            this.dn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn.Image = ((System.Drawing.Image)(resources.GetObject("dn.Image")));
            this.dn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dn.Location = new System.Drawing.Point(296, 245);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(126, 39);
            this.dn.TabIndex = 10;
            this.dn.Text = "Login";
            this.dn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dn.UseVisualStyleBackColor = false;
            this.dn.Click += new System.EventHandler(this.dn_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(673, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.tendn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button thoat;
        internal System.Windows.Forms.Button dn;
        internal System.Windows.Forms.TextBox matkhau;
        internal System.Windows.Forms.TextBox tendn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}