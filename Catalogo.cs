using Datos;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaraokeDesktop
{
    public partial class Catalogo : UserControl
    {
        //Variables globales
        string[] archivos;//Variable para poder almacenar los nombres de los archivos de musica que han sido cargados
        int totalCanciones;//Variable para almacenar el valor total de las canciones, que se obtendra de la capa de Datos
        int IdCancion;//Variable para guardar el Id de la Cancion
        public Catalogo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarCancion();
        }
        private void BuscarCancion()
        {
            DataTable dt = new DataTable();
            DCanciones canciones = new DCanciones();
            canciones.BUSAR_CANCIONES(ref dt, txtBuscar.Text);
            dgvCanciones.DataSource = dt;
            OcultarColumnas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Realizamos un filtro, para buscar Musica, que sean de punto mp3, y .mp4
            openFileDialog.Filter = "Musica|*.mp3;*.mp4";
            //Ahora permitimos que sea de multiseleccion, con (Multiselect)
            openFileDialog.Multiselect = true;
            //Agregamos el titulo a la venta que se abrira
            openFileDialog.Title = "Cargar Canciones";
            //Validamos si despues de seleccionar el usuario dio click en el boton de OK, afirmando que son archivos listos a subir
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LCanciones parametros = new LCanciones();
                DCanciones funciones = new DCanciones();
                archivos = openFileDialog.SafeFileNames;
                foreach (string nombreCancion in archivos)
                {
                    parametros.NOMBRE = nombreCancion;
                    funciones.INSERTAR_CANCION(parametros);
                }
                MostrarCanciones();
            }
        }
        private void MostrarCanciones()
        {
            DCanciones dCanciones = new DCanciones();
            DataTable dt = new DataTable();
            dCanciones.MOSTRAR_CANCIONES(ref dt);
            dgvCanciones.DataSource = dt;
            OcultarColumnas();
            TotalCanciones();
        }
        private void OcultarColumnas()
        {
            dgvCanciones.Columns[1].Visible = false;
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            EliminarTodasCanciones();
        }
        private void EliminarTodasCanciones()
        {
            DCanciones canciones = new DCanciones();
            canciones.ELIMINAR_TODAS_CANCIONES();
            MostrarCanciones();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            MostrarCanciones();
        }
        private void TotalCanciones()
        {
            DCanciones canciones = new DCanciones();
            canciones.TOTAL_CANCIONES(ref totalCanciones);
            lblNumeroCanciones.Text = totalCanciones.ToString();
        }

        private void dgvCanciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validamos si los eventos, trae una seleccion del indice de la columna Eliminar, que fue creada en el diseno, si le dio click sobre esa columna
            //quiere decir que desea eliminar un registro del DataGridView
            if (e.ColumnIndex == dgvCanciones.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("Realmente desea Eliminar la Canción?","Eliminar Canción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    IdCancion = Convert.ToInt32(dgvCanciones.SelectedCells[1].Value);
                    EliminarCancion();
                }
            }
        }
        private void EliminarCancion()
        {
            LCanciones lCanciones = new LCanciones();
            DCanciones canciones = new DCanciones();
            lCanciones.IDCANCION = IdCancion;
            if (canciones.ELIMINAR_CANCION(lCanciones))
            {
                MostrarCanciones();
            }
        }
    }
}
