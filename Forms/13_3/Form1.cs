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

            // ªì©l¤Æ¬õ¿O
            labelLight.BackColor = Color.Red;
            labelLight.Text = "¬õ¿O";
            labelLight.Font = new Font("Arial", 14, FontStyle.Bold);
            labelLight.TextAlign = ContentAlignment.MiddleCenter;

            // µù¥U·Æ¹«ÂIÀ»¨Æ¥ó
            labelLight.MouseClick += LabelLight_MouseClick;
        }

        private void LabelLight_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                labelLight.BackColor = Color.Yellow;
                labelLight.Text = "¶À¿O";
            }
            else if (e.Button == MouseButtons.Right)
            {
                labelLight.BackColor = Color.Green;
                labelLight.Text = "ºñ¿O";
            }
        }
    }
}
