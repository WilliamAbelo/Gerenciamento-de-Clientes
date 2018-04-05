using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listRegioes.Items.Add("Regiao 1");
            listRegioes.Items.Add("Regiao 2");
            listRegioes.Items.Add("Regiao 3");
            listRegioes.Items.Add("Regiao 4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listRegioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = listRegioes.SelectedItem;

            switch (listRegioes.SelectedItem)
            {
                case "Regiao 1":

                    break;
                case "Regiao 2":

                    break;
                case "Regiao 3":

                    break;
                case "Regiao 4":

                    break;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario fm = new frmUsuario();
            fm.Show();
        }
    }
}
