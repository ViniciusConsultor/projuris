using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Reflection.Emit;

namespace BaseCore
{
    public partial class Login : Form
    {
        private SQLDMO.SQLServer srv;

		public Form Main { get; set; }
        public Login()
        {
            InitializeComponent();
        }

		protected virtual void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                srv = new SQLDMO.SQLServer();
                //tempo de conexao com o servidor
                srv.LoginTimeout = 20;
                if (chbSSIP.Checked)
                {
                   
                    srv.LoginSecure = true;
                    srv.Connect(".",null,null);            
                }
                else 
                {
                    srv.Connect(".",tbLogin.Text,tbSenha.Text);
                }
				this.ParentForm.Text = srv.TrueLogin + "@" + srv.TrueName;
				this.ParentForm.Tag = "true";
				
                this.Close();
               
              
            }
            catch (Exception)
            {
				this.ParentForm.Tag = "false";
             
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbSSIP_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSSIP.Checked)
            {
                tbLogin.Enabled = false;
                tbSenha.Enabled = false;
            }
            else 
            {
                tbLogin.Enabled = true;
                tbSenha.Enabled = true;
            }
        }

      
    }
}
