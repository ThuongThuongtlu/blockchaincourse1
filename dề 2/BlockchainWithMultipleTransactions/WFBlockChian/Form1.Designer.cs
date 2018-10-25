using System;
using System.Windows.Forms;

namespace WFBlockChain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoCMT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btclear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtNgayCap = new System.Windows.Forms.TextBox();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtToChucCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrird = new System.Windows.Forms.DataGridView();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLanThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGNhapDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfilename = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btverify = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnimport = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.txtnumblock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBlockNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreatDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrird)).BeginInit();
            this.txtfilename.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoCMT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtThoiHan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btclear);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.txtNgayCap);
            this.groupBox1.Controls.Add(this.txtNguoiNhan);
            this.groupBox1.Controls.Add(this.txtToChucCap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // txtSoCMT
            // 
            this.txtSoCMT.Location = new System.Drawing.Point(135, 87);
            this.txtSoCMT.Name = "txtSoCMT";
            this.txtSoCMT.Size = new System.Drawing.Size(180, 20);
            this.txtSoCMT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số CMT";
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Location = new System.Drawing.Point(135, 144);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(180, 20);
            this.txtThoiHan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thời hạn chứng chỉ";
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(197, 174);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(52, 27);
            this.btclear.TabIndex = 9;
            this.btclear.Text = "&Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(65, 174);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 27);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add Transaction";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNgayCap
            // 
            this.txtNgayCap.Location = new System.Drawing.Point(135, 115);
            this.txtNgayCap.Name = "txtNgayCap";
            this.txtNgayCap.Size = new System.Drawing.Size(180, 20);
            this.txtNgayCap.TabIndex = 6;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(135, 56);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(180, 20);
            this.txtNguoiNhan.TabIndex = 5;
            // 
            // txtToChucCap
            // 
            this.txtToChucCap.Location = new System.Drawing.Point(135, 31);
            this.txtToChucCap.Name = "txtToChucCap";
            this.txtToChucCap.Size = new System.Drawing.Size(180, 20);
            this.txtToChucCap.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người nhận chứng chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổ chức cấp";
            // 
            // dataGrird
            // 
            this.dataGrird.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGrird.AllowUserToAddRows = false;
            this.dataGrird.AllowUserToDeleteRows = false;
            this.dataGrird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSV,
            this.MaMon,
            this.Diem,
            this.DiemLanThu,
            this.TGNhapDiem});
            this.dataGrird.Location = new System.Drawing.Point(12, 227);
            this.dataGrird.Name = "dataGrird";
            this.dataGrird.ReadOnly = true;
            this.dataGrird.Size = new System.Drawing.Size(617, 112);
            this.dataGrird.TabIndex = 1;
            this.dataGrird.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrird_CellContentClick);
            // 
            // MSV
            // 
            this.MSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSV.DataPropertyName = "ToChucCap";
            this.MSV.HeaderText = "Tổ chức cấp";
            this.MSV.Name = "MSV";
            this.MSV.ReadOnly = true;
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.DataPropertyName = "NguoiNhanChungChi";
            this.MaMon.HeaderText = "Người nhận chứng chỉ";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // Diem
            // 
            this.Diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diem.DataPropertyName = "SoCMT";
            this.Diem.HeaderText = "Số chứng minh thư";
            this.Diem.Name = "Diem";
            this.Diem.ReadOnly = true;
            // 
            // DiemLanThu
            // 
            this.DiemLanThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemLanThu.DataPropertyName = "NgayCap";
            this.DiemLanThu.HeaderText = "Ngày cấp";
            this.DiemLanThu.Name = "DiemLanThu";
            this.DiemLanThu.ReadOnly = true;
            // 
            // TGNhapDiem
            // 
            this.TGNhapDiem.DataPropertyName = "ThoiHan";
            this.TGNhapDiem.HeaderText = "Thời hạn chứng chỉ";
            this.TGNhapDiem.Name = "TGNhapDiem";
            this.TGNhapDiem.ReadOnly = true;
            // 
            // txtfilename
            // 
            this.txtfilename.Controls.Add(this.button1);
            this.txtfilename.Controls.Add(this.btverify);
            this.txtfilename.Controls.Add(this.btnexport);
            this.txtfilename.Controls.Add(this.label6);
            this.txtfilename.Controls.Add(this.txtFname);
            this.txtfilename.Controls.Add(this.btnimport);
            this.txtfilename.Controls.Add(this.Show);
            this.txtfilename.Controls.Add(this.txtnumblock);
            this.txtfilename.Controls.Add(this.label5);
            this.txtfilename.Location = new System.Drawing.Point(390, 20);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(275, 201);
            this.txtfilename.TabIndex = 2;
            this.txtfilename.TabStop = false;
            this.txtfilename.Text = "Blockchain";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "MerkleTreeHash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btverify
            // 
            this.btverify.Location = new System.Drawing.Point(142, 107);
            this.btverify.Name = "btverify";
            this.btverify.Size = new System.Drawing.Size(104, 27);
            this.btverify.TabIndex = 8;
            this.btverify.Text = "Verify Block chain";
            this.btverify.UseVisualStyleBackColor = true;
            this.btverify.Click += new System.EventHandler(this.btverify_Click);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(167, 55);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(79, 28);
            this.btnexport.TabIndex = 7;
            this.btnexport.Text = "Export data";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "File name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(68, 26);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(178, 20);
            this.txtFname.TabIndex = 5;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(68, 55);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(82, 28);
            this.btnimport.TabIndex = 4;
            this.btnimport.Text = "Import data";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(154, 167);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(54, 28);
            this.Show.TabIndex = 2;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // txtnumblock
            // 
            this.txtnumblock.Location = new System.Drawing.Point(88, 140);
            this.txtnumblock.Name = "txtnumblock";
            this.txtnumblock.Size = new System.Drawing.Size(73, 20);
            this.txtnumblock.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Block number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "BlockNum";
            // 
            // txtBlockNum
            // 
            this.txtBlockNum.Location = new System.Drawing.Point(136, 373);
            this.txtBlockNum.Name = "txtBlockNum";
            this.txtBlockNum.Size = new System.Drawing.Size(100, 20);
            this.txtBlockNum.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "CreatDate";
            // 
            // txtCreatDate
            // 
            this.txtCreatDate.Location = new System.Drawing.Point(137, 411);
            this.txtCreatDate.Name = "txtCreatDate";
            this.txtCreatDate.Size = new System.Drawing.Size(100, 20);
            this.txtCreatDate.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 465);
            this.Controls.Add(this.txtCreatDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBlockNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.dataGrird);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Blockchain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrird)).EndInit();
            this.txtfilename.ResumeLayout(false);
            this.txtfilename.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGrird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtNgayCap;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.TextBox txtToChucCap;
        private System.Windows.Forms.DataGridView dataGrird;
        private System.Windows.Forms.GroupBox txtfilename;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox txtnumblock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnimport;
        private Button btverify;
        private Button button1;
        private TextBox txtThoiHan;
        private Label label4;
        private DataGridViewTextBoxColumn MSV;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn Diem;
        private DataGridViewTextBoxColumn DiemLanThu;
        private DataGridViewTextBoxColumn TGNhapDiem;
        private TextBox txtSoCMT;
        private Label label7;
        private Label label8;
        private TextBox txtBlockNum;
        private Label label9;
        private TextBox txtCreatDate;
    }
}

