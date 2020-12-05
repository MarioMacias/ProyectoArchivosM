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
using System.Diagnostics;

namespace Archivos
{
    public partial class FormSQL : Form
    {
        private string[] palabrasClave = new string[] { "SELECT", "FROM", "WHERE", "INNER JOIN", "ON" };
        private List<string> comando;
        private List<string> SelecList;
        private List<string> FromList;
        private List<string> WhereList;
        private List<string> InnerList;
        private List<string> OnList;
        private int pos = -1;
        private List<int> posAtributos;
        private bool todosAtributos;

        private FormEntidad fEntidad;
        private FileStream Fichero;
        private string nombreArchivo;
        private List<Entidad> entidades;

        public FormSQL(FormEntidad formEntidad, FileStream Fichero, string nombreArchivo, List<Entidad> entidades)
        {
            InitializeComponent();
            this.fEntidad = formEntidad;
            this.Fichero = Fichero;
            this.nombreArchivo = nombreArchivo;
            this.entidades = entidades;
    }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            if (rtb_Comando.Text != "")
            {
                verificaCodigo(rtb_Comando.Text);
                creaSentencia();
                buscaPosTabla();
                buscaPosAtributos();
                iniciaTabla();
            }
        }
        private void escribirDatosData()
        {
            dgv_Consulta.Rows.Clear();
            int j = 0, i = 0;
            
            foreach (Registro regis in entidades[pos].registros)
            {
                dgv_Consulta.Rows.Add();
                if (todosAtributos)
                {
                    for (i = 0; i < entidades.ElementAt(pos).atributos.Count; i++)
                    {
                        if (WhereList.Count > 0) //si tiene where
                        {
                            if (cumpleWhere(regis))
                            {
                                dgv_Consulta.Rows[j].Cells[i].Value = regis.element_Registro[i].ToString();
                                //MessageBox.Show(regis.element_Registro[i].ToString());
                            }
                            else
                            {
                                //dgv_Consulta.Rows.RemoveAt(j);
                            }
                        }
                        else
                        {
                            dgv_Consulta.Rows[j].Cells[i].Value = regis.element_Registro[i].ToString();
                            //MessageBox.Show(regis.element_Registro[i].ToString());
                        }
                    }
                    j++;
                }
                else
                {
                    i = 0;
                    foreach (int p in posAtributos)
                    {
                        if (WhereList.Count > 0) //si tiene where
                        {
                            if (cumpleWhere(regis))
                            {
                                dgv_Consulta.Rows[j].Cells[i].Value = regis.element_Registro[p].ToString();
                                i++;
                            }
                            else
                            {
                                //dgv_Consulta.Rows.RemoveAt(j);
                            }
                        }
                        else
                        {
                            dgv_Consulta.Rows[j].Cells[i].Value = regis.element_Registro[p].ToString();
                            i++;
                        }
                    }
                    j++;
                }
            }
        }

        private bool cumpleWhere(Registro regis)
        {
            int posAux = buscaAtributo(WhereList[0]);
            int comp = Convert.ToInt32(WhereList[2]);
            bool band = false;

            switch (WhereList[1])
            {
                case "=":
                    if (Convert.ToInt32(regis.element_Registro[posAux]) == comp)
                    {
                        band = true;
                    }
                    else
                    {
                        band = false;
                    }
                    break;
                case ">":
                    if (Convert.ToInt32(regis.element_Registro[posAux]) > comp)
                    {
                        band = true;
                    }
                    else
                    {
                        band = false;
                    }
                    break;
                case "<":
                    if (Convert.ToInt32(regis.element_Registro[posAux]) < comp)
                    {
                        band = true;
                    }
                    else
                    {
                        band = false;
                    }
                    break;
                case ">=":
                    if (Convert.ToInt32(regis.element_Registro[posAux]) >= comp)
                    {
                        band = true;
                    }
                    else
                    {
                        band = false;
                    }
                    break;
                case "<=":
                    if (Convert.ToInt32(regis.element_Registro[posAux]) <= comp)
                    {
                        band = true;
                    }
                    else
                    {
                        band = false;
                    }
                    break;
                case "<>":
                    if (Convert.ToInt32(regis.element_Registro[posAux]) != comp)
                    {
                        band = true;
                    }
                    else
                    {
                        band = false;
                    }
                    break;
            }
            return band;
        }

        private void iniciaTabla()
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            dgv_Consulta.Columns.Clear();
            
