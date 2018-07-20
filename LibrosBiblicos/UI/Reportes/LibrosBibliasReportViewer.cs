using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibrosBiblicos.Entidades;

namespace LibrosBiblicos.UI.Reportes
{
    public partial class LibrosBibliasReportViewer : Form
    {
        //private List<LibrosBiblia> Libros = new List<LibrosBiblia>();
        public List<LibrosBiblia> Libros = null; //{ get; set; }

        public LibrosBibliasReportViewer(List<LibrosBiblia> Datos )
        {
            InitializeComponent();
            this.Libros = Datos;
        }

        private void LibrosBibliasReportViewer_Load(object sender, EventArgs e)
        {
            

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportLibrosBiblicos ListadoLibros = new ReportLibrosBiblicos();
            ListadoLibros.SetDataSource(Libros);

            LibrosBiblicosReportViewer.ReportSource = ListadoLibros;
            LibrosBiblicosReportViewer.Refresh();
        }
    }
}
