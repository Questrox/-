using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StudyPlanString"].ConnectionString;
        SqlDataAdapter planAdapter, fieldOfStudyAdapter;

        SqlCommandBuilder planBuilder, fieldOfStudyBuilder;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();

            planAdapter = new SqlDataAdapter("select * from \"Plan\"", connectionString);
            fieldOfStudyAdapter = new SqlDataAdapter("select * from \"Field_of_study\"", connectionString);
            planBuilder = new SqlCommandBuilder(planAdapter);
            fieldOfStudyBuilder = new SqlCommandBuilder(fieldOfStudyAdapter);
            planAdapter.Fill(ds, "Plan");
            fieldOfStudyAdapter.Fill(ds, "Field_of_study");
            dataGridView1.DataSource = ds.Tables["Plan"];
            dataGridView4.DataSource = ds.Tables["Field_of_study"];
            FillPlanCombobox();
        }

        void FillPlanCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["FK_Field_of_study"]).DataSource =
                ds.Tables["Field_of_study"];
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["FK_Field_of_study"]).DisplayMember =
                "Code";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["FK_Field_of_study"]).ValueMember =
                "ID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                planAdapter.Update(ds, "Plan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Discipline.Name, PD.Volume FROM Plan_discipline AS PD\r" +
                "JOIN Discipline ON Discipline.ID = PD.FK_Discipline\r" +
                "WHERE FK_Plan = " + numericUpDown1.Value.ToString() + "\r" +
                "ORDER BY Volume DESC";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable("report1");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Volume");
                while (sqlDataReader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Name"] = sqlDataReader["Name"];
                    row["Volume"] = sqlDataReader["Volume"];
                    dataTable.Rows.Add(row);
                }
                sqlDataReader.Close();
                dataGridView2.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("GetPlans", sqlConnection);
                sqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                sqlAdapter.SelectCommand.Parameters["@date"].Value = dateTimePicker1.Value;


                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "report2");

                dataGridView3.DataSource = dataSet.Tables["report2"];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                fieldOfStudyAdapter.Update(ds, "Field_of_study");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных");
            }
        }
    }
}
