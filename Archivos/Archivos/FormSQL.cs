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

        public FormSQL(FormEntidad formEntidad, FileStream Fichero, string nombreArchivo, List<Entidad> entidades)
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            if (rtb_Comando.Text != "")
            {
                verificaCodigo(rtb_Comando.Text);
            }
        }
        private void verificaCodigo(string comand)
        {
            comando = new List<string>();
            string palabra = "";

            for(int i = 0; i < comand.Length; i++)
            {
                if (comand.Substring(i, 1).CompareTo(";") == 0)
                {
                    comando.Add(palabra);
                    break;
                }
                palabra += comand.Substring(i, 1);
                if (comand.Substring(i, 1).CompareTo(" ") == 0)
                {
                    comando.Add(palabra);
                    palabra = "";
                }
            }
            for (int i = 0; i < comando.Count; i++)
            {
                MessageBox.Show(comando[i]);
            }
        }
    }
}
