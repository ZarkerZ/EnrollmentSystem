using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnrollmentSystem
{
    public partial class StudentEntryForm : Form
    {
        public StudentEntryForm()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Yan2\2nd Year\2nd Sem\APPSDEV\Finals Project\Database\Database1.accdb";

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string sql = "Select * FROM STUDENTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "StudentFile");

            DataRow thisRow = thisDataSet.Tables["StudentFile"].NewRow();
            thisRow["STFSTUDID"] = IdNumberTextBox.Text;
            thisRow["STFSTUDLNAME"] = LastNameTextBox.Text;
            thisRow["STFSTUDFNAME"] = FirstNameTextBox.Text;
            thisRow["STFSTUDMNAME"] = MiddleInitialTextBox.Text;
            thisRow["STFSTUDCOURSE"] = CourseTextBox.Text;
            thisRow["STFSTUDYEAR"] = YearTextBox.Text;
            thisRow["STFSTUDREMARKS"] = RemarksComboBox.Text;
            thisRow["STFSTUDSTATUS"] = StatusComboBox.Text.Substring(0, 2).ToUpper();

            thisDataSet.Tables["StudentFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "StudentFile");

            MessageBox.Show("Entries Recorded");

        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            Hide();
            mainMenuForm.ShowDialog();
            Close();
        }

        private void DisplayStudentsButton_Click(object sender, EventArgs e)
        {
            DisplayStudentsForm displayStudentForm = new DisplayStudentsForm();
            Hide();
            displayStudentForm.ShowDialog();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IdNumberTextBox.Text = "";
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            MiddleInitialTextBox.Text = "";
            CourseTextBox.Text = "";
            YearTextBox.Text = "";
            RemarksComboBox.Text = "";
            StatusComboBox.Text = "";
        }
    }
}
