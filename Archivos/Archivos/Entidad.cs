using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Archivos
{
    public class Entidad
    {
        private static int TAM = 30; //tamaño del array de nombre
        private string sNombre; //nombre de la entidad
        private char[] Nombre; //nombre de la entidad por caracter
        private long dirEntidad, dirAtributo, dirDato, dirSigEntidad; //direcciones
        private string datos; //string de los datos de las entidades
        //private byte[] IdEntidad; //id de las identidades aleatoriamente

        /*Para los atributos*/
        public List<Atributo> atributos;

        /*Para los registros*/
        public List<Registro> registros = new List<Registro>();

        /*para los primarios*/
        public List<Primario> primarios = new List<Primario>();

        /*para los secundarios*/
        public List<Secundario> secundarios = new List<Secundario>();

        /*Para los arboles primarios*/
        public List<ArbolB> Arboles = new List<ArbolB>();

        /*Para los arboles secundarios*/
        // public List<ArbolB> ArbolSecundario = new List<ArbolB>();

        /*para indice hash*/
        public List<Secundario> hash = new List<Secundario>();

        /*para indice multilista*/
        public List<Primario> multilista = new List<Primario>();

        /*Constructor de una nueva identidad*/
        public Entidad(string sNombre)
        {
            this.sNombre = sNombre;
            Nombre = new char[TAM];
            dirEntidad = dirAtributo = dirDato = dirSigEntidad = -1;
            int i = 0;

            /*Se separa por caracter el nombre de la entidad*/
            foreach (char c in sNombre)
            {
                this.Nombre[i] = c;
                i++;
            }

            /*Se crea su lista de atributos*/
            atributos = new List<Atributo>();
        }

        /*Constructor para abrir una entidad*/
        public Entidad(char[] nc)
        //public Entidad(char[] nc, byte[] IdEntidad)
        {
            int i = 0, e = 0;
            //this.IdEntidad = IdEntidad;
            Nombre = nc;
            //sNombre = new string(nc);

            char[] aux = new char[TAM];
            char[] aux2;
            foreach (char c in Nombre)
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

            dirEntidad = dirAtributo = dirDato = dirSigEntidad = -1;
            //Nombre = nc;
            /*Se crea su lista de atributos*/
            atributos = new List<Atributo>();
        }

        /*Propiedades GET SET para los diferentes variables de la entidad (Clase)*/
        public long direccion_Entidad
        {
            get { return dirEntidad; }
            set { dirEntidad = value; }
        }

        public long direccion_Atributo
        {
            get { return dirAtributo; }
            set { dirAtributo = value; }
        }

        public long direccion_Dato
        {
            get { return dirDato; }
            set { dirDato = value; }
        }

        public long direccion_Siguiente
        {
            get { return dirSigEntidad; }
            set { dirSigEntidad = value; }
        }
        
        public char[] nombre_Entidad
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        
        public string string_Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }
        
        public string datos_Entidad
        {
            get { return datos; }
            set { datos = value; }
        }
/*
        public byte[] Id_Entidad
        {
            get { return IdEntidad; }
            set { IdEntidad = value; }
        }
        */

        /*Añadir atributos a la lista*/
        public void agregarAtributo(Atributo atribut)
        {
            atributos.Add(atribut);
        }
    }
}
