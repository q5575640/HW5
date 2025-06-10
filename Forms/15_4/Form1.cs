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
                File.WriteAllText(filePath, "���ѬO�@���A�X��Ǫ̾ǲ� Visual C# �{���]�p���n�Ч��C");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, "");
            MessageBox.Show("���e�w�M��");
        }

        private void btnAddChen_Click(object sender, EventArgs e)
        {
            File.AppendAllText(filePath, Environment.NewLine + "���|�w");
            MessageBox.Show("�w�s�W�ťզ�P���|�w");
        }

        private void btnAddNames_Click(object sender, EventArgs e)
        {
            File.AppendAllLines(filePath, new[] { "�p�s�k", "�����R" });
            MessageBox.Show("�w�s�W��ӦW�r");
        }

        private void btnRead10Chars_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText(filePath);
            string first10 = content.Length >= 10 ? content.Substring(0, 10) : content;
            MessageBox.Show("�e10�Ӧr���G" + first10);
        }

        private void btnReadLine3_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 3)
                MessageBox.Show("��3�C���G" + lines[2]);
            else
                MessageBox.Show("�ɮפ���3�C");
        }
    }
}
