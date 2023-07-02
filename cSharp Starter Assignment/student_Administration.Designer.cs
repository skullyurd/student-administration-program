namespace cSharp_Starter_Assignment
{
    partial class StudentAdministrationForm
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
            this.groupBoxNewCourse = new System.Windows.Forms.GroupBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.numberLbl = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.buttonSearchGroup = new System.Windows.Forms.Button();
            this.buttonShowAllStudent = new System.Windows.Forms.Button();
            this.allGroupsBttn = new System.Windows.Forms.Button();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.groupBoxNewStudent = new System.Windows.Forms.GroupBox();
            this.groupBoxNewCourse.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.groupBoxNewStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewCourse
            // 
            this.groupBoxNewCourse.Controls.Add(this.textBoxCourseName);
            this.groupBoxNewCourse.Controls.Add(this.labelCourseName);
            this.groupBoxNewCourse.Controls.Add(this.buttonAddCourse);
            this.groupBoxNewCourse.Location = new System.Drawing.Point(13, 13);
            this.groupBoxNewCourse.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxNewCourse.Name = "groupBoxNewCourse";
            this.groupBoxNewCourse.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxNewCourse.Size = new System.Drawing.Size(225, 86);
            this.groupBoxNewCourse.TabIndex = 18;
            this.groupBoxNewCourse.TabStop = false;
            this.groupBoxNewCourse.Text = "Create Course";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(79, 16);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(132, 22);
            this.textBoxCourseName.TabIndex = 0;
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(8, 20);
            this.labelCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(47, 16);
            this.labelCourseName.TabIndex = 2;
            this.labelCourseName.Text = "Name:";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(12, 48);
            this.buttonAddCourse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(200, 28);
            this.buttonAddCourse.TabIndex = 4;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(79, 27);
            this.textBoxStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(132, 22);
            this.textBoxStudentName.TabIndex = 0;
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Location = new System.Drawing.Point(79, 57);
            this.textBoxStudentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(132, 22);
            this.textBoxStudentNumber.TabIndex = 1;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(8, 31);
            this.labelStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(47, 16);
            this.labelStudentName.TabIndex = 2;
            this.labelStudentName.Text = "Name:";
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(8, 61);
            this.numberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(58, 16);
            this.numberLbl.TabIndex = 3;
            this.numberLbl.Text = "Number:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(12, 87);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(200, 28);
            this.buttonAddStudent.TabIndex = 4;
            this.buttonAddStudent.Text = "Add";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.buttonStatistic);
            this.groupBoxInformation.Controls.Add(this.textBoxSearch);
            this.groupBoxInformation.Controls.Add(this.buttonSearchStudent);
            this.groupBoxInformation.Controls.Add(this.buttonSearchGroup);
            this.groupBoxInformation.Controls.Add(this.buttonShowAllStudent);
            this.groupBoxInformation.Controls.Add(this.allGroupsBttn);
            this.groupBoxInformation.Controls.Add(this.listBoxInfo);
            this.groupBoxInformation.Location = new System.Drawing.Point(243, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(442, 529);
            this.groupBoxInformation.TabIndex = 19;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Location = new System.Drawing.Point(231, 485);
            this.buttonStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(200, 28);
            this.buttonStatistic.TabIndex = 23;
            this.buttonStatistic.Text = "Show statistics";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 413);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(199, 22);
            this.textBoxSearch.TabIndex = 20;
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.Location = new System.Drawing.Point(6, 445);
            this.buttonSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(200, 28);
            this.buttonSearchStudent.TabIndex = 21;
            this.buttonSearchStudent.Text = "Search student";
            this.buttonSearchStudent.UseVisualStyleBackColor = true;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // buttonSearchGroup
            // 
            this.buttonSearchGroup.Location = new System.Drawing.Point(6, 481);
            this.buttonSearchGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchGroup.Name = "buttonSearchGroup";
            this.buttonSearchGroup.Size = new System.Drawing.Size(200, 28);
            this.buttonSearchGroup.TabIndex = 22;
            this.buttonSearchGroup.Text = "Search group";
            this.buttonSearchGroup.UseVisualStyleBackColor = true;
            this.buttonSearchGroup.Click += new System.EventHandler(this.buttonSearchGroup_Click);
            // 
            // buttonShowAllStudent
            // 
            this.buttonShowAllStudent.Location = new System.Drawing.Point(231, 413);
            this.buttonShowAllStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowAllStudent.Name = "buttonShowAllStudent";
            this.buttonShowAllStudent.Size = new System.Drawing.Size(200, 28);
            this.buttonShowAllStudent.TabIndex = 18;
            this.buttonShowAllStudent.Text = "View all students";
            this.buttonShowAllStudent.UseVisualStyleBackColor = true;
            this.buttonShowAllStudent.Click += new System.EventHandler(this.buttonShowAllStudent_Click);
            // 
            // allGroupsBttn
            // 
            this.allGroupsBttn.Location = new System.Drawing.Point(231, 449);
            this.allGroupsBttn.Margin = new System.Windows.Forms.Padding(4);
            this.allGroupsBttn.Name = "allGroupsBttn";
            this.allGroupsBttn.Size = new System.Drawing.Size(200, 28);
            this.allGroupsBttn.TabIndex = 19;
            this.allGroupsBttn.Text = "View all groups";
            this.allGroupsBttn.UseVisualStyleBackColor = true;
            this.allGroupsBttn.Click += new System.EventHandler(this.allGroupsBttn_Click);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(6, 18);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(426, 388);
            this.listBoxInfo.TabIndex = 17;
            // 
            // groupBoxNewStudent
            // 
            this.groupBoxNewStudent.Controls.Add(this.labelStudentName);
            this.groupBoxNewStudent.Controls.Add(this.buttonAddStudent);
            this.groupBoxNewStudent.Controls.Add(this.textBoxStudentName);
            this.groupBoxNewStudent.Controls.Add(this.numberLbl);
            this.groupBoxNewStudent.Controls.Add(this.textBoxStudentNumber);
            this.groupBoxNewStudent.Location = new System.Drawing.Point(6, 116);
            this.groupBoxNewStudent.Name = "groupBoxNewStudent";
            this.groupBoxNewStudent.Size = new System.Drawing.Size(219, 117);
            this.groupBoxNewStudent.TabIndex = 20;
            this.groupBoxNewStudent.TabStop = false;
            this.groupBoxNewStudent.Text = "Add new student";
            // 
            // StudentAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 531);
            this.Controls.Add(this.groupBoxNewStudent);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.groupBoxNewCourse);
            this.Name = "StudentAdministrationForm";
            this.Text = "Student Administration";
            this.Load += new System.EventHandler(this.StudentAdministrationForm_Load);
            this.groupBoxNewCourse.ResumeLayout(false);
            this.groupBoxNewCourse.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.groupBoxNewStudent.ResumeLayout(false);
            this.groupBoxNewStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxNewCourse;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.Button buttonSearchGroup;
        private System.Windows.Forms.Button buttonShowAllStudent;
        private System.Windows.Forms.Button allGroupsBttn;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxNewStudent;
    }
}

