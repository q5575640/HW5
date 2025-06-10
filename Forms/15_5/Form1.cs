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
            // �p�G�ɮצs�b�A�NŪ����r���e
            if (File.Exists(path))
            {
                txtOutput.Text = File.ReadAllText(path);
                txtOutput.SelectionStart = 0;
                txtOutput.SelectionLength = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // �N txtOutput �����e�g�J��r�ɮ�
            File.WriteAllText(path, txtOutput.Text);
        }
    }
}
