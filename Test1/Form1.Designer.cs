namespace Test1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaSV = new System.Windows.Forms.TextBox();
            this.textTenSV = new System.Windows.Forms.TextBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textHocLuc = new System.Windows.Forms.TextBox();
            this.Bang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hoc Luc";
            // 
            // textMaSV
            // 
            this.textMaSV.Location = new System.Drawing.Point(104, 27);
            this.textMaSV.Name = "textMaSV";
            this.textMaSV.Size = new System.Drawing.Size(128, 22);
            this.textMaSV.TabIndex = 4;
            this.textMaSV.TextChanged += new System.EventHandler(this.textMaSV_TextChanged);
            // 
            // textTenSV
            // 
            this.textTenSV.Location = new System.Drawing.Point(104, 60);
            this.textTenSV.Name = "textTenSV";
            this.textTenSV.Size = new System.Drawing.Size(128, 22);
            this.textTenSV.TabIndex = 5;
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(104, 96);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(128, 22);
            this.textSDT.TabIndex = 6;
            // 
            // textHocLuc
            // 
            this.textHocLuc.Location = new System.Drawing.Point(104, 143);
            this.textHocLuc.Name = "textHocLuc";
            this.textHocLuc.Size = new System.Drawing.Size(128, 22);
            this.textHocLuc.TabIndex = 7;
            // 
            // Bang
            // 
            this.Bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bang.Location = new System.Drawing.Point(52, 200);
            this.Bang.Name = "Bang";
            this.Bang.RowHeadersWidth = 51;
            this.Bang.RowTemplate.Height = 24;
            this.Bang.Size = new System.Drawing.Size(571, 222);
            this.Bang.TabIndex = 8;
            this.Bang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bang_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(352, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 31);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(468, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 31);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(580, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 31);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(352, 99);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 31);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(468, 96);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 31);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiiem
            // 
            this.btnTimKiiem.Location = new System.Drawing.Point(580, 99);
            this.btnTimKiiem.Name = "btnTimKiiem";
            this.btnTimKiiem.Size = new System.Drawing.Size(84, 31);
            this.btnTimKiiem.TabIndex = 14;
            this.btnTimKiiem.Text = "Tim Kiem";
            this.btnTimKiiem.UseVisualStyleBackColor = true;
            this.btnTimKiiem.Click += new System.EventHandler(this.btnTimKiiem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.Bang);
            this.Controls.Add(this.textHocLuc);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(this.textTenSV);
            this.Controls.Add(this.textMaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaSV;
        private System.Windows.Forms.TextBox textTenSV;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textHocLuc;
        private System.Windows.Forms.DataGridView Bang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiiem;
    }
}

