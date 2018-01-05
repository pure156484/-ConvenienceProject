﻿namespace PosProject_psi
{
    partial class ProductManagement
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
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modified = new System.Windows.Forms.Button();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.product__unit_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.product_cust_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.product_barcode = new System.Windows.Forms.TextBox();
            this.product_num = new System.Windows.Forms.TextBox();
            this.product_count = new System.Windows.Forms.TextBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.product__image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product__image)).BeginInit();
            this.SuspendLayout();
            // 
            // product_grid
            // 
            this.product_grid.AllowUserToAddRows = false;
            this.product_grid.AllowUserToDeleteRows = false;
            this.product_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.Location = new System.Drawing.Point(12, 245);
            this.product_grid.Name = "product_grid";
            this.product_grid.ReadOnly = true;
            this.product_grid.RowTemplate.Height = 23;
            this.product_grid.Size = new System.Drawing.Size(756, 199);
            this.product_grid.TabIndex = 33;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_exit.Location = new System.Drawing.Point(311, 176);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 46);
            this.btn_exit.TabIndex = 32;
            this.btn_exit.Text = "닫기";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_delete.Location = new System.Drawing.Point(311, 122);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 46);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_modified
            // 
            this.btn_modified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_modified.FlatAppearance.BorderSize = 0;
            this.btn_modified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_modified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modified.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_modified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_modified.Location = new System.Drawing.Point(311, 69);
            this.btn_modified.Name = "btn_modified";
            this.btn_modified.Size = new System.Drawing.Size(95, 46);
            this.btn_modified.TabIndex = 30;
            this.btn_modified.Text = "수정";
            this.btn_modified.UseVisualStyleBackColor = false;
            // 
            // btn_enroll
            // 
            this.btn_enroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_enroll.FlatAppearance.BorderSize = 0;
            this.btn_enroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enroll.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_enroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_enroll.Location = new System.Drawing.Point(311, 16);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(95, 46);
            this.btn_enroll.TabIndex = 29;
            this.btn_enroll.Text = "등록";
            this.btn_enroll.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.product__unit_price);
            this.groupBox1.Controls.Add(this.btn_modified);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_enroll);
            this.groupBox1.Controls.Add(this.product_cust_price);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.product_name);
            this.groupBox1.Controls.Add(this.product_barcode);
            this.groupBox1.Controls.Add(this.product_num);
            this.groupBox1.Controls.Add(this.product_count);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 230);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(6, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "단       가";
            // 
            // product__unit_price
            // 
            this.product__unit_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product__unit_price.Location = new System.Drawing.Point(106, 196);
            this.product__unit_price.Name = "product__unit_price";
            this.product__unit_price.Size = new System.Drawing.Size(192, 26);
            this.product__unit_price.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "가       격";
            // 
            // product_cust_price
            // 
            this.product_cust_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_cust_price.Location = new System.Drawing.Point(106, 160);
            this.product_cust_price.Name = "product_cust_price";
            this.product_cust_price.Size = new System.Drawing.Size(192, 26);
            this.product_cust_price.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "상  품  명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "바  코  드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "재       고";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "종       류";
            // 
            // product_name
            // 
            this.product_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_name.Location = new System.Drawing.Point(106, 16);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(192, 26);
            this.product_name.TabIndex = 8;
            // 
            // product_barcode
            // 
            this.product_barcode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_barcode.Location = new System.Drawing.Point(106, 52);
            this.product_barcode.Name = "product_barcode";
            this.product_barcode.Size = new System.Drawing.Size(192, 26);
            this.product_barcode.TabIndex = 9;
            // 
            // product_num
            // 
            this.product_num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_num.Location = new System.Drawing.Point(106, 124);
            this.product_num.Name = "product_num";
            this.product_num.Size = new System.Drawing.Size(192, 26);
            this.product_num.TabIndex = 13;
            // 
            // product_count
            // 
            this.product_count.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_count.Location = new System.Drawing.Point(106, 88);
            this.product_count.Name = "product_count";
            this.product_count.Size = new System.Drawing.Size(192, 26);
            this.product_count.TabIndex = 10;
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_image.FlatAppearance.BorderSize = 0;
            this.btn_image.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_image.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btn_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_image.Location = new System.Drawing.Point(661, 212);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(107, 27);
            this.btn_image.TabIndex = 27;
            this.btn_image.Text = "이미지 추가";
            this.btn_image.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(566, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "이미지";
            // 
            // product__image
            // 
            this.product__image.Location = new System.Drawing.Point(430, 36);
            this.product__image.Name = "product__image";
            this.product__image.Size = new System.Drawing.Size(338, 170);
            this.product__image.TabIndex = 26;
            this.product__image.TabStop = false;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(780, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.product__image);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.product_grid);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품 관리";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product__image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView product_grid;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modified;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.TextBox product_barcode;
        private System.Windows.Forms.TextBox product_num;
        private System.Windows.Forms.TextBox product_count;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.PictureBox product__image;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox product__unit_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox product_cust_price;
    }
}