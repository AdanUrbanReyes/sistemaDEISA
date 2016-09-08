using System;
using System.Reflection;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SistemaDEISA.modelo;

namespace SistemaDEISA.utilerias
{
    public class Mysql
    {
        public static string valorNoSeteadoString = null;
        public static char valorNoSeteadoChar = default(char);
        public static int valorNoSeteadoInt = Int32.MinValue;
        public static double valorNoSeteadoDouble = double.MinValue;
        public static DateTime valorNoSeteadoDateTime = default(DateTime);
        public static string formatoDateTime = "yyyy-MM-dd HH:mm:ss";

        public static string escapaSQL(string cadena) {
            return MySqlHelper.EscapeString(cadena);
        }

        /// <summary>
        /// Inserta el valor de un objeto en un string valido para SQL
        /// por ejemplo:
        /// si el objeto es string regresa el string entre ' ('el string')
        /// si el objeto es un char regresa el char entre ' ('el char')
        /// si el objeto es un int regresa el int como string ... etc
        /// si el objeto no esta seteado regresa null. Para saber si
        /// un objeto esta seteado se toman encuenta las variables estaticas
        /// valorNoSeteado* definidas en esta clase.
        /// </summary>
        /// <param name="objeto">objeto a convertir</param>
        /// <returns>cadena que representa el valor del objeto envuelto o no entre ' (notacion SQL)
        /// o null en caso de que el objeto sea null o no tenga su propiedad seteada</returns>
        public static string aSQL(object objeto)
        {
            if (objeto == null)
            {
                return null;
            }
            if (objeto is string && (string)objeto != Mysql.valorNoSeteadoString)
            {
                return "'" + MySqlHelper.EscapeString((string)objeto) + "'";
            }
            if (objeto is char && (char)objeto != Mysql.valorNoSeteadoChar) 
            {
                return "'" + (char)objeto + "'";
            }
            if (objeto is int && (int)objeto != Mysql.valorNoSeteadoInt) 
            {
                return "" + (int)objeto;
            }
            if (objeto is double && (double)objeto != Mysql.valorNoSeteadoDouble)
            {
                return "" + (double)objeto;
            }
            if (objeto is DateTime && (DateTime)objeto != Mysql.valorNoSeteadoDateTime)
            {
                return "'" + MySqlHelper.EscapeString(((DateTime)objeto).ToString(formatoDateTime)) + "'";
            }
            return null;
        }

        /// <summary>
        /// Establece el valor para el atributo del objeto.
        /// Si el valor es DBNull.Value o es null se le asigna
        /// algun valor de las variables estaticas valorNoSeteado* 
        /// de esta clase.
        /// </summary>
        /// <param name="objeto">objeto al cual se le asignara valor a uno de sus atributos</param>
        /// <param name="atributo">atributo del objeto que se asignara su valor</param>
        /// <param name="valor">valor a asignar al atributo del objeto</param>
        public static void establecerValor(object  objeto, PropertyInfo atributo, object valor)
        {
            try
            {
                if (atributo.PropertyType == typeof(string))
                {
                    atributo.SetValue(objeto, (valor == DBNull.Value || valor == null) ? valorNoSeteadoString : valor.ToString(), null);
                }
                if (atributo.PropertyType == typeof(char))
                {
                    atributo.SetValue(objeto, (valor == DBNull.Value || valor == null) ? valorNoSeteadoChar : Convert.ToChar(valor), null);
                }
                if (atributo.PropertyType == typeof(int))
                {
                    atributo.SetValue(objeto, (valor == DBNull.Value || valor == null) ? valorNoSeteadoInt : (int)valor, null);
                }
                if (atributo.PropertyType == typeof(double))
                {
                    atributo.SetValue(objeto, (valor == DBNull.Value || valor == null) ? valorNoSeteadoDouble : (double)valor, null);
                }
                if (atributo.PropertyType == typeof(DateTime))
                {
                    atributo.SetValue(objeto, (valor == DBNull.Value || valor == null) ? valorNoSeteadoDateTime : (DateTime)valor, null);
                }
            }catch(Exception e){
                Console.WriteLine("Excepcion en la clase "+typeof(Mysql)+" en el metodo establecerValor "+e.ToString());
            }
        }

