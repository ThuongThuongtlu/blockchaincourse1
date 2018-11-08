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
            this.txtChiphi = new System.Windows.Forms.TextBox();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btclear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtNguoiMuon = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrird = new System.Windows.Forms.DataGridView();
            this.MNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrird)).BeginInit();
            this.txtfilename.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChiphi);
            this.groupBox1.Controls.Add(this.txtNgayTra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btclear);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.txtNguoiMuon);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtMNV);
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
            // txtChiphi
            // 
            this.txtChiphi.Location = new System.Drawing.Point(82, 141);
            this.txtChiphi.Name = "txtChiphi";
            this.txtChiphi.Size = new System.Drawing.Size(180, 20);
            this.txtChiphi.TabIndex = 13;
            this.txtChiphi.Text = "10000";
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Location = new System.Drawing.Point(82, 115);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(180, 20);
            this.txtNgayTra.TabIndex = 12;
            this.txtNgayTra.Text = "29-Oct-18 8:37:17 PM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chi phí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày trả";
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(198, 174);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(52, 27);
            this.btclear.TabIndex = 9;
            this.btclear.Text = "&Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(82, 174);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 27);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add Transaction";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNguoiMuon
            // 
            this.txtNguoiMuon.Location = new System.Drawing.Point(82, 84);
            this.txtNguoiMuon.Name = "txtNguoiMuon";
            this.txtNguoiMuon.Size = new System.Drawing.Size(180, 20);
            this.txtNguoiMuon.TabIndex = 6;
            this.txtNguoiMuon.Text = "A";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(82, 56);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(180, 20);
            this.txtMaSach.TabIndex = 5;
            this.txtMaSach.Text = "CT100";
            // 
            // txtMNV
            // 
            this.txtMNV.Location = new System.Drawing.Point(82, 24);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(180, 20);
            this.txtMNV.TabIndex = 4;
            this.txtMNV.Text = "A27857";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dataGrird
            // 
            this.dataGrird.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGrird.AllowUserToAddRows = false;
            this.dataGrird.AllowUserToDeleteRows = false;
            this.dataGrird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MNV,
            this.MaSach,
            this.NguoiMuon,
            this.TGMuon,
            this.TGTra,
            this.ChiPhi});
            this.dataGrird.Location = new System.Drawing.Point(12, 263);
            this.dataGrird.Name = "dataGrird";
            this.dataGrird.ReadOnly = true;
            this.dataGrird.Size = new System.Drawing.Size(653, 153);
            this.dataGrird.TabIndex = 1;
            this.dataGrird.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrird_CellContentClick);
            // 
            // MNV
            // 
            this.MNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MNV.DataPropertyName = "MNV";
            this.MNV.HeaderText = "Mã nhân viên";
            this.MNV.Name = "MNV";
            this.MNV.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // NguoiMuon
            // 
            this.NguoiMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NguoiMuon.DataPropertyName = "NguoiMuon";
            this.NguoiMuon.HeaderText = "Người mượn";
            this.NguoiMuon.Name = "NguoiMuon";
            this.NguoiMuon.ReadOnly = true;
            // 
            // TGMuon
            // 
            this.TGMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TGMuon.DataPropertyName = "TGMuon";
            this.TGMuon.HeaderText = "Ngày mượn";
            this.TGMuon.Name = "TGMuon";
            this.TGMuon.ReadOnly = true;
            // 
            // TGTra
            // 
            this.TGTra.DataPropertyName = "TGTra";
            this.TGTra.HeaderText = "Ngày trả";
            this.TGTra.Name = "TGTra";
            this.TGTra.ReadOnly = true;
            // 
            // ChiPhi
            // 
            this.ChiPhi.DataPropertyName = "ChiPhi";
            this.ChiPhi.HeaderText = "Chi phí";
            this.ChiPhi.Name = "ChiPhi";
            this.ChiPhi.ReadOnly = true;
            // 
            // txtfilename
            // 
            this.txtfilename.Controls.Add(this.button2);
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
            this.button1.Location = new System.Drawing.Point(26, 165);
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
            this.txtFname.Text = "test.txt";
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
            this.Show.Location = new System.Drawing.Point(128, 165);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "ShowAll";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Text = "Thuongtlu";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtNguoiMuon;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMNV;
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
        private TextBox txtChiphi;
        private TextBox txtNgayTra;
        private Label label7;
        private Label label4;
        private DataGridViewTextBoxColumn MNV;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn NguoiMuon;
        private DataGridViewTextBoxColumn TGMuon;
        private DataGridViewTextBoxColumn TGTra;
        private DataGridViewTextBoxColumn ChiPhi;
        private Button button2;
    }
}

