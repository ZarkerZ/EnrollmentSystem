namespace EnrollmentSystem
{
    partial class SubjectEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.OfferingComboBox = new System.Windows.Forms.ComboBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequisiteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PreRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.CoPreRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Units:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Offering:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Course Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Curriculum Year:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Subject Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurriculumYearTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CourseCodeComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OfferingComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UnitsTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SubjectCodeTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 276);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Information";
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(167, 222);
            this.CurriculumYearTextBox.MaxLength = 10;
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(121, 26);
            this.CurriculumYearTextBox.TabIndex = 16;
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "BSACT",
            "BSN",
            "BSBA",
            "BSCRIM",
            "BSHRM"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(167, 190);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(121, 26);
            this.CourseCodeComboBox.TabIndex = 15;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "LECTURE",
            "LABORATORY"});
            this.CategoryComboBox.Location = new System.Drawing.Point(167, 160);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 26);
            this.CategoryComboBox.TabIndex = 14;
            // 
            // OfferingComboBox
            // 
            this.OfferingComboBox.FormattingEnabled = true;
            this.OfferingComboBox.Items.AddRange(new object[] {
            "1 - First Sem",
            "2 - Second Sem",
            "3 - Summer"});
            this.OfferingComboBox.Location = new System.Drawing.Point(167, 130);
            this.OfferingComboBox.Name = "OfferingComboBox";
            this.OfferingComboBox.Size = new System.Drawing.Size(121, 26);
            this.OfferingComboBox.TabIndex = 13;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.Location = new System.Drawing.Point(167, 101);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(121, 26);
            this.UnitsTextBox.TabIndex = 12;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(167, 70);
            this.DescriptionTextBox.MaxLength = 40;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(121, 26);
            this.DescriptionTextBox.TabIndex = 11;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(167, 36);
            this.SubjectCodeTextBox.MaxLength = 15;
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(121, 26);
            this.SubjectCodeTextBox.TabIndex = 10;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeColumn,
            this.DescriptionColumn,
            this.UnitsColumn,
            this.CoPreColumn});
            this.SubjectDataGridView.Location = new System.Drawing.Point(38, 82);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.Size = new System.Drawing.Size(432, 126);
            this.SubjectDataGridView.TabIndex = 10;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.Name = "UnitsColumn";
            // 
            // CoPreColumn
            // 
            this.CoPreColumn.HeaderText = "Co/Pre";
            this.CoPreColumn.Name = "CoPreColumn";
            // 
            // RequisiteTextBox
            // 
            this.RequisiteTextBox.Location = new System.Drawing.Point(150, 40);
            this.RequisiteTextBox.Name = "RequisiteTextBox";
            this.RequisiteTextBox.Size = new System.Drawing.Size(121, 26);
            this.RequisiteTextBox.TabIndex = 11;
            this.RequisiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RequisiteTextBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PreRequisiteRadioButton);
            this.groupBox2.Controls.Add(this.SubjectDataGridView);
            this.groupBox2.Controls.Add(this.CoPreRequisiteRadioButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.RequisiteTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(77, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 220);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requisite Information";
            // 
            // PreRequisiteRadioButton
            // 
            this.PreRequisiteRadioButton.AutoSize = true;
            this.PreRequisiteRadioButton.Location = new System.Drawing.Point(342, 55);
            this.PreRequisiteRadioButton.Name = "PreRequisiteRadioButton";
            this.PreRequisiteRadioButton.Size = new System.Drawing.Size(134, 22);
            this.PreRequisiteRadioButton.TabIndex = 13;
            this.PreRequisiteRadioButton.TabStop = true;
            this.PreRequisiteRadioButton.Text = "Pre-Requisite";
            this.PreRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // CoPreRequisiteRadioButton
            // 
            this.CoPreRequisiteRadioButton.AutoSize = true;
            this.CoPreRequisiteRadioButton.Location = new System.Drawing.Point(342, 28);
            this.CoPreRequisiteRadioButton.Name = "CoPreRequisiteRadioButton";
            this.CoPreRequisiteRadioButton.Size = new System.Drawing.Size(128, 22);
            this.CoPreRequisiteRadioButton.TabIndex = 12;
            this.CoPreRequisiteRadioButton.TabStop = true;
            this.CoPreRequisiteRadioButton.Text = "Co-Requisite";
            this.CoPreRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(572, 245);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(149, 50);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(572, 319);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(149, 50);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 649);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CurriculumYearTextBox;
        private System.Windows.Forms.ComboBox CourseCodeComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox OfferingComboBox;
        private System.Windows.Forms.TextBox UnitsTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.TextBox RequisiteTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PreRequisiteRadioButton;
        private System.Windows.Forms.RadioButton CoPreRequisiteRadioButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPreColumn;
    }
}

