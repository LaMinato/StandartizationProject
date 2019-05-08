namespace WindowsFormsApp1
{
    partial class FAddStudent
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.InputFio = new System.Windows.Forms.TextBox();
            this.InputAns1 = new System.Windows.Forms.TextBox();
            this.InputAns4 = new System.Windows.Forms.TextBox();
            this.InputAns3 = new System.Windows.Forms.TextBox();
            this.InputAns2 = new System.Windows.Forms.TextBox();
            this.InputAns5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InputSchool = new System.Windows.Forms.ComboBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // InputFio
            // 
            this.InputFio.Location = new System.Drawing.Point(198, 41);
            this.InputFio.Name = "InputFio";
            this.InputFio.Size = new System.Drawing.Size(234, 20);
            this.InputFio.TabIndex = 0;
            // 
            // InputAns1
            // 
            this.InputAns1.Location = new System.Drawing.Point(198, 114);
            this.InputAns1.Name = "InputAns1";
            this.InputAns1.Size = new System.Drawing.Size(234, 20);
            this.InputAns1.TabIndex = 2;
            // 
            // InputAns4
            // 
            this.InputAns4.Location = new System.Drawing.Point(198, 226);
            this.InputAns4.Name = "InputAns4";
            this.InputAns4.Size = new System.Drawing.Size(234, 20);
            this.InputAns4.TabIndex = 5;
            // 
            // InputAns3
            // 
            this.InputAns3.Location = new System.Drawing.Point(198, 190);
            this.InputAns3.Name = "InputAns3";
            this.InputAns3.Size = new System.Drawing.Size(234, 20);
            this.InputAns3.TabIndex = 4;
            // 
            // InputAns2
            // 
            this.InputAns2.Location = new System.Drawing.Point(198, 153);
            this.InputAns2.Name = "InputAns2";
            this.InputAns2.Size = new System.Drawing.Size(234, 20);
            this.InputAns2.TabIndex = 3;
            // 
            // InputAns5
            // 
            this.InputAns5.Location = new System.Drawing.Point(198, 265);
            this.InputAns5.Name = "InputAns5";
            this.InputAns5.Size = new System.Drawing.Size(234, 20);
            this.InputAns5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО участника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Школа участника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ответ №1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ответ №2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ответ №3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ответ №4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ответ №5";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // InputSchool
            // 
            this.InputSchool.FormattingEnabled = true;
            this.InputSchool.Items.AddRange(new object[] {
            "Школа №2000",
            "Школа №921",
            "Школа №444"});
            this.InputSchool.Location = new System.Drawing.Point(198, 77);
            this.InputSchool.Name = "InputSchool";
            this.InputSchool.Size = new System.Drawing.Size(234, 21);
            this.InputSchool.TabIndex = 14;
            this.InputSchool.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(146, 317);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(146, 42);
            this.AcceptBtn.TabIndex = 15;
            this.AcceptBtn.Text = "Добавить";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // FAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 371);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.InputSchool);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputAns5);
            this.Controls.Add(this.InputAns4);
            this.Controls.Add(this.InputAns3);
            this.Controls.Add(this.InputAns2);
            this.Controls.Add(this.InputAns1);
            this.Controls.Add(this.InputFio);
            this.Name = "FAddStudent";
            this.Text = "Добавить ученика";
            this.Load += new System.EventHandler(this.FAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox InputAns4;
        private System.Windows.Forms.TextBox InputAns3;
        private System.Windows.Forms.TextBox InputAns2;
        private System.Windows.Forms.TextBox InputAns1;
        private System.Windows.Forms.TextBox InputFio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputAns5;
        private System.Windows.Forms.ComboBox InputSchool;
        private System.Windows.Forms.Button AcceptBtn;
    }
}