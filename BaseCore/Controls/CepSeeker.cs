using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;


namespace BaseCore
{
	public partial class CepSeeker
	{
		private string cep;
		//private CEPService CEP_WS;
		
		#region propriedades
		public string CEP { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Endereco { get; set; }
		public string UF { get; set; }
		#endregion
		
		public CepSeeker(string cep)
		{
			CEP = cep;
			if (IsConnected())
			{
				try
				{
					DataTable dt = null;
					CepWebService.wscep myCep = new CepWebService.wscep();
					dt = myCep.cep(CEP).Tables[0];
					if (dt.Rows.Count == 0)
					{
						//MessageBox.Show("Cep não existente", "Aviso");

					}
					else
					{
						DataRow dr = dt.Rows[0];
						Cidade = dr["cidade"].ToString();
						Bairro = dr["bairro"].ToString();
						Endereco = dr["logradouro"].ToString() + " " + dr["nome"].ToString(); ;
						UF = dr["uf"].ToString();
					}
				}
				catch (Exception)
				{
					//MessageBox.Show("Não foi possível conectar ao WebService de CEP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					//return null;
				}
			}
			else
			{
				//tratar excecao
			}		
		}	
		
		/// <summary>
		/// Verifica se há conexão com a internet
		/// </summary>
		/// <returns></returns>
		internal static bool IsConnected()
		{
		  HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.bronzebusiness.com.br/webservices/wscep.asmx");

		  // Perform GET
		  try
		  {
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			if (response.StatusCode == HttpStatusCode.OK)
			{
			  request.Abort();
			  response.Close();
			  return true;
			}

			return false;
		  }
		  catch (Exception)
		  {
			return false;
		  }

		
	
	}
}

}
