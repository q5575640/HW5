using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileEditorApp
{
    public partial class Form1 : Form
    {
        string filePath = "listFile.txt";

        public Form1()
        {
            InitializeComponent();
            InitializeFile();
        }

        private void InitializeFile()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "本書是一本適合初學者學習 Visual C# 程式設計的好教材。");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, "");
            MessageBox.Show("內容已清除");
        }

        private void btnAddChen_Click(object sender, EventArgs e)
        {
            File.AppendAllText(filePath, Environment.NewLine + "陳會安");
            MessageBox.Show("已新增空白行與陳會安");
        }

        private void btnAddNames_Click(object sender, EventArgs e)
        {
            File.AppendAllLines(filePath, new[] { "小龍女", "王美麗" });
            MessageBox.Show("已新增兩個名字");
        }

        private void btnRead10Chars_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText(filePath);
            string first10 = content.Length >= 10 ? content.Substring(0, 10) : content;
            MessageBox.Show("前10個字為：" + first10);
        }

        private void btnReadLine3_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 3)
                MessageBox.Show("第3列為：" + lines[2]);
            else
                MessageBox.Show("檔案不足3列");
        }
    }
}
