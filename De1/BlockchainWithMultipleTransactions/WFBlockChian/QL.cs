using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;
using BlockChainCourse.Cryptography;
using BlockChainCourse.BlockWithMultipleTransactions;
using System.IO;

namespace WFBlockChain
{
    public partial class Form1 : Form
    {
        BlockChain chain = new BlockChain();
        int i = 0;
        IBlock block1 = new Block(0);
        public Form1()
        {
            InitializeComponent();
        }
        public bool Isnumber(string pvalue)
        {
            foreach (Char c in pvalue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string a = this.txtMNV.Text.Trim();
            string b = this.txtMaSach.Text.Trim();
            string c = this.txtNguoiMuon.Text.Trim();
            DateTime d = Convert.ToDateTime(this.txtNgayTra.Text.Trim());
            if (Isnumber(this.txtChiphi.Text.Trim()) == false)
                throw new InvalidOperationException("Lỗi nhập");
            double f = Convert.ToDouble(this.txtChiphi.Text.Trim());
            //int lan = 1;
            //for (int g = 0; g < block1.Transaction.Count(); g++)
            //    if (block1.Transaction[g].MSV == a && block1.Transaction[g].MaMon == b)
            //        lan++;
            //for (int k = 0; k < i; k++)
            //{
            //    for (int z = 0; z < 5; z++)

            //        if (chain.Blocks[k].Transaction[z].MSV == a && chain.Blocks[k].Transaction[z].MaMon == b)
            //            lan++;
            //}
            
            ITransaction x = new Transaction(a, b,c, DateTime.Now, d,f, ClaimType.TotalLoss);
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b)&&!string.IsNullOrEmpty(c) &&
                !string.IsNullOrEmpty(this.txtNgayTra.Text.Trim())&& f>0)
            {
                if (block1.Transaction.Count < 5)
                {
                    block1.AddTransaction(x);

                    MessageBox.Show("Thêm Transaction thành công!");
                }
                else
                {
                    if (i == 0)
                        block1.SetBlockHash(null);
                    else
                        block1.SetBlockHash(chain.Blocks[i - 1]);
                    chain.AcceptBlock(block1);
                    MessageBox.Show("Block" + Convert.ToInt32(i + 1) + " được thêm vào blockchain!");
                    GhiFile();
                    block1 = new Block(i + 1);
                    i++;
                }
                dataGrird.DataSource = null;
                this.dataGrird.DataSource = block1.Transaction;
            }
            else
                throw new InvalidOperationException("Lỗi nhập");
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtMNV.Clear();
            txtNguoiMuon.Clear();
            txtNgayTra.Clear();
            txtChiphi.Clear();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if(Isnumber(this.txtnumblock.Text.Trim())==false)
                throw new InvalidOperationException("Lỗi nhập");
            int num = Convert.ToInt32(this.txtnumblock.Text.Trim());
            if (chain.Blocks.Count < num)
                MessageBox.Show("Lỗi!!");
            dataGrird.DataSource = null;
            this.dataGrird.DataSource = chain.Blocks[num].Transaction;

        }

      
        private void GhiFile()
        {

            FileStream fs = new FileStream("E:\\Ledgers.txt",FileMode.Append);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            for(int j=0;j<i;j++)
            {
                sWriter.WriteLine(chain.Blocks[j].BlockNumber);
                sWriter.WriteLine(chain.Blocks[j].CreatedDate);
                sWriter.WriteLine(chain.Blocks[j].BlockHash);
                sWriter.WriteLine(chain.Blocks[j].PreviousBlockHash);
                for (int k=0;k<5;k++)
                    sWriter.WriteLine(chain.Blocks[j].Transaction[k].ToString());
            }
            sWriter.Flush();
            fs.Close();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            string filename = ("E:\\" + txtFname.Text.Trim());
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            for (int j = 0; j < i; j++)
            {
                sWriter.WriteLine(chain.Blocks[j].BlockNumber);
                sWriter.WriteLine(chain.Blocks[j].CreatedDate);
                sWriter.WriteLine(chain.Blocks[j].BlockHash);
                sWriter.WriteLine(chain.Blocks[j].PreviousBlockHash);
                for (int k = 0; k < 5; k++)
                    sWriter.WriteLine(chain.Blocks[j].Transaction[k].ToString());
            }
            sWriter.Flush();
            fs.Close();
            MessageBox.Show("Đã export dữ liệu ra file " + filename);
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            chain = new BlockChain();
            string filename = ("E:\\" + txtFname.Text.Trim());
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            while (!rd.EndOfStream)
            {
                block1 = new Block(i);
                int line1 = Convert.ToInt32(rd.ReadLine());
                DateTime line2 = Convert.ToDateTime(rd.ReadLine());
                string line3 = rd.ReadLine();
                string line4 = rd.ReadLine();
                for (int k = 0; k < 5; k++)
                {
                    ITransaction a = new Transaction(rd.ReadLine());
                    block1.AddTransaction(a);
                }
                if(i==0)
                    block1.Add(line1, line2, line3, line4,null);
                else
                    block1.Add(line1, line2, line3, line4, chain.Blocks[i - 1]);
                chain.AcceptBlock(block1);
                i++;
            }
            i--;
            MessageBox.Show("Import dữ liệu thành công!!");
            rd.Close();
            Console.ReadLine();
        }

        private void btverify_Click(object sender, EventArgs e)
        {
            if (chain.HeadBlock == null)
                throw new InvalidOperationException("Chưa nhập blockchain!!");
            else
            {
                bool isValid = chain.HeadBlock.IsValidChain(null, true);
                if (isValid)
                    MessageBox.Show("Blockchain còn nguyên vẹn ");
                else
                    MessageBox.Show("Blockchain KHÔNG còn nguyên vẹn");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Isnumber(this.txtnumblock.Text.Trim()) == false)
                throw new InvalidOperationException("Lỗi nhập");
            int num = Convert.ToInt32(this.txtnumblock.Text.Trim());
            chain.Blocks[num].BuildMerkleTree();
            MessageBox.Show(chain.Blocks[num].GetMerkleTree());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Isnumber(this.txtnumblock.Text.Trim()) == false)
                throw new InvalidOperationException("Lỗi nhập");
            int num = Convert.ToInt32(this.txtnumblock.Text.Trim());
            MessageBox.Show("Block: "+ chain.Blocks[num].BlockNumber +
                "\nBlockhash: " + chain.Blocks[num].BlockHash + "\n" +
                "BlockPrevious: " + chain.Blocks[num].PreviousBlockHash 
                +"\nCreatDate: " + chain.Blocks[num].CreatedDate);
        }
    }
}
