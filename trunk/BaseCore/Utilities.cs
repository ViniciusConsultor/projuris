using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Reporting.WinForms;


namespace BaseCore
{
    abstract class Utilities
    {
        private static StringBuilder connStr;
        private static SqlConnection conn;
        private static SqlDataAdapter adapter;
        private static SqlCommand cmd;
        private static SqlCommandBuilder builder;
        private static BindingSource bindsource;
        private static DataTable dt;

        private static void montaStringConexao()
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
        //retorno de um Scalar
        public static T ExecuteScalarQuery<T>(string sqline)
        {
            montaStringConexao();
            conn = new SqlConnection(connStr.ToString());
            cmd = new SqlCommand(sqline, conn);
            conn.Open();
            cmd.CommandText = sqline;
            cmd.Connection = conn;
            object retorno = cmd.ExecuteScalar();
            conn.Close();

            return (T)retorno;
        }
        //retorno de uma linha do banco
        public static object GetRow(string sqline)
        {
            montaStringConexao();
            conn = new SqlConnection(connStr.ToString());
            cmd = new SqlCommand(sqline, conn);
            conn.Open();
            cmd.CommandText = sqline;
            cmd.Connection = conn;
            SqlDataReader retorno = cmd.ExecuteReader();
           
            conn.Close();

            return retorno;
        }

       //Namespace References


        /// <summary>
        /// Retorna um DataTable de acordo com o comando sql
        public static DataTable GetDataTable(string sqline)
        {
            try
            {
                montaStringConexao();
                SqlConnection conn = new SqlConnection(connStr.ToString());
                SqlCommand cmd = new SqlCommand(sqline, conn);
                // create a new data adapter based on the specified query.
                SqlDataAdapter da = new SqlDataAdapter();
                //set the SelectCommand of the adapter
                da.SelectCommand = cmd;
                // create a new DataTable
                DataTable dtGet = new DataTable();
                //fill the DataTable
                da.Fill(dtGet);
                //return the DataTable
                return dtGet;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void OpenMPSForm(Form form)        
        {

            bool estaAberto = false;
            foreach (Form f in Application.OpenForms)
            {
                //se o form (T) de fato estiver aberto na aplicacao 
                if ((f.Name == form.Name))
                {
                    estaAberto = true;
                }
            }
            //so vai instanciar se ainda nao tiver sido :D So generics mesmo :D
            if (!estaAberto)
            {
                form.Show();

            }        
        }

        public static void geraRelatorio(string nomeProjeto,string[] sqlines, string reportPath)
        {
            ReportViewer rptViewer = new ReportViewer();

            foreach (string sqline in sqlines)
            {
                string[] composicaoSqline = sqline.Split(';');
                DataTable dt = Utilities.GetDataTable(composicaoSqline[1]);
                StreamReader str = new StreamReader(reportPath);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Rdl.Report));
                Rdl.Report rpt = (Rdl.Report)serializer.Deserialize(str.BaseStream);
                MemoryStream ms = new MemoryStream();
                XmlSerializer serial = new XmlSerializer(typeof(Rdl.Report));
                serial.Serialize(ms, rpt);
                ms.Position = 0;
                rptViewer.compRptViewer.LocalReport.LoadReportDefinition(ms);
                rptViewer.compRptViewer.LocalReport.DataSources.Add(new ReportDataSource(nomeProjeto+"_"+composicaoSqline[0],dt));    
            }            
			//rptViewer.MdiParent = Main.ActiveForm;
            rptViewer.StartPosition = FormStartPosition.CenterScreen;
            rptViewer.Show();      
        }
    }
   
    //pro cara nao ficar abrindo e ele instanciando toda vez
    // TODO: verificar a existencia dessa classe e tentar substituir ela por OpenMPSForm, atualmente essa classe so e usada pelo Principal
    public class FormMPS<T> where T : Form, new() 
   {	   	
       public void show()
       {
           Boolean estaAberto=false;         
           T openForm = new T();          
           foreach (Form f in Application.OpenForms)
			{ 
			//se o form (T) de fato estiver aberto na aplicacao 
    			 if ((f.Name == openForm.Name))
				 {
					 estaAberto = true;                           
				 }
			}
            //so vai instanciar se ainda nao tiver sido :D So generics mesmo :D
            if (!estaAberto)
            {
				Form Principal = Application.OpenForms["Principal"];
				openForm.MdiParent = Principal;
                openForm.StartPosition = FormStartPosition.CenterScreen;
                openForm.Show();      

            }
        }
    }


}
