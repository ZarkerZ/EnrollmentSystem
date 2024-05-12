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
    public partial class DisplayStudentsForm : Form
    {
        public DisplayStudentsForm()
        {
            InitializeComponent();
            DisplayStudents();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Yan2\2nd Year\2nd Sem\APPSDEV\Finals Project\Database\Database1.accdb";
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayStudents()
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            String thisCommand = "Select * From STUDENTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(thisCommand, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "StudentFile");
            for (int i = 0; i < thisDataSet.Tables["StudentFile"].Rows.Count; i++)
            {
                DataRow row = thisDataSet.Tables["StudentFile"].Rows[i];
                StudentListDataGridView.Rows.Add(row["STFSTUDID"], row["STFSTUDLNAME"], row["STFSTUDFNAME"], row["STFSTUDMNAME"], row["STFSTUDCOURSE"], row["STFSTUDYEAR"], row["STFSTUDREMARKS"], row["STFSTUDSTATUS"]);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            Hide();
            studentEntryForm.ShowDialog();
            Close();
        }
    }
}
