﻿using System;
using System.IO;
using System.Collections.Generic;
using SistemaDEISA.modelo.basedatos;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo
{
    /// <summary>
    /// Encargada de validar el inicio de sesion de algun usuario, ademas de iniciar la
    /// conexion con la base de datos.
    /// </summary>
    public class InicioSesion_modelo
    {
        private static string pathIPPublicaServidorMysql = @"C:\sistemaDEISA\conexionBasedatos\ipPublicaServidorMysql.dat";
        private static string pathIPPrivadaServidorMysql = @"C:\sistemaDEISA\conexionBasedatos\ipPrivadaServidorMysql.dat";

        //private static string pathCodigoPostal = @"C:\Users\Ayan\Downloads\CPdescargatxt\CPdescarga.txt";
        private static string servidorDNSMysql = "deisacv.dlinkddns.com";
        private ConexionBasedatos conexionBasedatos;
        
        /*
        public void insertaCodigosPostales(){
            string linea = null;
            string[] codigoPostal = null;
            StreamReader archivo;
            try
            {
                archivo = new StreamReader(pathCodigoPostal, System.Text.Encoding.Default, false);
                while ((linea = archivo.ReadLine()) != null )
                {
                    codigoPostal = linea.Split('|');
                    conexionBasedatos.ejecutaSentenciaIUD("INSERT INTO codigo_postal VALUE (" + codigoPostal[0] + ",'" + Mysql.escapaSQL(codigoPostal[4]) + "','" + Mysql.escapaSQL(codigoPostal[3]) + "','" + Mysql.escapaSQL(codigoPostal[1]) + "');");
//conexionBasedatos.ejecutaSentenciaIUD("INSERT INTO codigo_postal_colonia VALUE ("+ codigoPostal[0] +",'"+Mysql.escapaSQL(codigoPostal[1])+"');");

//                  Console.WriteLine("INSERT INTO codigo_postal VALUE (" + codigoPostal[0] + ",'" + Mysql.escapaSQL(codigoPostal[4]) + "','" + Mysql.escapaSQL(codigoPostal[3]) + "');");
  //                  Console.WriteLine("INSERT INTO codigo_postal_colonia VALUE (" + codigoPostal[0] + ",'" + Mysql.escapaSQL(codigoPostal[1]) + "');");                    

                    Console.WriteLine("codigoPostal = " + codigoPostal[0]);
                    Console.WriteLine("colonia = " + codigoPostal[1]);
                    Console.WriteLine("municipio = " + codigoPostal[3]);
                    Console.WriteLine("estado = " + codigoPostal[4]);
                }
                archivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR al leer linea del archivo "+ e.ToString());
            }
            //conexionBasedatos.terminarTransaccion();
        }
        */

        /// <summary>
        /// Trata de leer la primera linea de un archivo la cual deberia corresponder
        /// con una IP en caso de algun ERROR como no encontrar el archivo, se regresa
        /// una IP configurada por el programador
        /// </summary>
        /// <param name="pathIPServidorMysql">ruta absoluta del archivo donde se encuentra alojada en la primera linea una IP</param>
        /// <returns>IP leeida del archivo</returns>
        public static string obtenerIPServidorMysql(string pathIPServidorMysql)
        {
            string IP = null;
            try
            {
                StreamReader archivo = new StreamReader(pathIPServidorMysql);
                IP = archivo.ReadLine();
            }
            catch (Exception)
            {
                IP = servidorDNSMysql;
            }
            return IP;
        }
        
        /// <summary>
        /// Se trata de iniciar la conexion con la base de datos, los parametros
        /// (servidor,basedatos,usuario,clave y puerto) estan establecidos por 
        /// el programador es aqui en donde si se desea se puede cambiar esos parametros.
        /// Porque una ves establecida la conexion las siguientes llamadas a los metodos
        /// obtenerInstancia de la clase Mysql siempre regresaran la conexion que establecio
        /// este metodo. El metodo trata de leer la IP publica o privada para las conexiones
        /// remotas o locales respectiamente. En caso de no poder leer la IP del
        /// arhivo establecido por el programador este intenta conectarce remotamente mediante
        /// un servidor DNS.
        /// </summary>
        /// <param name="tipoConexion">Unicamente 2 posibles valores
        /// Local para conexiones dentro de la red en la que se encuentra
        /// el servidor de base de datos y Remota para conexiones fuera de la red.</param>
        /// <returns>true en caso de haber establecido la conexion y falso en caso contrario</returns>
        public bool trataIniciarConexionBasedatos(string tipoConexion)
        {
            string IP = null;
            if (tipoConexion == "Local")
            {
                IP = InicioSesion_modelo.obtenerIPServidorMysql(pathIPPrivadaServidorMysql);
                conexionBasedatos = new ConexionBasedatos(IP, "deisa", "root", "s1i3s7t1e1mas?", 3306);
            }
            else
            {
                IP = obtenerIPServidorMysql(pathIPPublicaServidorMysql);
                conexionBasedatos = new ConexionBasedatos(IP, "deisa", "root", "s1i3s7t1e1mas?", 3306);
            }
            if (conexionBasedatos.iniciarTransaccion())
            {
                return true;
            }
            else {
                conexionBasedatos = new ConexionBasedatos(servidorDNSMysql, "deisa", "root", "s1i3s7t1e1mas?", 3306);
            }
            return conexionBasedatos.iniciarTransaccion();
        }
        
        /// <summary>
        /// Valida el inicio de secion de los usuarios, en caso de exito abre la vista principal de lo contrario no
        /// </summary>
        /// <param name="cuenta">cuenta ingresada por el usuario</param>
        /// <param name="clave">clave ingresada por el usuario</param>
        /// <param name="tipoConexion">tipo de conexion ingresada por el usuario 
        /// deveria ser alguno de los siguientes valores: Local o Remota</param>
        /// <returns>El usuario si los datos son correctos o null si los datos son incorrectos o la conexion fallo</returns>
        public Usuario validaInicioSesion(string cuenta, string clave)
        {
            if (cuenta == null || clave == null || cuenta == string.Empty || clave == string.Empty)
            {
                return null;
            }
            List<object> usuarios = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM usuario WHERE cuenta='" + Mysql.escapaSQL(cuenta) + "' AND clave='" + Mysql.escapaSQL(clave) + "';"), new Usuario());
            if (usuarios == null || usuarios.Count == 0)
            {
                return null;
            }
            return (Usuario)usuarios[0];
        }

        public bool terminarTransaccion() {
            return (conexionBasedatos == null) ? true : conexionBasedatos.terminarTransaccion();
        }

    }
}