            if (todosAtributos)
            {
                foreach (Atributo en in entidades.ElementAt(pos).atributos)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.HeaderText = en.string_Nombre;
                    columna.ReadOnly = true;
                    dgv_Consulta.Columns.Add(columna);
                }
            }
            else
            {
                foreach (int p in posAtributos)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.HeaderText = entidades[pos].atributos[p].string_Nombre;
                    columna.ReadOnly = true;
                    dgv_Consulta.Columns.Add(columna);
                }
            }

            escribirDatosData();
        }

        private void buscaPosTabla()
        {
            for (int i = 0; i < entidades.Count; i++)
            {
                foreach (string nomFrom in FromList)
                {
                    if (entidades[i].string_Nombre.CompareTo(nomFrom) == 0)
                    {
                        pos = i;
                        break;
                    }
                }
            }
        }

        private void buscaPosAtributos()
        {
            todosAtributos = false;
            posAtributos = new List<int>();
            for (int i = 0; i < entidades[pos].atributos.Count; i++)
            {
                foreach (string nomAtributo in SelecList)
                {
                    if (nomAtributo.CompareTo("*") == 0)
                    {
                        todosAtributos = true;
                        return;
                    }
                    if (entidades[pos].atributos[i].string_Nombre.CompareTo(nomAtributo) == 0)
                    {
                        //MessageBox.Show(nomAtributo + " " + i);
                        posAtributos.Add(i);
                    }
                }
            }
        }

        private int buscaAtributo(string nomAt)
        {
            int i = 0;
            foreach (Atributo a in entidades[pos].atributos)
            {
                if (a.string_Nombre.Equals(nomAt))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        private void verificaCodigo(string comand)
        {
            comando = new List<string>();
            string palabra = "";

            for (int i = 0; i < comand.Length; i++)
            {
                if (comand.Substring(i, 1).CompareTo(";") == 0)
                {
                    comando.Add(palabra);
                    break;
                }

                if (comand.Substring(i, 1).CompareTo(" ") == 0 || comand.Substring(i, 1).CompareTo(",") == 0)
                {
                    if (comand.Substring(i, 1).CompareTo(",") == 0)
                    {
                        if (comand.Substring(i + 1, 1).CompareTo(" ") == 0)
                        {
                            i = i + 1;
                        }
                    }
                    comando.Add(palabra);
                    palabra = "";
                }
                else
                {
                    palabra += comand.Substring(i, 1);
                }
            }
        }

        private void creaSentencia()
        {
            bool from = false;
            bool selec = false;
            bool where = false;
            bool iner = false;
            bool on = false;

          SelecList = new List<string>();
          FromList = new List<string>();
          WhereList = new List<string>();
          InnerList = new List<string>();
          OnList = new List<string>();

            foreach (string pComm in comando)
            {
                if (comando[0].ToUpper().CompareTo(palabrasClave[0]) == 0)
                {
                    switch (pComm.ToUpper())
                    {
                        case "SELECT": //FROM
                            from = false;
                            selec = true;
                            where = false;
                            on = false;
                            break;
                        case "FROM": //FROM
                            from = true;//
                            selec = false;
                            where = false;
                            on = false;
                            break;
                        case "WHERE": //FROM
                            from = false;
                            selec = false;
                            where = true;//
                            iner = false;
                            on = false;
                            break;
                        case "INNER": //FROM
                            from = false;
                            selec = false;
                            where = false;
                            iner = true;//
                            on = false;
                            break;
                        case "ON": //FROM
                            from = false;
                            selec = false;
                            where = false;
                            iner = false;
                            on = true;//
                            break;
                    }

                    if (from)
                    {
                        if(pComm.ToUpper().CompareTo("FROM") != 0)
                        FromList.Add(pComm);
                        //MessageBox.Show(pComm + " from");
                    }
                    else if (selec)
                    {
                        if (pComm.ToUpper().CompareTo("SELECT") != 0)
                            SelecList.Add(pComm);
                        //MessageBox.Show(pComm + " selec");
                    }
                    else if (where)
                    {
                        if (pComm.ToUpper().CompareTo("WHERE") != 0)
                            WhereList.Add(pComm);
                        if (pComm.ToUpper().CompareTo("WHERE") != 0)
                            MessageBox.Show(pComm + " where");
                    }
                    else if (iner)
                    {
                        if (pComm.ToUpper().CompareTo("INNER") != 0 || pComm.ToUpper().CompareTo("JOIN") != 0)
                            InnerList.Add(pComm);
                        //MessageBox.Show(pComm + " iner");
                    }
                    else if (on)
                    {
                        if (pComm.ToUpper().CompareTo("ON") != 0)
                            OnList.Add(pComm);
                        //MessageBox.Show(pComm + " on");
                    }
                }
                else
                {
                    MessageBox.Show("No empeiza con SELECT");
                    break;
                }
            }
        }
    }
}