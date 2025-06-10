namespace TrafficLightApp
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelLight;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelLight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLight
            // 
            this.labelLight.BackColor = System.Drawing.Color.Red;
            this.labelLight.Location = new System.Drawing.Point(90, 70);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(100, 100);
            this.labelLight.TabIndex = 0;
            this.labelLight.Text = "紅燈";
            this.labelLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelLight);
            this.Name = "Form1";
            this.Text = "紅綠燈模擬器";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
