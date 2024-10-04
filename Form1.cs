using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Конструирование_ПО
{
    public partial class Form1 : Form
    {
        Model1 dbcontext = new Model1();
        List<Plan> allPlans;
        List<Field_of_study> allFields;
        List<Department> allDepartments;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            allFields = dbcontext.Field_of_study.ToList();
            allDepartments = dbcontext.Department.ToList();
            LoadPlans();
            FillComboboxes();
        }

        void LoadPlans()
        {
            dbcontext.Plan.Load();
            allPlans = dbcontext.Plan.ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = allPlans;
        }

        void FillComboboxes()
        {
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["ID_Field_of_study"]).DataSource =
                dbcontext.Field_of_study.ToList();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["ID_Field_of_study"]).DisplayMember =
                "Code";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["ID_Field_of_study"]).ValueMember =
                "ID";

            ((DataGridViewComboBoxColumn)dataGridView1.Columns["ID_Department"]).DataSource =
                dbcontext.Department.ToList();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["ID_Department"]).DisplayMember =
                "Abbreviation";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["ID_Department"]).ValueMember =
                "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var request = dbcontext.Plan_discipline
                .Join(dbcontext.Discipline, pd => pd.ID_Discipline, disc => disc.ID, (pd, disc) => pd)
                .Where(i => i.ID_Plan == numericUpDown1.Value)
                .Select(i => new { Name = i.Discipline.Name, Volume = i.Volume })
                .OrderBy(i => i.Volume)
                .ToList();
            dataGridView2.DataSource = request;
        }   

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPlanForm f = new AddPlanForm();

            f.comboBox1.DataSource = allFields;
            f.comboBox1.DisplayMember = "Code";
            f.comboBox1.ValueMember = "ID";

            f.comboBox2.DataSource = allDepartments;
            f.comboBox2.DisplayMember = "Abbreviation";
            f.comboBox2.ValueMember = "ID";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            Plan plan = new Plan();
            plan.ID_Field_of_study = (int)f.comboBox1.SelectedValue;
            plan.ID_Department = (int)f.comboBox2.SelectedValue;
            plan.Admission_date = f.dateTimePicker1.Value;
            plan.Specialty = f.textBox1.Text;
            plan.Form = f.textBox2.Text;
            plan.Duration = (int)f.numericUpDown1.Value;
            plan.Qualification = f.textBox3.Text;

            dbcontext.Plan.Add(plan);
            dbcontext.SaveChanges();
            LoadPlans();
            MessageBox.Show("Новый объект добавлен");
        }

        class SPResult
        {
            public string Name { get; set; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlParameter param = new SqlParameter("@date", dateTimePicker1.Value);
            var result = dbcontext.Database.SqlQuery<SPResult>("GetPlans @date", new object[] {param}).ToList();
            dataGridView3.DataSource = result;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int index = GetSelectedRow(dataGridView1);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Plan plan = dbcontext.Plan.Where(i => i.ID == id).FirstOrDefault();
                if (plan != null)
                {
                    AddPlanForm f = new AddPlanForm();

                    f.comboBox1.DataSource = allFields;
                    f.comboBox1.DisplayMember = "Code";
                    f.comboBox1.ValueMember = "ID";
                    f.comboBox2.DataSource = allDepartments;
                    f.comboBox2.DisplayMember = "Abbreviation";
                    f.comboBox2.ValueMember = "ID";

                    f.dateTimePicker1.Value = plan.Admission_date;
                    f.textBox1.Text = plan.Specialty;
                    f.textBox2.Text = plan.Form;
                    f.numericUpDown1.Value = plan.Duration;
                    f.textBox3.Text = plan.Qualification;
                    f.comboBox1.SelectedValue = plan.ID_Field_of_study;
                    f.comboBox2.SelectedValue = plan.ID_Department;
                    
                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;
                    plan.ID_Field_of_study = (int)f.comboBox1.SelectedValue;
                    plan.ID_Department = (int)f.comboBox2.SelectedValue;
                    plan.Admission_date = f.dateTimePicker1.Value;
                    plan.Specialty = f.textBox1.Text;
                    plan.Form = f.textBox2.Text;
                    plan.Duration = (int)f.numericUpDown1.Value;
                    plan.Qualification = f.textBox3.Text;


                    dbcontext.SaveChanges();
                    MessageBox.Show("Объект обновлен");
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }
        
        int GetSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = GetSelectedRow(dataGridView1);
            if (index != -1)
            {
                var row = dbcontext.Plan.Find(index);
                dbcontext.Plan.Remove(row);
                dbcontext.SaveChanges();
                LoadPlans();
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }
    }
}
