using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
namespace BaseCore
{

    public partial class NewForm : Form
    {
        #region propriedades
        [Description("Nome da Procedure."),
            Category("Values"),
            DefaultValue(""),
            Browsable(true)]
        public string Procedure { get; set; }
        [Description("Nome dos campos que podem ser nulos."),
                        Category("Values"),
                        DefaultValue(""),
                        Browsable(true)]
        public string Campos { get; set; }
        public string Operacao { get; set; }
        //isso resolve uma limitacao do mdiParent ao qual todos os forms de gridview estao associados
        public Form Pai { get; set; }
        public DataGridViewRow CurrentRow { get; set; }
        public string Id { get; set; }
        #endregion
       

        public NewForm()
        {
            InitializeComponent();
        }

        public void DeleteOperation()
        {
            DialogResult r = MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Aviso", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
				Dictionary<string, object> dic = new Dictionary<string, object>();
				dic.Add("id",Id);
				dic.Add("Operacao", "d");
				StoredProcedure proc = new StoredProcedure(Procedure);
				proc.addParameter(dic);
				proc.executeProcedure();
                base.Close();
                
                ReloadNoGrid();
            }
        }

        public StoredProcedure montaProcedure()
        {
			//vai conter nomeDoCampo e valor
			Dictionary<string, object> dic = new Dictionary<string, object>();
			//Objeto Procedure
			BaseCore.StoredProcedure proc = new BaseCore.StoredProcedure(Procedure);
            
            StringBuilder sbuilder = new StringBuilder("exec " + Procedure + " " + "@operacao=" + Operacao + ", ");
            //operacao de update
            if (Operacao == "u")
            {
                dic.Add("id",Id);
				dic.Add("operacao", Operacao);
			}
			//operacao de insert
			else
			{
				dic.Add("operacao", Operacao);
			}
				
            //string ParamNomeValor = "";
            foreach (Control ctrl in base.Controls)
            {				
				if (ctrl.GetType() == typeof(TextBox))
				{
					dic.Add(ctrl.Name,ctrl.Text);					
				}
				else if (ctrl.GetType() == typeof(ComboBox))
				{
					dic.Add(ctrl.Name, ctrl.Text);
				}
				else if (ctrl.GetType() == typeof(DateTimePicker))
				{
					dic.Add(ctrl.Name, (ctrl as DateTimePicker).Value);
				}
				else if (ctrl.GetType() == typeof(MaskedTextBox))
				{
					dic.Add(ctrl.Name, ctrl.Text);
				
				}
				

            }
            proc.addParameter(dic);         
		
            return proc;
        }

        public bool ValidarCampos()
        {
            bool resultado = true;
            foreach (Control ctrl in base.Controls)
            {
                if ((ctrl.GetType() == typeof(TextBox)) || (ctrl.GetType() == typeof(DateTimePicker)))
                {
                    if (ctrl.Text == null || ctrl.Text.Trim() == "") // Verificando se os valores informados não são nulos.
                    {
                        if (Campos != null)
                        {
                            if (!Campos.Contains(ctrl.Name)) resultado = false;
                            ctrl.BackColor = Color.Yellow;
                        }
                        else
                        {
                            resultado = false;
                            ctrl.BackColor = Color.Yellow;
                        }

                    }
                    else
                    {
                        ctrl.BackColor = Color.White;
                    }
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
					if ((ctrl as ComboBox).getSelectedValue().ToString().Equals("")) // Verificando se os valores informados não são nulos.
					{
					    if (Campos != null)
					    {
						    if (!Campos.Contains(ctrl.Name)) resultado = false;
						    ctrl.BackColor = Color.Yellow;
					    }
					    else
					    {
						    resultado = false;
						    ctrl.BackColor = Color.Yellow;
					    }

					}
					else
					{
									ctrl.BackColor = Color.White;
					}
                }
            }
            return resultado;
        }

        public void ReloadNoGrid()
        {

            foreach (Control ctrl in this.Pai.Controls)
            {
                if (ctrl.GetType() == typeof(GridView))
                {
                    (ctrl as GridView).Reload();
                }
            }

        }

        private void getCampos()
        {

			//conn.Open();
			//cmd.CommandText = "se";
        }

        private void insertUpdateOperation()
        {
		    bool erro = false;
            if (ValidarCampos())
            {
				StoredProcedure proc = montaProcedure();               
              	try
				{
					proc.executeProcedure();
				}
				catch (Exception e)
				{
					erro = true;
					if (e.Source == ".Net SqlClient Data Provider")
						MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
						MessageBox.Show("Erro no cadastro. Verifique os dados preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
                
               
                if (!erro)
                base.Close();
            }
            else
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos.", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public virtual void btnOk_Click(object sender, EventArgs e)
        {
            //operacao de insert
            if (Operacao == "i")
            {
                insertUpdateOperation();

            }
            //operacao de update
            else if (Operacao == "u")
            {
                insertUpdateOperation();
            }

            ReloadNoGrid();

        }

        public virtual void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void NovoForm_Load(object sender, EventArgs e)
        {
            if (Operacao == "u")
            {
                foreach (DataGridViewCell cel in this.CurrentRow.Cells)
                {
                    foreach (Control ctrl in base.Controls)
                    {
                        if (cel.OwningColumn.Name.ToLower() == ctrl.Name.ToLower() && ctrl.GetType() == typeof(TextBox))
                        {
                            (ctrl as TextBox).Text = cel.Value.ToString();
                        }
						else if (cel.OwningColumn.Name.ToLower() == ctrl.Name.ToLower() && ctrl.GetType() == typeof(ComboBox))
                        {
                            (ctrl as ComboBox).setValue(cel.Value.ToString());
                        }
						else if (cel.OwningColumn.Name.ToLower() == ctrl.Name.ToLower() && ctrl.GetType() == typeof(MaskedTextBox))
						{
							(ctrl as MaskedTextBox).Text= cel.Value.ToString();
						}

                    }
                }
            }

        }

    }
       
    }

