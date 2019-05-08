namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.StudentsList = new System.Windows.Forms.ListView();
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoolNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadStudentsBtn = new System.Windows.Forms.Button();
            this.LoadAnswersBtn = new System.Windows.Forms.Button();
            this.FormListBtn = new System.Windows.Forms.Button();
            this.SortAscBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SortDescBtn = new System.Windows.Forms.Button();
            this.SaveStudentsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(1387, 90);
            this.AddStudentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(189, 54);
            this.AddStudentBtn.TabIndex = 0;
            this.AddStudentBtn.Text = "Добавить ученика";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentsList
            // 
            this.StudentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LastName,
            this.SchoolNum,
            this.Answer1,
            this.Answer2,
            this.Answer3,
            this.Answer4,
            this.Answer5});
            this.StudentsList.Location = new System.Drawing.Point(16, 15);
            this.StudentsList.Margin = new System.Windows.Forms.Padding(4);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(1268, 795);
            this.StudentsList.TabIndex = 1;
            this.StudentsList.UseCompatibleStateImageBehavior = false;
            this.StudentsList.View = System.Windows.Forms.View.Details;
            this.StudentsList.SelectedIndexChanged += new System.EventHandler(this.StudentsList_SelectedIndexChanged);
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 130;
            // 
            // SchoolNum
            // 
            this.SchoolNum.Text = "Школа";
            this.SchoolNum.Width = 130;
            // 
            // Answer1
            // 
            this.Answer1.Text = "Ответ №1";
            this.Answer1.Width = 130;
            // 
            // Answer2
            // 
            this.Answer2.Text = "Ответ №2";
            this.Answer2.Width = 130;
            // 
            // Answer3
            // 
            this.Answer3.Text = "Ответ №3";
            this.Answer3.Width = 130;
            // 
            // Answer4
            // 
            this.Answer4.Text = "Ответ №4";
            this.Answer4.Width = 130;
            // 
            // Answer5
            // 
            this.Answer5.Text = "Ответ №5";
            this.Answer5.Width = 130;
            // 
            // LoadStudentsBtn
            // 
            this.LoadStudentsBtn.Location = new System.Drawing.Point(1387, 151);
            this.LoadStudentsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadStudentsBtn.Name = "LoadStudentsBtn";
            this.LoadStudentsBtn.Size = new System.Drawing.Size(189, 54);
            this.LoadStudentsBtn.TabIndex = 4;
            this.LoadStudentsBtn.Text = "Загрузить список учеников";
            this.LoadStudentsBtn.UseVisualStyleBackColor = true;
            this.LoadStudentsBtn.Click += new System.EventHandler(this.LoadStudentsBtn_Click);
            // 
            // LoadAnswersBtn
            // 
            this.LoadAnswersBtn.Location = new System.Drawing.Point(1387, 431);
            this.LoadAnswersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadAnswersBtn.Name = "LoadAnswersBtn";
            this.LoadAnswersBtn.Size = new System.Drawing.Size(189, 54);
            this.LoadAnswersBtn.TabIndex = 5;
            this.LoadAnswersBtn.Text = "Загрузить список ответов";
            this.LoadAnswersBtn.UseVisualStyleBackColor = true;
            this.LoadAnswersBtn.Click += new System.EventHandler(this.LoadAnswersBtn_Click);
            // 
            // FormListBtn
            // 
            this.FormListBtn.Enabled = false;
            this.FormListBtn.Location = new System.Drawing.Point(1387, 492);
            this.FormListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FormListBtn.Name = "FormListBtn";
            this.FormListBtn.Size = new System.Drawing.Size(189, 54);
            this.FormListBtn.TabIndex = 6;
            this.FormListBtn.Text = "Составить список по результатам";
            this.FormListBtn.UseVisualStyleBackColor = true;
            this.FormListBtn.Click += new System.EventHandler(this.FormListBtn_Click);
            // 
            // SortAscBtn
            // 
            this.SortAscBtn.Location = new System.Drawing.Point(1341, 630);
            this.SortAscBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortAscBtn.Name = "SortAscBtn";
            this.SortAscBtn.Size = new System.Drawing.Size(139, 54);
            this.SortAscBtn.TabIndex = 7;
            this.SortAscBtn.Text = "По возрастанию";
            this.SortAscBtn.UseVisualStyleBackColor = true;
            this.SortAscBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1383, 591);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сортировка списка учеников";
            // 
            // SortDescBtn
            // 
            this.SortDescBtn.Location = new System.Drawing.Point(1488, 630);
            this.SortDescBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortDescBtn.Name = "SortDescBtn";
            this.SortDescBtn.Size = new System.Drawing.Size(133, 54);
            this.SortDescBtn.TabIndex = 9;
            this.SortDescBtn.Text = "По убыванию";
            this.SortDescBtn.UseVisualStyleBackColor = true;
            this.SortDescBtn.Click += new System.EventHandler(this.SortDescBtn_Click);
            // 
            // SaveStudentsBtn
            // 
            this.SaveStudentsBtn.Location = new System.Drawing.Point(1387, 213);
            this.SaveStudentsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveStudentsBtn.Name = "SaveStudentsBtn";
            this.SaveStudentsBtn.Size = new System.Drawing.Size(189, 54);
            this.SaveStudentsBtn.TabIndex = 10;
            this.SaveStudentsBtn.Text = "Сохранить список учеников";
            this.SaveStudentsBtn.UseVisualStyleBackColor = true;
            this.SaveStudentsBtn.Click += new System.EventHandler(this.SaveStudentsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 823);
            this.Controls.Add(this.SaveStudentsBtn);
            this.Controls.Add(this.SortDescBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortAscBtn);
            this.Controls.Add(this.FormListBtn);
            this.Controls.Add(this.LoadAnswersBtn);
            this.Controls.Add(this.LoadStudentsBtn);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.AddStudentBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Три школы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button LoadStudentsBtn;
        private System.Windows.Forms.Button LoadAnswersBtn;
        private System.Windows.Forms.Button FormListBtn;
        private System.Windows.Forms.Button SortAscBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SortDescBtn;
        private System.Windows.Forms.Button SaveStudentsBtn;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader SchoolNum;
        private System.Windows.Forms.ColumnHeader Answer1;
        private System.Windows.Forms.ColumnHeader Answer2;
        private System.Windows.Forms.ColumnHeader Answer3;
        private System.Windows.Forms.ColumnHeader Answer4;
        private System.Windows.Forms.ColumnHeader Answer5;
        public System.Windows.Forms.ListView StudentsList;
    }
}

