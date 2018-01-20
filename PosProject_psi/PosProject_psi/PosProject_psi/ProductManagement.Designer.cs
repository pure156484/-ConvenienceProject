namespace PosProject_psi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_image_search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.product_event = new System.Windows.Forms.ComboBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.product_count = new System.Windows.Forms.TextBox();
            this.product_select = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.product__unit_price = new System.Windows.Forms.TextBox();
            this.btn_modified = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.product_cust_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.product_barcode = new System.Windows.Forms.TextBox();
            this.product__image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product__image)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // product_grid
            // 
            this.product_grid.AllowUserToAddRows = false;
            this.product_grid.AllowUserToDeleteRows = false;
            this.product_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.Location = new System.Drawing.Point(14, 305);
            this.product_grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_grid.Name = "product_grid";
            this.product_grid.ReadOnly = true;
            this.product_grid.RowTemplate.Height = 23;
            this.product_grid.Size = new System.Drawing.Size(864, 261);
            this.product_grid.TabIndex = 38;
            this.product_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_grid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_image_search);
            this.groupBox1.Controls.Add(this.product_barcode);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.product_event);
            this.groupBox1.Controls.Add(this.btn_image);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.product_count);
            this.groupBox1.Controls.Add(this.product_select);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.product__unit_price);
            this.groupBox1.Controls.Add(this.btn_modified);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_enroll);
            this.groupBox1.Controls.Add(this.product_cust_price);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.product_name);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(606, 292);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // btn_image_search
            // 
            this.btn_image_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_image_search.FlatAppearance.BorderSize = 0;
            this.btn_image_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_image_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_image_search.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btn_image_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_image_search.Location = new System.Drawing.Point(359, 19);
            this.btn_image_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_image_search.Name = "btn_image_search";
            this.btn_image_search.Size = new System.Drawing.Size(233, 57);
            this.btn_image_search.TabIndex = 38;
            this.btn_image_search.Text = "이미지 검색";
            this.btn_image_search.UseVisualStyleBackColor = false;
            this.btn_image_search.Click += new System.EventHandler(this.btn_image_search_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(56, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 29);
            this.button1.TabIndex = 37;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // product_event
            // 
            this.product_event.FormattingEnabled = true;
            this.product_event.Location = new System.Drawing.Point(120, 259);
            this.product_event.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_event.Name = "product_event";
            this.product_event.Size = new System.Drawing.Size(219, 23);
            this.product_event.TabIndex = 36;
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_image.FlatAppearance.BorderSize = 0;
            this.btn_image.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_image.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btn_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_image.Location = new System.Drawing.Point(359, 86);
            this.btn_image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(233, 57);
            this.btn_image.TabIndex = 36;
            this.btn_image.Text = "이미지 업로드";
            this.btn_image.UseVisualStyleBackColor = false;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(7, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "이벤트";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(7, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "수량";
            // 
            // product_count
            // 
            this.product_count.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_count.Location = new System.Drawing.Point(120, 219);
            this.product_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_count.Multiline = true;
            this.product_count.Name = "product_count";
            this.product_count.Size = new System.Drawing.Size(219, 24);
            this.product_count.TabIndex = 34;
            // 
            // product_select
            // 
            this.product_select.FormattingEnabled = true;
            this.product_select.Location = new System.Drawing.Point(120, 99);
            this.product_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_select.Name = "product_select";
            this.product_select.Size = new System.Drawing.Size(219, 23);
            this.product_select.TabIndex = 18;
            this.product_select.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_exit.Location = new System.Drawing.Point(483, 222);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(109, 58);
            this.btn_exit.TabIndex = 32;
            this.btn_exit.Text = "새로고침";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(7, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "가격";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_delete.Location = new System.Drawing.Point(483, 155);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 58);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "삭 제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // product__unit_price
            // 
            this.product__unit_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product__unit_price.Location = new System.Drawing.Point(120, 179);
            this.product__unit_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product__unit_price.Multiline = true;
            this.product__unit_price.Name = "product__unit_price";
            this.product__unit_price.Size = new System.Drawing.Size(219, 24);
            this.product__unit_price.TabIndex = 17;
            // 
            // btn_modified
            // 
            this.btn_modified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_modified.FlatAppearance.BorderSize = 0;
            this.btn_modified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_modified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modified.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_modified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_modified.Location = new System.Drawing.Point(359, 222);
            this.btn_modified.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_modified.Name = "btn_modified";
            this.btn_modified.Size = new System.Drawing.Size(109, 58);
            this.btn_modified.TabIndex = 30;
            this.btn_modified.Text = "수 정";
            this.btn_modified.UseVisualStyleBackColor = false;
            this.btn_modified.Click += new System.EventHandler(this.btn_modified_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(7, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "단가";
            // 
            // btn_enroll
            // 
            this.btn_enroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_enroll.FlatAppearance.BorderSize = 0;
            this.btn_enroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enroll.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_enroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_enroll.Location = new System.Drawing.Point(359, 154);
            this.btn_enroll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(109, 58);
            this.btn_enroll.TabIndex = 29;
            this.btn_enroll.Text = "등 록";
            this.btn_enroll.UseVisualStyleBackColor = false;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // product_cust_price
            // 
            this.product_cust_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_cust_price.Location = new System.Drawing.Point(120, 139);
            this.product_cust_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_cust_price.Multiline = true;
            this.product_cust_price.Name = "product_cust_price";
            this.product_cust_price.Size = new System.Drawing.Size(219, 24);
            this.product_cust_price.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "바코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "품종";
            // 
            // product_name
            // 
            this.product_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_name.Location = new System.Drawing.Point(120, 58);
            this.product_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_name.Multiline = true;
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(219, 24);
            this.product_name.TabIndex = 8;
            // 
            // product_barcode
            // 
            this.product_barcode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_barcode.Location = new System.Drawing.Point(120, 20);
            this.product_barcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_barcode.Multiline = true;
            this.product_barcode.Name = "product_barcode";
            this.product_barcode.Size = new System.Drawing.Size(219, 24);
            this.product_barcode.TabIndex = 9;
            // 
            // product__image
            // 
            this.product__image.InitialImage = ((System.Drawing.Image)(resources.GetObject("product__image.InitialImage")));
            this.product__image.Location = new System.Drawing.Point(626, 13);
            this.product__image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product__image.Name = "product__image";
            this.product__image.Size = new System.Drawing.Size(252, 284);
            this.product__image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product__image.TabIndex = 35;
            this.product__image.TabStop = false;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(891, 570);
            this.Controls.Add(this.product_grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.product__image);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품 관리";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.ImeModeChanged += new System.EventHandler(this.ProductManagement_ImeModeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product__image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView product_grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox product_event;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_count;
        private System.Windows.Forms.ComboBox product_select;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox product__unit_price;
        private System.Windows.Forms.Button btn_modified;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.TextBox product_cust_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.TextBox product_barcode;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.PictureBox product__image;
        private System.Windows.Forms.Button btn_image_search;
    }
}