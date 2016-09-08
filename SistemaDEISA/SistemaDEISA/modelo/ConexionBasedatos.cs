using System;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SistemaDEISA.modelo
{
    public class ConexionBasedatos
    {
        private static string servidor = "localhost";//"192.168.2.151";
        private static string basedatos = "deisa";//"deisa_db1";
        private static string usuario = "root";
        private static string clave = "A1y3a1n7?";//"";
        private static int puerto = 3306;

        private MySqlConnection conexion = null;
        private MySqlCommand comando = null;
        private MySqlTransaction transaccion = null;

        public ConexionBasedatos(string servidor, string basedatos, string usuario, string clave, int puerto)
        {
            ConexionBasedatos.servidor = servidor;
            ConexionBasedatos.basedatos = basedatos;
            ConexionBasedatos.usuario = usuario;
            ConexionBasedatos.clave = clave;
            ConexionBasedatos.puerto = puerto;
        }
        
        public ConexionBasedatos()
        {
            ;
        }

        public bool iniciarTransaccion() {
            try { 
                this.conexion = new MySqlConnection("SERVER=" + servidor + ";" + "DATABASE=" + basedatos + ";" + "UID=" + usuario + ";" + "PWD=" + clave + ";" + "PORT=" + puerto + ";");
                this.conexion.Open();
                this.comando = conexion.CreateCommand();
                this.transaccion = conexion.BeginTransaction();
                this.comando.Connection = this.conexion;
                this.comando.Transaction = transaccion;
            }catch(MySqlException msq){
                Console.WriteLine("ERROR al iniciar la transaccion\n\t"+msq.ToString());
                return false;
            }
            return true;
        }
        
        public bool terminarTransaccion() {
            bool transaccionTerminada = true;
            try {
                this.transaccion.Commit();
            }catch(Exception e){
                try {
                    this.transaccion.Rollback();
                }catch(MySqlException mse){
                    Console.WriteLine("ERROR al hacer roolback para la transaccion \n\t" + mse.ToString());
                }
                transaccionTerminada = false;
                Console.WriteLine("ERROR al hacer commit para la transaccion \n\t" + e.ToString());
            }
            finally
            {
                this.transaccion.Dispose();
                this.transaccion = null;
                this.comando.Dispose();
                this.comando = null;
                this.conexion.Close();
                this.conexion = null;
            }
            return transaccionTerminada;
        }

        public bool ejecutaSentenciaIUD(string sentencia) {
            try
            {
                this.comando.CommandText = sentencia;
                this.comando.ExecuteNonQuery();
                Console.WriteLine("Sentencia: " + this.comando.CommandText + " EXECUTADA");
            }
            catch (Exception e) {
                Console.WriteLine("ERROR al ejecutar\n\tsentencia MySQL:\n\t\t" + sentencia + "\n\t\t\t" + e.ToString());
                return false;
            }
            return true;
        }

        public MySqlDataReader ejecutaSentenciaS(string sentencia)
        {
            MySqlDataReader tuplas = null;
            try
            {
                this.comando.CommandText = sentencia;
                tuplas = this.comando.ExecuteReader();
                Console.WriteLine("Sentencia: " + this.comando.CommandText + " EXECUTADA");
            }
            catch (Exception e)
            {
                if (tuplas != null)
                {
                    tuplas.Close();
                    tuplas = null;
                }
                Console.WriteLine("ERROR al ejecutar\n\tsentencia MySQL:\n\t\t" + sentencia + "\n\t\t\t" + e.ToString());
            }
            return tuplas;
        }

        public string obtenerBasedatos()
        {
            return basedatos;
        }
    }
}
