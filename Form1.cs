using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DataTable_Filtrada
{
    public partial class Form1 : Form
    {
        int filaIndice = 0;
        static DataTable tabla = new DataTable("Estudiantes");
        DataView tablaFiltrada = new DataView(tabla);
        int cantidadAlumnos = 0;
        int promedioGeneral = 0;

        public Form1()
        {
            InitializeComponent();
            IniciarTabla();

            tabla.Rows.Add(null, "Oscar", "Programación II", "1", 60);
            tabla.Rows.Add(null, "Pedro", "Programación II", "1", 55);
            tabla.Rows.Add(null, "Matias", "Programación II", "2", 53);

            cantidadAlumnos = tabla.Rows.Count;
            alumnosCuentaLabel.Text = cantidadAlumnos.ToString();

            promedioGeneral = CalcularPromedioGeneral();
            promedioGeneralLabel.Text = promedioGeneral.ToString();

            tablaForm.DataSource = tablaFiltrada;
        }

        static void IniciarTabla()
        {
            DataColumn columna = new DataColumn("ID", typeof(int));
            columna.Unique = true;
            columna.AutoIncrement = true;
            tabla.Columns.Add(columna);

            columna = new DataColumn("Nombre", typeof(string));
            tabla.Columns.Add(columna);

            columna = new DataColumn("Asignatura", typeof(string));
            tabla.Columns.Add(columna);

            columna = new DataColumn("Semestre", typeof(string));
            tabla.Columns.Add(columna);

            columna = new DataColumn("Promedio", typeof(int));
            tabla.Columns.Add(columna);
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (DatosValidos() && !FilaDuplicada())
            {
                tabla.Rows.Add(null, nombreInput.Text, asignaturaInput.Text, semestreInput.Text, promedioInput.Value);
                tablaFiltrada.RowFilter = "";

                cantidadAlumnos++;
                alumnosCuentaLabel.Text = cantidadAlumnos.ToString();

                promedioGeneral = CalcularPromedioGeneral();
                promedioGeneralLabel.Text = promedioGeneral.ToString();
            }
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            // Lógica cortesía de chatgpt (entiendo el código)
            List<string> filtros = new List<string>();

            if (nombreFiltro.Text != "")
            {
                filtros.Add($"Nombre = '{nombreFiltro.Text}'");
                nombreFiltroLabel.Text = nombreFiltro.Text;
            }
            if (asignaturaFiltro.Text != "")
            {
                filtros.Add($"Asignatura = '{asignaturaFiltro.Text}'");
                asignaturaFiltroLabel.Text = asignaturaFiltro.Text;

            }
            if (semestreFiltro.Text != "")
            {
                filtros.Add($"Semestre = '{semestreFiltro.Text}'");
                semestreFiltroLabel.Text = semestreFiltro.Text;
            }
            if (mayorSeleccion.Checked || menorSeleccion.Checked || igualSeleccion.Checked)
            {
                if (mayorSeleccion.Checked)
                {
                    filtros.Add($"Promedio > {promedioFiltro.Value}");
                }
                else if(menorSeleccion.Checked)
                {
                    filtros.Add($"Promedio < {promedioFiltro.Value}");
                }
                else
                {
                    filtros.Add($"Promedio = {promedioFiltro.Value}");
                }
            }

            tablaFiltrada.RowFilter = string.Join(" AND ", filtros);

        }

        bool DatosValidos()
        {
            if (nombreInput.TextLength > 2 &&
                asignaturaInput.Text != "" &&
                semestreInput.Text != ""
                ) return true;

            else return false;
        }

        bool FilaDuplicada()
        {
            foreach (DataRow fila in tabla.Rows)
            {
                if (
                    fila["Nombre"].ToString() == nombreInput.Text &&
                    fila["Asignatura"].ToString() == asignaturaInput.Text &&
                    fila["Semestre"].ToString() == semestreInput.Text &&
                    fila["Promedio"].ToString() == promedioInput.Value.ToString()
                    )
                {
                    return true;
                }
            }
            return false;
        }

        int CalcularPromedioGeneral()
        {
            int total = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                total += (int)fila["Promedio"];
            }
            return total / cantidadAlumnos;
        }

        private void eliminarFiltro_Click(object sender, EventArgs e)
        {
            tablaFiltrada.RowFilter = "";

            nombreFiltroLabel.Text = "-";
            asignaturaFiltroLabel.Text = "-";
            semestreFiltroLabel.Text = "-";
            mayorSeleccion.Checked = false;
            menorSeleccion.Checked = false;
            igualSeleccion.Checked = false;
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                tabla.Rows.RemoveAt(filaIndice);

                cantidadAlumnos--;
                alumnosCuentaLabel.Text = cantidadAlumnos.ToString();

                promedioGeneral = CalcularPromedioGeneral();
                promedioGeneralLabel.Text = promedioGeneral.ToString();
            }
            catch { MessageBox.Show("Seleccione una casilla"); };
        }

        private void tablaForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaIndice = e.RowIndex;
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                DataRow filaSeleccionada = tabla.Rows[filaIndice];
                filaSeleccionada["Nombre"] = nombreInput.Text;
                filaSeleccionada["Asignatura"] = asignaturaInput.Text;
                filaSeleccionada["Semestre"] = semestreInput.Text;
                filaSeleccionada["Promedio"] = promedioInput.Value;
            }
        }
    }
}
