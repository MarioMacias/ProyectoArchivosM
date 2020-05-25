using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class FormEntidad : Form
    {
        private FuncionEntidad fa; //Variable para las funciones de un archivo, crear, guardar...
        private Entidad entidad; //Variable para las entidades.
        private List<Entidad> entidades; //Lista para poder guardar todas las entidades que se vayan creando.
        private long cab; //Variable para la cabezera de las entidades;

        public FormEntidad()
        {
            InitializeComponent();
            fa = new FuncionEntidad(); // variable para las funciones de un archivo.
            entidades = new List<Entidad>(); // Lista para guardar todas las entidades.

            cab = -1; //Asignacion para la primera cabezera.

            //iniciar con los botones en enable.
            botonVisible(false);
        }

        /*Creamos un nuevo archivo, para las entidades de fomra binaria*/
        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fa.crearArchivo())
            {
                lbl_Cabecera.Text = fa.asignarCabecera(cab);  // forma visual de mostrar la cabezera.

                //Mostrar los botones.
                botonVisible(true);
            }   // verifica si se pudo crear el archivo.
        }

        /*Creación de una nueva entidad*/
        private void btn_CrearEntidad_Click(object sender, EventArgs e)
        {
            if (nombreRepetido(tb_entidad.Text))
            {
                MessageBox.Show("El nombre esta repetido, no se agregara.");
                return;
            }

            if (tb_entidad != null || tb_entidad.Text != "")
            {
                entidad = new Entidad(tb_entidad.Text); //Nueva entidad, con el nombre del tb.
                entidades.Add(entidad); //se agrega la entidad creada a la lista
                //List<Entidad> auxListEntidad;
                entidades = fa.asigrarDatos(entidades); //Le paso la lista de entidades para poder asignar la direccion de la entidad.
                if (entidades != null) // si se pudo hacer todos los pasos para guardar la nueva entidad y no fue null
                {
                    //entidades = auxListEntidad;
                    lbl_Cabecera.Text = fa.sCabe;
                    datosDataG(); //Poner los datos en el data
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                MessageBox.Show("¿Tiene nombre la identidad?");
            }
            tb_entidad.Text = "";
        }

        /*Ponemos las identidades en el data grid view*/
        public void datosDataG()
        {
            dgv_Entidad.Rows.Clear();
            foreach(Entidad en in entidades){
                //string identid = BitConverter.ToString(en.Id_Entidad);
                //dgv_Entidad.Rows.Add(identid, en.string_Nombre, en.direccion_Entidad, en.direccion_Atributo, en.direccion_Dato, en.direccion_Siguiente);
                dgv_Entidad.Rows.Add(en.string_Nombre, en.direccion_Entidad, en.direccion_Atributo, en.direccion_Dato, en.direccion_Siguiente);
            }
        }

        /*Cambiar la visibilidad de los botones de crear, borrar, modificar, tb entidad*/
        private void botonVisible(bool visible)
        {
            btn_CrearEntidad.Enabled = visible;
            btn_Borrar.Enabled = visible;
            btn_Modificar.Enabled = visible;
            tb_entidad.Enabled = visible;
            btn_Atributo.Enabled = visible;
            lb_atributo.Visible = visible;
            tb_modificar.Visible = visible;
            tb_modificar.Text = "";
        }

        /*Si se quiere agregar atributos a cierta entidad*/
        private void btn_Atributo_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int posicion = dgv_Entidad.CurrentRow.Index; //saber la pos de la fila que se selecciono

                this.Hide();
                FormAtributo fAtributo = new FormAtributo(this, entidades, fa.nombreArchivo, posicion);
                fAtributo.cambia += new FormAtributo.pasar(regresa);
                fAtributo.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad para ver sus atributos.");
            }
        }

        /*Evento para poder pasar de un form a otro*/
        private void regresa(FormEntidad fed, List<Entidad> enti)
        {
            entidades = enti;
            fed.Show();
            datosDataG();
        }

        private void FormEntidad_Load(object sender, EventArgs e)
        {

        }

        /*Boton para modificar el archivo*/
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (nombreRepetido(tb_modificar.Text))
            {
                MessageBox.Show("El nombre esta repetido, no se modificara.");
                return;
            }

            if (tb_modificar != null || tb_modificar.Text != "")
            {
                int pos = dgv_Entidad.CurrentRow.Index;

                if(fa.modificaElemento(tb_modificar.Text, pos, entidades))
                {
                    lbl_Cabecera.Text = fa.sCabe;
                    tb_modificar.Text = "";
                    datosDataG();
                }
            }
        }

        private bool nombreRepetido(string nombreModificar)
        {
            foreach (Entidad enti in entidades)
            {
                if (enti.string_Nombre.CompareTo(nombreModificar) == 0) //Es el mismo
                {
                    return true;
                }
            }
            return false;
        }

        /*Boton para borrar una parte*/
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            int pos = dgv_Entidad.CurrentRow.Index;

            if (entidades[pos].direccion_Dato != -1)
            {
                MessageBox.Show("Existen datos guardados, no se puede eliminar.");
                return;
            }
            string res = fa.eliminarEntidad(pos, entidades);

            if (res != null)
            {
                lbl_Cabecera.Text = res;
            }
            else
            {
                datosDataG();
            }
        }

        /*Abrir un archivo*/
        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entidades = new List<Entidad>();
            string c = fa.abrirArchivo(entidades);
            if (c != "")
            {
                lbl_Cabecera.Text = c;
                datosDataG();
                botonVisible(true);
            }
            else
            {
                MessageBox.Show("No se pudo abrir");
            }
        }

        /*Cerrar un archivo*/
        private void cerrarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fa.cerrarArchivo())
            {
                dgv_Entidad.Rows.Clear();
                tb_entidad.Text = "";
                tb_modificar.Text = "";
                lbl_Cabecera.Text = "";
                lb_atributo.Text = "";
                MessageBox.Show("cerrado homs");
            }
        }

        /*Evento del data, para mostras valores en los tb, modificaciones, etc*/
        private void dgv_Entidad_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int pos = dgv_Entidad.CurrentRow.Index;
                tb_modificar.Text = entidades.ElementAt(pos).string_Nombre;
                lb_atributo.Text = "Atributos de la entidad: " + entidades.ElementAt(pos).string_Nombre;
                //btn_Atributo.Text = "Tabla de atributos de:  " + entidades.ElementAt(pos).string_Nombre;
            }
            catch
            {

            }
        }

        private long buscarEntidadForanea(int pos)
        {
            int i = 0;

            foreach (Atributo atri in entidades[pos].atributos)
            {
                if (atri.tipo_Indice == 8)
                {
                    return atri.direccion_Indice;
                }
                i++;
            }
            return -1;
        }

        /*Actualiza la lista de entidades y vuelve a mostrar los datos actualizados en el dataG*/
        private void direccionIndice(FormEntidad formEntidad, List<Entidad> entidades)
        {
            this.entidades = entidades;
            formEntidad.Show();
            datosDataG();
        }

        /*Evento para ingresar al form de Indices primarios*/
        private void primarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int pos = dgv_Entidad.CurrentRow.Index;

                this.Hide();
                MessageBox.Show("en form entidad: " + entidades[pos].primarios.Count);
                FormIndicePrimario ip = new FormIndicePrimario(this, entidades, pos);
                ip.cambiar += new FormIndicePrimario.cambio(regresa);
                ip.Show();
            }
            else { MessageBox.Show("Seleccione una entidad."); }
        }

        /*Evento para ingresar al form de Indices secundarios*/
        private void secundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int pos = dgv_Entidad.CurrentRow.Index;

                this.Hide();
                FormIndiceSecundario iS = new FormIndiceSecundario(this, entidades, pos);
                iS.cambiar += new FormIndiceSecundario.cambio(regresa);
                iS.Show();
            }
            else { MessageBox.Show("Seleccione una entidad."); }
        }

        private void indicePrimarioBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int pos = dgv_Entidad.CurrentRow.Index;

                this.Hide();
                FormArbolPrimario nuevoArbol = new FormArbolPrimario(this, entidades, pos);
                nuevoArbol.cambiar += new FormArbolPrimario.cambio(direccionIndice);
                nuevoArbol.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad");
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaEntidad cEntidad = new ConsultaEntidad(this, entidades, fa.nombreArchivo);
            cEntidad.cambia += new ConsultaEntidad.pasar(regresa);
            cEntidad.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int pos = dgv_Entidad.CurrentRow.Index;
                int posHash = posicionHash(pos);
                if (posHash == -1)
                {
                    MessageBox.Show("Entidad seleccionada sin indice hash");
                }

                this.Hide();
                FormIndiceHash indiceHash = new FormIndiceHash(this, entidades, pos, posHash);
                indiceHash.cambiar += new FormIndiceHash.cambio(direccionIndice);
                indiceHash.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad");
            }
        }

        private int posicionHash(int pos)
        {
            int i = 0;
            foreach (Atributo at in entidades[pos].atributos)
            {
                if (at.tipo_Indice == 6)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int posicion = dgv_Entidad.CurrentRow.Index; //saber la pos de la fila que se selecciono
                long posForanea = buscarEntidadForanea(posicion);

                if (posForanea != -1)
                {
                    int i = 0;
                    foreach (Entidad en in entidades)
                    {
                        if (posForanea == en.direccion_Entidad)
                        {
                            break;
                        }
                        i++;
                    }

                    this.Hide();
                    ConsultaRegistros cRegistros = new ConsultaRegistros(this, entidades, posicion, i);
                    cRegistros.cambia += new ConsultaRegistros.pasar(regresa);
                    cRegistros.Show();
                }
                else
                {
                    this.Hide();
                    ConsultaRegistros cRegistros = new ConsultaRegistros(this, entidades, posicion);
                    cRegistros.cambia += new ConsultaRegistros.pasar(regresa);
                    cRegistros.Show();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una entidad para ver sus atributos.");
            }
        }

        private void secuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int posicion = dgv_Entidad.CurrentRow.Index; //saber la pos de la fila que se selecciono

                this.Hide();
                FormAtributo fAtributo = new FormAtributo(this, entidades, fa.nombreArchivo, posicion);
                fAtributo.cambia += new FormAtributo.pasar(regresa);
                fAtributo.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad para ver sus atributos.");
            }
        }

        private void secuencialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int pos = dgv_Entidad.CurrentRow.Index;

                long posForanea = buscarEntidadForanea(pos);

                if (posForanea != -1)
                {
                    foreach (Entidad en in entidades)
                    {
                        if (posForanea == en.direccion_Entidad)
                        {
                            if (en.direccion_Dato == -1)
                            {
                                MessageBox.Show("Contiene clave foranea, sin datos en la enidad", "Primero agrega registros");
                                return;
                            }
                        }
                    }
                }

                this.Hide();
                FormRegistro nuevoRegistro = new FormRegistro(this, fa.fileS, fa.nombreDelArchivo, entidades, pos, 1);
                nuevoRegistro.cambia += new FormRegistro.regresar(direccionIndice);
                nuevoRegistro.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad");
            }
        }

        private void secuencialIndexadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int pos = dgv_Entidad.CurrentRow.Index;

                long posForanea = buscarEntidadForanea(pos);

                if (posForanea != -1)
                {
                    foreach (Entidad en in entidades)
                    {
                        if (posForanea == en.direccion_Entidad)
                        {
                            if (en.direccion_Dato == -1)
                            {
                                MessageBox.Show("Contiene clave foranea, sin datos en la enidad", "Primero agrega registros");
                                return;
                            }
                        }
                    }
                }

                this.Hide();
                FormRegistro nuevoRegistro = new FormRegistro(this, fa.fileS, fa.nombreDelArchivo, entidades, pos, 2);
                nuevoRegistro.cambia += new FormRegistro.regresar(direccionIndice);
                nuevoRegistro.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad");
            }
        }

        private void hashEstaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int pos = dgv_Entidad.CurrentRow.Index;

                long posForanea = buscarEntidadForanea(pos);

                if (posForanea != -1)
                {
                    foreach (Entidad en in entidades)
                    {
                        if (posForanea == en.direccion_Entidad)
                        {
                            if (en.direccion_Dato == -1)
                            {
                                MessageBox.Show("Contiene clave foranea, sin datos en la enidad", "Primero agrega registros");
                                return;
                            }
                        }
                    }
                }

                this.Hide();
                FormRegistro nuevoRegistro = new FormRegistro(this, fa.fileS, fa.nombreDelArchivo, entidades, pos, 3);
                nuevoRegistro.cambia += new FormRegistro.regresar(direccionIndice);
                nuevoRegistro.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad");
            }
        }

        private void consultaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void indicePrimarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int posicion = dgv_Entidad.CurrentRow.Index; //saber la pos de la fila que se selecciono
                long posForanea = buscarEntidadForanea(posicion);

                if (posForanea != -1)
                {
                    int i = 0;
                    foreach (Entidad en in entidades)
                    {
                        if (posForanea == en.direccion_Entidad)
                        {
                            break;
                        }
                        i++;
                    }

                   // this.Hide();
                    BusquedaIndice bIndice = new BusquedaIndice(entidades, posicion, i);
                    bIndice.Show();
                }
                else
                {
                    //this.Hide();
                    BusquedaIndice bIndice = new BusquedaIndice(entidades, posicion);
                    bIndice.Show();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una entidad para ver sus atributos.");
            }
        }
    }
}
