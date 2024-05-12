namespace EnrollmentSystem
{
    partial class MainMenuForm
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
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.EnrollmentEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StudentGradeEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enrollment System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(192, 93);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(384, 50);
            this.SubjectScheduleEntryButton.TabIndex = 1;
            this.SubjectScheduleEntryButton.Text = "Subject Schedule Entry";
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = true;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEntryButton.Location = new System.Drawing.Point(192, 149);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(384, 50);
            this.StudentEntryButton.TabIndex = 2;
            this.StudentEntryButton.Text = "Student Entry";
            this.StudentEntryButton.UseVisualStyleBackColor = true;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click);
            // 
            // EnrollmentEntryButton
            // 
            this.EnrollmentEntryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentEntryButton.Location = new System.Drawing.Point(192, 261);
            this.EnrollmentEntryButton.Name = "EnrollmentEntryButton";
            this.EnrollmentEntryButton.Size = new System.Drawing.Size(384, 50);
            this.EnrollmentEntryButton.TabIndex = 3;
            this.EnrollmentEntryButton.Text = "Enrollment Entry";
            this.EnrollmentEntryButton.UseVisualStyleBackColor = true;
            this.EnrollmentEntryButton.Click += new System.EventHandler(this.EnrollmentEntryButton_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectEntryButton.Location = new System.Drawing.Point(192, 205);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(384, 50);
            this.SubjectEntryButton.TabIndex = 4;
            this.SubjectEntryButton.Text = "Subject Entry";
            this.SubjectEntryButton.UseVisualStyleBackColor = true;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(321, 392);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(128, 46);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StudentGradeEntryButton
            // 
            this.StudentGradeEntryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGradeEntryButton.Location = new System.Drawing.Point(192, 317);
            this.StudentGradeEntryButton.Name = "StudentGradeEntryButton";
            this.StudentGradeEntryButton.Size = new System.Drawing.Size(384, 50);
            this.StudentGradeEntryButton.TabIndex = 6;
            this.StudentGradeEntryButton.Text = "Student Grade Entry";
            this.StudentGradeEntryButton.UseVisualStyleBackColor = true;
            this.StudentGradeEntryButton.Click += new System.EventHandler(this.StudentGradeEntryButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentGradeEntryButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.EnrollmentEntryButton);
            this.Controls.Add(this.StudentEntryButton);
            this.Controls.Add(this.SubjectScheduleEntryButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button EnrollmentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StudentGradeEntryButton;
    }
}