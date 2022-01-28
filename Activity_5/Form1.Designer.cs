namespace Activity_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameFileTxb = new System.Windows.Forms.TextBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.FirstWordBtn = new System.Windows.Forms.Button();
            this.FirstTxb = new System.Windows.Forms.TextBox();
            this.LastWordBtn = new System.Windows.Forms.Button();
            this.LastTxb = new System.Windows.Forms.TextBox();
            this.LongestWordBtn = new System.Windows.Forms.Button();
            this.LongTxb = new System.Windows.Forms.TextBox();
            this.MostVowelsBtn = new System.Windows.Forms.Button();
            this.VowelTxb = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of file";
            // 
            // NameFileTxb
            // 
            this.NameFileTxb.Location = new System.Drawing.Point(265, 35);
            this.NameFileTxb.Name = "NameFileTxb";
            this.NameFileTxb.Size = new System.Drawing.Size(100, 22);
            this.NameFileTxb.TabIndex = 1;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(39, 34);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.Text = "Open file";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(116, 83);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(134, 23);
            this.ConvertBtn.TabIndex = 3;
            this.ConvertBtn.Text = "Convert content";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // FirstWordBtn
            // 
            this.FirstWordBtn.Location = new System.Drawing.Point(39, 133);
            this.FirstWordBtn.Name = "FirstWordBtn";
            this.FirstWordBtn.Size = new System.Drawing.Size(134, 23);
            this.FirstWordBtn.TabIndex = 4;
            this.FirstWordBtn.Text = "The first word";
            this.FirstWordBtn.UseVisualStyleBackColor = true;
            this.FirstWordBtn.Click += new System.EventHandler(this.FirstWordBtn_Click);
            // 
            // FirstTxb
            // 
            this.FirstTxb.Location = new System.Drawing.Point(265, 134);
            this.FirstTxb.Name = "FirstTxb";
            this.FirstTxb.Size = new System.Drawing.Size(100, 22);
            this.FirstTxb.TabIndex = 5;
            // 
            // LastWordBtn
            // 
            this.LastWordBtn.Location = new System.Drawing.Point(39, 174);
            this.LastWordBtn.Name = "LastWordBtn";
            this.LastWordBtn.Size = new System.Drawing.Size(134, 23);
            this.LastWordBtn.TabIndex = 6;
            this.LastWordBtn.Text = "The last word";
            this.LastWordBtn.UseVisualStyleBackColor = true;
            this.LastWordBtn.Click += new System.EventHandler(this.LastWordBtn_Click);
            // 
            // LastTxb
            // 
            this.LastTxb.Location = new System.Drawing.Point(265, 175);
            this.LastTxb.Name = "LastTxb";
            this.LastTxb.Size = new System.Drawing.Size(100, 22);
            this.LastTxb.TabIndex = 7;
            // 
            // LongestWordBtn
            // 
            this.LongestWordBtn.Location = new System.Drawing.Point(39, 215);
            this.LongestWordBtn.Name = "LongestWordBtn";
            this.LongestWordBtn.Size = new System.Drawing.Size(165, 23);
            this.LongestWordBtn.TabIndex = 8;
            this.LongestWordBtn.Text = "The longest word";
            this.LongestWordBtn.UseVisualStyleBackColor = true;
            this.LongestWordBtn.Click += new System.EventHandler(this.LongestWordBtn_Click);
            // 
            // LongTxb
            // 
            this.LongTxb.Location = new System.Drawing.Point(265, 216);
            this.LongTxb.Name = "LongTxb";
            this.LongTxb.Size = new System.Drawing.Size(100, 22);
            this.LongTxb.TabIndex = 9;
            // 
            // MostVowelsBtn
            // 
            this.MostVowelsBtn.Location = new System.Drawing.Point(39, 258);
            this.MostVowelsBtn.Name = "MostVowelsBtn";
            this.MostVowelsBtn.Size = new System.Drawing.Size(211, 23);
            this.MostVowelsBtn.TabIndex = 10;
            this.MostVowelsBtn.Text = "The word with the most vowels";
            this.MostVowelsBtn.UseVisualStyleBackColor = true;
            this.MostVowelsBtn.Click += new System.EventHandler(this.MostVowelsBtn_Click);
            // 
            // VowelTxb
            // 
            this.VowelTxb.Location = new System.Drawing.Point(265, 258);
            this.VowelTxb.Name = "VowelTxb";
            this.VowelTxb.Size = new System.Drawing.Size(100, 22);
            this.VowelTxb.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 302);
            this.Controls.Add(this.VowelTxb);
            this.Controls.Add(this.MostVowelsBtn);
            this.Controls.Add(this.LongTxb);
            this.Controls.Add(this.LongestWordBtn);
            this.Controls.Add(this.LastTxb);
            this.Controls.Add(this.LastWordBtn);
            this.Controls.Add(this.FirstTxb);
            this.Controls.Add(this.FirstWordBtn);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.NameFileTxb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Activity 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameFileTxb;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Button FirstWordBtn;
        private System.Windows.Forms.TextBox FirstTxb;
        private System.Windows.Forms.Button LastWordBtn;
        private System.Windows.Forms.TextBox LastTxb;
        private System.Windows.Forms.Button LongestWordBtn;
        private System.Windows.Forms.TextBox LongTxb;
        private System.Windows.Forms.Button MostVowelsBtn;
        private System.Windows.Forms.TextBox VowelTxb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

