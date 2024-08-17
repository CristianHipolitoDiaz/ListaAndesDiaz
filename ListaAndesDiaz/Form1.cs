using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAndesDiaz
{
    public partial class Form1 : Form
    {

        public class Tarea
        {
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public bool Completada { get; set; }

            // Constructor para inicializar los campos
            public Tarea(string descripcion, DateTime fecha, bool completada)
            {
                Descripcion = descripcion;
                Fecha = fecha;
                Completada = completada;
            }

            // Sobrescribimos ToString para que el ListBox muestre algo útil

          
            public override string ToString()
            {
                return $"{Descripcion} - {Fecha.ToString("dd/MM/yyyy")} - {(Completada ? "Completada" : "Pendiente")}";
            }
            
        }



        List<Tarea> listaTareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
            InicializarListView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InicializarListView()
        {
            // Configuración del ListView
            listView1.View = View.Details; // Mostrar columnas
            listView1.FullRowSelect = true; // Seleccionar toda la fila
            listView1.Columns.Add("Descripción", 150); // Columna de la tarea
            listView1.Columns.Add("Fecha", 100); // Columna de la fecha
            listView1.Columns.Add("Estado", 70); // Columna de estado (Completada/Pendiente)
            listView1.Columns.Add("Eliminar", 70); // Columna de eliminar

            // Manejar el evento de clic en el ListView
            listView1.MouseClick += listView1_MouseClick;
        }


        //Boton
        private void button1_Click(object sender, EventArgs e)
        {
            // Condición que valida que el campo no esté vacío y sea un string:
            if (!string.IsNullOrEmpty(Titulo.Text))
            {
                string titulo = Titulo.Text;
                bool status = statustarea.Checked;
                DateTime fecha = vencimiento.Value;

                // Objeto instanciado de la clase Tarea.
               Tarea nuevaTarea = new Tarea(titulo, fecha, status);

                // Agregar la tarea.
                listaTareas.Add(nuevaTarea);

                MessageBox.Show("Tarea Agregada");

                ActualizarListaTareas();
            }
            else
            {
                MessageBox.Show("Campos Incompletos");
            }            


        }

        private void ActualizarListaTareas()
        {
            // Limpiar el ListView antes de actualizar
            listView1.Items.Clear();

            // Agregar las tareas a la lista
            foreach (Tarea tarea in listaTareas)
            {
                ListViewItem item = new ListViewItem(tarea.Descripcion);
                item.SubItems.Add(tarea.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(tarea.Completada ? "Completada" : "Pendiente");
                item.SubItems.Add("Eliminar");

                listView1.Items.Add(item);
            }
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            var hitTest = listView1.HitTest(e.Location);
            var selectedItem = hitTest.Item;
            int columnIndex = hitTest.Item.SubItems.IndexOf(hitTest.SubItem);

            if (columnIndex == 2) // Columna de estado (Completada/Pendiente)
            {
                // Encontrar la tarea correspondiente
                int index = listView1.Items.IndexOf(selectedItem);
                Tarea tarea = listaTareas[index];

                // Cambiar el estado de la tarea
                tarea.Completada = !tarea.Completada;

                // Actualizar el ListView
                ActualizarListaTareas();
            }
            else if (columnIndex == 3) // Columna de "Eliminar"
            {
                // Eliminar la tarea seleccionada
                listaTareas.RemoveAt(listView1.Items.IndexOf(selectedItem));
                listView1.Items.Remove(selectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
    }
}
