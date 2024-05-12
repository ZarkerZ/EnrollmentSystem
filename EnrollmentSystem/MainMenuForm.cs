using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void SubjectScheduleEntryButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntryForm subjectSchedEntryForm = new SubjectScheduleEntryForm();
            Hide();
            subjectSchedEntryForm.ShowDialog();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            Hide();
            studentEntryForm.ShowDialog();
            Close();
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            SubjectEntryForm subjectEntry = new SubjectEntryForm();
            Hide();
            subjectEntry.ShowDialog();
            Close();
        }

        private void EnrollmentEntryButton_Click(object sender, EventArgs e)
        {
            //code to open enrollment entry form
        }

        private void StudentGradeEntryButton_Click(object sender, EventArgs e)
        {
            //code to open student grade entry form
        }
    }
}
