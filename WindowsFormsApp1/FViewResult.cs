using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FViewResult : Form
    {
        public FViewResult()
        {
            InitializeComponent();
        }

        public FViewResult(Form1 f)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FViewResult_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            List<Student> school1 = new List<Student>();
            List<Student> school2 = new List<Student>();
            List<Student> school3 = new List<Student>();
            if (main.students.Count == 0)
            {
                MessageBox.Show("Внимание! В исходном списке учеников нет записей! Добавьте учеников в списку и повторите попытку.");
                Close();
            }
            else
            {
                foreach (Student istud in main.students)
                {
                    int count = 0;
                    if (istud.Answer1 == main.sheet.Answer1) count++;
                    if (istud.Answer2 == main.sheet.Answer2) count++;
                    if (istud.Answer3 == main.sheet.Answer3) count++;
                    if (istud.Answer4 == main.sheet.Answer4) count++;
                    if (istud.Answer5 == main.sheet.Answer5) count++;

                    istud.Correct = count;

                    switch (istud.School)
                    {
                        case "Школа №2000":
                            school1.Add(istud);
                            break;
                        case "Школа №921":
                            school2.Add(istud);
                            break;
                        case "Школа №444":
                            school3.Add(istud);
                            break;
                    }
                }

                for (int i = 0; i < school1.Count; i++)
                {
                    for (int j = 0; j < school1.Count; j++)
                    {
                        if (school1[j].Correct < school1[i].Correct)
                        {
                            Student buf;
                            buf = school1[j];
                            school1[j] = school1[i];
                            school1[i] = buf;
                        }
                    }
                }

                for (int i = 0; i < school2.Count; i++)
                {
                    for (int j = 0; j < school2.Count; j++)
                    {
                        if (school2[j].Correct < school2[i].Correct)
                        {
                            Student buf;
                            buf = school2[j];
                            school2[j] = school2[i];
                            school2[i] = buf;
                        }
                    }
                }

                for (int i = 0; i < school3.Count; i++)
                {
                    for (int j = 0; j < school3.Count; j++)
                    {
                        if (school3[j].Correct < school3[i].Correct)
                        {
                            Student buf;
                            buf = school3[j];
                            school3[j] = school3[i];
                            school3[i] = buf;
                        }
                    }
                }

                foreach (Student istud in school1)
                {
                    ListViewItem LastName = new ListViewItem();
                    LastName.Text = istud.LastName;
                    ListViewItem.ListViewSubItem Info = new ListViewItem.ListViewSubItem();
                    Info = new ListViewItem.ListViewSubItem();
                    Info.Text = istud.Correct.ToString();
                    if (istud.Correct == 5)
                        LastName.BackColor = System.Drawing.Color.Red;
                    LastName.SubItems.Add(Info);
                    vSchool1.Items.Add(LastName);        
                }

                foreach (Student istud in school2)
                {
                    ListViewItem LastName = new ListViewItem();
                    LastName.Text = istud.LastName;
                    ListViewItem.ListViewSubItem Info = new ListViewItem.ListViewSubItem();
                    Info = new ListViewItem.ListViewSubItem();
                    if (istud.Correct == 5)
                        LastName.BackColor = System.Drawing.Color.Red;
                    Info.Text = istud.Correct.ToString();
                    LastName.SubItems.Add(Info);
                    vSchool2.Items.Add(LastName);
                }

                foreach (Student istud in school3)
                {
                    ListViewItem LastName = new ListViewItem();
                    LastName.Text = istud.LastName;
                    ListViewItem.ListViewSubItem Info = new ListViewItem.ListViewSubItem();
                    if (istud.Correct == 5)
                        LastName.BackColor = System.Drawing.Color.Red;
                    Info = new ListViewItem.ListViewSubItem();
                    Info.Text = istud.Correct.ToString();
                    LastName.SubItems.Add(Info);
                    vSchool3.Items.Add(LastName);
                }
            }
        }
    }
}
