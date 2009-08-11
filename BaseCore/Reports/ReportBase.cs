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
    public partial class ReportBase : Form
    {
        [Description("Nome do Relatorio."),
           Category("Values"),
           DefaultValue(""),
           Browsable(true)]
        public string ReportName { get; set; }

        [Description("Datasource ; comando sql"),
          Category("Values"),
          DefaultValue(""),
          Browsable(true)]
        public string[] DataSources { get; set; }


        public ReportBase()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //pega o nome do projeto para criar um DataSet
            Assembly _assembly = this.GetType().Assembly;
            AssemblyBuilder.GetExecutingAssembly();
            AssemblyName projectName = _assembly.GetName();
            string ReportPath = global::BaseCore.Properties.Settings.Default.ReportPath + "\\" + ReportName + ".rdlc";
            //O nome do DataSet do Relatorio precisa ser o mesmo nome do Projeto
            Utilities.geraRelatorio(projectName.Name, DataSources, ReportPath);
          
           
            

        }
    }
}
