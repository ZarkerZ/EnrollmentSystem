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

namespace EnrollmentSystem
{
    public partial class SubjectScheduleEntryForm : Form
    {
        public SubjectScheduleEntryForm()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Yan2\2nd Year\2nd Sem\APPSDEV\Finals Project\Database\Database1.accdb";
        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string sql = "Select * From SUBJECTSCHEDFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectSchedFile");

            DataRow thisRow = thisDataSet.Tables["SubjectSchedFile"].NewRow();
            thisRow["SSFEDPCODE"] = SubjectEDPCodeTextBox.Text;
            thisRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SSFSTARTTIME"] = TimeStartComboBox.Text;
            thisRow["SSFENDTIME"] = TimeEndComboBox.Text;
            thisRow["SSFDAYS"] = DaysComboBox.Text.Substring(0, 3);
            thisRow["SSFROOM"] = RoomTextBox.Text;
            thisRow["SSFMAXSIZE"] = 50;
            thisRow["SSFCLASSSIZE"] = 0;
            thisRow["SSFSTATUS"] = StatusComboBox.Text.Substring(0, 2).ToUpper();
            thisRow["SSFXM"] = AmPmComboBox.Text;
            thisRow["SSFSECTION"] = SectionTextBox.Text.ToUpper();
            thisRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text;

            thisDataSet.Tables["SubjectSchedFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectSchedFile");

            MessageBox.Show("Entries Recorded");


        }
    }
}
