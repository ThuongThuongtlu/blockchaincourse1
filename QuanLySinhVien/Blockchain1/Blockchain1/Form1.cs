using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Blockchain;

namespace Blockchain1
{
    public partial class Form1 : Form
    {
        DigitalSignature DigSign = new DigitalSignature();
        public Form1()
        {
            DigSign.AssignNewKey();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void but_Click(object sender, EventArgs e)
        {
            string text1, text2;
            text1 = textBox1.Text.Trim();
            text2 = textBox2.Text.Trim();
            var sha256HashedMessage = Hashing.ComputeHashSha256(Encoding.UTF8.GetBytes(text1));
            var sha256HashedMessage2 = Hashing.ComputeHashSha256(Encoding.UTF8.GetBytes(text2));
            textBox3.Text = Convert.ToBase64String(sha256HashedMessage);
            textBox4.Text = Convert.ToBase64String(sha256HashedMessage2);
        }

        private void button384_Click(object sender, EventArgs e)
        {
            string text1, text2;
            text1 = textBox1.Text.Trim();
            text2 = textBox2.Text.Trim();
            var sha384HashedMessage = Hashing.ComputeHashSha384(Encoding.UTF8.GetBytes(text1));
            var sha384HashedMessage2 = Hashing.ComputeHashSha384(Encoding.UTF8.GetBytes(text2));
            textBox3.Text = Convert.ToBase64String(sha384HashedMessage);
            textBox4.Text = Convert.ToBase64String(sha384HashedMessage2);
        }

        private void button512_Click(object sender, EventArgs e)
        {
            string text1, text2;
            text1 = textBox1.Text.Trim();
            text2 = textBox2.Text.Trim();
            var sha512HashedMessage = Hashing.ComputeHashSha512(Encoding.UTF8.GetBytes(text1));
            var sha512HashedMessage2 = Hashing.ComputeHashSha512(Encoding.UTF8.GetBytes(text2));
            textBox3.Text = Convert.ToBase64String(sha512HashedMessage);
            textBox4.Text = Convert.ToBase64String(sha512HashedMessage2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1;
            text1 = truocbam.Text.Trim();
            var sha256HashedMessage = Hashing.ComputeHashSha256(Encoding.UTF8.GetBytes(text1));
            saubam.Text = Convert.ToBase64String(sha256HashedMessage);
            var signature = DigSign.SignData(sha256HashedMessage);
            chukyso.Text = Convert.ToBase64String(signature);
        }

        private void chukyso_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text1;
            text1 = truocbam.Text.Trim();
            var sha256HashedMessage = Hashing.ComputeHashSha256(Encoding.UTF8.GetBytes(text1));
            var signature = DigSign.SignData(sha256HashedMessage);
            bool t = DigSign.VerifiSignature(sha256HashedMessage, signature);
            if (t == true)
                MessageBox.Show("Chữ ký được xác thực");
            else
                MessageBox.Show("Chữ ký không đúng!!!");
        }

        private void truocbam_TextChanged(object sender, EventArgs e)
        {

        }

        private void saubam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnendcode_Click(object sender, EventArgs e)
        {
            string a;
            a = input.Text.Trim();
            output.Text = Convert.ToBase64String(DigSign.Encrypt(Encoding.Unicode.GetBytes(a)));
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string a;
            a = deinput.Text.Trim();
            byte[] data = System.Convert.FromBase64String(a);
            deoutput.Text = Convert.ToBase64String(DigSign.Decrypt(data));

        }
    }
}
