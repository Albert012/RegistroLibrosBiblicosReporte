using LibrosBiblicos.UI.Consultas;
using LibrosBiblicos.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibrosBiblicos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void libroBiblicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLibrosBiblicos libro = new rLibrosBiblicos();
            libro.MdiParent = this.MdiParent;
            libro.Show();
        }

        private void libroBiblicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cLibroBiblicos cLibrosBiblicos = new cLibroBiblicos();
            cLibrosBiblicos.MdiParent = this.MdiParent;
            cLibrosBiblicos.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este Es Un Registro De Libro Biblicos Realizado Por: Albert De Jesus Rosario Mendoza", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
