using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class SubjectEntryForm : Form
    {
        public SubjectEntryForm()
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
            thisAdapter.Fill(thisDataSet, "SubjectFile");

            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            thisRow["SFSUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SFSUBJDESC"] = DescriptionTextBox.Text;
            thisRow["SFSUBJUNITS"] = Convert.ToInt16(UnitsTextBox.Text);
            thisRow["SFSUBJREGOFRNG"] = Convert.ToUInt16(OfferingComboBox.Text.Substring(0, 1));
            thisRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 3);
            thisRow["SFSUBJSTATUS"] = "AC";
            thisRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
            thisRow["SFSUBJCURRCODE"] = CurriculumYearTextBox.Text;

            thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectFile");
            
            OleDbConnection requisiteConnection = new OleDbConnection(connectionString);
            string requisite = "SELECT * FROM SUBJECPREQFILE";
            OleDbDataAdapter requisiteAdapter = new OleDbDataAdapter(requisite, requisiteConnection);


            MessageBox.Show("Entries Recorded");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SubjectCodeTextBox.Text = "";
            DescriptionTextBox.Text = "";
            UnitsTextBox.Text = "";
            OfferingComboBox.Text = "";
            CategoryComboBox.Text = "";
            CourseCodeComboBox.Text = "";
            CurriculumYearTextBox.Text = "";
            CoPreRequisiteRadioButton.Checked = false;
            PreRequisiteRadioButton.Checked = false;
            RequisiteTextBox.Text = "";
            SubjectDataGridView.Rows.Clear();
        }

        private void RequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                string sql = "SELECT * FROM SUBJECTFILE";
                string subjectPreqSQL = "SELECT * FROM SUBJECTPREQFILE";
                thisCommand.CommandText = sql;
                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(subjectPreqSQL, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SubjectPreqFile");

                bool found = false;
                string subjectCode = "";
                string description = "";
                string units = "";
                string subjectWithPreRequisite = SubjectCodeTextBox.Text;

                while (thisDataReader.Read())
                {
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        subjectCode = thisDataReader["SFSUBJCODE"].ToString();
                        description = thisDataReader["SFSUBJDESC"].ToString();
                        units = thisDataReader["SFSUBJUNITS"].ToString();
                        break;

                    }

                }
                int index;
                if (found == false)
                    MessageBox.Show("Subject Code Not Found");
                else
                {
                    DataRow thisRow;
                    index = SubjectDataGridView.Rows.Add();
                    SubjectDataGridView.Rows[index].Cells["SUBJECTCODECOLUMN"].Value = subjectCode;
                    SubjectDataGridView.Rows[index].Cells["DESCRIPTIONCOLUMN"].Value = description;
                    SubjectDataGridView.Rows[index].Cells["UNITSCOLUMN"].Value = units;
                    if (PreRequisiteRadioButton.Checked)
                    {
                        thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
                        thisRow["SUBJCODE"] = subjectWithPreRequisite;
                        thisRow["SUBJPRECODE"] = subjectCode;
                        thisRow["SUBJCATEGORY"] = "PR";
                        thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "SubjectPreqFile");
                    }
                    else if (CoPreRequisiteRadioButton.Checked)
                    {
                        thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
                        thisRow["SUBJCODE"] = subjectWithPreRequisite;
                        thisRow["SUBJPRECODE"] = subjectCode;
                        thisRow["SUBJCATEGORY"] = "CR";
                        thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "SubjectPreqFile");
                    }
                    else
                    {
                        MessageBox.Show("Please select a Form of requisite");
                    }
                }
            }
        }
    }
}
