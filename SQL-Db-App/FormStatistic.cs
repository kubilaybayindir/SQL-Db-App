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
using System.Xml.Linq;
using System.Data.SqlClient;

namespace SQL_Db_App
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private void FormStatistic_Load(object sender, EventArgs e)
        {

            sqlConnection.Open();
            //Total Employees
            SqlCommand sqlTotalEmployeesCommand = new SqlCommand("SELECT COUNT(*) FROM Employees ", sqlConnection);
            SqlDataReader sqlTEDataReader = sqlTotalEmployeesCommand.ExecuteReader();
            while (sqlTEDataReader.Read())
            {
                LblTotalEmployees.Text = "Total Employees: " + sqlTEDataReader[0].ToString();
            }
            sqlConnection.Close();

            //Married Employees
            sqlConnection.Open();
            SqlCommand sqlMarriedEmployeesCommand = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE State=1;", sqlConnection);
            SqlDataReader sqlMEDataReader = sqlMarriedEmployeesCommand.ExecuteReader();
            while (sqlMEDataReader.Read())
            {
                LblMEmployees.Text = "Married Employees: " + sqlMEDataReader[0].ToString();
            }
            sqlConnection.Close();

            //Single Employees
            sqlConnection.Open();
            SqlCommand sqlSingleEmployeesCommand = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE State=0;", sqlConnection);
            SqlDataReader sqlSEDataReader = sqlSingleEmployeesCommand.ExecuteReader();
            while (sqlSEDataReader.Read())
            {
                LblSEmployees.Text = "Single Employees: " + sqlSEDataReader[0].ToString();
            }
            sqlConnection.Close();

            //Total Cities
            sqlConnection.Open();
            SqlCommand sqlTotalCitiesCommand = new SqlCommand("SELECT COUNT(Distinct(City)) FROM Employees ", sqlConnection);
            SqlDataReader sqlTCDataReader = sqlTotalCitiesCommand.ExecuteReader();
            while (sqlTCDataReader.Read())
            {
                LblCities.Text = "Total Cities: " + sqlTCDataReader[0].ToString();
            }
            sqlConnection.Close();

            //Total Salary
            sqlConnection.Open();
            SqlCommand sqlTotalSalaryCommand = new SqlCommand("SELECT Sum(Salary) FROM Employees ", sqlConnection);
            SqlDataReader sqlTSDataReader = sqlTotalSalaryCommand.ExecuteReader();
            while (sqlTSDataReader.Read())
            {
                int ts = 0;
                //ts += sqlTSDataReader[0];

                LblTSalary.Text = "Total Salary: " + sqlTSDataReader[0].ToString();
            }
            sqlConnection.Close();

            //Average Salary
            sqlConnection.Open();
            SqlCommand sqlAverageSalaryCommand = new SqlCommand("SELECT Avg(Salary) FROM Employees ", sqlConnection);
            SqlDataReader sqlASDataReader = sqlAverageSalaryCommand.ExecuteReader();
            while (sqlASDataReader.Read())
            {
                LblAvgSalary.Text = "Average Salary: " + sqlASDataReader[0].ToString();
            }
            sqlConnection.Close();
        }
    }
}
