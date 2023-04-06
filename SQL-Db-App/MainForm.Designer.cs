namespace SQL_Db_App
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbMarried = new System.Windows.Forms.RadioButton();
            this.MtbxSalary = new System.Windows.Forms.MaskedTextBox();
            this.CbxCity = new System.Windows.Forms.ComboBox();
            this.TbxId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RbSingle = new System.Windows.Forms.RadioButton();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxJob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtReport = new System.Windows.Forms.Button();
            this.BtGraph = new System.Windows.Forms.Button();
            this.BtStatistic = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            this.BtSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgwEmployeeDb = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new SQL_Db_App.EmployeeDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeesTableAdapter = new SQL_Db_App.EmployeeDataSetTableAdapters.EmployeesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwEmployeeDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbMarried);
            this.groupBox1.Controls.Add(this.MtbxSalary);
            this.groupBox1.Controls.Add(this.CbxCity);
            this.groupBox1.Controls.Add(this.TbxId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RbSingle);
            this.groupBox1.Controls.Add(this.TbxSurname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbxJob);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Register";
            // 
            // RbMarried
            // 
            this.RbMarried.AutoSize = true;
            this.RbMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbMarried.Location = new System.Drawing.Point(160, 298);
            this.RbMarried.Name = "RbMarried";
            this.RbMarried.Size = new System.Drawing.Size(60, 17);
            this.RbMarried.TabIndex = 14;
            this.RbMarried.TabStop = true;
            this.RbMarried.Text = "Married";
            this.RbMarried.UseVisualStyleBackColor = true;
            // 
            // MtbxSalary
            // 
            this.MtbxSalary.Location = new System.Drawing.Point(104, 239);
            this.MtbxSalary.Mask = "00000";
            this.MtbxSalary.Name = "MtbxSalary";
            this.MtbxSalary.Size = new System.Drawing.Size(110, 32);
            this.MtbxSalary.TabIndex = 5;
            this.MtbxSalary.ValidatingType = typeof(int);
            // 
            // CbxCity
            // 
            this.CbxCity.FormattingEnabled = true;
            this.CbxCity.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Bursa",
            "Antalya",
            "Konya",
            "Adana",
            "Şanlıurfa",
            "Gaziantep",
            "Kocaeli"});
            this.CbxCity.Location = new System.Drawing.Point(104, 188);
            this.CbxCity.Name = "CbxCity";
            this.CbxCity.Size = new System.Drawing.Size(110, 33);
            this.CbxCity.TabIndex = 4;
            // 
            // TbxId
            // 
            this.TbxId.Location = new System.Drawing.Point(104, 31);
            this.TbxId.Name = "TbxId";
            this.TbxId.Size = new System.Drawing.Size(110, 32);
            this.TbxId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(2, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Id:";
            // 
            // RbSingle
            // 
            this.RbSingle.AutoSize = true;
            this.RbSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbSingle.Location = new System.Drawing.Point(104, 298);
            this.RbSingle.Name = "RbSingle";
            this.RbSingle.Size = new System.Drawing.Size(54, 17);
            this.RbSingle.TabIndex = 6;
            this.RbSingle.TabStop = true;
            this.RbSingle.Text = "Single";
            this.RbSingle.UseVisualStyleBackColor = true;
            // 
            // TbxSurname
            // 
            this.TbxSurname.Location = new System.Drawing.Point(104, 137);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(110, 32);
            this.TbxSurname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Surname:";
            // 
            // TbxJob
            // 
            this.TbxJob.Location = new System.Drawing.Point(104, 341);
            this.TbxJob.Name = "TbxJob";
            this.TbxJob.Size = new System.Drawing.Size(110, 32);
            this.TbxJob.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(2, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Job:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "City:";
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(104, 86);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(110, 32);
            this.TbxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // BtList
            // 
            this.BtList.BackColor = System.Drawing.Color.Azure;
            this.BtList.Location = new System.Drawing.Point(25, 31);
            this.BtList.Name = "BtList";
            this.BtList.Size = new System.Drawing.Size(183, 41);
            this.BtList.TabIndex = 1;
            this.BtList.Text = "List";
            this.BtList.UseVisualStyleBackColor = false;
            this.BtList.Click += new System.EventHandler(this.BtList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtReport);
            this.groupBox2.Controls.Add(this.BtGraph);
            this.groupBox2.Controls.Add(this.BtStatistic);
            this.groupBox2.Controls.Add(this.BtClear);
            this.groupBox2.Controls.Add(this.BtUpdate);
            this.groupBox2.Controls.Add(this.BtDelete);
            this.groupBox2.Controls.Add(this.BtSave);
            this.groupBox2.Controls.Add(this.BtList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 400);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // BtReport
            // 
            this.BtReport.BackColor = System.Drawing.Color.Azure;
            this.BtReport.Location = new System.Drawing.Point(25, 339);
            this.BtReport.Name = "BtReport";
            this.BtReport.Size = new System.Drawing.Size(183, 41);
            this.BtReport.TabIndex = 8;
            this.BtReport.Text = "Report";
            this.BtReport.UseVisualStyleBackColor = false;
            this.BtReport.Click += new System.EventHandler(this.BtReport_Click);
            // 
            // BtGraph
            // 
            this.BtGraph.BackColor = System.Drawing.Color.Azure;
            this.BtGraph.Location = new System.Drawing.Point(25, 295);
            this.BtGraph.Name = "BtGraph";
            this.BtGraph.Size = new System.Drawing.Size(183, 41);
            this.BtGraph.TabIndex = 7;
            this.BtGraph.Text = "Graph";
            this.BtGraph.UseVisualStyleBackColor = false;
            this.BtGraph.Click += new System.EventHandler(this.BtGraph_Click);
            // 
            // BtStatistic
            // 
            this.BtStatistic.BackColor = System.Drawing.Color.Azure;
            this.BtStatistic.Location = new System.Drawing.Point(25, 251);
            this.BtStatistic.Name = "BtStatistic";
            this.BtStatistic.Size = new System.Drawing.Size(183, 41);
            this.BtStatistic.TabIndex = 6;
            this.BtStatistic.Text = "Statistic";
            this.BtStatistic.UseVisualStyleBackColor = false;
            this.BtStatistic.Click += new System.EventHandler(this.BtStatistic_Click);
            // 
            // BtClear
            // 
            this.BtClear.BackColor = System.Drawing.Color.Azure;
            this.BtClear.Location = new System.Drawing.Point(25, 207);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(183, 41);
            this.BtClear.TabIndex = 5;
            this.BtClear.Text = "Clear";
            this.BtClear.UseVisualStyleBackColor = false;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.BackColor = System.Drawing.Color.Azure;
            this.BtUpdate.Location = new System.Drawing.Point(25, 163);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(183, 41);
            this.BtUpdate.TabIndex = 4;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.BackColor = System.Drawing.Color.Azure;
            this.BtDelete.Location = new System.Drawing.Point(25, 119);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(183, 41);
            this.BtDelete.TabIndex = 3;
            this.BtDelete.Text = "Delete";
            this.BtDelete.UseVisualStyleBackColor = false;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // BtSave
            // 
            this.BtSave.BackColor = System.Drawing.Color.Azure;
            this.BtSave.Location = new System.Drawing.Point(25, 75);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(183, 41);
            this.BtSave.TabIndex = 2;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = false;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgwEmployeeDb);
            this.groupBox3.Location = new System.Drawing.Point(12, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(921, 214);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // DgwEmployeeDb
            // 
            this.DgwEmployeeDb.AllowUserToAddRows = false;
            this.DgwEmployeeDb.AllowUserToDeleteRows = false;
            this.DgwEmployeeDb.AllowUserToResizeRows = false;
            this.DgwEmployeeDb.AutoGenerateColumns = false;
            this.DgwEmployeeDb.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.DgwEmployeeDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwEmployeeDb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.DgwEmployeeDb.DataSource = this.employeesBindingSource;
            this.DgwEmployeeDb.Location = new System.Drawing.Point(6, 19);
            this.DgwEmployeeDb.Name = "DgwEmployeeDb";
            this.DgwEmployeeDb.ReadOnly = true;
            this.DgwEmployeeDb.Size = new System.Drawing.Size(909, 174);
            this.DgwEmployeeDb.TabIndex = 9;
            this.DgwEmployeeDb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwEmployeeDb_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn5.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "State";
            this.dataGridViewCheckBoxColumn1.HeaderText = "State";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn6.HeaderText = "Job";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(945, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Employee Database ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwEmployeeDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbSingle;
        private System.Windows.Forms.Button BtList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtGraph;
        private System.Windows.Forms.Button BtStatistic;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.TextBox TbxId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgwEmployeeDb;
        private System.Windows.Forms.MaskedTextBox MtbxSalary;
        private System.Windows.Forms.ComboBox CbxCity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.RadioButton RbMarried;
        private System.Windows.Forms.Button BtReport;
    }
}

