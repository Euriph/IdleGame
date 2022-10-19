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

namespace IdleGame
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T376648;Initial Catalog=IdleGame;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into tblUser values(@name,@lastname,@nickname,@password,@email,@statusId,@CreDate,@ModDate,@ActiveFlg)", con);
            cmd.CommandType = CommandType.StoredProcedure;  
            cmd.Parameters.AddWithValue("name", txtName.Text);  
            cmd.Parameters.AddWithValue("lastname", txtLastname.Text);  
            cmd.Parameters.AddWithValue("nickname", txtNickname.Text);  
            cmd.Parameters.AddWithValue("password", txtPassword.Text);
            cmd.Parameters.AddWithValue("email", txtEmail.Text);
            cmd.Parameters.AddWithValue("statusId", 1);
            cmd.Parameters.AddWithValue("CreDate", DateTime.Now);
            cmd.Parameters.AddWithValue("ModDate", DateTime.Now);
            cmd.Parameters.AddWithValue("ActiveFlg", 1);

            con.Open();
            int i = cmd.ExecuteNonQuery();  
  
            con.Close();  
  
            if (i!=0)  
            {
                new FrmLogin().Show();
                this.Hide();
            }
        }

    }
}
