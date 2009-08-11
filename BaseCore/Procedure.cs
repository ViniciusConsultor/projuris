using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseCore
{
	class Procedure
	{
		private string nomeProcedure;
		private List<string> parametros;

		private SqlConnection conn; 
		private SqlCommand cmd;
		
		public Procedure(string nomeProcedure)
		{
			this.nomeProcedure = nomeProcedure;
		}
		public void addParameter(string parametro)
		{
			this.parametros.Add(parametro);
		}
		public void addParameter(List<string> parametros)
		{
			this.parametros.Concat<string>(parametros);
		}
		public void executeProcedure()
		{
			StringBuilder sbuilder = new StringBuilder("exec " + nomeProcedure + " " );
			conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
			cmd = new SqlCommand();
			
			cmd.CommandText = "exec sp_help "+nomeProcedure;
			IAsyncResult resultado = null;
			SqlDataReader sqlReader =  cmd.EndExecuteReader(resultado);
		
				
			
			
			foreach (string param in parametros)
			{
				
			}
			
				//sbuilder.Append("@id=" + Id + ", ");
			
			//remove a ultima virgula
			sbuilder.Remove(sbuilder.Length - 2, 2);

			//return sbuilder.ToString();
		
		}
	}
}
