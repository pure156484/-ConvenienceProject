﻿namespace PosProject_psi
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnWait = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtReturnMoney = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBacode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPordInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnGarbage = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnGain = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnEmploy = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGrid.ColumnHeadersHeight = 40;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.itemGrid.Location = new System.Drawing.Point(12, 64);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemGrid.RowTemplate.Height = 23;
            this.itemGrid.Size = new System.Drawing.Size(732, 301);
            this.itemGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 52);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(184, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "홍길동(01)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(130, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "날짜 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(121, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "근무자 :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(184, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "날짜";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("휴먼매직체", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "등록";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Location = new System.Drawing.Point(750, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(168, 236);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 46);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(168, 164);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 46);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(168, 92);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 46);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(168, 20);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 46);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.Location = new System.Drawing.Point(87, 236);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 46);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(6, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(87, 164);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 46);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(6, 164);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 46);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(87, 92);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 46);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(6, 92);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 46);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(87, 20);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 46);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(6, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 46);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btnWait
            // 
            this.btnWait.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWait.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWait.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWait.Location = new System.Drawing.Point(833, 6);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(110, 52);
            this.btnWait.TabIndex = 4;
            this.btnWait.Text = "보류";
            this.btnWait.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtReturnMoney);
            this.panel2.Controls.Add(this.txtMoney);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtBacode);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPordInfo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 187);
            this.panel2.TabIndex = 5;
            // 
            // txtReturnMoney
            // 
            this.txtReturnMoney.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReturnMoney.Location = new System.Drawing.Point(635, 141);
            this.txtReturnMoney.Multiline = true;
            this.txtReturnMoney.Name = "txtReturnMoney";
            this.txtReturnMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReturnMoney.Size = new System.Drawing.Size(208, 39);
            this.txtReturnMoney.TabIndex = 14;
            this.txtReturnMoney.Text = "0원";
            this.txtReturnMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoney.Location = new System.Drawing.Point(635, 92);
            this.txtMoney.Multiline = true;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMoney.Size = new System.Drawing.Size(208, 39);
            this.txtMoney.TabIndex = 13;
            this.txtMoney.Text = "0원";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrice.Location = new System.Drawing.Point(635, 47);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(208, 39);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.Text = "0원";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBacode
            // 
            this.txtBacode.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBacode.Location = new System.Drawing.Point(635, 2);
            this.txtBacode.Multiline = true;
            this.txtBacode.Name = "txtBacode";
            this.txtBacode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBacode.Size = new System.Drawing.Size(208, 39);
            this.txtBacode.TabIndex = 11;
            this.txtBacode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("휴먼매직체", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(497, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "거스름돈";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("휴먼매직체", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(497, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 39);
            this.label8.TabIndex = 7;
            this.label8.Text = "받은금액";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("휴먼매직체", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(497, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "받을금액";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("휴먼매직체", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(497, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "상품등록";
            // 
            // txtPordInfo
            // 
            this.txtPordInfo.Location = new System.Drawing.Point(49, 0);
            this.txtPordInfo.Multiline = true;
            this.txtPordInfo.Name = "txtPordInfo";
            this.txtPordInfo.Size = new System.Drawing.Size(442, 187);
            this.txtPordInfo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("휴먼매직체", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(2, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 144);
            this.label5.TabIndex = 5;
            this.label5.Text = "상품정보";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Orange;
            this.btnList.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnList.Location = new System.Drawing.Point(12, 371);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(150, 46);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "영수증조회";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGarbage
            // 
            this.btnGarbage.BackColor = System.Drawing.Color.Orange;
            this.btnGarbage.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnGarbage.FlatAppearance.BorderSize = 0;
            this.btnGarbage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarbage.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGarbage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGarbage.Location = new System.Drawing.Point(346, 371);
            this.btnGarbage.Name = "btnGarbage";
            this.btnGarbage.Size = new System.Drawing.Size(150, 46);
            this.btnGarbage.TabIndex = 7;
            this.btnGarbage.Text = "폐기물";
            this.btnGarbage.UseVisualStyleBackColor = false;
            this.btnGarbage.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.Orange;
            this.btnDiscount.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDiscount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiscount.Location = new System.Drawing.Point(680, 371);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(150, 46);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.Text = "할인";
            this.btnDiscount.UseVisualStyleBackColor = false;
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.Orange;
            this.btnEvent.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEvent.Location = new System.Drawing.Point(513, 371);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(150, 46);
            this.btnEvent.TabIndex = 7;
            this.btnEvent.Text = "행사상품";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnGain
            // 
            this.btnGain.BackColor = System.Drawing.Color.White;
            this.btnGain.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnGain.FlatAppearance.BorderSize = 0;
            this.btnGain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGain.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGain.Location = new System.Drawing.Point(879, 555);
            this.btnGain.Name = "btnGain";
            this.btnGain.Size = new System.Drawing.Size(120, 55);
            this.btnGain.TabIndex = 4;
            this.btnGain.Text = "매출현황";
            this.btnGain.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Orange;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrder.Location = new System.Drawing.Point(849, 371);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(150, 46);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "발주/재고";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnEmploy
            // 
            this.btnEmploy.BackColor = System.Drawing.Color.White;
            this.btnEmploy.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnEmploy.FlatAppearance.BorderSize = 0;
            this.btnEmploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploy.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEmploy.Location = new System.Drawing.Point(879, 489);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(120, 55);
            this.btnEmploy.TabIndex = 9;
            this.btnEmploy.Text = "직원관리";
            this.btnEmploy.UseVisualStyleBackColor = false;
            this.btnEmploy.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCustomer.Location = new System.Drawing.Point(879, 423);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(120, 55);
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.Text = "회원관리";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.Orange;
            this.btnProd.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProd.Location = new System.Drawing.Point(179, 371);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(150, 46);
            this.btnProd.TabIndex = 11;
            this.btnProd.Text = "상품관리";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.button10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1010, 622);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnEmploy);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnGarbage);
            this.Controls.Add(this.btnGain);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnWait);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.itemGrid);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnGarbage;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnGain;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnEmploy;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.TextBox txtReturnMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBacode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPordInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnProd;
    }
}
