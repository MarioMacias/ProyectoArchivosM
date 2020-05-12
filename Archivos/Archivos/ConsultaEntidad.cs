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
    public partial class ConsultaEntidad : Form
    {
        public delegate void pasar(FormEntidad fEntidad, List<Entidad> enti);
        public event pasar cambia;

        private FormEntidad fEntidad;
        private List<Entidad> entidades;
        private string nombreArchivo;

        public ConsultaEntidad(FormEntidad fEntidad, List<Entidad> entidades, string nombreArchivo)
        {
            this.fEntidad = fEntidad;
            this.entidades = entidades;
            this.nombreArchivo = nombreArchivo;
            InitializeComponent();
        }

        private void btn_Atributo_Click(object sender, EventArgs e)
        {
            if (dgv_Entidad.SelectedCells != null)
            {
                int posicion = dgv_Entidad.CurrentRow.Index; //saber la pos de la fila que se selecciono

                this.Hide();
                ConsultaAtributo fAtributo = new ConsultaAtributo(this, entidades, nombreArchivo, posicion);
                fAtributo.cambia += new ConsultaAtributo.pasar(regresa);
                fAtributo.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una entidad para ver sus atributos.");
            }
        }

        private void regresa(ConsultaEntidad fed, List<Entidad> enti)
        {
            entidades = enti;
            fed.Show();
            datosDataG();
        }

        public void datosDataG()
        {
            dgv_Entidad.Rows.Clear();
            foreach (Entidad en in entidades)
            {
                dgv_Entidad.Rows.Add(en.string_Nombre, en.direccion_Entidad, en.direccion_Atributo, en.direccion_Dato, en.direccion_Siguiente);
            }
        }

        private void btn_regreso_Click(object sender, EventArgs e)
        {
            dgv_Entidad.Rows.Clear();
            this.Close();
            cambia(fEntidad, entidades);
        }

        private void ConsultaEntidad_Load(object sender, EventArgs e)
        {
            datosDataG();
        }

        private void tb_Buscar_TextChanged(object sender, EventArgs e)
        {
            dgv_Entidad.Rows.Clear();

            foreach (Entidad en in entidades)
            {
                if (en.string_Nombre.Contains(tb_Buscar.Text))
                {
                    dgv_Entidad.Rows.Add(en.string_Nombre, en.direccion_Entidad, en.direccion_Atributo, en.direccion_Dato, en.direccion_Siguiente);
                }
            }
        }
    }
}
