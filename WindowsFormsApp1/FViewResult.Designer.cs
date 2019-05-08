namespace WindowsFormsApp1
{
    partial class FViewResult
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
            this.vSchool1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cFio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vSchool2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vSchool3 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // vSchool1
            // 
            this.vSchool1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cFio,
            this.columnHeader2});
            this.vSchool1.Location = new System.Drawing.Point(60, 79);
            this.vSchool1.Name = "vSchool1";
            this.vSchool1.Size = new System.Drawing.Size(373, 478);
            this.vSchool1.TabIndex = 0;
            this.vSchool1.UseCompatibleStateImageBehavior = false;
            this.vSchool1.View = System.Windows.Forms.View.Details;
            this.vSchool1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Школа №2000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Школа №921";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1084, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Школа №444";
            // 
            // cFio
            // 
            this.cFio.Text = "ФИО";
            this.cFio.Width = 242;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Правильных ответов";
            this.columnHeader2.Width = 121;
            // 
            // vSchool2
            // 
            this.vSchool2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.vSchool2.Location = new System.Drawing.Point(508, 79);
            this.vSchool2.Name = "vSchool2";
            this.vSchool2.Size = new System.Drawing.Size(373, 478);
            this.vSchool2.TabIndex = 7;
            this.vSchool2.UseCompatibleStateImageBehavior = false;
            this.vSchool2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО";
            this.columnHeader1.Width = 242;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Правильных ответов";
            this.columnHeader3.Width = 121;
            // 
            // vSchool3
            // 
            this.vSchool3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.vSchool3.Location = new System.Drawing.Point(935, 79);
            this.vSchool3.Name = "vSchool3";
            this.vSchool3.Size = new System.Drawing.Size(373, 478);
            this.vSchool3.TabIndex = 8;
            this.vSchool3.UseCompatibleStateImageBehavior = false;
            this.vSchool3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ФИО";
            this.columnHeader4.Width = 242;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Правильных ответов";
            this.columnHeader5.Width = 121;
            // 
            // FViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 610);
            this.Controls.Add(this.vSchool3);
            this.Controls.Add(this.vSchool2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vSchool1);
            this.Name = "FViewResult";
            this.Text = "FViewResult";
            this.Load += new System.EventHandler(this.FViewResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vSchool1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader cFio;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView vSchool2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView vSchool3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}