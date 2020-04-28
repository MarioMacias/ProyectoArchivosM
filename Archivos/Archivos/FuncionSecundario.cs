using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archivos
{
    public class FuncionSecundario
    {
        private List<Entidad> entidades = new List<Entidad>();
        private FileStream Fichero;
        private string nombreArchivoDAT, nombreArchivoIDX, nombreArchivo;
        private int pos, indice2;

        BinaryWriter binaryWriter;
        BinaryReader binaryReader;

        public void escribirArchivoInddiceSecundario()
        {
            ///Primero escribimos nuestro indice de claves
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);
            
            binaryWriter = new BinaryWriter(Fichero);

            for (int s2 = 0; s2 < entidades[pos].secundarios.Count; ++s2)
            {
                for (int s1 = 0; s1 < entidades[pos].secundarios[s2].listSecD.Count; ++s1)
                {
                    string vs = entidades[pos].secundarios[s2].listSecD[s1].getClave.ToString();

                    if (entidades[pos].atributos[indice2].tipo_Dato == 'C')
                    {
                        char[] caracter = new char[entidades[pos].atributos[indice2].longitud_Tipo];
                        int j = 0;
                        foreach (char c in vs)
                        {
                            caracter[j] = c;
                            j++;
                        }
                        binaryWriter.Write(caracter);
                    }
                    else
                    {
                        if (entidades[pos].atributos[indice2].tipo_Dato == 'E')
                        {
                            //MessageBox.Show(vs);
                            int entero = int.Parse(vs);
                            binaryWriter.Write(entero);
                        }
                    }
                    //MessageBox.Show("Direccion1: " + entidades[pos].secundarios[s2].listSecD[s1].getDireccion);
                    binaryWriter.Write(entidades[pos].secundarios[s2].listSecD[s1].getDireccion);
                }
                binaryWriter.Write(entidades[pos].secundarios[s2].getApuntadorSig);
            }
            //MessageBox.Show("fichero 2: " + Fichero.Length);
            Fichero.Close();

            ///Despues escribiremos nuestro primer cajon de direcciones
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            //MessageBox.Show("fichero 1: " + Fichero.Length);
            //MessageBox.Show("fichero 3: " + Fichero.Length);
            Fichero.Position = Fichero.Length;

            //MessageBox.Show("Direccion2: " + entidades[pos].secundarios.Last().listSecD.First().getDireccion);
            entidades[pos].secundarios.Last().listSecD.First().getDireccion = Fichero.Length;

            //MessageBox.Show("Direccion3: " + entidades[pos].secundarios.Last().listSecD.First().getDireccion);
            binaryWriter = new BinaryWriter(Fichero);
            for (int s1 = 0; s1 < entidades[pos].secundarios[0].listSecD[0].listSecDirs[0].listIndiceSecundario.Count; ++s1)
            {
                binaryWriter.Write(entidades[pos].secundarios[0].listSecD[0].listSecDirs[0].listIndiceSecundario[s1].getDireccion);
            }
            binaryWriter.Write(entidades[pos].secundarios[0].listSecD[0].listSecDirs[0].getApSiguiente);
            Fichero.Close();
            
            ///Como ya sabemos donde insertaramos el primer cajon de datos, sobreescribimos
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);

            binaryWriter = new BinaryWriter(Fichero);

            for (int s2 = 0; s2 < entidades[pos].secundarios.Count; ++s2)
            {
                for (int s1 = 0; s1 < entidades[pos].secundarios[s2].listSecD.Count; ++s1)
                {
                    string vs = entidades[pos].secundarios[s2].listSecD[s1].getClave.ToString();

                    if (entidades[pos].atributos[indice2].tipo_Dato == 'C')
                    {
                        char[] caracter = new char[entidades[pos].atributos[indice2].longitud_Tipo];
                        int j = 0;
                        foreach (char c in vs)
                        {
                            caracter[j] = c;
                            j++;
                        }
                        binaryWriter.Write(caracter);
                    }
                    else
                    {
                        if (entidades[pos].atributos[indice2].tipo_Dato == 'E')
                        {
                            int entero = int.Parse(vs);
                            binaryWriter.Write(entero);
                        }
                    }
                    //MessageBox.Show("Direccion4: " + entidades[pos].secundarios[s2].listSecD[s1].getDireccion);
                    binaryWriter.Write(entidades[pos].secundarios[s2].listSecD[s1].getDireccion);
                }
                binaryWriter.Write(entidades[pos].secundarios[s2].getApuntadorSig);
            }
            Fichero.Close();
        }

        /*Poner nuevas direcciones en el archivo*/
        public void ponerDireccionIndice(int ind)
        {
            Fichero = File.Open(nombreArchivo, FileMode.Open);
            Fichero.Seek(entidades[pos].atributos[ind].direccion_Atributo, SeekOrigin.Begin);
            binaryWriter = new BinaryWriter(Fichero);

            //binaryWriter.Write(entidades[pos].atributos[ind].id_Atributo);
            binaryWriter.Write(entidades[pos].atributos[ind].nombre_Atributo);
            binaryWriter.Write(entidades[pos].atributos[ind].tipo_Dato);
            binaryWriter.Write(entidades[pos].atributos[ind].longitud_Tipo);
            binaryWriter.Write(entidades[pos].atributos[ind].direccion_Atributo);
            binaryWriter.Write(entidades[pos].atributos[ind].tipo_Indice);
            binaryWriter.Write(entidades[pos].atributos[ind].direccion_Indice);
            binaryWriter.Write(entidades[pos].atributos[ind].direccion_sigAtributo);
            Fichero.Close();
        }

        /**Se guarda la direccion del indice secundario*/
        public void asignarDireccionIndiceSecundario()
        {
            Fichero = File.Open(nombreArchivoIDX, FileMode.Open);
            entidades[pos].atributos[indice2].direccion_Indice = Fichero.Length;
            Fichero.Close();
        }

        /*Reescribir en el archivo de indices las iteraciones una vez ordenados*/
        public void reescribirCajones()
        {
            ///Solo reescribiremos cuando se ordene los cajones
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);

            binaryWriter = new BinaryWriter(Fichero);

            for (int s2 = 0; s2 < entidades[pos].secundarios.Count; ++s2)
            {
                for (int s1 = 0; s1 < entidades[pos].secundarios[s2].listSecD.Count; ++s1)
                {
                    string vs = entidades[pos].secundarios[s2].listSecD[s1].getClave.ToString();

                    if (entidades[pos].atributos[indice2].tipo_Dato == 'C')
                    {
                        char[] caracter = new char[entidades[pos].atributos[indice2].longitud_Tipo];
                        int j = 0;
                        foreach (char c in vs)
                        {
                            caracter[j] = c;
                            j++;
                        }
                        binaryWriter.Write(caracter);
                    }
                    else
                    {
                        if (entidades[pos].atributos[indice2].tipo_Dato == 'E')
                        {
                            int entero = int.Parse(vs);
                            binaryWriter.Write(entero);
                        }
                    }
                    binaryWriter.Write(entidades[pos].secundarios[s2].listSecD[s1].getDireccion);
                }
                binaryWriter.Write(entidades[pos].secundarios[s2].getApuntadorSig);
            }
            Fichero.Close();
        }

        /*Ordenar los datos por la clave de busqueda*/
        public void ordenarIndiceSecundario()
        {
            //MessageBox.Show("Hay "+ entidades[pos].secundarios.Last().listSecD.Count.ToString()+ " cajones iniciales");
            int cajones = entidades[pos].secundarios.Last().listSecD.Count;
            entidades[pos].secundarios.Last().listSecD.RemoveRange(entidades[pos].secundarios.Last().getIteracion, entidades[pos].secundarios.Last().listSecD.Count - entidades[pos].secundarios.Last().getIteracion);
            //MessageBox.Show("mierda esa: " + entidades[pos].secundarios.Last().listSecD.Last().getClave.ToString());
            entidades[pos].secundarios.Last().listSecD = entidades[pos].secundarios.Last().listSecD.OrderBy(x => x.getClave).ToList();
            int cajones2 = entidades[pos].secundarios.Last().listSecD.Count;
            
            for (int i = cajones2; i < cajones; ++i)
            {
                entidades[pos].secundarios.Last().AddIndice(-1);
            }
            //MessageBox.Show("Hay "+ entidades[pos].secundarios.Last().listSecD.Count.ToString()+ " cajones iniciales");
        }

        /*metodo para poder escribir en el archivo de indices los nuevos datos*/
        public void escribirIndice2Exist(int posicion)
        {
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);

            binaryWriter = new BinaryWriter(Fichero);

            for (int s2 = 0; s2 < entidades[pos].secundarios.Count; ++s2)
            {
                for (int s1 = 0; s1 < entidades[pos].secundarios[s2].listSecD.Count; ++s1)
                {
                    string vs = entidades[pos].secundarios[s2].listSecD[s1].getClave.ToString();

                    if (entidades[pos].atributos[indice2].tipo_Dato == 'C')
                    {
                        char[] caracter = new char[entidades[pos].atributos[indice2].longitud_Tipo];
                        int j = 0;
                        foreach (char c in vs)
                        {
                            caracter[j] = c;
                            j++;
                        }
                        binaryWriter.Write(caracter);
                    }
                    else
                    {
                        if (entidades[pos].atributos[indice2].tipo_Dato == 'E')
                        {
                            int entero = int.Parse(vs);
                            binaryWriter.Write(entero);
                        }
                    }
                    binaryWriter.Write(entidades[pos].secundarios[s2].listSecD[s1].getDireccion);
                }
                binaryWriter.Write(entidades[pos].secundarios[s2].getApuntadorSig);
            }
            Fichero.Close();

            ///Despues escribiremos nuestro primer cajon de direcciones de nuevo y asignaremos posicion para el nuevo cajon
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Position = Fichero.Length;
            entidades[pos].secundarios.Last().listSecD[posicion].getDireccion = Fichero.Length;

            binaryWriter = new BinaryWriter(Fichero);
            for (int s1 = 0; s1 < entidades[pos].secundarios[0].listSecD[posicion].listSecDirs[0].listIndiceSecundario.Count; ++s1) //el primero
            {
                binaryWriter.Write(entidades[pos].secundarios[0].listSecD[posicion].listSecDirs[0].listIndiceSecundario[s1].getDireccion);
            }
            binaryWriter.Write(entidades[pos].secundarios[0].listSecD[posicion].listSecDirs[0].getApSiguiente);
            Fichero.Close();


            ///Como ya sabemos donde insertaramos el primer cajon de datos, sobreescribimos
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write); //Se vuelve a abrir para asignar el seek
            Fichero.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);

            binaryWriter = new BinaryWriter(Fichero);

            for (int s2 = 0; s2 < entidades[pos].secundarios.Count; ++s2)
            {
                for (int s1 = 0; s1 < entidades[pos].secundarios[s2].listSecD.Count; ++s1)
                {
                    string vs = entidades[pos].secundarios[s2].listSecD[s1].getClave.ToString();

                    if (entidades[pos].atributos[indice2].tipo_Dato == 'C')
                    {
                        char[] caracter = new char[entidades[pos].atributos[indice2].longitud_Tipo];
                        int j = 0;
                        foreach (char c in vs)
                        {
                            caracter[j] = c;
                            j++;
                        }
                        binaryWriter.Write(caracter);
                    }
                    else
                    {
                        if (entidades[pos].atributos[indice2].tipo_Dato == 'E')
                        {
                            int entero = int.Parse(vs);
                            binaryWriter.Write(entero);
                        }
                    }
                    binaryWriter.Write(entidades[pos].secundarios[s2].listSecD[s1].getDireccion);
                }
                binaryWriter.Write(entidades[pos].secundarios[s2].getApuntadorSig);
            }
            Fichero.Close();
        }

        /*Reescribir en el archivo las direcciones*/
        public void reescribirDirecciones(int pos2)
        {
            //Solo empezaremos a escribir donde se encuentre la direccion de ese bloque
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Seek(entidades[pos].secundarios.Last().listSecD[pos2].getDireccion, SeekOrigin.Begin);

            binaryWriter = new BinaryWriter(Fichero);
            for (int s1 = 0; s1 < entidades[pos].secundarios[0].listSecD[pos2].listSecDirs[0].listIndiceSecundario.Count; ++s1)
            {
                binaryWriter.Write(entidades[pos].secundarios[0].listSecD[pos2].listSecDirs[0].listIndiceSecundario[s1].getDireccion);
            }
            binaryWriter.Write(entidades[pos].secundarios[0].listSecD[pos2].listSecDirs[0].getApSiguiente);
            Fichero.Close();
        }

        /*Metodo para buscar el bloque con la misma clave de busqueda*/
        public int buscarBloque(Registro r)
        {
            int res = -1;

            string vs2 = r.element_Registro[indice2].ToString();
            for (int i = 0; i < entidades[pos].secundarios.Last().getIteracion; ++i)
            {
                string vs = entidades[pos].secundarios.Last().listSecD[i].getClave.ToString();

                if (vs == vs2)
                {
                    res = i;
                }
            }
            return res;
        }
        
        /*Asignar en memoria datos del indice secundario*/ //checadoooooo
        public void asignarMemoriaIndice2()
        {
            bool ban = true;
            bool ban2 = true;
            object o = new object();
            long data = 0;
            long dir = 0;
            long temp;
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Read);
            binaryReader = new BinaryReader(Fichero);
            binaryReader.BaseStream.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);

            while (ban)
            {
                switch (entidades[pos].atributos[indice2].tipo_Dato)
                {
                    case 'E':
                        o = binaryReader.ReadInt32();
                        break;
                    case 'C':
                        char[] c = binaryReader.ReadChars(entidades[pos].atributos[indice2].longitud_Tipo);
                        o = new string(c);
                        break;
                }
                Secundario s1 = new Secundario(o);
                entidades[pos].secundarios.Add(s1);
                data = binaryReader.ReadInt64();
                entidades[pos].secundarios.Last().listSecD.Last().getClave = o;
                entidades[pos].secundarios.Last().listSecD.Last().getDireccion = data;
                entidades[pos].secundarios.Last().getIteracion += 1;

                temp = Fichero.Position;
                if (data != -1)
                {
                    binaryReader.BaseStream.Seek(data, SeekOrigin.Begin);

                    while (ban2)
                    {
                        dir = binaryReader.ReadInt64();
                        entidades[pos].secundarios.Last().listSecD.Last().agregarBloquesDirecciones(-1);
                        entidades[pos].secundarios.Last().listSecD.Last().listSecDirs.Last().listIndiceSecundario.Last().getDireccion = dir;
                        entidades[pos].secundarios.Last().listSecD.Last().listSecDirs.Last().getIteracion += 1;

                        for (int i = 1; i < numeroDeIteracion(8); ++i)
                        {
                            dir = binaryReader.ReadInt64();
                            entidades[pos].secundarios.Last().listSecD.Last().listSecDirs.Last().addIndice(-1);
                            entidades[pos].secundarios.Last().listSecD.Last().listSecDirs.Last().listIndiceSecundario.Last().getDireccion = dir;
                            if (dir != -1)
                            {
                                entidades[pos].secundarios.Last().listSecD.Last().listSecDirs.Last().getIteracion += 1;
                            }
                        }
                        dir = binaryReader.ReadInt64();
                        
                        entidades[pos].secundarios.Last().listSecD.Last().listSecDirs.Last().getApSiguiente = dir;
                        if (dir == -1)
                        {
                            ban2 = false;
                        }
                        else { binaryReader.BaseStream.Seek(dir, SeekOrigin.Begin); }
                    }
                }
                binaryReader.BaseStream.Seek(temp, SeekOrigin.Begin);
                for (int i = 1; i < numeroDeIteracion(entidades[pos].atributos[indice2].longitud_Tipo); ++i)
                {
                    switch (entidades[pos].atributos[indice2].tipo_Dato)
                    {
                        case 'E':
                            o = binaryReader.ReadInt32();
                            break;
                        case 'C':
                            char[] c = binaryReader.ReadChars(entidades[pos].atributos[indice2].longitud_Tipo);
                            o = new string(c);
                            break;
                    }
                    entidades[pos].secundarios.Last().AddIndice(o);
                    data = binaryReader.ReadInt64();
                    entidades[pos].secundarios.Last().listSecD.Last().getClave = o;
                    entidades[pos].secundarios.Last().listSecD.Last().getDireccion = data;

                    if (data != -1)
                    {
                        entidades[pos].secundarios.Last().getIteracion += 1;
                    }
                }
                //binaryReader.BaseStream.Seek(temp, SeekOrigin.Begin);
                data = binaryReader.ReadInt64();
                entidades[pos].secundarios.Last().getApuntadorSig = data;

                if (data == -1)
                {
                    ban = false;
                }
                else { binaryReader.BaseStream.Seek(data, SeekOrigin.Begin); }
            }
            Fichero.Close();
            //Leer todas la direcciones por separado
          
            for (int i = 1; i < entidades[pos].secundarios.Last().getIteracion; ++i)
            {
                Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Read);
                binaryReader = new BinaryReader(Fichero);
                binaryReader.BaseStream.Seek(entidades[pos].secundarios.Last().listSecD[i].getDireccion, SeekOrigin.Begin);

                for (int j = 0; j < numeroDeIteracion(8); ++j)
                {
                    dir = binaryReader.ReadInt64();
                    if (j == 0)
                    {
                        entidades[pos].secundarios.Last().listSecD[i].agregarBloquesDirecciones(-1);
                        entidades[pos].secundarios.Last().listSecD[i].listSecDirs.Last().listIndiceSecundario.Last().getDireccion = dir;
                        entidades[pos].secundarios.Last().listSecD[i].listSecDirs.Last().getIteracion += 1;
                    }
                    else
                    {
                        entidades[pos].secundarios.Last().listSecD[i].listSecDirs.Last().addIndice(-1);
                        entidades[pos].secundarios.Last().listSecD[i].listSecDirs.Last().listIndiceSecundario.Last().getDireccion = dir;
                        if (dir != -1)
                        {
                            entidades[pos].secundarios.Last().listSecD[i].listSecDirs.Last().getIteracion += 1;
                        }
                    }
                }
                dir = binaryReader.ReadInt64();
                Fichero.Close();
            }
        }

        /*Metodo para obtener el numero de iteracion que existe en el momento*/
        public int numeroDeIteracion(int ite)
        {
            int numIte = 0;
            int tam = 8 + ite;

            //MessageBox.Show("ite: " + ite);
              if (ite != 8)
              {
                //numIte = 2040 / (8 + ite);
                numIte = 1040 / tam;

                //numIte = ite / 1040;
                //numIte += 8;
                //int regis = 1040 / tam;
                //int regis = tam / 1040;
                //numIte = (regis * tam) + 8;
                // MessageBox.Show("num de ite: " + numIte); // Se muestra cuantos cajones puede haber

                //int tamA = 8 + (numIte * (ite + 8));

                // MessageBox.Show("Tam total: " + tamA);// Se muestra el tamaño total del archivo
            }
              if (ite == 8)
              {
                  //MessageBox.Show("entro?");
                  //numIte = 2040 / ite;
                  numIte = 1040 / ite;
              }
            //MessageBox.Show("regis: " + regis);
            MessageBox.Show("num ite: " + numIte);
            return numIte;
        }
        
        public int posicionIndice2
        {
            set { indice2 = value; }
        }

        public int posicionEntidad
        {
            set { pos = value; }
        }

        public List<Entidad> listEntidades
        {
            get { return entidades; }
            set { entidades = value; }
        }
        
        /*Ponemos el FilseStream y el nombre del archivo en las variables globales*/
        public void setNameFichero(FileStream Fichero, string nombreArchivoDAT, string nombreArchivoIDX, string nombreArchivo)
        {
            this.Fichero = Fichero;
            this.nombreArchivoDAT = nombreArchivoDAT;
            this.nombreArchivoIDX = nombreArchivoIDX;
            this.nombreArchivo = nombreArchivo;
        }

        /************************AQUI EMPIEZA HASH*******************************************/

        /*Asignar memoria al indice hash*/
        public void asignarMemoriaIndiceHash()
        {
            object o = new object();
            long data = 0;
            long dir = 0;
            int clave = 0;
            long temp;
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Read);
            binaryReader = new BinaryReader(Fichero);
            binaryReader.BaseStream.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);

            ///Creo los primeros 7 cajones
            Secundario s1 = new Secundario(-1);
            entidades[pos].hash.Add(s1);
            for (int i = 1; i < 7; ++i)
            {
                entidades[pos].hash.Last().AddIndice(-1);
            }

            ///Leo las 7 direcciones
            for (int i = 0; i < 7; ++i)
            {
                data = binaryReader.ReadInt64();
                entidades[pos].hash.Last().listSecD[i].getDireccion = data;
            }
            Fichero.Close();

            ///Despues leemos los bloques de clave y direccion recorriendo el diccionario 
            for (int i = 0; i < 7; i++)
            {
                if (entidades[pos].hash.Last().listSecD[i].getDireccion != -1)
                {
                    Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Read);
                    binaryReader = new BinaryReader(Fichero);
                    binaryReader.BaseStream.Seek(entidades[pos].hash.Last().listSecD[i].getDireccion, SeekOrigin.Begin);

                    int cant = numeroDeIteracion(entidades[pos].atributos[indice2].longitud_Tipo);
                    entidades[pos].hash.Last().listSecD[i].agregarBloquesDirecciones(-1);
                    for (int j = 1; j < cant; j++)
                    {
                        entidades[pos].hash.Last().listSecD[i].listSecDirs.Last().addIndice(-1);
                    }

                    for (int j = 0; j < cant; j++)
                    {
                        clave = binaryReader.ReadInt32();
                        entidades[pos].hash.Last().listSecD[i].listSecDirs.Last().listIndiceSecundario[j].getClave = clave;
                        data = binaryReader.ReadInt64();
                        entidades[pos].hash.Last().listSecD[i].listSecDirs.Last().listIndiceSecundario[j].getDireccion = data;
                        if (data != -1)
                        {
                            entidades[pos].hash.Last().listSecD[i].listSecDirs.Last().getIteracion += 1;
                        }
                    }
                    data = binaryReader.ReadInt64();
                    entidades[pos].hash.Last().listSecD[i].listSecDirs.Last().getApSiguiente = data;
                    Fichero.Close();
                }
            }
        }

        //Funcion en hash
        public int aplicarHash(string s)
        {
            int clave = int.Parse(s);

            int res = clave / 7;

            res = res * 7;

            return ((clave - res));
        }

        //asignar direcciones en las iteraciones de hash
        public void asignarDirCajH(int index)
        {
            Fichero = File.Open(nombreArchivoIDX, FileMode.Open);
            entidades[pos].hash.Last().listSecD[index].getDireccion = Fichero.Length;
            Fichero.Close();
        }

        //Escribir en el archivo 
        public void escribirDiccionarioHash()
        {
            ///Escribimos nuestro diccionario
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Seek(entidades[pos].atributos[indice2].direccion_Indice, SeekOrigin.Begin);

            binaryWriter = new BinaryWriter(Fichero);

            for (int s1 = 0; s1 < entidades[pos].hash.Last().listSecD.Count; ++s1)
            {
                binaryWriter.Write(entidades[pos].hash.Last().listSecD[s1].getDireccion);
            }
            Fichero.Close();
        }

        //Escribir en los cajones hash
        public void escribirCajonHash(int index)
        {
            Fichero = new FileStream(nombreArchivoIDX, FileMode.Open, FileAccess.Write);
            Fichero.Seek(entidades[pos].hash.Last().listSecD[index].getDireccion, SeekOrigin.Begin);

            binaryWriter = new BinaryWriter(Fichero);
            for (int s1 = 0; s1 < entidades[pos].hash.Last().listSecD[index].listSecDirs[0].listIndiceSecundario.Count; ++s1)
            {
                binaryWriter.Write(int.Parse(entidades[pos].hash.Last().listSecD[index].listSecDirs[0].listIndiceSecundario[s1].getClave.ToString()));
                binaryWriter.Write(entidades[pos].hash.Last().listSecD[index].listSecDirs[0].listIndiceSecundario[s1].getDireccion);
            }
            binaryWriter.Write(entidades[pos].hash.Last().listSecD[index].listSecDirs[0].getApSiguiente);
            Fichero.Close();
        }
    
        public void asignarDireIndH()
        {
            Fichero = File.Open(nombreArchivoIDX, FileMode.Open);
            entidades[pos].atributos[indice2].direccion_Indice = Fichero.Length;
            Fichero.Close();
            ponerDireccionIndice(indice2);
        }
    }
}
