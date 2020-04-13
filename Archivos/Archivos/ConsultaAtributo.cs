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
    public partial class ConsultaAtributo : Form
    {
        public delegate void pasar(ConsultaEntidad fEntidad, List<Entidad> enti);
        public event pasar cambia;

        private ConsultaEntidad fEntidad;
        private List<Entidad> entidades;
        private string nombreArchivo;
        private int pos;

        public ConsultaAtributo(ConsultaEntidad fEntidad, List<Entidad> entidades, string nombreArchivo, int pos)
        {
            InitializeComponent();
            this.fEntidad = fEntidad;
            this.entidades = entidades;
            this.nombreArchivo = nombreArchivo;
            this.pos = pos;
        }

        private void ConsultaAtributo_Load(object sender, EventArgs e)
        {
            foreach (Entidad enti in entidades)
            {
                cb_Entidades.Items.Add(enti.string_Nombre);
            }
            llenaDataG();
        }

        private void llenaDataG()
        {
            try
            {
                dgv_Atributo.Rows.Clear();

                if (entidades.ElementAt(pos).atributos != null)
                {
                    foreach (Atributo at in entidades.ElementAt(pos).atributos)
                    {
                        dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                    }
                    cb_Entidades.Text = entidades.ElementAt(pos).string_Nombre;
                }
                else
                {
                    MessageBox.Show("No existen atributos.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Seleccione una Entidad" + e.Message);
            }
        }

        private void btn_regreso_Click(object sender, EventArgs e)
        {
            dgv_Atributo.Rows.Clear();
            this.Close();
            cambia(fEntidad, entidades);
        }

        private void btn_aceptarEntidad_Click(object sender, EventArgs e)
        {
            pos = cb_Entidades.SelectedIndex;
            llenaDataG();
        }
    }
}
