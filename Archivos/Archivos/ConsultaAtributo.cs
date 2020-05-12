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
        private int formatoBusqueda = -1;

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

        private void tb_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_Atributo.Rows.Clear();

                if (entidades.ElementAt(pos).atributos != null)
                {
                    foreach (Atributo at in entidades.ElementAt(pos).atributos)
                    {
                        if (tb_Buscar.Text == "")
                        {
                            dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                        }
                        else
                        {
                            switch (formatoBusqueda)
                            {
                                case 0:
                                    if (at.string_Nombre.Contains(tb_Buscar.Text))
                                    {
                                        dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                                    }
                                    break;
                                case 1:
                                    if (at.tipo_Dato.Equals(Convert.ToChar(tb_Buscar.Text)))
                                    {
                                        dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                                    }
                                    break;
                                case 2:
                                    if (at.longitud_Tipo == Convert.ToInt32(tb_Buscar.Text))
                                    {
                                        dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                                    }
                                    break;
                                case 3:
                                    if (at.tipo_Indice == Convert.ToInt32(tb_Buscar.Text))
                                    {
                                        dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                                    }
                                    break;
                                default:
                                    if (at.string_Nombre.Contains(tb_Buscar.Text))
                                    {
                                        dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                                    }
                                    break;
                            }
                        }
                    }

                    cb_Entidades.Text = entidades.ElementAt(pos).string_Nombre;
                }
                else
                {
                    MessageBox.Show("No existen atributos.");
                }
            }
            catch (Exception ee)
            {
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*0 Nombre
             * 1 Tipo Dato
             * 2 Longitud
             * 3 Tipo de indice*/
            formatoBusqueda = cb_Filtro.SelectedIndex;
        }
    }
}
