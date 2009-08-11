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

		private SqlConnection conn = new SqlConnection("Server=.;DataBase=ProJuris;Integrated Security=SSPI");
        private SqlCommand cmd = new SqlCommand();

        public NewForm()
        {
            InitializeComponent();
        }

        public void DeleteOperation()
        {
            DialogResult r = MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Aviso", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                conn.Open();
                cmd.CommandText = "exec " + Procedure + " " + "@operacao=" + Operacao + " ,@id =" + this.Id.ToString();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                if (conn != null)
                {
                    conn.Close();
                }
                base.Close();
                ReloadNoGrid();
            }
        }

        public string montaStringProcedure()
        {
            StringBuilder sbuilder = new StringBuilder("exec " + Procedure + " " + "@operacao=" + Operacao + ", ");
            if (Operacao == "u")
                sbuilder.Append("@id=" + Id + ", ");

            string ParamNomeValor = "";
            foreach (Control ctrl in base.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ParamNomeValor = "@" + ctrl.Name + "='" + ctrl.Text;
                    sbuilder.Append(ParamNomeValor + "', ");
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ParamNomeValor = "@" + (ctrl as ComboBox).Name + "='" + (ctrl as ComboBox).getSelectedValue().ToString();
                    sbuilder.Append(ParamNomeValor + "', ");
                }
                else if (ctrl.GetType() == typeof(DateTimePicker))
                {
                    ParamNomeValor = "@" + (ctrl as DateTimePicker).Name + "='" + (ctrl as DateTimePicker).Value;
                    sbuilder.Append(ParamNomeValor + "', ");
                }
                else if (ctrl.GetType() == typeof(MaskedTextBox))
                {
					ParamNomeValor = "@" + ctrl.Name + "='" + ctrl.Text;
					sbuilder.Append(ParamNomeValor + "', ");
                }

            }
            //remove a ultima virgula
            sbuilder.Remove(sbuilder.Length - 2, 2);

            return sbuilder.ToString();
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

            conn.Open();
            cmd.CommandText = "se";
        }

        private void insertUpdateOperation()
        {
		    bool erro = false;
            if (ValidarCampos())
            {
                conn.Open();
                cmd.CommandText = montaStringProcedure();
                cmd.Connection = conn;
				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					erro = true;
					if (e.Source == ".Net SqlClient Data Provider")
						MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
						MessageBox.Show("Erro no cadastro. Verifique os dados preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
                
                if (conn != null)
                {
                    conn.Close();
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
                        if (cel.OwningColumn.Name == ctrl.Name && ctrl.GetType() == typeof(TextBox))
                        {
                            (ctrl as TextBox).Text = cel.Value.ToString();
                        }
                        else if (cel.OwningColumn.Name == ctrl.Name && ctrl.GetType() == typeof(ComboBox))
                        {
                            (ctrl as ComboBox).setValue(cel.Value.ToString());
                        }

                    }
                }
            }

        }

    }
       
    }

