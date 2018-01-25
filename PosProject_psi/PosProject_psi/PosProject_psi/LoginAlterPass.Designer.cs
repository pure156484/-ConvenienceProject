namespace PosProject_psi
{
    partial class LoginAlterPass
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pk = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_Alter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NewPassCheck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(31, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "주민번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(31, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "전화번호";
            // 
            // txt_pk
            // 
            this.txt_pk.Location = new System.Drawing.Point(186, 75);
            this.txt_pk.Name = "txt_pk";
            this.txt_pk.Size = new System.Drawing.Size(133, 21);
            this.txt_pk.TabIndex = 25;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(186, 33);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(133, 21);
            this.txt_phone.TabIndex = 24;
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackColor = System.Drawing.Color.Orange;
            this.btn_Alter.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn_Alter.FlatAppearance.BorderSize = 0;
            this.btn_Alter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alter.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Alter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Alter.Location = new System.Drawing.Point(117, 245);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(125, 49);
            this.btn_Alter.TabIndex = 23;
            this.btn_Alter.Text = "변경";
            this.btn_Alter.UseVisualStyleBackColor = false;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(31, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "현재 비밀번호";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(186, 117);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(133, 21);
            this.txt_pass.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(31, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "새 비밀번호";
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Location = new System.Drawing.Point(186, 159);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(133, 21);
            this.txt_NewPass.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(31, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "새 비밀번호 확인";
            // 
            // txt_NewPassCheck
            // 
            this.txt_NewPassCheck.Location = new System.Drawing.Point(186, 201);
            this.txt_NewPassCheck.Name = "txt_NewPassCheck";
            this.txt_NewPassCheck.Size = new System.Drawing.Size(133, 21);
            this.txt_NewPassCheck.TabIndex = 32;
            // 
            // LoginAlterPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(359, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NewPassCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pk);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.btn_Alter);
            this.Name = "LoginAlterPass";
            this.Text = "LoginAlterPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pk;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_Alter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NewPassCheck;
    }
}