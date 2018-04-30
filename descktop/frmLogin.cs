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

namespace descktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEntrar;
        }

        ////Connection String
        //string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True;";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Por Favor, Insira um Usuario e Senha");
                return;
            }
            try
            {
                ////Create SqlConnection
                //SqlConnection con = new SqlConnection(cs);
                //SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con);
                //cmd.Parameters.AddWithValue("@username", txtUsuario.Text);
                //cmd.Parameters.AddWithValue("@password", txtSenha.Text);
                //con.Open();
                //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //adapt.Fill(ds);
                //con.Close();
                //int count = ds.Tables[0].Rows.Count;
                ////If count is equal to 1, than show frmMain form
                if (txtUsuario.Text == "will" && txtSenha.Text == "123")
                {
                    //MessageBox.Show("Login Successful!");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Login Failed!", "", MessageBoxButtons.RetryCancel);
                    switch (dr)
                    {
                        case DialogResult.Retry:
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                switch (dr)
                {
                    case DialogResult.OK:
                        this.Close();
                        break;
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
