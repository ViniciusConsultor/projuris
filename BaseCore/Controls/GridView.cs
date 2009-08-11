using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Reflection.Emit;
using BaseCore;

namespace BaseCore
{
    
    public partial class GridView : UserControl
    {
        #region propriedades
        [Description("Nome da Tabela."),
          Category("Values"),
          DefaultValue(""),
          Browsable(true)]
        public string Table { get; set; }

        [Description("Descrição do Label do GridView."),
         Category("Values"),
         DefaultValue(""),
         Browsable(true)]
        public string Description { get; set; }

        [Description("Form que servirá para cadastrar."),
         Category("Values"),
         DefaultValue(null),
         Browsable(true)]
        public string NovoForm { get; set; }

								[Description("Coluna da tabela que deverá ocupar o espaço restante do gridview."),
								 Category("Values"),
								 DefaultValue(null),
								 Browsable(true)]
								public string ColunaFill { get; set; }

        [Description("Gerenciador de Colunas do GridView"),
         Category("Values"),
         DefaultValue(null),
         Browsable(true)]
        public DataGridViewColumnCollection ColumnConfigurator { get; set; }

		[Description("Colunas que não devem aparecer."),
			Category("Values"),
			DefaultValue(null),
			Browsable(true)]
		public String [] HideColumns { get; set; }

		[Description("Colunas que servirão para o order by.(Ex: denominacao asc, data asc)"),
			Category("Values"),
			DefaultValue(null),
			Browsable(true)]
		public String OrderBy { get; set; }

		[Description("Expressão utilizada no filtro.(Ex: Ativo = 1)"),
		 Category("Values"),
		 DefaultValue(null),
		 Browsable(true)]
		public String Filter { get; set; }
								
        #endregion

        private StringBuilder connStr;
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommand command;
        private SqlCommandBuilder builder;
        private BindingSource bindsource;
        private DataTable dt;
        private NewForm ficha;
        private String filtro = "1=1";
        private int colunaIndex = 0;

        public GridView()
        {
            
            InitializeComponent();
           
        }


        private void montaStringConexao()
        {
            connStr = new StringBuilder();
            connStr.Append("Data Source=");
            connStr.Append(".");
            connStr.Append(";Initial Catalog=");
            connStr.Append("ProJuris");
            connStr.Append(";Integrated Security=");
            connStr.Append("True");
            connStr.Append("");

        }

