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
    public partial class FAddStudent : Form
    {
        public FAddStudent()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void FAddStudent_Load(object sender, EventArgs e)
        {

        }

        public FAddStudent(Form1 f)
        { 
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (InputFio.Text.Length == 0 || InputSchool.Text.Length == 0)
            {
                MessageBox.Show("Номер школы и ФИО участника являются обязательными параметрами");
            }
            else
            {
                Form1 main = this.Owner as Form1;
                main.StudentsList.Items.Clear();
                Student stud = new Student(InputFio.Text, InputSchool.Text, InputAns1.Text, InputAns2.Text, InputAns3.Text, InputAns4.Text, InputAns5.Text);
                main.students.Add(stud);
                foreach (Student istud in main.students)
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
                    main.StudentsList.Items.Add(LastName);

                }
                Close();
            }
        }
    }
}
