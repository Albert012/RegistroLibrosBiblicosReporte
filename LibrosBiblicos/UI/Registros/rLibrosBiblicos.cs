using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibrosBiblicos.Entidades;

namespace LibrosBiblicos.UI.Registros
{
    public partial class rLibrosBiblicos : Form
    {
        public rLibrosBiblicos()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            FechaDateTimePicker.ResetText();
            DescripcionTextBox.Clear();
            SiglasTextBox.Clear();
            TipoComboBox.Text = "";
            ValidarErrorProvider.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            int id = (int)LibroIdNumericUpDown.Value;
            LibrosBiblia libro = BLL.LibrosBiblicosBLL.Buscar(id);

            if (Validar())
            {
                MessageBox.Show("Favor Revisar El Llenado", "Error Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            libro = LlenaClase();

            if(libro != null)
            {
                paso = BLL.LibrosBiblicosBLL.Guardar(libro);
            }
            else
            {
                paso = BLL.LibrosBiblicosBLL.Modificar(libro);
            }

            if (paso)
            {
                MessageBox.Show("Guardado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NuevoButton.PerformClick();
            }
            else
                MessageBox.Show("No Se Pudo Guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)LibroIdNumericUpDown.Value;
            LibrosBiblia libro = BLL.LibrosBiblicosBLL.Buscar(id);

            if(libro != null)
            {
                BLL.LibrosBiblicosBLL.Eliminar(id);
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NuevoButton.PerformClick();
            }
            else
                MessageBox.Show("No Se Pudo Eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = (int)LibroIdNumericUpDown.Value;
            LibrosBiblia libro = BLL.LibrosBiblicosBLL.Buscar(id);

            if (libro != null)
            {
                FechaDateTimePicker.Value = libro.Fecha;
                DescripcionTextBox.Text = libro.Descripcion;
                SiglasTextBox.Text = libro.Siglas;
                TipoComboBox.Text = libro.Tipo;
            }
            else
                MessageBox.Show("No Se Pudo Encontrar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool Validar()
        {
            bool Validar = false;

            if(string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                ValidarErrorProvider.SetError(DescripcionTextBox, "Falta La Descripcion");
                Validar = true;
            }

            if(string.IsNullOrWhiteSpace(SiglasTextBox.Text))
            {
                ValidarErrorProvider.SetError(SiglasTextBox, "Falta La Siglas");
                Validar = true;
            }

            if(TipoComboBox.Text == "")
            {
                ValidarErrorProvider.SetError(TipoComboBox, "Seleccione El Tipo");
                Validar = true;
            }

            return Validar;
        }

        private LibrosBiblia LlenaClase()
        {
            LibrosBiblia libro = new LibrosBiblia();
            libro.LibroId = (int)LibroIdNumericUpDown.Value;
            libro.Fecha = FechaDateTimePicker.Value.Date;
            libro.Descripcion = DescripcionTextBox.Text;
            libro.Siglas = SiglasTextBox.Text;
            libro.Tipo = TipoComboBox.Text;
            return libro;
        }

    }
}