        public void Reload() 
        {
			lblReload_Click(this,null);
        }
        private void carregaDataSet()
        {
            try
            {
                string sqlQuery = "select top 200 * from " + Table;
                sqlQuery = sqlQuery + " where " + this.filtro;
                if (this.Filter != null && this.Filter.Trim() != "") sqlQuery = sqlQuery + " and " + this.Filter;
																if (this.OrderBy != null && this.OrderBy.Trim() != "") sqlQuery = sqlQuery + " order by " + this.OrderBy;
                lbDescription.Text = Description;
                conn = new SqlConnection(connStr.ToString());
                command = new SqlCommand(sqlQuery, conn);
                adapter = new SqlDataAdapter(command);
                builder = new SqlCommandBuilder(adapter);
                this.dt = new DataTable();
                bindsource = new BindingSource();
                conn.Open();
                adapter.Update(dt);
                adapter.Fill(dt);
                              
            }
            catch
            {
                //
            }

        }
         //   carregaDataSet();
        private void GridView_Load(object sender, EventArgs e)
        {
        try
            {
                montaStringConexao();
                carregaDataSet();
                bindsource.DataSource = dt;
                dataGridView.DataSource = bindsource;													
				dataGridView.RowHeadersVisible = false;
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
				dataGridView.Columns["id"].Visible = false;
				if (dataGridView.Columns["denominacao"] != null) dataGridView.Columns["denominacao"].HeaderText = "Nome";
				dataGridView.Columns[ColunaFill].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

				foreach (String a in this.HideColumns) // Retira as Colunas que não devem aparecer.
				{
					dataGridView.Columns[a].Visible = false;
				}
																
				this.ColumnConfigurator = dataGridView.Columns;
                dataGridView.ReadOnly = true;
                conn.Close();
            }
        catch { }
        }
        private NewForm geraNovoForm() 
        {
			Assembly asm = this.Parent.GetType().Assembly;
			AssemblyName projectName = asm.GetName();
			object obj = asm.CreateInstance(projectName.Name + "." + NovoForm);
			ficha = (NewForm)obj;
            //o MdiParent dele o Principal
            ficha.MdiParent = this.ParentForm.ParentForm;
            ficha.Pai = this.ParentForm;
            ficha.StartPosition = FormStartPosition.CenterScreen;
            return ficha;
        }
        #region eventosDosBotoes
        private void btnNovo_Click(object sender, EventArgs e)
        {
            ficha = geraNovoForm();           
            ficha.Operacao = "i";
            //Setando o text do form de acordo com o Genero.
            String nome = ficha.Text.Substring(0,1);
		    if (nome == "a") ficha.Text = "Nova " + ficha.Text.Substring(2);								
		    if (nome == "o") ficha.Text = "Novo " + ficha.Text.Substring(2);
            Utilities.OpenMPSForm(ficha);
                   
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ficha = geraNovoForm();
            //string id = dataGridView.CurrentRow.Cells["id"].Value.ToString();
            ficha.Id = dataGridView.CurrentRow.Cells["id"].Value.ToString();
            ficha.CurrentRow = dataGridView.CurrentRow;
            ficha.Operacao = "u";
            object currentRow = Utilities.GetRow(String.Format("select * from {0} where id={1}",Table,ficha.Id));
            
            //Setando o text do form de acordo com o Genero.
            String nome = ficha.Text.Substring(0, 1);
            if (nome == "a") ficha.Text = "Editando a " + ficha.Text.Substring(2);
            if (nome == "o") ficha.Text = "Editando o " + ficha.Text.Substring(2);
            Utilities.OpenMPSForm(ficha);            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
			if (dataGridView.CurrentRow != null) 
            {
                ficha = geraNovoForm();
			    ficha.Id = dataGridView.CurrentRow.Cells["id"].Value.ToString();
                ficha.Operacao = "d";
			    ficha.DeleteOperation();
            } else 
            {
				MessageBox.Show("Selecione um registro válido.","Erro", MessageBoxButtons.OK);
            }
        }
        #endregion

      	

		private void lblReload_Click(object sender, EventArgs e)
		{
		    GridView_Load(sender, e);
		}

		private void lblReload_MouseDown(object sender, MouseEventArgs e)
		{
						this.lblReload.Location = new Point(this.lblReload.Location.X +1,this.lblReload.Location.Y +1);
		}

		private void lblReload_MouseUp(object sender, MouseEventArgs e)
		{
						this.lblReload.Location = new Point(this.lblReload.Location.X - 1, this.lblReload.Location.Y - 1);
		}

		private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
		{					
						if (this.dataGridView.CurrentCell == null) MessageBox.Show("Selecione uma Coluna para efetuar a busca.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
						else {
						this.txtFiltro.Visible = true;
						this.lblFiltroColuna.Visible = true;
						this.txtFiltro.Text = e.KeyChar.ToString();
						this.txtFiltro.Select();
						this.txtFiltro.Select(1,0);					
						}		
		}


		private void txtFiltro_TextChanged(object sender, EventArgs e)
		{
			if (colunaIndex == 0) colunaIndex = this.dataGridView.CurrentCell.ColumnIndex;
			this.filtro = this.dataGridView.Columns[colunaIndex].Name + " like '%%'";
			this.lblFiltroColuna.Text = "Filtrando por " + this.dataGridView.Columns[colunaIndex].HeaderText;
			this.filtro = this.filtro.Remove(this.filtro.Length - 2, 2);
			this.filtro = this.filtro + this.txtFiltro.Text + "%'";
			this.Reload();
			if (this.txtFiltro.Text.Equals("")) {
			this.colunaIndex = 0; this.lblFiltroColuna.Visible = false; this.txtFiltro.Visible = false;
			}
		}

        
    }
}
