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
    public partial class BusquedaIndice : Form
    {
        public List<Entidad> entidades;
        int pos, posForanea;
        private int posAtributoEntidFor = -1;
        private int formatoBusqueda = 0;
        private List<object> datos_registro;
        private int indicePrimario = -1, indiceSecundario = -1;
        private int pos2 = -1;
        private bool botonActualizar = false;
        string palabra;

        public BusquedaIndice(List<Entidad> entidades, int pos)
        {
            this.entidades = entidades;
            this.pos = pos;
            InitializeComponent();
        }

        public BusquedaIndice(List<Entidad> entidades, int pos, int posForanea)
        {
            this.posForanea = posForanea;
            this.entidades = entidades;
            this.pos = pos;
            InitializeComponent();
        }

        private void BusquedaIndice_Load(object sender, EventArgs e)
        {
            indicePrimario = buscaIndicePrimario();
            indiceSecundario = buscaIndiceSecundario();
            consultaRegistro_Load();
            if(indicePrimario != -1)
            {
                consultaPrimario_Load();
                llenaDataPrimaro();
            }
                
            if(indiceSecundario != -1)
            {
                consultaSecundario_Load();
                llenaDataIndiceSecundario();
            }
        }

        private void consultaRegistro_Load()
        {
            //Primero agregamos la columna de la direccion del registro
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "Dir. Registro";
            columna.ReadOnly = true;
            dgv_Registro.Columns.Add(columna);

            int i = 0;
            DataGridViewComboBoxColumn colCB = new DataGridViewComboBoxColumn();

            foreach (Atributo en in entidades.ElementAt(pos).atributos)
            {
                if (en.tipo_Indice == 8)
                {
                    colCB = new DataGridViewComboBoxColumn();
                    colCB.HeaderText = en.string_Nombre;
                    colCB.ReadOnly = true;
                    verificaClaveForanea();
                    //MessageBox.Show("nombre: " + entidades[posEntidadForanea].registros[posAtributoForaneo].element_Registro[0].ToString());
                    foreach (Registro reg in entidades[posForanea].registros)
                    {
                        colCB.Items.Add(reg.element_Registro[posAtributoEntidFor].ToString());
                    }
                    dgv_Registro.Columns.Add(colCB);
                }
                else
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.HeaderText = en.string_Nombre;
                    columna.ReadOnly = true;
                    dgv_Registro.Columns.Add(columna);
                }
            }

            //Al final la columna del apuntador siguiente del registro
            columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "Apuntador siguiente";
            columna.ReadOnly = true;
            dgv_Registro.Columns.Add(columna);

            escribirDatosData_Registros();

            cb_Filtrar.Items.Clear();

            foreach (Atributo atributo in entidades[pos].atributos)
            {
                cb_Filtrar.Items.Add(atributo.string_Nombre);
            }
        }

        private void consultaPrimario_Load()
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "Clave";
            columna.ReadOnly = false;
            dgv_IndicePrimario.Columns.Add(columna);

            columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "Direccion";
            columna.ReadOnly = false;
            dgv_IndicePrimario.Columns.Add(columna);

            columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "Apuntador";
            columna.ReadOnly = false;
            dgv_IndicePrimario.Columns.Add(columna);
        }

        private void consultaSecundario_Load()
        {
            dgv_IndiceSecundario.DataSource = null;
            dgv_IndiceSecundario.Columns.Add("Clave", "Clave");
            dgv_IndiceSecundario.Columns.Add("Direccion", "Direccion");
            dgv_IndiceSecundario.Columns.Add("Dir. Diguiente", "Dir. Diguiente");
        }

        private bool verificaClaveForanea()
        {
            int i = 0;
            int ii = 0;
            foreach (Atributo at in entidades[posForanea].atributos)
            {
                if (at.tipo_Indice == 2)
                {
                    posAtributoEntidFor = ii;
                    return true;
                }
                ii++;
            }

            return false;
        }

        private void tb_Buscar_TextChanged(object sender, EventArgs e)
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

        private void cb_Filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatoBusqueda = cb_Filtrar.SelectedIndex;
        }

        private bool creaListaObjetos()
        {
            int pRe = dgv_Registro.RowCount - 1;//la posicion del ultimo elemento
            datos_registro = new List<object>();

            if ((pRe) >= 0)
            {
                int i = 1;

                if (dgv_Registro.SelectedCells.Count > 0)
                {
                    foreach (Atributo atributo in entidades[pos].atributos)
                    {
                        try
                        {
                            datos_registro.Add(dgv_Registro.SelectedCells[i].Value);
                            i++;
                        }
                        catch
                        {
                            MessageBox.Show("Algo salio mal en FormRegistro - creaListaObjetos");
                            return false;
                        }
                    }
                    //MessageBox.Show("termino");
                    return true;
                }
                else
                {
                    MessageBox.Show("Selecciona la fila a agregar ");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No hay elementos");
                return false; //no hay elementos
            }
        }

        private void btn_ActualizaIndice_Click(object sender, EventArgs e)
        {
            botonActualizar = true;

            if (creaListaObjetos())
            {
                if (indicePrimario != -1)
                {
                    llenaDataPrimaro();
                }

                if (indiceSecundario != -1)
                {
                    llenaDataIndiceSecundario();
                }
            }
        }

        private void llenaDataIndiceSecundario()
        {
            dgv_IndiceSecundario.Rows.Clear();
            int j = 0;

            foreach (Secundario s in entidades[pos].secundarios)
            {
                for (int i = 0; i < s.listSecD.Count; ++i)
                {
                    if (botonActualizar == true)
                    {
                        if (s.listSecD[i].getClave.ToString() == datos_registro[indiceSecundario].ToString())
                        {
                            pos2 = i;
                            dgv_IndiceSecundario.Rows.Add(s.listSecD[i].getClave.ToString());
                            dgv_IndiceSecundario.Rows[j].Cells[1].Value = s.listSecD[i].getDireccion;
                            if (i == s.listSecD.Count - 1)
                            {
                                dgv_IndiceSecundario.Rows[j].Cells[2].Value = s.getApuntadorSig;
                            }
                            j++;
                        }
                    }
                    else
                    {
                        pos2 = i;
                        dgv_IndiceSecundario.Rows.Add(s.listSecD[i].getClave.ToString());
                        dgv_IndiceSecundario.Rows[j].Cells[1].Value = s.listSecD[i].getDireccion;
                        if (i == s.listSecD.Count - 1)
                        {
                            dgv_IndiceSecundario.Rows[j].Cells[2].Value = s.getApuntadorSig;
                        }
                        j++;
                    }
                }
            }
        }

        private void llenaDataPrimaro()
        {
            dgv_IndicePrimario.Rows.Clear();
            int j = 0;
            //MessageBox.Show("en form primario: " + entidades[pos].primarios.Count);
            foreach (Primario primario in entidades[pos].primarios)
            {
                for (int i = 0; i < primario.indice.Count; ++i)
                {
                    if (botonActualizar == true)
                    {
                        if (primario.indice[i].IndiceP_Clave.ToString() == datos_registro[indicePrimario].ToString())
                        {
                            dgv_IndicePrimario.Rows.Add(primario.indice[i].IndiceP_Clave.ToString()); //mostramos la clave
                            dgv_IndicePrimario.Rows[j].Cells[1].Value = primario.indice[i].IndiceP_Direccion;
                            if (i == primario.indice.Count - 1)
                            {
                                dgv_IndicePrimario.Rows[j].Cells[2].Value = primario.apuntador_Siguiente;
                            }
                            j++;
                        }
                    }
                    else
                    {
                        dgv_IndicePrimario.Rows.Add(primario.indice[i].IndiceP_Clave.ToString()); //mostramos la clave
                        dgv_IndicePrimario.Rows[j].Cells[1].Value = primario.indice[i].IndiceP_Direccion;
                        if (i == primario.indice.Count - 1)
                        {
                            dgv_IndicePrimario.Rows[j].Cells[2].Value = primario.apuntador_Siguiente;
                        }
                        j++;
                    }
                    
                }
            }
        }

        private int buscaIndicePrimario()
        {
            int i = 0;
            foreach (Atributo atributo in entidades[pos].atributos)
            {
                if (atributo.tipo_Indice == 2)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void dgv_IndiceSecundario_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_IndiceSecundario.CurrentRow.Index >= 0)
            {
                escribeDataGDirecciones();
            }
        }

        private void escribeDataGDirecciones()
        {
            dgv_Direcciones.DataSource = null;

            if (dgv_IndiceSecundario.CurrentRow.Index >= 0)
            {
                if (dgv_Direcciones.Rows.Count > 0)
                {
                    dgv_Direcciones.Columns.Remove("Dirección");
                    dgv_Direcciones.Columns.Remove("Dir. Siguiente");
                }

                dgv_Direcciones.Columns.Add("Dirección", "Dirección");
                dgv_Direcciones.Columns.Add("Dir. Siguiente", "Dir. Siguiente");

                int j = 0;

                List<IndiceSecundario> auxInd = new List<IndiceSecundario>();

                if (botonActualizar == false)
                {
                    pos2 = 0;
                    int pos3 = dgv_IndiceSecundario.CurrentRow.Index;
                    foreach (SecundarioCve sc in entidades[pos].secundarios.Last().listSecD)
                    {
                        //MessageBox.Show("dvg_registro: " + dgv_IndiceSecundario.SelectedCells[0].Value.ToString() + " clave: " + sc.getClave.ToString());
                        if (dgv_IndiceSecundario.SelectedCells[0].Value.ToString() == sc.getClave.ToString())
                        {
                            break;
                        }
                        pos2++;
                    }//
                }

                string cl = Convert.ToString(entidades[pos].secundarios.Last().listSecD[pos2].getClave);
                lbl_direccion.Text = "DIRECCIÓN  DE: " + cl;

                foreach (SecundarioDir ip in entidades[pos].secundarios.Last().listSecD[pos2].listSecDirs)
                {
                    auxInd = new List<IndiceSecundario>();

                    for (int i = 0; i < ip.listIndiceSecundario.Count; ++i)
                    {
                        if (ip.listIndiceSecundario[i].getDireccion != -1)
                        {
                            auxInd.Add(ip.listIndiceSecundario[i]);
                        }
                    }

                    auxInd = auxInd.OrderBy(x => x.getDireccion).ToList();

                    for (int i = 0; i < ip.listIndiceSecundario.Count; ++i)
                    {
                        if (ip.listIndiceSecundario[i].getDireccion == -1)
                        {
                            auxInd.Add(ip.listIndiceSecundario[i]);
                        }
                    }

                    ip.listIndiceSecundario = auxInd;
                }

                foreach (SecundarioDir ip in entidades[pos].secundarios.Last().listSecD[pos2].listSecDirs)
                {
                    for (int i = 0; i < ip.listIndiceSecundario.Count; ++i)
                    {
                        dgv_Direcciones.Rows.Add(ip.listIndiceSecundario[i].getDireccion.ToString());
                        if (i == ip.listIndiceSecundario.Count - 1)
                        {
                            dgv_Direcciones.Rows[j].Cells[1].Value = ip.getApSiguiente;
                        }
                        j++;
                    }
                }
            }
        }

        private void tb_primario_TextChanged(object sender, EventArgs e)
        {
            botonActualizar = false;

            dgv_IndicePrimario.Rows.Clear();
            int j = 0;
            
            foreach (Primario primario in entidades[pos].primarios)
            {
                for (int i = 0; i < primario.indice.Count; ++i)
                {
                    if (primario.indice[i].IndiceP_Clave.ToString().Contains(tb_primario.Text))
                    {
                        dgv_IndicePrimario.Rows.Add(primario.indice[i].IndiceP_Clave.ToString()); //mostramos la clave
                        dgv_IndicePrimario.Rows[j].Cells[1].Value = primario.indice[i].IndiceP_Direccion;
                        if (i == primario.indice.Count - 1)
                        {
                            dgv_IndicePrimario.Rows[j].Cells[2].Value = primario.apuntador_Siguiente;
                        }
                        j++;
                    }
                }
            }

            actualizaRegistroIndice(indicePrimario, 2);
        }

        private void actualizaRegistroIndice(int pos3, int tipo)
        {
            switch (tipo)
            {
                case 2:
                    palabra = tb_primario.Text;
                    break;
                case 3:
                    palabra = tb_secundario.Text;
                    break;
            }

            //Para el data greed de registros
            dgv_Registro.Rows.Clear();

            int j = 0;
            foreach (Registro regis in entidades[pos].registros)
            {
                if (regis.element_Registro[pos3].ToString().Contains(palabra))
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

        private void tb_secundario_TextChanged(object sender, EventArgs e)
        {
            botonActualizar = false;
            
            dgv_IndiceSecundario.Rows.Clear();
            int j = 0;

            foreach (Secundario s in entidades[pos].secundarios)
            {
                for (int i = 0; i < s.listSecD.Count; ++i)
                {
                    if (s.listSecD[i].getClave.ToString().Contains(tb_secundario.Text))
                    {
                        pos2 = i;
                        dgv_IndiceSecundario.Rows.Add(s.listSecD[i].getClave.ToString());
                        dgv_IndiceSecundario.Rows[j].Cells[1].Value = s.listSecD[i].getDireccion;
                        if (i == s.listSecD.Count - 1)
                        {
                            dgv_IndiceSecundario.Rows[j].Cells[2].Value = s.getApuntadorSig;
                        }
                        j++;
                    }
                }
            }

            actualizaRegistroIndice(indiceSecundario, 3);
        }

        private void dgv_IndiceSecundario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private int buscaIndiceSecundario()
        {
            int i = 0;
            foreach (Atributo atributo in entidades[pos].atributos)
            {
                if (atributo.tipo_Indice == 3)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void escribirDatosData_Registros()
        {
            dgv_Registro.Rows.Clear();
            int j = 0;
            foreach (Registro regis in entidades[pos].registros)
            {
                int aux = 0;
                dgv_Registro.Rows.Add(regis.dir_Registro);

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
}
