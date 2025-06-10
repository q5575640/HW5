namespace FileEditorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnClear;
        private Button btnAddChen;
        private Button btnAddNames;
        private Button btnRead10Chars;
        private Button btnReadLine3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddChen = new System.Windows.Forms.Button();
            this.btnAddNames = new System.Windows.Forms.Button();
            this.btnRead10Chars = new System.Windows.Forms.Button();
            this.btnReadLine3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(30, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 30);
            this.btnClear.Text = "清除 listFile.txt 內容";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddChen
            // 
            this.btnAddChen.Location = new System.Drawing.Point(30, 60);
            this.btnAddChen.Name = "btnAddChen";
            this.btnAddChen.Size = new System.Drawing.Size(220, 30);
            this.btnAddChen.Text = "新增空白行與陳會安";
            this.btnAddChen.Click += new System.EventHandler(this.btnAddChen_Click);
            // 
            // btnAddNames
            // 
            this.btnAddNames.Location = new System.Drawing.Point(30, 100);
            this.btnAddNames.Name = "btnAddNames";
            this.btnAddNames.Size = new System.Drawing.Size(220, 30);
            this.btnAddNames.Text = "新增 小龍女 和 王美麗";
            this.btnAddNames.Click += new System.EventHandler(this.btnAddNames_Click);
            // 
            // btnRead10Chars
            // 
            this.btnRead10Chars.Location = new System.Drawing.Point(30, 140);
            this.btnRead10Chars.Name = "btnRead10Chars";
            this.btnRead10Chars.Size = new System.Drawing.Size(220, 30);
            this.btnRead10Chars.Text = "讀取前 10 個字";
            this.btnRead10Chars.Click += new System.EventHandler(this.btnRead10Chars_Click);
            // 
            // btnReadLine3
            // 
            this.btnReadLine3.Location = new System.Drawing.Point(30, 180);
            this.btnReadLine3.Name = "btnReadLine3";
            this.btnReadLine3.Size = new System.Drawing.Size(220, 30);
            this.btnReadLine3.Text = "讀取第 3 列名字";
            this.btnReadLine3.Click += new System.EventHandler(this.btnReadLine3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddChen);
            this.Controls.Add(this.btnAddNames);
            this.Controls.Add(this.btnRead10Chars);
            this.Controls.Add(this.btnReadLine3);
            this.Name = "Form1";
            this.Text = "ListFile 管理器";
            this.ResumeLayout(false);
        }
    }
}
