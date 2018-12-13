namespace CS_ListView
{
    partial class ListView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStudentId = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbNationalscale = new System.Windows.Forms.Label();
            this.lbGraduatePoints = new System.Windows.Forms.Label();
            this.lbScale = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbGraduatepoint = new System.Windows.Forms.MaskedTextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbScale = new System.Windows.Forms.ComboBox();
            this.cmbNationalscale = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStudentId
            // 
            this.lbStudentId.AutoSize = true;
            this.lbStudentId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStudentId.Location = new System.Drawing.Point(21, 46);
            this.lbStudentId.Name = "lbStudentId";
            this.lbStudentId.Size = new System.Drawing.Size(106, 22);
            this.lbStudentId.TabIndex = 0;
            this.lbStudentId.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudentID.Location = new System.Drawing.Point(143, 41);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(217, 29);
            this.txtStudentID.TabIndex = 2;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstname.Location = new System.Drawing.Point(143, 95);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(217, 29);
            this.txtFirstname.TabIndex = 3;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(143, 152);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(217, 29);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFirstname.Location = new System.Drawing.Point(21, 100);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(103, 22);
            this.lbFirstname.TabIndex = 6;
            this.lbFirstname.Text = "Firstname";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(21, 157);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(94, 22);
            this.lbSurname.TabIndex = 7;
            this.lbSurname.Text = "Surname";
            // 
            // lbNationalscale
            // 
            this.lbNationalscale.AutoSize = true;
            this.lbNationalscale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNationalscale.Location = new System.Drawing.Point(-1, 213);
            this.lbNationalscale.Name = "lbNationalscale";
            this.lbNationalscale.Size = new System.Drawing.Size(139, 22);
            this.lbNationalscale.TabIndex = 8;
            this.lbNationalscale.Text = "National scale";
            // 
            // lbGraduatePoints
            // 
            this.lbGraduatePoints.AutoSize = true;
            this.lbGraduatePoints.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGraduatePoints.Location = new System.Drawing.Point(-1, 263);
            this.lbGraduatePoints.Name = "lbGraduatePoints";
            this.lbGraduatePoints.Size = new System.Drawing.Size(149, 22);
            this.lbGraduatePoints.TabIndex = 9;
            this.lbGraduatePoints.Text = "Graduate Point";
            // 
            // lbScale
            // 
            this.lbScale.AutoSize = true;
            this.lbScale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScale.Location = new System.Drawing.Point(-1, 325);
            this.lbScale.Name = "lbScale";
            this.lbScale.Size = new System.Drawing.Size(128, 22);
            this.lbScale.TabIndex = 10;
            this.lbScale.Text = "Scale(ABCD)";
            this.lbScale.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCourse.Location = new System.Drawing.Point(21, 383);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(78, 22);
            this.lbCourse.TabIndex = 11;
            this.lbCourse.Text = "Course";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYear.Location = new System.Drawing.Point(21, 444);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(52, 22);
            this.lbYear.TabIndex = 12;
            this.lbYear.Text = "Year";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(298, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Selecte Item";
            // 
            // mtbGraduatepoint
            // 
            this.mtbGraduatepoint.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbGraduatepoint.Location = new System.Drawing.Point(143, 260);
            this.mtbGraduatepoint.Mask = "999";
            this.mtbGraduatepoint.Name = "mtbGraduatepoint";
            this.mtbGraduatepoint.Size = new System.Drawing.Size(217, 29);
            this.mtbGraduatepoint.TabIndex = 14;
            this.mtbGraduatepoint.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbGraduatepoint_MaskInputRejected);
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(143, 375);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(217, 30);
            this.cmbCourse.TabIndex = 16;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(143, 436);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(217, 30);
            this.cmbYear.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(392, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 86);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 46);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(22, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 39);
            this.panel3.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(332, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(497, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(163, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove__Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(392, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 318);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student_ID";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firstname";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "National scale";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Graduate Point";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Scale";
            this.columnHeader6.Width = 86;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Course";
            this.columnHeader7.Width = 85;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Year";
            this.columnHeader8.Width = 142;
            // 
            // cmbScale
            // 
            this.cmbScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbScale.FormattingEnabled = true;
            this.cmbScale.Location = new System.Drawing.Point(143, 317);
            this.cmbScale.Name = "cmbScale";
            this.cmbScale.Size = new System.Drawing.Size(217, 30);
            this.cmbScale.TabIndex = 20;
            this.cmbScale.SelectedIndexChanged += new System.EventHandler(this.cmbScale_SelectedIndexChanged);
            // 
            // cmbNationalscale
            // 
            this.cmbNationalscale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNationalscale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNationalscale.FormattingEnabled = true;
            this.cmbNationalscale.Location = new System.Drawing.Point(144, 205);
            this.cmbNationalscale.Name = "cmbNationalscale";
            this.cmbNationalscale.Size = new System.Drawing.Size(217, 30);
            this.cmbNationalscale.TabIndex = 21;
            this.cmbNationalscale.SelectedIndexChanged += new System.EventHandler(this.cmbNationalscale_SelectedIndexChanged);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 505);
            this.Controls.Add(this.cmbNationalscale);
            this.Controls.Add(this.cmbScale);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.mtbGraduatepoint);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbScale);
            this.Controls.Add(this.lbGraduatePoints);
            this.Controls.Add(this.lbNationalscale);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lbStudentId);
            this.Name = "ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentId;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbNationalscale;
        private System.Windows.Forms.Label lbGraduatePoints;
        private System.Windows.Forms.Label lbScale;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbGraduatepoint;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cmbScale;
        private System.Windows.Forms.ComboBox cmbNationalscale;
        private System.Windows.Forms.Button btnClear;
    }
}

