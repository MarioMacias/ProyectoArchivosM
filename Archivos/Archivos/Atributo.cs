using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public class Atributo
    {
        private static int TAM = 30;
        //private byte[] IdAtributo; //id de las identidades aleatoriamente
        private char[] nombre = new char[TAM]; //nombre del archivo para separar
        private string sNombre; //nombre del archivo en string
        private char tipoDato; //tipo de dato a asignar
        private int longitud; //longitud que tiene ese dato
        private long direccionAtributo; //direccion del atributo actual
        private int tipoIndice; //tipo de indice
        private long direccionIndice; //direccion del indice
        private long direccionSigAtributo; //direccion siguiente del atributo


        /*Constructor principal*/
        public Atributo(string sNombre, char tipoDato, int longitud, int tipoIndice)
        {
            this.sNombre = sNombre;
            this.tipoDato = tipoDato;
            this.longitud = longitud;
            direccionAtributo = -1;
            this.tipoIndice = tipoIndice;
            direccionIndice = -1;
            direccionSigAtributo = -1;

            this.nombre = new char[TAM];
            int i = 0;
            foreach (char c in sNombre)
            {
                this.nombre[i] = c;
                i++;
            }
        }

        /*Constructor para leer*/
        public Atributo(char[] nc, char tipoDato, int longitud)
        //public Atributo(byte[] IdAtributo, char[] nc, char tipoDato, int longitud)
        {
            //this.IdAtributo = IdAtributo;
            sNombre = new string(nc);
            //MessageBox.Show("Primer nombre : " + sNombre);
            nombre = nc;
            int i = 0, e = 0;
            char[] aux = new char[TAM];
            char[] aux2;
            foreach (char c in nombre)
            {
                if (c != '\0')
                {
                    aux[i] = c;
                    i++;
                    e++;
                }
            }
            aux2 = new char[e];

            for (int j = 0; j < e; j++)
            {
                aux2[j] = aux[j];
            }
            sNombre = new string(aux2);

            //MessageBox.Show("Segundo nombre: " + sNombre);
            this.tipoDato = tipoDato;
            this.longitud = longitud;
            direccionAtributo = -1;
            tipoIndice = 0;
            direccionIndice = -1;
            direccionSigAtributo = -1;
        }

        /*Propiedades GET SET para los diferentes variables de los atributos (Clase)*/
        /*public byte[] id_Atributo
        {
            get { return IdAtributo; }
            set { IdAtributo = value; }
        }*/

        public char[] nombre_Atributo
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string string_Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public char tipo_Dato
        {
            get { return tipoDato; }
            set { tipoDato = value; }
        }

        public long direccion_Atributo
        {
            get { return direccionAtributo; }
            set { direccionAtributo = value; }
        }

        public int longitud_Tipo
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public int tipo_Indice
        {
            get { return tipoIndice; }
            set { tipoIndice = value; }
        }

        public long direccion_Indice
        {
            get { return direccionIndice; }
            set { direccionIndice = value; }
        }

        public long direccion_sigAtributo
        {
            get { return direccionSigAtributo; }
            set { direccionSigAtributo = value; }
        }
    }
}
