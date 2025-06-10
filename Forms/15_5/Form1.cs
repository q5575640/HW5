using System;
using System.IO;
using System.Windows.Forms;

namespace Ch15_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "NotePad.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            // 如果檔案存在，就讀取文字內容
            if (File.Exists(path))
            {
                txtOutput.Text = File.ReadAllText(path);
                txtOutput.SelectionStart = 0;
                txtOutput.SelectionLength = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 將 txtOutput 的內容寫入文字檔案
            File.WriteAllText(path, txtOutput.Text);
        }
    }
}
