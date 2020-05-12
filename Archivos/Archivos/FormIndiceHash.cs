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
    public partial class FormIndiceHash : Form
    {
        public delegate void cambio(FormEntidad form, List<Entidad> entidades);
        public event cambio cambiar;

        int pos;
        FormEntidad form;
        FileStream Fichero;
        List<Entidad> entidades = new List<Entidad>();

        public FormIndiceHash(FormEntidad form, List<Entidad> entidades, int pos)
        {
            this.form = form;
            this.entidades = entidades;
            this.pos = pos;
            InitializeComponent();
        }

        private void FormIndiceHash_Load(object sender, EventArgs e)
        {
            escribirIndice();
        }

        private void escribirIndice()
        {
            dgv_IndiceHash.DataSource = null;
            dgv_IndiceHash.Columns.Add("Direccion", "Direccion");
            //MessageBox.Show("tiene: " + entidades[pos].hash.Last().listSecD.Count);
            for (int i = 0; i < entidades[pos].hash.Last().listSecD.Count; ++i)
            {
                dgv_IndiceHash.Rows.Add(entidades[pos].hash.Last().listSecD[i].getDireccion);
            }
        }

        private void btn_regresaEntidad_Click(object sender, EventArgs e)
        {
            dgv_IndiceHash.Rows.Clear();
            dgv_Direcciones.Rows.Clear();
            this.Close();
            cambiar(form, entidades);
        }

        private void dgv_IndiceHash_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_IndiceHash.CurrentRow.Index >= 0)
            {
                escribeDireccionesCajones();
            }
        }

        private void escribeDireccionesCajones()
        {
            dgv_Direcciones.DataSource = null;

            if (dgv_IndiceHash.Rows.Count >= 0)
            {
                if (dgv_Direcciones.Rows.Count > 0)
                {
                    dgv_Direcciones.Columns.Remove("Clave");
                    dgv_Direcciones.Columns.Remove("Direccion");
                    dgv_Direcciones.Columns.Remove("Desbordamiento");
                }


                int pos2 = dgv_IndiceHash.CurrentRow.Index;
                //string cl = Convert.ToString(entidades[pos].hash.Last().listSecD[pos2].listSecDirs.);
               // lbl_direccion.Text = "DIRECCIÓN  DE: " + cl;

                dgv_Direcciones.Columns.Add("Clave", "Clave");
                dgv_Direcciones.Columns.Add("Direccion", "Direccion");
                dgv_Direcciones.Columns.Add("Desbordamiento", "Desbordamiento");

                

                int j = 0;

                foreach (SecundarioDir ip in entidades[pos].hash.Last().listSecD[pos2].listSecDirs)
                {
                    for (int i = 0; i < ip.listIndiceSecundario.Count; ++i)
                    {
                        dgv_Direcciones.Rows.Add(ip.listIndiceSecundario[i].getClave.ToString());
                        dgv_Direcciones.Rows[j].Cells[1].Value = ip.listIndiceSecundario[i].getDireccion;
                        if (i == ip.listIndiceSecundario.Count - 1)
                        {
                            dgv_Direcciones.Rows[j].Cells[2].Value = ip.getApSiguiente;
                        }
                        j++;
                    }
                }
            }
        }
    }
}
