
namespace _59_2151050503_NguyenChauTuan_SelinumTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cmBox1 = new System.Windows.Forms.ComboBox();
            this.cmbchucnang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmBox1
            // 
            this.cmBox1.FormattingEnabled = true;
            this.cmBox1.Location = new System.Drawing.Point(412, 60);
            this.cmBox1.Name = "cmBox1";
            this.cmBox1.Size = new System.Drawing.Size(121, 24);
            this.cmBox1.TabIndex = 2;
            this.cmBox1.Text = "TestCase";
            this.cmBox1.SelectedIndexChanged += new System.EventHandler(this.cmBox1_SelectedIndexChanged);
            // 
            // cmbchucnang
            // 
            this.cmbchucnang.FormattingEnabled = true;
            this.cmbchucnang.Location = new System.Drawing.Point(412, 12);
            this.cmbchucnang.Name = "cmbchucnang";
            this.cmbchucnang.Size = new System.Drawing.Size(121, 24);
            this.cmbchucnang.TabIndex = 3;
            this.cmbchucnang.Text = "Chuc Nang";
            this.cmbchucnang.SelectedIndexChanged += new System.EventHandler(this.cmbchucnang_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 302);
            this.Controls.Add(this.cmbchucnang);
            this.Controls.Add(this.cmBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmBox1;
        private System.Windows.Forms.ComboBox cmbchucnang;
    }
}

