using LibrosBiblicos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace LibrosBiblicos.UI.Consultas
{
    public partial class cLibroBiblicos : Form
    {
        public cLibroBiblicos()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<LibrosBiblia,bool>> filtro = l => true;
            int id;

            if(FiltroComboBox.SelectedIndex != 0 && string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                MessageBox.Show("Seleccione Un Filtro y Ingrese Un Criterio De Busqueda", "Fallo Consulta", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }


            switch(FiltroComboBox.SelectedIndex)
            {
                case 0://Todos
                    break;
                case 1://LibroId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = l => (l.LibroId.Equals(id)) && (l.Fecha >= DesdeDateTimePicker.Value.Date && l.Fecha <= HastaDateTimePicker.Value.Date);
                    break;
                case 2://Descripcion
                    filtro = l => (l.Descripcion.Contains(CriterioTextBox.Text)) && (l.Fecha >= DesdeDateTimePicker.Value.Date && l.Fecha <= HastaDateTimePicker.Value.Date);
                    break;
                case 3://Siglas
                    filtro = l => (l.Siglas.Contains(CriterioTextBox.Text)) && (l.Fecha >= DesdeDateTimePicker.Value.Date && l.Fecha <= HastaDateTimePicker.Value.Date);
                    break;
                case 4://Tipo
                    filtro = l => (l.Tipo.Contains(CriterioTextBox.Text)) && (l.Fecha >= DesdeDateTimePicker.Value.Date && l.Fecha <= HastaDateTimePicker.Value.Date);
                    break;
            }
            ConsultaDataGridView.DataSource = BLL.LibrosBiblicosBLL.GetList(filtro);


        }
    }
}
