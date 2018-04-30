namespace descktop
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbControll = new System.Windows.Forms.TabControl();
            this.TbClientes = new System.Windows.Forms.TabPage();
            this.TbUsuarios = new System.Windows.Forms.TabPage();
            this.checkRegioes = new System.Windows.Forms.CheckedListBox();
            this.listClientes = new System.Windows.Forms.ListView();
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbControll.SuspendLayout();
            this.TbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControll
            // 
            this.tbControll.Controls.Add(this.TbClientes);
            this.tbControll.Controls.Add(this.TbUsuarios);
            this.tbControll.Location = new System.Drawing.Point(12, 12);
            this.tbControll.Name = "tbControll";
            this.tbControll.SelectedIndex = 0;
            this.tbControll.Size = new System.Drawing.Size(760, 537);
            this.tbControll.TabIndex = 0;
            // 
            // TbClientes
            // 
            this.TbClientes.Controls.Add(this.listClientes);
            this.TbClientes.Controls.Add(this.checkRegioes);
            this.TbClientes.Location = new System.Drawing.Point(4, 22);
            this.TbClientes.Name = "TbClientes";
            this.TbClientes.Padding = new System.Windows.Forms.Padding(3);
            this.TbClientes.Size = new System.Drawing.Size(752, 511);
            this.TbClientes.TabIndex = 1;
            this.TbClientes.Text = "Clientes";
            this.TbClientes.UseVisualStyleBackColor = true;
            this.TbClientes.Click += new System.EventHandler(this.TbClientes_Click);
            // 
            // TbUsuarios
            // 
            this.TbUsuarios.Location = new System.Drawing.Point(4, 22);
            this.TbUsuarios.Name = "TbUsuarios";
            this.TbUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.TbUsuarios.Size = new System.Drawing.Size(752, 511);
            this.TbUsuarios.TabIndex = 2;
            this.TbUsuarios.Text = "Usuarios";
            this.TbUsuarios.UseVisualStyleBackColor = true;
            // 
            // checkRegioes
            // 
            this.checkRegioes.CheckOnClick = true;
            this.checkRegioes.FormattingEnabled = true;
            this.checkRegioes.Location = new System.Drawing.Point(7, 7);
            this.checkRegioes.Name = "checkRegioes";
            this.checkRegioes.Size = new System.Drawing.Size(120, 94);
            this.checkRegioes.TabIndex = 20;
            this.checkRegioes.SelectedIndexChanged += new System.EventHandler(this.checkRegioes_SelectedIndexChanged);
            // 
            // listClientes
            // 
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colCidade,
            this.colTelefone});
            this.listClientes.Location = new System.Drawing.Point(7, 108);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(739, 397);
            this.listClientes.TabIndex = 21;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            // 
            // colCidade
            // 
            this.colCidade.Text = "Cidade";
            // 
            // colTelefone
            // 
            this.colTelefone.Text = "Telefone";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbControll);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbControll.ResumeLayout(false);
            this.TbClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControll;
        private System.Windows.Forms.TabPage TbClientes;
        private System.Windows.Forms.TabPage TbUsuarios;
        private System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colCidade;
        private System.Windows.Forms.ColumnHeader colTelefone;
        private System.Windows.Forms.CheckedListBox checkRegioes;
    }
}