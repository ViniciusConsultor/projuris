using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseCore
{
	public class StoredProcedure
	{
		private string nomeProcedure;
		private Dictionary<string,object> parametros;

		private SqlConnection conn; 
		private SqlCommand cmd;
		
		public StoredProcedure(string nomeProcedure)
		{
			this.nomeProcedure = nomeProcedure;
		}
		public void addParameter(KeyValuePair<string,object> parametro)
		{
			this.parametros.Add(parametro.Key,parametro.Value);
		}
		public void addParameter(Dictionary<string, object> dic)
		{
			this.parametros = dic;
		}
		//TODO: colocar pra concatenar duas dictionaries
		public void executeProcedure()
		{
			//StringBuilder sbuilder = new StringBuilder("exec " + nomeProcedure + " " );
			conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
			cmd = new SqlCommand();
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			//cmd.CommandText = "exec sp_help "+nomeProcedure;
			cmd.CommandText = nomeProcedure;
			cmd.Connection = conn;
			conn.Open();
			SqlCommandBuilder.DeriveParameters(cmd); 
			
			// Populate the Input Parameters With Values Provided        
			foreach (SqlParameter parameter in cmd.Parameters)
			{
				if (parameter.Direction == System.Data.ParameterDirection.Input ||
					 parameter.Direction == System.Data.ParameterDirection.InputOutput)
				{
					//remove @ do nome do parametro
					parameter.ParameterName = parameter.ParameterName.Replace("@","");
					foreach (KeyValuePair<string,object> item in parametros)
					{
					//isso resolve o problema do case sensitive do sql server
						if (item.Key.ToLower() == parameter.ParameterName.ToLower())
							parameter.Value = item.Value;						
					}				//parameter.Value = null;
		
				}
			}
				
			cmd.ExecuteNonQuery();
			if (conn != null)
			{
				conn.Close();
				cmd.Dispose();
			}
		}
	}
}