        /// <summary>
        /// Establece los valores para los atributos del objeto recivido; en base
        /// a las columnas que tenga el MySqlDataReader si alguna columna del MySqlDataReader
        /// no coincide con un atributo del objeto este solo se omite y no se establece su
        /// atributo.
        /// </summary>
        /// <param name="objeto">objeto a ser llenado con la informacion del MySqlDataReader</param>
        /// <param name="tuplas">MySqlDataReader que contiene la tupla a leer</param>
        /// <returns>Un objeto con los atributos seteados o null en caso de que el MySqlDataReader sea null o el objeto</returns>
        public static object llena(object objeto, MySqlDataReader tuplas) {
            if (tuplas == null || objeto == null) {
                return null;
            }
            int i;
            for (i = 0; i < tuplas.FieldCount; i++) {
                establecerValor(objeto, objeto.GetType().GetProperty(tuplas.GetName(i)),tuplas[i]);
            }
            return objeto;
        }

        public static bool tieneLlavePrimariaSeteada(object objeto, List<string> llavePrimaria) {
            if (llavePrimaria == null || objeto == null) {
                return false;
            }
            int i;
            for (i = 0; i < llavePrimaria.Count; i++)
            {
                try{
                    if(aSQL(objeto.GetType().GetProperty(llavePrimaria[i]).GetValue(objeto,null)) == null){
                        return false;
                    }
                }catch(Exception ){
                    return false;
                }
                
            }
            return true;
        }

        /// <summary>
        /// Pasa los atributos del objeto recivido a un nuevo objeto del mismo tipo;
        /// Los atributos que se toman en cuenta son los que esten en la lista recivida.
        /// Si el atributo no existe entonces se lo salta. Este metodo no des-setea
        /// los atributos del objeto recivido
        /// </summary>
        /// <param name="objeto">objeto que deberia contener los atributos que tiene la lista recivida</param>
        /// <param name="atributos">lista de atributos que deveria coinsidir con los del objeto recivido</param>
        /// <returns>objeto con los atributos de la lista seteados en vase al valor del objeto recivido</returns>
        public static object pasaAtributos(object objeto, List<string> atributos) {
            if (objeto == null || atributos == null) {
                return null;
            }
            object copia = Activator.CreateInstance(objeto.GetType());
            int i;
            for (i = 0; i < atributos.Count; i++)
            {
                try
                {
                    copia.GetType().GetProperty(atributos[i]).SetValue(copia, objeto.GetType().GetProperty(atributos[i]).GetValue(objeto, null), null);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excepcion en la clase "+typeof(Mysql)+" en el metodo pasaAtributos " + e.ToString());
                }
            }
            return copia;
        }

        /// <summary>
        /// quita el valor puesto en cada atributo del objeto, basandoce en la lista
        /// de atributos recividos. Si el atributo no existe se lo salta.
        /// </summary>
        /// <param name="objeto">objeto a desSetear atributos</param>
        /// <param name="atributos">lista de atributos del objeto; estos deberian existir en el objeto</param>
        /// <returns>objeto con los valores deseteados</returns>
        public static object desSeteaAtributos(object objeto, List<string> atributos)
        {
            if (objeto == null || atributos == null)
            {
                return null;
            }
            int i;
            for (i = 0; i < atributos.Count; i++)
            {
                Mysql.establecerValor(objeto, objeto.GetType().GetProperty(atributos[i]), null);
            }
            return objeto;
        }
        
        /// <summary>
        /// Obtiene la clave primaria de una tabla en la base de datos
        /// </summary>
        /// <param name="conexionBasedatos">Referencia a una instancia de conexionBasedatos para poder obener la llave</param>
        /// <param name="nombreBasedatos">Nombre de la base de datos o esquema de la base de datos</param>
        /// <param name="nombreTabla">Nombre de la tabla que se encuentra en el esquema</param>
        /// <returns>Lista de cadenas que representan los atributos que conforman la clave primaria</returns>
        public static List<string> llavePrimariaDeUnaTabla(ConexionBasedatos conexionBasedatos, string nombreBasedatos, string nombreTabla)
        {
            if (conexionBasedatos==null || nombreBasedatos == null || nombreTabla == null || nombreBasedatos == string.Empty || nombreTabla == string.Empty)
            {
                return null;
            }
            MySqlDataReader tuplas = conexionBasedatos.ejecutaSentenciaS("call llave_primaria_de_una_tabla(\"" + Mysql.escapaSQL(nombreBasedatos) + "\",\"" + Mysql.escapaSQL(nombreTabla) + "\");");
            if (tuplas == null) {
                return null;
            }
            List<string> llavePrimaria = null;
            if (tuplas.HasRows)
            {
                llavePrimaria = new List<string>();
                while (tuplas.Read())
                {
                    llavePrimaria.Add(tuplas["column_name"].ToString());
                }
            }
            tuplas.Close();
            return llavePrimaria;
        }

