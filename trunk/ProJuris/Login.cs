using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseCore;

namespace ProJuris
{
	public partial class Login : BaseCore.Login
	{
		public Login()
		{
			InitializeComponent();
		
		}
		protected override void btnOK_Click(object sender, EventArgs e)
		{
			base.btnOK_Click(sender, e);
			Principal principal = (Application.OpenForms["Principal"] as Principal);
			object enable = principal.Tag;
			//por algum motivo que eu nao sei ele nao conseguiu fazer o casting corretamente
			//TODO: verficar isso mais tarde
			bool resposta = false;
			if (enable.ToString() == "true")
				resposta = true;
			else
				resposta = false;
			principal.menuStrip.Enabled = resposta;

				
			//(this.ParentForm as Principal).enableMenu();	
		}
	}
}
