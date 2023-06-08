using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.IO;
using SistemaProva.Suporte;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.CodeDom.Compiler;
using System.Collections;
using System.Xml.Linq;

namespace SistemaProva
{
    public partial class VisualizadorRelatorio : Form
    {
        public VisualizadorRelatorio()
        {
            InitializeComponent();
        }

        private void VisualizadorRelatorio_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        

        public void GerarRelatorioCidades()
        {
            using (var connection = new SqlConnection("Server=(local)\\SQLEXPRESS;Database=BancoProva;Trusted_Connection=True;"))
            {
                var listaEstoque = connection.Query<EstoqueGris>("SELECT ID, Nome, Sigla FROM Estoque").ToList();

                reportViewer1.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "EstoqueListaReport.rdlc");
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource(
                    "DataSet1", 
                    listaEstoque)
                    );
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.RefreshReport();
            }
        }

        //public void GerarRelatorioCidades()
        //{
        //    //using (var connection = new SqlConnection("Server=(local)\\SQLEXPRESS;Database=BancoProva;Trusted_Connection=True;"))
        //    //{
        //    //    connection.Open();
        //    //    var estoqueDataTable = connection.Query("SELECT * FROM Estoque").ToList();
        //    //    List<EstoqueGris> listaEstoque = new List<EstoqueGris>();
        //    //    foreach (var row in estoqueDataTable)
        //    //    {
        //    //        listaEstoque.Add(new EstoqueGris
        //    //        {
        //    //            ID = Convert.ToInt32(row.ID),
        //    //            Nome = row.Nome,
        //    //            Sigla = row.Sigla
        //    //        });
        //    //    }

        //    //    reportViewer1.LocalReport.ReportPath = Application.StartupPath + "/EstoqueListaReport.rdlc";
        //    //    reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource
        //    //    {
        //    //        Name = "DataSet1",
        //    //        Value = listaEstoque
        //    //    });
        //    //    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        //    //    reportViewer1.ZoomMode = ZoomMode.PageWidth;
        //    //    reportViewer1.RefreshReport();
        //    //}
        //}

        //public void GerarRelatorioCidades()
        //{
        //    using (var connection = new SqlConnection("Server=(local)\\SQLEXPRESS;Database=BancoProva;Trusted_Connection=True;"))
        //    {
        //        var estoque = connection.Query<EstoqueGris>("SELECT * FROM Estoque");

        //        reportViewer1.LocalReport.ReportPath = Application.StartupPath + "/EstoqueListaReport.rdlc";
        //        reportViewer1.LocalReport.DataSources.Add(
        //            new Microsoft.Reporting.WinForms.ReportDataSource
        //            {
        //                Name = "DataSet1",
        //                Value = estoque
        //            });
        //        reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        //        reportViewer1.ZoomMode = ZoomMode.PageWidth;
        //        reportViewer1.RefreshReport();
        //    }
        //}

        //public void GerarRelatorioCidades()
        //{
        //    var estoqueDataTable = new EstoqueDAO().ListarTodas();
        //    List<EstoqueGris> listaEstoque = new List<EstoqueGris>();
        //    for (int i = 0; i < estoqueDataTable.Count(); i++)
        //    {
        //        listaEstoque.Add(new EstoqueGris
        //        {
        //            ID = Convert.ToInt32(estoqueDataTable.Rows[i]["ID"].ToString()),
        //            Nome = estoqueDataTable.Rows[i]["Nome"].ToString(),
        //            Sigla = estoqueDataTable.Rows[i]["Sigla"].ToString()
        //            //ID = Convert.ToInt32(estoqueDataTable.Count() ),
        //            ////ID = Convert.ToInt32(estoqueDataTable..ToString()),
        //            //Nome = estoqueDataTable.Count().ToString(),
        //            ////Nome = estoqueDataTable.,
        //            //Sigla = estoqueDataTable.Count().ToString()
        //            //Sigla = estoqueDataTable.Sigla
        //        });
        //    }
        //    reportViewer1.LocalReport.ReportPath = Application.StartupPath + "/EstoqueListaReport.rdlc";
        //    reportViewer1.LocalReport.DataSources.Add(
        //    new Microsoft.Reporting.WinForms.ReportDataSource
        //    {
        //        Name = "DataSet1",
        //        Value = listaEstoque
        //    });
        //    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        //    reportViewer1.ZoomMode = ZoomMode.PageWidth;
        //    reportViewer1.RefreshReport();
        //}
        //}
        //}

    }

}
