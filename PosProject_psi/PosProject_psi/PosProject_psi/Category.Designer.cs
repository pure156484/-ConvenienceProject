namespace PosProject_psi
{
    partial class Category
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
            this.btn_modi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.category_grid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.category_num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.category_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modi
            // 
            this.btn_modi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_modi.FlatAppearance.BorderSize = 0;
            this.btn_modi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_modi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modi.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_modi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_modi.Location = new System.Drawing.Point(111, 240);
            this.btn_modi.Name = "btn_modi";
            this.btn_modi.Size = new System.Drawing.Size(95, 46);
            this.btn_modi.TabIndex = 30;
            this.btn_modi.Text = "수 정";
            this.btn_modi.UseVisualStyleBackColor = false;
            this.btn_modi.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "카테고리";
            // 
            // category_name
            // 
            this.category_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.category_name.Location = new System.Drawing.Point(150, 44);
            this.category_name.Multiline = true;
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(158, 20);
            this.category_name.TabIndex = 38;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_delete.Location = new System.Drawing.Point(212, 240);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 46);
            this.btn_delete.TabIndex = 39;
            this.btn_delete.Text = "삭 제";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_add.Location = new System.Drawing.Point(10, 240);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 46);
            this.btn_add.TabIndex = 40;
            this.btn_add.Text = "등 록";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // category_grid
            // 
            this.category_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_grid.Location = new System.Drawing.Point(10, 79);
            this.category_grid.Name = "category_grid";
            this.category_grid.ReadOnly = true;
            this.category_grid.RowTemplate.Height = 23;
            this.category_grid.Size = new System.Drawing.Size(297, 150);
            this.category_grid.TabIndex = 42;
            this.category_grid.Click += new System.EventHandler(this.category_grid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "카테고리 번호";
            // 
            // category_num
            // 
            this.category_num.AutoSize = true;
            this.category_num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.category_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.category_num.Location = new System.Drawing.Point(147, 21);
            this.category_num.Name = "category_num";
            this.category_num.Size = new System.Drawing.Size(0, 16);
            this.category_num.TabIndex = 44;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(324, 295);
            this.Controls.Add(this.category_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category_grid);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.btn_modi);
            this.Name = "Category";
            this.Text = "카테고리 관리";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.category_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView category_grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label category_num;
    }
}