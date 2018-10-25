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
            this.btclear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.txtAmout = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
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
            this.btverify = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnimport = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.txtnumblock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrird)).BeginInit();
            this.txtfilename.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btclear);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.txtRegistration);
            this.groupBox1.Controls.Add(this.txtAmout);
            this.groupBox1.Controls.Add(this.txtCN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(195, 122);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(52, 27);
            this.btclear.TabIndex = 9;
            this.btclear.Text = "&Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(72, 122);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 27);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add Transaction";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(113, 88);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(180, 20);
            this.txtRegistration.TabIndex = 6;
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(113, 56);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(180, 20);
            this.txtAmout.TabIndex = 5;
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(113, 28);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(180, 20);
            this.txtCN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
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
            this.dataGrird.Location = new System.Drawing.Point(48, 263);
            this.dataGrird.Name = "dataGrird";
            this.dataGrird.ReadOnly = true;
            this.dataGrird.Size = new System.Drawing.Size(617, 147);
            this.dataGrird.TabIndex = 1;
            this.dataGrird.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrird_CellContentClick);
            // 
            // MSV
            // 
            this.MSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSV.DataPropertyName = "MSV";
            this.MSV.HeaderText = "Mã sinh viên";
            this.MSV.Name = "MSV";
            this.MSV.ReadOnly = true;
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.DataPropertyName = "Mamon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // Diem
            // 
            this.Diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            this.Diem.ReadOnly = true;
            // 
            // DiemLanThu
            // 
            this.DiemLanThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemLanThu.DataPropertyName = "DiemLanThu";
            this.DiemLanThu.HeaderText = "Điểm lần thứ";
            this.DiemLanThu.Name = "DiemLanThu";
            this.DiemLanThu.ReadOnly = true;
            // 
            // TGNhapDiem
            // 
            this.TGNhapDiem.DataPropertyName = "TGNhapDiem";
            this.TGNhapDiem.HeaderText = "Ngày nhập";
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
            // btverify
            // 
            this.btverify.Location = new System.Drawing.Point(134, 110);
            this.btverify.Name = "btverify";
            this.btverify.Size = new System.Drawing.Size(112, 25);
            this.btverify.TabIndex = 8;
            this.btverify.Text = "Verify Block chain";
            this.btverify.UseVisualStyleBackColor = true;
            this.btverify.Click += new System.EventHandler(this.btverify_Click);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(167, 68);
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
            this.btnimport.Location = new System.Drawing.Point(68, 72);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(82, 28);
            this.btnimport.TabIndex = 4;
            this.btnimport.Text = "Import data";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(167, 172);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(53, 23);
            this.Show.TabIndex = 2;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // txtnumblock
            // 
            this.txtnumblock.Location = new System.Drawing.Point(105, 141);
            this.txtnumblock.Name = "txtnumblock";
            this.txtnumblock.Size = new System.Drawing.Size(73, 20);
            this.txtnumblock.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Block number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Merkle Root hash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 465);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.dataGrird);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "File name";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrird)).EndInit();
            this.txtfilename.ResumeLayout(false);
            this.txtfilename.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.TextBox txtAmout;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.DataGridView dataGrird;
        private System.Windows.Forms.GroupBox txtfilename;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox txtnumblock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLanThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGNhapDiem;
        private Button btverify;
        private Button button1;
    }
}