        /// <summary>
        /// Geneara el filtro para las sentencias de tipo
        /// SELECT, UPDATE, DELETE; para las tres ayuda en la parte
        /// del filtro WHERE y para UPDATE ademas del filtro
        /// para la puesta de valores por ejemplo:
        /// SELECT * FROM tabla WHERE filtro;
        /// UPDATE tabla SET puesta de valores WHERE filtro;
        /// DELETE FROM tabla WHERE filtro;
        /// Se tienen en cuenta unicamente los valores seteados del objeto recivido.
        /// Se puede agregar mas tipos de datos a tomar en cuenta en el filtro
        /// </summary>
        /// <param name="objeto">Objeto que deveria representar una tabla en la base de datos
        /// es decir el nombre de la clase a la que pertenece el objeto deberia corresponder
        /// con el nombre de la tabla (el nombre de la clase se pasa atrabes de la funcion toLower())
        /// a la que hace referencia asi como cada atributo de 
        /// este objeto deberia tener EXACTAMENTE el mismo nombre del atributo en la tabla
        /// de la base de datos</param>
        /// <param name="separador">Separador entre cada propiedad del objeto y valor de la propiedad</param>
        /// <returns>cadena que representa el filtro generado o null en caso de que el 
        /// objeto recivido sea null o que el objeto no tenga ninguna propiedad o propiedad seteada</returns>
        public static string generaFiltro(object objeto, string separador)
        {
            if (objeto == null)
            {
                return null;
            }
            string filtro = string.Empty;
            PropertyInfo[] propiedades = objeto.GetType().GetProperties();
            string valorPropiedadSQL;
            foreach (PropertyInfo propiedad in propiedades)
            {
                valorPropiedadSQL = Mysql.aSQL(propiedad.GetValue(objeto, null));
                if (valorPropiedadSQL != null) {
                    filtro += propiedad.Name + " = " + valorPropiedadSQL + " " + separador + " ";
                }
            }
            return (filtro == string.Empty) ? null : filtro.Substring(0, filtro.LastIndexOf(" " + separador + " "));
        }

        /// <summary>
        /// Genera la una sentencia SQL valida para insertar en la base de datos
        /// el el objeto recivido por parametro.
        /// Se tienen en cuenta unicamente los valores seteados del objeto recivido.
        /// Se puede agregar mas tipos de datos a tomar en cuenta
        /// </summary>
        /// <param name="objeto">Objeto que deveria representar una tabla en la base de datos
        /// es decir el nombre de la clase a la que pertenece el objeto deberia corresponder
        /// con el nombre de la tabla (el nombre de la clase se pasa atrabes de la funcion toLower())
        /// a la que hace referencia asi como cada atributo de 
        /// este objeto deberia tener EXACTAMENTE el mismo nombre del atributo en la tabla
        /// de la base de datos</param>
        /// <returns>cadena que representa sentencia INSERT generada o null en caso de que el 
        /// objeto recivido sea null o que el objeto no tenga ninguna propiedad o propiedad seteada</returns>
        public static string generaSentenciaInsertar(object objeto)
        {
            if (objeto == null)
            {
                return null;
            }
            string atributos = string.Empty;
            string valores = string.Empty;
            PropertyInfo[] propiedades = objeto.GetType().GetProperties();
            string valorPropiedadSQL = null;
            foreach (PropertyInfo propiedad in propiedades)
            {
                valorPropiedadSQL = Mysql.aSQL(propiedad.GetValue(objeto, null));
                if (valorPropiedadSQL != null) {
                    atributos += propiedad.Name + ",";
                    valores += valorPropiedadSQL + ",";
                }
            }
            if (atributos == string.Empty || valores == string.Empty)
            {
                return null;
            }
            atributos = atributos.Remove(atributos.Length - 1);
            valores = valores.Remove(valores.Length - 1);
            return "INSERT INTO " + objeto.GetType().Name.ToLower() + " (" + atributos + ") VALUE (" + valores + ");";
        }

