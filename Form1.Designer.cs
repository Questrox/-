﻿namespace Конструирование_ПО
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name_Grid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume_Grid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admission_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Field_of_study = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Department = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFieldofstudyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldofstudyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plandisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePlans = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePlans)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(722, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчет 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Факультеты, которые принимали учебные планы позже заданной даты:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 137);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(720, 269);
            this.dataGridView3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Показать факультеты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберите дату:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Показать дисциплины";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Grid2,
            this.Volume_Grid2});
            this.dataGridView2.Location = new System.Drawing.Point(0, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(717, 274);
            this.dataGridView2.TabIndex = 3;
            // 
            // Name_Grid2
            // 
            this.Name_Grid2.DataPropertyName = "Name";
            this.Name_Grid2.HeaderText = "Название";
            this.Name_Grid2.Name = "Name_Grid2";
            this.Name_Grid2.ReadOnly = true;
            // 
            // Volume_Grid2
            // 
            this.Volume_Grid2.DataPropertyName = "Volume";
            this.Volume_Grid2.HeaderText = "Объем";
            this.Volume_Grid2.Name = "Volume_Grid2";
            this.Volume_Grid2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Все дисциплины данного учебного плана:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(211, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите учебный план:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.UpdateButton);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Учебные планы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(164, 358);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(122, 39);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(8, 358);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(127, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Admission_date,
            this.Specialty,
            this.Form,
            this.Duration,
            this.Qualification,
            this.ID_Field_of_study,
            this.ID_Department,
            this.iDDataGridViewTextBoxColumn,
            this.admissiondateDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.formDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.iDFieldofstudyDataGridViewTextBoxColumn,
            this.iDDepartmentDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.fieldofstudyDataGridViewTextBoxColumn,
            this.plandisciplineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourcePlans;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50.81241F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Admission_date
            // 
            this.Admission_date.DataPropertyName = "Admission_date";
            this.Admission_date.FillWeight = 134.7106F;
            this.Admission_date.HeaderText = "Дата принятия";
            this.Admission_date.Name = "Admission_date";
            this.Admission_date.Width = 114;
            // 
            // Specialty
            // 
            this.Specialty.DataPropertyName = "Specialty";
            this.Specialty.FillWeight = 92.18448F;
            this.Specialty.HeaderText = "Профиль";
            this.Specialty.Name = "Specialty";
            this.Specialty.Width = 78;
            // 
            // Form
            // 
            this.Form.DataPropertyName = "Form";
            this.Form.FillWeight = 68.54495F;
            this.Form.HeaderText = "Форма обучения";
            this.Form.Name = "Form";
            this.Form.Width = 58;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.FillWeight = 92.14318F;
            this.Duration.HeaderText = "Срок";
            this.Duration.Name = "Duration";
            this.Duration.Width = 78;
            // 
            // Qualification
            // 
            this.Qualification.DataPropertyName = "Qualification";
            this.Qualification.FillWeight = 114.5925F;
            this.Qualification.HeaderText = "Квалификация";
            this.Qualification.Name = "Qualification";
            this.Qualification.Width = 97;
            // 
            // ID_Field_of_study
            // 
            this.ID_Field_of_study.DataPropertyName = "ID_Field_of_study";
            this.ID_Field_of_study.FillWeight = 124.1194F;
            this.ID_Field_of_study.HeaderText = "Направление";
            this.ID_Field_of_study.Name = "ID_Field_of_study";
            this.ID_Field_of_study.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID_Field_of_study.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID_Field_of_study.Width = 105;
            // 
            // ID_Department
            // 
            this.ID_Department.DataPropertyName = "ID_Department";
            this.ID_Department.FillWeight = 122.8926F;
            this.ID_Department.HeaderText = "Кафедра";
            this.ID_Department.Name = "ID_Department";
            this.ID_Department.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID_Department.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID_Department.Width = 104;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // admissiondateDataGridViewTextBoxColumn
            // 
            this.admissiondateDataGridViewTextBoxColumn.DataPropertyName = "Admission_date";
            this.admissiondateDataGridViewTextBoxColumn.HeaderText = "Admission_date";
            this.admissiondateDataGridViewTextBoxColumn.Name = "admissiondateDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // formDataGridViewTextBoxColumn
            // 
            this.formDataGridViewTextBoxColumn.DataPropertyName = "Form";
            this.formDataGridViewTextBoxColumn.HeaderText = "Form";
            this.formDataGridViewTextBoxColumn.Name = "formDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            // 
            // iDFieldofstudyDataGridViewTextBoxColumn
            // 
            this.iDFieldofstudyDataGridViewTextBoxColumn.DataPropertyName = "ID_Field_of_study";
            this.iDFieldofstudyDataGridViewTextBoxColumn.HeaderText = "ID_Field_of_study";
            this.iDFieldofstudyDataGridViewTextBoxColumn.Name = "iDFieldofstudyDataGridViewTextBoxColumn";
            // 
            // iDDepartmentDataGridViewTextBoxColumn
            // 
            this.iDDepartmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.HeaderText = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.Name = "iDDepartmentDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // fieldofstudyDataGridViewTextBoxColumn
            // 
            this.fieldofstudyDataGridViewTextBoxColumn.DataPropertyName = "Field_of_study";
            this.fieldofstudyDataGridViewTextBoxColumn.HeaderText = "Field_of_study";
            this.fieldofstudyDataGridViewTextBoxColumn.Name = "fieldofstudyDataGridViewTextBoxColumn";
            // 
            // plandisciplineDataGridViewTextBoxColumn
            // 
            this.plandisciplineDataGridViewTextBoxColumn.DataPropertyName = "Plan_discipline";
            this.plandisciplineDataGridViewTextBoxColumn.HeaderText = "Plan_discipline";
            this.plandisciplineDataGridViewTextBoxColumn.Name = "plandisciplineDataGridViewTextBoxColumn";
            // 
            // bindingSourcePlans
            // 
            this.bindingSourcePlans.DataSource = typeof(Конструирование_ПО.Plan);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(318, 358);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(115, 39);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(728, 433);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePlans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourcePlans;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume_Grid2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admission_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Field_of_study;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFieldofstudyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldofstudyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plandisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

