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
        public Catalogo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        }
    }
}
