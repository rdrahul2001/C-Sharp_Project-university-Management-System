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
//using System.Data.SqlClient;

namespace UniversityManagementSystem_B_
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\OneDrive\Documents\Aiubdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDataGridView.DataSource = ds.Tables[0];
            Con.Close();
            
        }
       
        private void User_Load(object sender, EventArgs e)
        {

        }

        private void btnUAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(UidTb.Text=="" || UnameTb.Text=="" || UpassTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl values(" + UidTb.Text + ",'" + UnameTb.Text + "','" + UpassTb.Text + "')",Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User succesfully Added");
                    Con.Close();
                    populate();
                }
            }catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UidTb.Text = UserDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            UnameTb.Text = UserDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UserDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(UidTb.Text == "")
                {
                    MessageBox.Show("Enter User id");
                }
                else
                {
                    Con.Open();
                    string query = "delete from UserTbl where Userid=" + UidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted succesfully");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("User Not deleted ");

            }
        }

        private void btnUEdit_Click(object sender, EventArgs e)
        {
             try
            {
                if(UidTb.Text == "" || UnameTb.Text == "" || UpassTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    Con.Open();
                    string query = "update UserTbl set UserName='" + UnameTb.Text + "',password ='" + UpassTb.Text + "'where UserId=" + UidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updateded Successfuly");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("User Not deleted ");
            }
        }

        private void btnTback_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
                
        }
    }
}
