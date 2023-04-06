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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection=new SqlConnection(Properties.Settings.Default.ConnectionString);
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //this.TbxUsername.Size = new System.Drawing.Size(173, 100);
            //TbxUsername.Size.Height = 100;
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From LoginManagement Where Username=@p1 and Password=@p2",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",TbxUsername.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TbxPassword.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                MainForm mainForm = new MainForm();

                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password","Error");
            }
            sqlConnection.Close();
        }
    }
}
