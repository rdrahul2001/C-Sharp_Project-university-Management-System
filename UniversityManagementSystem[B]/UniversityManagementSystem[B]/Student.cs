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



namespace UniversityManagementSystem_B_
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\OneDrive\Documents\Aiubdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            stdDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        
        }
        private void label3_Click(object sender, EventArgs e)
        {
            populate();

        }
        
        private void textSid_TextChanged(object sender, EventArgs e)
        {
        
        }
        
        private void btnSadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (StdId.Text == "" || StdName.Text == "" || stdGendreCb.Text == "" || stdDepartCB.Text == "" || stdFeesTb.Text == "" || stdDate.Text=="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl values('" + StdId.Text + "','" + StdName.Text + "','" + stdGendreCb.SelectedItem.ToString() + "','" + stdDate.Text + "','" + stdDepartCB.SelectedItem.ToString() + "','" + stdFeesTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added succesfully");
                    Con.Close();
                    populate();
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong");

            }

        }
        
        private void Student_Load(object sender, EventArgs e)
        {
        
        }

        private void studentEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (StdId.Text == "" || StdName.Text == "" || stdGendreCb.Text == "" || stdDepartCB.Text == "" || stdFeesTb.Text == "" || stdDate.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    Con.Open();
                    string query = "update StudentTbl set StudentName ='" + StdName.Text + "',StudentGender ='" + stdGendreCb.SelectedItem.ToString() + "',StudentDOB='" + stdDate.Text + "',StudentDept ='" + stdDepartCB.SelectedItem.ToString() + "',StudentFees='" + stdFeesTb.Text + "'where StudentId='" + StdId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updateded Successfuly");
                    Con.Close();
                    populate(); 
                }

            }
            catch
            {
                MessageBox.Show("Student not updated");
            }
        }

        private void studentDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (StdId.Text == "")
                {
                    MessageBox.Show("Enter te Student's Id");
                }
                else
                {
                    Con.Open();
                    string query = "Delete From StudentTbl where StudentId='" + StdId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Teacher Not Deleted ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSback_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stdDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdName.Text = stdDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            StdId.Text = stdDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            stdGendreCb.Text = stdDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            stdDepartCB.Text = stdDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            stdDate.Text = stdDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            stdFeesTb.Text = stdDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }
    }
}