        /// <summary>
        /// Trata de leer las informacion  (tuplas) regresadas por una llamada previa
        /// al metodo ejecutarSentencia y insertarlos en una lista de objetos del
        /// tipo del objeto recivido
        /// </summary>
        /// <param name="tuplas">MySqlDataReader que representa las tuplas regresadas
        /// por una llamada al metodo ejecutarSentencia</param>
        /// <param name="objeto">Objeto que deveria representar una tabla en la base de datos
        /// es decir el nombre de la clase a la que pertenece el objeto deberia corresponder
        /// con el nombre de la tabla (el nombre de la clase se pasa atrabes de la funcion toLower())
        /// a la que hace referencia asi como cada atributo de 
        /// este objeto deberia tener EXACTAMENTE el mismo nombre del atributo que contiene
        /// la "tabla" del objeto tuplas recivido. El objeto deve extender de la clase Copia
        /// para poder ser clonable</param>
        /// <returns>Lista de objetos del mismo tipo del objeto recivido con cada tupla leida o
        /// null en caso de que tuplas u objeto sea null o que tuplas no tenga ninguna tupla por leer</returns>
        public static List<object> leerTuplas(MySqlDataReader tuplas, object objeto)
        {
            if (tuplas == null || objeto == null)
            {
                return null;
            }
            PropertyInfo[] propiedades = objeto.GetType().GetProperties();
            List<object> objetos = null;
            try
            {
                if (tuplas.HasRows)
                {
                    objetos = new List<object>();
                    while (tuplas.Read())
                    {
                        objetos.Add(((modelo.Copia)llena(objeto, tuplas)).Clone());
                    }
                }
            }
            catch (MySqlException mse)
            {
                Console.WriteLine("ERROR al leer tuplas de la tabla " + objeto.GetType().Name.ToLower() + "\n" + mse.ToString());
            }
            tuplas.Close();
            return objetos;
        }

        public static List<object[]> leerTuplas(MySqlDataReader tuplas) { 
            if(tuplas == null){
                return null;
            }
            List<object[]> cadenas = null;
            int i;
            try
            {
                if (tuplas.HasRows)
                {
                    cadenas = new List<object[]>();
                    while (tuplas.Read())
                    {
                        object []valores=new object [tuplas.FieldCount];
                        for (i = 0; i < tuplas.FieldCount; i++) {
                            valores[i] = tuplas[i];
                        }
                        cadenas.Add(valores);
                    }
                }
            }
            catch (MySqlException mse)
            {
                Console.WriteLine("ERROR al leer tuplas para List<string[]>\n" + mse.ToString());
            }
            tuplas.Close();
            return cadenas;
        }

        public static string generaSentenciaSelect(object objeto) {
            if (objeto == null)
            {
                return null;
            }
            string filtro = Mysql.generaFiltro(objeto, "AND");
            return (filtro == null) ? "SELECT * FROM " + objeto.GetType().Name.ToLower() + ";" : "SELECT * FROM " + objeto.GetType().Name.ToLower() + " WHERE " + filtro+";";
        }

        public static string generaSentenciaUpdate(ConexionBasedatos conexionBasedatos, object objeto)
        {
            if (objeto == null || conexionBasedatos == null) {
                return null;
            }
            string nombreTabla = objeto.GetType().Name.ToLower();
            List<string> llavePrimaria = Mysql.llavePrimariaDeUnaTabla(conexionBasedatos,conexionBasedatos.obtenerBasedatos(), nombreTabla);
            if (llavePrimaria == null || Mysql.tieneLlavePrimariaSeteada(objeto, llavePrimaria) == false)
            {
                return null;
            }
            string filtro = generaFiltro(Mysql.pasaAtributos(objeto, llavePrimaria), "AND");
            string actualizacion = generaFiltro(Mysql.desSeteaAtributos(objeto,llavePrimaria), ",");
            if (actualizacion == null || filtro == null)
            {
                return null;
            }
            return "UPDATE " + nombreTabla + " SET " + actualizacion + " WHERE " + filtro + ";";
        }

        public static string generaSentenciaDelete(ConexionBasedatos conexionBasedatos, object objeto)
        {
            if (objeto == null || conexionBasedatos == null)
            {
                return null;
            }
            string nombreTabla = objeto.GetType().Name.ToLower();
            List<string> llavePrimaria = Mysql.llavePrimariaDeUnaTabla(conexionBasedatos, conexionBasedatos.obtenerBasedatos(), nombreTabla);
            if (llavePrimaria == null)
            {
                return null;
            }
            string filtro = string.Empty;
            if (Mysql.tieneLlavePrimariaSeteada(objeto, llavePrimaria))
            {
                filtro = generaFiltro(Mysql.pasaAtributos(objeto,llavePrimaria), "AND");
            }
            else {
                filtro = generaFiltro(objeto, "AND");
            }
            if (filtro == null || filtro == string.Empty)
            {// con esto no se permitira elimiar todo afurezas necesita un filtro
                return null;
            }
            return "DELETE FROM " + nombreTabla + " where " + filtro + ";";
        }
    }
}
