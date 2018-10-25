namespace Blockchain1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn256 = new System.Windows.Forms.Button();
            this.button384 = new System.Windows.Forms.Button();
            this.button512 = new System.Windows.Forms.Button();
            this.truocbam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saubam = new System.Windows.Forms.TextBox();
            this.chukyso = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbam = new System.Windows.Forms.Button();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deinput = new System.Windows.Forms.RichTextBox();
            this.deoutput = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnendcode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản rõ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(516, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(25, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bản mã";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(519, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(39, -25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(518, 20);
            this.textBox5.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(37, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(518, 20);
            this.textBox4.TabIndex = 0;
            // 
            // btn256
            // 
            this.btn256.Location = new System.Drawing.Point(611, 41);
            this.btn256.Name = "btn256";
            this.btn256.Size = new System.Drawing.Size(84, 27);
            this.btn256.TabIndex = 3;
            this.btn256.Text = "HASH256";
            this.btn256.UseVisualStyleBackColor = true;
            this.btn256.Click += new System.EventHandler(this.but_Click);
            // 
            // button384
            // 
            this.button384.Location = new System.Drawing.Point(611, 97);
            this.button384.Name = "button384";
            this.button384.Size = new System.Drawing.Size(84, 27);
            this.button384.TabIndex = 4;
            this.button384.Text = "HASH384";
            this.button384.UseVisualStyleBackColor = true;
            this.button384.Click += new System.EventHandler(this.button384_Click);
            // 
            // button512
            // 
            this.button512.Location = new System.Drawing.Point(611, 159);
            this.button512.Name = "button512";
            this.button512.Size = new System.Drawing.Size(84, 26);
            this.button512.TabIndex = 5;
            this.button512.Text = "HASH512";
            this.button512.UseVisualStyleBackColor = true;
            this.button512.Click += new System.EventHandler(this.button512_Click);
            // 
            // truocbam
            // 
            this.truocbam.Location = new System.Drawing.Point(9, 32);
            this.truocbam.Name = "truocbam";
            this.truocbam.Size = new System.Drawing.Size(274, 20);
            this.truocbam.TabIndex = 6;
            this.truocbam.TextChanged += new System.EventHandler(this.truocbam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Văn bản trước băm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Văn bản sau băm";
            // 
            // saubam
            // 
            this.saubam.Location = new System.Drawing.Point(9, 101);
            this.saubam.Name = "saubam";
            this.saubam.Size = new System.Drawing.Size(274, 20);
            this.saubam.TabIndex = 9;
            this.saubam.TextChanged += new System.EventHandler(this.saubam_TextChanged);
            // 
            // chukyso
            // 
            this.chukyso.Location = new System.Drawing.Point(9, 140);
            this.chukyso.Name = "chukyso";
            this.chukyso.Size = new System.Drawing.Size(274, 82);
            this.chukyso.TabIndex = 10;
            this.chukyso.Text = "";
            this.chukyso.TextChanged += new System.EventHandler(this.chukyso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chữ ký số";
            // 
            // btnbam
            // 
            this.btnbam.Location = new System.Drawing.Point(9, 58);
            this.btnbam.Name = "btnbam";
            this.btnbam.Size = new System.Drawing.Size(51, 24);
            this.btnbam.TabIndex = 12;
            this.btnbam.Text = "Băm";
            this.btnbam.UseVisualStyleBackColor = true;
            this.btnbam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Location = new System.Drawing.Point(205, 228);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(67, 26);
            this.btnkiemtra.TabIndex = 13;
            this.btnkiemtra.Text = "Kiểm tra";
            this.btnkiemtra.UseVisualStyleBackColor = true;
            this.btnkiemtra.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbam);
            this.groupBox3.Controls.Add(this.btnkiemtra);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chukyso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.truocbam);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.saubam);
            this.groupBox3.Location = new System.Drawing.Point(25, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 273);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sign";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.deinput);
            this.groupBox4.Controls.Add(this.deoutput);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.input);
            this.groupBox4.Controls.Add(this.output);
            this.groupBox4.Controls.Add(this.btnDecode);
            this.groupBox4.Controls.Add(this.btnendcode);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(326, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 273);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encode-Decode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "output";
            // 
            // deinput
            // 
            this.deinput.AccessibleName = "";
            this.deinput.Location = new System.Drawing.Point(6, 159);
            this.deinput.Name = "deinput";
            this.deinput.Size = new System.Drawing.Size(165, 73);
            this.deinput.TabIndex = 9;
            this.deinput.Text = "";
            // 
            // deoutput
            // 
            this.deoutput.Location = new System.Drawing.Point(191, 168);
            this.deoutput.Name = "deoutput";
            this.deoutput.Size = new System.Drawing.Size(172, 73);
            this.deoutput.TabIndex = 8;
            this.deoutput.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "output";
            // 
            // input
            // 
            this.input.AccessibleName = "";
            this.input.Location = new System.Drawing.Point(6, 32);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(170, 73);
            this.input.TabIndex = 5;
            this.input.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(191, 32);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(172, 73);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(107, 241);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(69, 26);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "DeCode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnendcode
            // 
            this.btnendcode.Location = new System.Drawing.Point(105, 111);
            this.btnendcode.Name = "btnendcode";
            this.btnendcode.Size = new System.Drawing.Size(71, 27);
            this.btnendcode.TabIndex = 2;
            this.btnendcode.Text = "EnCode";
            this.btnendcode.UseVisualStyleBackColor = true;
            this.btnendcode.Click += new System.EventHandler(this.btnendcode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 500);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button512);
            this.Controls.Add(this.button384);
            this.Controls.Add(this.btn256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn256;
        private System.Windows.Forms.Button button384;
        private System.Windows.Forms.Button button512;
        private System.Windows.Forms.TextBox truocbam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saubam;
        private System.Windows.Forms.RichTextBox chukyso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbam;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnendcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox deinput;
        private System.Windows.Forms.RichTextBox deoutput;
        private System.Windows.Forms.Label label7;
    }
}

