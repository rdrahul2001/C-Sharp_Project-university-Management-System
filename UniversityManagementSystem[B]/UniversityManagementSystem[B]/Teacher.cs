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

namespace UniversityManagementSystem_B_
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\OneDrive\Documents\Aiubdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridViewT.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void DeptCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(TName.Text == ""|| TId.Text == "" || DeptCb.Text == ""|| GenderCb.Text == "" || Salary.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl values('"+TName.Text +"','"+TId.Text+"','"+DeptCb.SelectedItem.ToString()+"','"+GenderCb.SelectedItem.ToString()+"','"+Salary.Text+"')",Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher added succesfully");
                    Con.Close();
                    populate();
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong");

            }
        }

        private void DataGridViewT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TName.Text = DataGridViewT.SelectedRows[0].Cells[0].Value.ToString();
            TId.Text = DataGridViewT.SelectedRows[0].Cells[1].Value.ToString();
            DeptCb.Text = DataGridViewT.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = DataGridViewT.SelectedRows[0].Cells[4].Value.ToString();
            Salary.Text = DataGridViewT.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnTdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(TId.Text == "")
                {
                    MessageBox.Show("Enter te Teacher's Id");
                }
                else
                {
                    Con.Open();
                    string query = "Delete From TeacherTbl where TeacherId='"+TId.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Teacher Not Deleted ");
            }
        }

        private void btnTedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TId.Text == "" || TName.Text == "" || DeptCb.Text=="" || GenderCb.Text=="" || Salary.Text=="" )
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    Con.Open();
                    string query = "update TeacherTbl set TeacherName ='" + TName.Text + "',TeacherGender ='" + GenderCb.SelectedItem.ToString() + "',TeacherDept='" + DeptCb.SelectedItem.ToString() + "',TeacherSalary='" + Salary.Text + "'where TeacherId='" + TId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher updateded Successfuly");
                    Con.Close();
                    populate();
                }

            }
            catch
            {
                MessageBox.Show("Teacher not updated");
            }
        }

        private void btnTback_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void TId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TName_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
