using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLightApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ��l�Ƭ��O
            labelLight.BackColor = Color.Red;
            labelLight.Text = "���O";
            labelLight.Font = new Font("Arial", 14, FontStyle.Bold);
            labelLight.TextAlign = ContentAlignment.MiddleCenter;

            // ���U�ƹ��I���ƥ�
            labelLight.MouseClick += LabelLight_MouseClick;
        }

        private void LabelLight_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                labelLight.BackColor = Color.Yellow;
                labelLight.Text = "���O";
            }
            else if (e.Button == MouseButtons.Right)
            {
                labelLight.BackColor = Color.Green;
                labelLight.Text = "��O";
            }
        }
    }
}
