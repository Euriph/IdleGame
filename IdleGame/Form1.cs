using System.Data;
using System.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IdleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T376648;Initial Catalog=IdleGame;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from tblUser where nickname='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows.Count > 0)
                {                  
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                }
            }
            else
            {
                MessageBox.Show("Enter both fields");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}