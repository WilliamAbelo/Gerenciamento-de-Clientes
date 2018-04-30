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


            checkRegioes.Items.Add("Regiao 1");
            checkRegioes.Items.Add("Regiao 2");
            checkRegioes.Items.Add("Regiao 3");
            checkRegioes.Items.Add("Regiao 4");

            
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
            //var selecionado = listRegioes.SelectedItem;

            //switch (listRegioes.SelectedItem)
            //{
            //    case "Regiao 1":

            //        break;
            //    case "Regiao 2":

            //        break;
            //    case "Regiao 3":

            //        break;
            //    case "Regiao 4":

            //        break;

            //}
        }

        private void usuariosMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario fu = new frmUsuario();
            fu.Show();
        }

        private void TbClientes_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblRua_Click(object sender, EventArgs e)
        {

        }

        private void txtMascCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApelido_Click(object sender, EventArgs e)
        {

        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkRegioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(checkRegioes.SelectedItem.ToString());
            //item.Name = checkRegioes.SelectedItem.ToString();
            item.SubItems.Add("Subitem");

            listClientes.Items.Add(item);
            //listClientes.Refresh();
            //listClientes.Show();
            //MessageBox.Show("selecionando: {0}", checkRegioes.SelectedItems.Count.ToString());
        }
    }
}
