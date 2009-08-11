using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaseCore
{
    public partial class ComboBox : UserControl
    {
        public string DataSource { get; set; }
        public string ValueMember { get; set; }
        public string DisplayMember { get; set; }

        private SqlDataAdapter da;
        private DataTable dt;
        private SqlCommand cmd;
        private StringBuilder connStr;
        private SqlConnection conn;

        public ComboBox()
        {
            InitializeComponent();
        }

        private void montaStringConexao()
        {
            connStr = new StringBuilder();
            connStr.Append("Data Source=");
            connStr.Append(".");
            connStr.Append(";Initial Catalog=");
            connStr.Append("MPS");
            connStr.Append(";Integrated Security=");
            connStr.Append("True");
            connStr.Append("");

        }
        public object getSelectedValue() 
        {

            return this.combo.SelectedValue;
        }

        public void setValue(string value)
        {
            
            this.combo.SelectedValue = value;
           
        }
        private void ComboBox_Load(object sender, EventArgs e)
        {
        //    try
        //    {
			if (DataSource != null) {
            montaStringConexao();
            conn = new SqlConnection(connStr.ToString());
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from " + DataSource;
            conn.Open();                
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
           
          
            DataRow emptyRow = dt.NewRow();
            emptyRow[ValueMember] = DBNull.Value;
            emptyRow[DisplayMember] = "(selecione um item)";
            dt.Rows.InsertAt(emptyRow, 0);
            combo.DataSource = dt;            
        
            
            combo.DisplayMember = DisplayMember;
            combo.ValueMember = ValueMember;
            conn.Close();
            }
            //}
            //catch (Exception)
            //{
                
            //    throw;
            //}
           
        }
    }
}
