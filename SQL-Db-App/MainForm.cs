using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace SQL_Db_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void ClearAllCursor()
        {
            TbxId.Text = "";
            TbxName.Text = "";
            TbxSurname.Text = "";
            MtbxSalary.Text = "";
            CbxCity.Text = "";
            RbSingle.Checked = false;
            RbMarried.Checked = false;
            TbxJob.Text = "";
        }


        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);
        }

        private void BtList_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                
                if (TbxName.Text == "" || TbxSurname.Text == "" || CbxCity.SelectedItem == "" || MtbxSalary.Text == "" || (RbMarried.Checked == false && RbSingle.Checked== false) || TbxJob.Text == "" )
                {
                    MessageBox.Show("Fill in the blanks", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("Insert Into Employees (Name,Surname,City,Salary,State,Job) Values (@p1,@p2,@p3,@p4,@p5,@p6);", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@p1", TbxName.Text);
                    sqlCommand.Parameters.AddWithValue("@p2", TbxSurname.Text);
                    sqlCommand.Parameters.AddWithValue("@p3", CbxCity.SelectedItem);
                    sqlCommand.Parameters.AddWithValue("@p4", MtbxSalary.Text);
                    sqlCommand.Parameters.AddWithValue("@p5", RbMarried.Checked ? 1 : (RbSingle.Checked ? 0 : 0));
                    sqlCommand.Parameters.AddWithValue("@p6", TbxJob.Text);

                    sqlCommand.ExecuteNonQuery();//insert update delete de kullanılır.

                    MessageBox.Show("Save operation is completed succesfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllCursor();
                }
            }
            else
            {
                MessageBox.Show("An error occurred about database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            ClearAllCursor();
        }

        public void DgwEmployeeDb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenCursor = DgwEmployeeDb.SelectedCells[0].RowIndex;

            TbxId.Text = DgwEmployeeDb.Rows[chosenCursor].Cells[0].Value.ToString();
            TbxName.Text = DgwEmployeeDb.Rows[chosenCursor].Cells[1].Value.ToString();
            TbxSurname.Text = DgwEmployeeDb.Rows[chosenCursor].Cells[2].Value.ToString();
            CbxCity.Text = DgwEmployeeDb.Rows[chosenCursor].Cells[3].Value.ToString();
            MtbxSalary.Text = DgwEmployeeDb.Rows[chosenCursor].Cells[4].Value.ToString();
            RbSingle.Checked = !(bool)DgwEmployeeDb.Rows[chosenCursor].Cells[5].Value;
            RbMarried.Checked = (bool)DgwEmployeeDb.Rows[chosenCursor].Cells[5].Value;
            TbxJob.Text = DgwEmployeeDb.Rows[chosenCursor].Cells[6].Value.ToString();
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Employees WHERE Id=@p1;", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", TbxId.Text);

                sqlCommand.ExecuteNonQuery();//insert update delete de kullanılır.

                sqlConnection.Close();

                MessageBox.Show("Delete operation is completed succesfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllCursor();
            }
            else
            {
                MessageBox.Show("An error occurred about database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State ==ConnectionState.Open)
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Employees SET Name = @p1, Surname = @p2, City = @p3, Salary = @p4,State = @p5,Job = @p6 Where Id=@p7;", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", TbxName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", TbxSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", CbxCity.Text);
                sqlCommand.Parameters.AddWithValue("@p4", MtbxSalary.Text);
                sqlCommand.Parameters.AddWithValue("@p5", RbMarried.Checked ? 1 : (RbSingle.Checked ? 0 : 0));
                sqlCommand.Parameters.AddWithValue("@p6", TbxJob.Text);
                sqlCommand.Parameters.AddWithValue("@p7", TbxId.Text);

                sqlCommand.ExecuteNonQuery();//insert update delete de kullanılır.

                MessageBox.Show("Update operation is completed succesfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllCursor();
            }
            else
            {
                MessageBox.Show("An error occurred about database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void BtStatistic_Click(object sender, EventArgs e)
        {
            FormStatistic form =new FormStatistic();
            form.Show();
        }

        private void BtGraph_Click(object sender, EventArgs e)
        {
            FormGraph form = new FormGraph();
            form.Show();
        }

        private void BtReport_Click(object sender, EventArgs e)
        {
            FormReport form = new FormReport();
            form.Show();
        }
    }
}
