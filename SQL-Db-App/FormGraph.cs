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

namespace SQL_Db_App
{
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private void FormGraph_Load(object sender, EventArgs e)
        {

            sqlConnection.Open();
            //Cities
            SqlCommand sqlCitiesCommand = new SqlCommand("SELECT City,COUNT(*) FROM Employees Group By City", sqlConnection);
            SqlDataReader sqlCitiesDataReader = sqlCitiesCommand.ExecuteReader();
            while (sqlCitiesDataReader.Read())
            {
                ChCities.Series["Cities"].Points.AddXY(sqlCitiesDataReader[0], sqlCitiesDataReader[1]);
            }
            sqlConnection.Close();

            //Job-Average Salary 
            sqlConnection.Open();
            SqlCommand sqlJobAverageSalaryCommand = new SqlCommand("SELECT Job,Avg(Salary) FROM Employees Group By Job", sqlConnection);
            SqlDataReader sqlJASDataReader = sqlJobAverageSalaryCommand.ExecuteReader();
            while (sqlJASDataReader.Read())
            {
                ChJobSalary.Series["Job-Salary"].Points.AddXY(sqlJASDataReader[0], sqlJASDataReader[1]);
            }
            sqlConnection.Close();

        }
    }
}
