using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();
        public Answers sheet = new Answers();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAddStudent fAddStudent = new FAddStudent(this);
            fAddStudent.Owner = this;
            fAddStudent.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentsList.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].LastName.CompareTo(students[i].LastName) > students[i].LastName.CompareTo(students[j].LastName))
                    {
                        Student buf;
                        buf = students[j];
                        students[j] = students[i];
                        students[i] = buf;
                    }
                }

                for (int j = students.Count-1; j > 0; j--)
                {
                    if (students[j].LastName.CompareTo(students[i].LastName) > students[i].LastName.CompareTo(students[j].LastName))
                    {
                        Student buf;
                        buf = students[j];
                        students[j] = students[i];
                        students[i] = buf;
                    }
                }
            }

            foreach (Student istud in students)
            {
                ListViewItem LastName = new ListViewItem();
                LastName.Text = istud.LastName;
                ListViewItem.ListViewSubItem[] Info = new ListViewItem.ListViewSubItem[6];
                for (int i = 0; i < 6; i++)
                {
                    Info[i] = new ListViewItem.ListViewSubItem();
                }
                Info[0].Text = istud.School;
                Info[1].Text = istud.Answer1;
                Info[2].Text = istud.Answer2;
                Info[3].Text = istud.Answer3;
                Info[4].Text = istud.Answer4;
                Info[5].Text = istud.Answer5;
                LastName.SubItems.AddRange(Info);
                StudentsList.Items.Add(LastName);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteStudentBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadAnswersBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.CheckFileExists = true;
            ofd.Title = "Выберите файл со списком ответов";
            ofd.ShowDialog();
            using (StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.Default))
            {
                string[] line = new string[5];
                for (int i = 0; i<=4; i++)
                {
                    line[i] = sr.ReadLine();
                }

                sheet.Answer1 = line[0];
                sheet.Answer2 = line[1];
                sheet.Answer3 = line[2];
                sheet.Answer4 = line[3];
                sheet.Answer5 = line[4];
            }
            MessageBox.Show("Ответы на вопросы загружены успешно"); 
            FormListBtn.Enabled = true;
        }

        private void LoadStudentsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.CheckFileExists = true;
            ofd.Title = "Выберите файл со списком учеников";
            ofd.ShowDialog();
            StudentsList.Items.Clear();
            students.Clear();
            using (StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split('|');
                    switch (words[1])
                    {
                        case "1": words[1] = "Школа №2000"; break;
                        case "2": words[1] = "Школа №921"; break;
                        default: words[1] = "Школа №444"; break;

                    }


                    Student stud = new Student(words[0], words[1], words[2], words[3], words[4], words[5], words[6]);
                    students.Add(stud);
                }
            }
            foreach (Student istud in students)
            {
                ListViewItem LastName = new ListViewItem();
                LastName.Text = istud.LastName;
                ListViewItem.ListViewSubItem[] Info = new ListViewItem.ListViewSubItem[6];
                for (int i = 0; i < 6; i++)
                {
                    Info[i] = new ListViewItem.ListViewSubItem();
                }
                Info[0].Text = istud.School;
                Info[1].Text = istud.Answer1;
                Info[2].Text = istud.Answer2;
                Info[3].Text = istud.Answer3;
                Info[4].Text = istud.Answer4;
                Info[5].Text = istud.Answer5;
                LastName.SubItems.AddRange(Info);
                StudentsList.Items.Add(LastName);

            }
        }

        private void FormListBtn_Click(object sender, EventArgs e)
        {
            FViewResult fAddStudent = new FViewResult(this);
            fAddStudent.Owner = this;
            fAddStudent.Show();
        }

        private void SaveStudentsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.CheckFileExists = true;
            ofd.Title = "Выберите файл для сохранения списка учеников";
            ofd.ShowDialog();
            using (StreamWriter sw = new StreamWriter(ofd.FileName))
            {
                foreach (Student istud in students)
                {
                    string line;
                    switch (istud.School)
                    {
                        case "Школа №2000": line = "1"; break;
                        case "Школа №921": line = "2"; break;
                        case "Школа №444": line = "3"; break;
                        default: line = "3"; break;
                    }
                    line = istud.LastName + "|" + line + "|" + istud.Answer1 + "|" + istud.Answer2 + "|" + istud.Answer3 + "|" + istud.Answer4 + "|" + istud.Answer5;
                    sw.WriteLine(line);
                }
            }
        }

        private void SortDescBtn_Click(object sender, EventArgs e)
        {

        }
    }

    public class Answers
    {
        public string Answer1 { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public string Answer4 { get; set; }

        public string Answer5 { get; set; }
    }

    public class Student
    {
        public string LastName { get; set; }

        public string School { get; set; }

        public string Answer1 { get; set; }

        public string Answer2 { get; set; }
        
        public string Answer3 { get; set; }
        
        public string Answer4 { get; set; }
        
        public string Answer5 { get; set; }

        public int Correct { get; set; }

        public Student(string lastName, string school, string answer1, string answer2, string answer3, string answer4, string answer5)
        {
            LastName = lastName;
            School = school;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            Answer5 = answer5;
            Correct = 0;
        }
    }
}
