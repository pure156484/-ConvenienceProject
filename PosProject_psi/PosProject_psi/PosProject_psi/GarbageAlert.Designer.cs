namespace PosProject_psi
{
    partial class GarbageAlert
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GarbageView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGarbageProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GarbageView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PosProject_psi.Properties.Resources.if_101_Warning_183416;
            this.pictureBox1.Location = new System.Drawing.Point(180, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warning!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(107, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "유효기간이 얼마 남지 않는 상품이 존재합니다!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(183, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "판매/재고 관리 시 확인 바랍니다.";
            // 
            // GarbageView
            // 
            this.GarbageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GarbageView.Location = new System.Drawing.Point(12, 259);
            this.GarbageView.Name = "GarbageView";
            this.GarbageView.RowTemplate.Height = 27;
            this.GarbageView.Size = new System.Drawing.Size(653, 164);
            this.GarbageView.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(12, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(321, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "확인";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGarbageProd
            // 
            this.btnGarbageProd.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGarbageProd.Location = new System.Drawing.Point(352, 441);
            this.btnGarbageProd.Name = "btnGarbageProd";
            this.btnGarbageProd.Size = new System.Drawing.Size(313, 43);
            this.btnGarbageProd.TabIndex = 6;
            this.btnGarbageProd.Text = "폐기메뉴";
            this.btnGarbageProd.UseVisualStyleBackColor = true;
            this.btnGarbageProd.Click += new System.EventHandler(this.btnGarbageProd_Click);
            // 
            // GarbageAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 496);
            this.Controls.Add(this.btnGarbageProd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.GarbageView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GarbageAlert";
            this.Text = "유효기간 알림";
            this.Load += new System.EventHandler(this.GarbageAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GarbageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GarbageView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGarbageProd;
    }
}