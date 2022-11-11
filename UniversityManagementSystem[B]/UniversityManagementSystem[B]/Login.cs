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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\OneDrive\Documents\Aiubdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from UserTbl where Username = '" + textUser.Text + "' and password = '" + textPass.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(textUser.Text=="" || textPass.Text == "")
            {
                MessageBox.Show("Enter Username and password");
            }
            else
            {
                if (cmbRole.SelectedIndex > -1)
                {
                    if(cmbRole.SelectedItem.ToString() == "Administration")
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            MainForm Home = new MainForm();
                            Home.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password");
                        }
                    }
                    else
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Dashboard d = new Dashboard();
                            d.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("wrong username or password");
                        }
                    }
                }
            }
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
