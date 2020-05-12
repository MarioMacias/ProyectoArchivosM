using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archivos
{
    public partial class ConsultaRegistros : Form
    {
        public delegate void pasar(FormEntidad fEntidad, List<Entidad> enti);
        public event pasar cambia;

        private FormEntidad formEntidad;
        public List<Entidad> entidades;
        private List<object> datos_registro;

        private int pos, posForanea = -1;

        public FuncionRegistro fr = new FuncionRegistro();
        public FuncionIndicePrimario fip = new FuncionIndicePrimario();
        public FuncionSecundario fs = new FuncionSecundario();

        private int formatoBusqueda = 0;

        private void tb_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_Registro.Rows.Clear();

                int j = 0;
                foreach (Registro regis in entidades[pos].registros)
                {
                    if (regis.element_Registro[formatoBusqueda].ToString().Contains(tb_Buscar.Text))
                    {

                        int aux = 0;
                        dgv_Registro.Rows.Add(regis.dir_Registro); //direccion del dato, no del registro idiota

                        for (int i = 0; i < entidades.ElementAt(pos).atributos.Count; ++i)
                        {
                            dgv_Registro.Rows[j].Cells[i + 1].Value = regis.element_Registro[i].ToString();
                            aux = i + 1;
                        }
                        dgv_Registro.Rows[j].Cells[aux + 1].Value = regis.dir_sigRegistro;
                        j++;
                    }
                }
            }
            catch (Exception ee)
            {

            }
        }

        private void cb_Filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatoBusqueda = cb_Filtrar.SelectedIndex;
        }

        public ConsultaRegistros(FormEntidad formEntidad, List<Entidad> entidades)
        {
            this.formEntidad = formEntidad;
            this.entidades = entidades;
            fr = new FuncionRegistro();
            fr.nuevaPosicion = pos;
            fr.lisEntidades = entidades;

            InitializeComponent();
        }

        public ConsultaRegistros(List<Entidad> entidades, int posForanea)
        {
            this.formEntidad = formEntidad;
            this.entidades = entidades;
            fr = new FuncionRegistro();
            this.posForanea = posForanea;
            fr.lisEntidades = entidades;

            InitializeComponent();
        }

        private void ConsultaRegistros_Load(object sender, EventArgs e)
        {
            //Primero agregamos la columna de la direccion del registro
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "Dir. Registro";
            columna.ReadOnly = true;
            dgv_Registro.Columns.Add(columna);

            //Despues todos los nombres de los atributos
            foreach (Atributo en in entidades.ElementAt(pos).atributos)
            {
                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = en.string_Nombre;
                columna.ReadOnly = false;
                dgv_Registro.Columns.Add(columna);
            }

            //Al final la columna del apuntador siguiente del registro
            columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "Apuntador siguiente";
            columna.ReadOnly = true;
            dgv_Registro.Columns.Add(columna);

            escribirDatosData();
            cb_Filtrar.Items.Clear();

            foreach (Atributo atributo in entidades[pos].atributos)
            {
                cb_Filtrar.Items.Add(atributo.string_Nombre);
            }
        }

        private void escribirDatosData()
        {
            dgv_Registro.Rows.Clear();

            int j = 0;

            if (posForanea != -1)
            {
                foreach (Registro regis in entidades[posForanea].registros)
                {
                    int aux = 0;
                    dgv_Registro.Rows.Add(regis.dir_Registro); //direccion del dato, no del registro idiota

                    for (int i = 0; i < entidades.ElementAt(posForanea).atributos.Count; ++i)
                    {
                        dgv_Registro.Rows[j].Cells[i + 1].Value = regis.element_Registro[i].ToString();
                        aux = i + 1;
                    }
                    dgv_Registro.Rows[j].Cells[aux + 1].Value = regis.dir_sigRegistro;
                    j++;
                }
            }
            else
            {
                foreach (Registro regis in entidades[pos].registros)
                {
                    int aux = 0;
                    dgv_Registro.Rows.Add(regis.dir_Registro); //direccion del dato, no del registro idiota

                    for (int i = 0; i < entidades.ElementAt(pos).atributos.Count; ++i)
                    {
                        dgv_Registro.Rows[j].Cells[i + 1].Value = regis.element_Registro[i].ToString();
                        aux = i + 1;
                    }
                    dgv_Registro.Rows[j].Cells[aux + 1].Value = regis.dir_sigRegistro;
                    j++;
                }
            }
            
        }

        private void regresa(ConsultaEntidad fed, List<Entidad> enti)
        {
            entidades = enti;
            fed.Show();
            escribirDatosData();
        }

        private void btn_regresaEntidad_Click(object sender, EventArgs e)
        {
            dgv_Registro.Rows.Clear();
            this.Close();
            cambia(formEntidad, entidades);
        }
    }
}
