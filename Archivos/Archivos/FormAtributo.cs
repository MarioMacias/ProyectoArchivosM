﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Archivos
{
    public partial class FormAtributo : Form
    {
        public delegate void pasar(FormEntidad fEntidad, List<Entidad> enti);
        public event pasar cambia;

        int pos; //posicion de la fila seleccionadaf
        int posForanea;
        private int tipoOrg = -1;
        FormEntidad formEntidad; // form de entidades
        Atributo atributo, atributoForanea; //variable para el atributo 
        FuncionAtributo fa; //variable para acceder a las funciones de los atributos
        List<Entidad> entidades;

        /*Nombre del archivo*/
        string nombreArchivo;

        public FormAtributo()
        {
            InitializeComponent();
        }

        /*Constructor del form*/
        public FormAtributo(FormEntidad formEntidad, List<Entidad> entidades, string nombreArchivo, int pos)
        {
            this.pos = pos;
            this.formEntidad = formEntidad;
            this.entidades = entidades;
            this.nombreArchivo = nombreArchivo;
            entidades = new List<Entidad>();
            fa = new FuncionAtributo();
            InitializeComponent();
        }

        /*Regresar a las entidades*/
        private void btn_Regreso_Click(object sender, EventArgs e)
        {
            dgv_Atributo.Rows.Clear();
            this.Close();
            cambia(formEntidad, entidades);
        }

        /*Si se quiere crear un nuevo atributo se habilitan los campos necesarios*/
        private void btn_CrearAtributo_Click(object sender, EventArgs e)
        {
            botonesVisibles(true);
        }

        /*Metodo para hacer visible o no los textbox o botones del form*/
        private void botonesVisibles(bool visible)
        {
            lb_Nombre.Visible = visible;
            lb_indice.Visible = visible;
            lb_Longitud.Visible = visible;
            lb_Tipo.Visible = visible;
            tb_Nombre.Visible = visible;
            tb_Longitud.Visible = visible;
            cb_TipoDato.Visible = visible;
            cb_Indice.Visible = visible;
            btn_Aceptar.Visible = visible;
            lb_Foranea.Visible = !visible;
            cb_Foranea.Visible = !visible;
        }

        private void claveForanea()
        {
            lb_Foranea.Visible = true;
            lb_Longitud.Visible = false;
            lb_Tipo.Visible = false;
            tb_Longitud.Visible = false;
            cb_TipoDato.Visible = false;
            cb_Foranea.Visible = true;

            foreach (Entidad enti in entidades)
            {
                cb_Foranea.Items.Add(enti.string_Nombre);
            }
        }

        /*Crear un nuevo atributo*/
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (nombreRepetido(tb_Nombre.Text))
            {
                MessageBox.Show("El nombre esta repetido, no se agregara.");
                return;
            }

            if(atributoForanea != null)
                if (atributoForanea.string_Nombre == "ERR")
                {
                    MessageBox.Show("ERR atributo");
                    return;
                }

            if (Convert.ToInt16(cb_Indice.Text) == 8)
            {
                atributo = new Atributo(tb_Nombre.Text, atributoForanea.tipo_Dato, atributoForanea.longitud_Tipo, Convert.ToInt16(cb_Indice.Text));
                fa.dirIndiceForanea = entidades[posForanea].direccion_Entidad;

                entidades.ElementAt(pos).agregarAtributo(atributo); //Agregamos la entidad seleccionada.
                                                                    //MessageBox.Show(entidades.ElementAt(pos).atributos.Count.ToString());
                
                if (fa.agregaAtributoArchivo(nombreArchivo, pos, entidades))
                {
                    llenaDataG();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else if (tb_Nombre != null || tb_Nombre.Text != "")
            {
                if (cb_TipoDato.Text != "")
                {
                    atributo = new Atributo(tb_Nombre.Text, 
                                            Convert.ToChar(cb_TipoDato.Text), 
                                            Convert.ToInt16(tb_Longitud.Text), 
                                            Convert.ToInt16(cb_Indice.Text));
                    
                    entidades.ElementAt(pos).agregarAtributo(atributo); //Agregamos la entidad seleccionada.
                    //MessageBox.Show(entidades.ElementAt(pos).atributos.Count.ToString());
                    if (fa.agregaAtributoArchivo(nombreArchivo, pos, entidades))
                    {
                        llenaDataG();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Verifica si los campos estan completos.");
                }
            }
            else
            {
                MessageBox.Show("Verifica si los campos estan completos.");
            }

            botonesVisibles(true);
            tb_Nombre.Text = "";
            tb_Longitud.Text = "";
            cb_Indice.Text = "";
            cb_TipoDato.Text = "";

        }

        private bool nombreRepetido(string nombreModificar)
        {
            foreach (Atributo atri in entidades.ElementAt(pos).atributos)
            {
                if (atri.string_Nombre.CompareTo(nombreModificar) == 0) //Es el mismo
                {
                    return true;
                }
            }
            return false;
        }
        private void FormAtributo_Load(object sender, EventArgs e)
        {
            botonesVisibles(false);
            tb_Nombre.Text = "";
            tb_Longitud.Text = "";
            foreach (Entidad enti in entidades)
            {
                cb_Entidades.Items.Add(enti.string_Nombre);
            }
           // prueba();
            llenaDataG();
        }

        private void prueba()
        {
            tb_Nombre.Text = "Cve";
            tb_Longitud.Text = "4";
            cb_Indice.Text = "4";
            cb_TipoDato.Text = "E";
        }

        /*Llenar con los datos la tabla*/
        private void llenaDataG()
        {
            try{
                dgv_Atributo.Rows.Clear();

                if (entidades.ElementAt(pos).atributos != null)
                {
                    foreach (Atributo at in entidades.ElementAt(pos).atributos)
                    {
                        //string identid = BitConverter.ToString(at.id_Atributo);
                        //dgv_Atributo.Rows.Add(identid, at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                        dgv_Atributo.Rows.Add(at.string_Nombre, at.tipo_Dato, at.longitud_Tipo, at.direccion_Atributo, at.tipo_Indice, at.direccion_Indice, at.direccion_sigAtributo);
                    }
                    cb_Entidades.Text = entidades.ElementAt(pos).string_Nombre;
                    botonesVisibles(true);
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

        
        private void btn_modifAtributo_Click(object sender, EventArgs e)
        {
            
        }

        /*Boton para eliminar el atributo seleccionado*/
        private void btn_eliminarAtributo_Click(object sender, EventArgs e)
        {
            int posAt = dgv_Atributo.CurrentRow.Index;

            //MessageBox.Show(entidades.ElementAt(pos).atributos.Count.ToString() + " pos " + posAt);
            if (fa.eliminarAtributo(pos, posAt, entidades, nombreArchivo))
            {
                llenaDataG();
            }
        }

        /*Metodo para acompletar la longitud, dependiendo del tipo de dato*/
        private void cb_TipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TipoDato.Text.CompareTo("E") == 0 || cb_TipoDato.Text.CompareTo("F") == 0) //si es igual
            {
                tb_Longitud.Text = "4";
            }
            else if(cb_TipoDato.Text.CompareTo("C") == 0)
            {
                tb_Longitud.Text = "25";
            }
        }

        private void btn_aceptarEntidad_Click(object sender, EventArgs e)
        {
            pos = cb_Entidades.SelectedIndex;
            llenaDataG();
        }

        /*Para modificar todos los valores*/
        private void modificarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posAt = dgv_Atributo.CurrentRow.Index;

            if (Convert.ToInt16(cb_Indice.Text) == 8)
            {
                if (atributoForanea.string_Nombre == "ERR")
                {
                    MessageBox.Show("ERR atributo");
                    return;
                }

                if (fa.modificaAtributoSel(nombreArchivo, tb_Nombre.Text, atributoForanea.tipo_Indice.ToString(), atributoForanea.tipo_Dato.ToString(), atributoForanea.longitud_Tipo.ToString(), posAt, entidades, 0))
                {
                    tb_Nombre.Text = "";
                    tb_Longitud.Text = "";
                    cb_TipoDato.Text = "";
                    cb_Indice.Text = "";

                    botonesVisibles(true);
                    llenaDataG();
                }
            }
            else if (fa.modificaAtributoSel(nombreArchivo, tb_Nombre.Text, cb_Indice.Text, cb_TipoDato.Text, tb_Longitud.Text, posAt, entidades,0))
            {
                tb_Nombre.Text = "";
                tb_Longitud.Text = "";
                cb_TipoDato.Text = "";
                cb_Indice.Text = "";

                botonesVisibles(true);
                llenaDataG();
            }
        }

        /*Modificar solo el nombre*/
        private void modificarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posAt = dgv_Atributo.CurrentRow.Index;
            //MessageBox.Show("Entidades: " + entidades.Count);
            if (fa.modificaAtributoSel(nombreArchivo, tb_Nombre.Text, cb_Indice.Text, cb_TipoDato.Text, tb_Longitud.Text, posAt, entidades, 1))
            {
                tb_Nombre.Text = "";
                tb_Longitud.Text = "";
                cb_TipoDato.Text = "";
                cb_Indice.Text = "";

                llenaDataG();
            }
        }

        /*Para modificar el tipo de dato*/
        private void modificarTipoDeDatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posAt = dgv_Atributo.CurrentRow.Index;

            if (fa.modificaAtributoSel(nombreArchivo, tb_Nombre.Text, cb_Indice.Text, cb_TipoDato.Text, tb_Longitud.Text, posAt, entidades, 2))
            {
                tb_Nombre.Text = "";
                tb_Longitud.Text = "";
                cb_TipoDato.Text = "";
                cb_Indice.Text = "";

                llenaDataG();
            }
        }

        /*Modificar la longitud*/
        private void modificarLongitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posAt = dgv_Atributo.CurrentRow.Index;

            if (fa.modificaAtributoSel(nombreArchivo, tb_Nombre.Text, cb_Indice.Text, cb_TipoDato.Text, tb_Longitud.Text, posAt, entidades, 3))
            {
                tb_Nombre.Text = "";
                tb_Longitud.Text = "";
                cb_TipoDato.Text = "";
                cb_Indice.Text = "";

                llenaDataG();
            }
        }

        /*Modificar el tipo de indice*/
        private void modificarTipoDeIndiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posAt = dgv_Atributo.CurrentRow.Index;

            if (fa.modificaAtributoSel(nombreArchivo, tb_Nombre.Text, cb_Indice.Text, cb_TipoDato.Text, tb_Longitud.Text, posAt, entidades, 4))
            {
                tb_Nombre.Text = "";
                tb_Longitud.Text = "";
                cb_TipoDato.Text = "";
                cb_Indice.Text = "";

                llenaDataG();
            }
        }

        private void cb_Entidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Indice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(cb_Indice.Text) == 8)
                {
                    claveForanea();
                }
            }
            catch(Exception ex){
                //Debug.Fail(ex.Message);
            }
        }

        private void cb_Foranea_SelectedIndexChanged(object sender, EventArgs e)
        {
            posForanea = cb_Foranea.SelectedIndex;
            //MessageBox.Show("Pos foranea: " + posForanea.ToString());
            atributoForanea = new Atributo("ERR", 'N', -1, -1);

            foreach(Atributo at in entidades.ElementAt(posForanea).atributos){
                //MessageBox.Show("Nombre de la entidad: " + entidades.ElementAt(posForanea).ToString() + " Nombre at: " + at.string_Nombre);
                //MessageBox.Show(" indice: " + at.tipo_Indice.ToString());
                if (at.tipo_Indice == 2)
                {
                    atributoForanea = at;
                    return;
                }
            }
            MessageBox.Show("No hay ninguna clave primaria en esa entidad");
        }
    }
}
