using System;
using System.Collections.Generic;
using SistemaDEISA.modelo.basedatos;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo
{
    public class AdministracionUsuarios_modelo
    {
        private ConexionBasedatos conexionBasedatos;
        
        public AdministracionUsuarios_modelo() {
            conexionBasedatos = new ConexionBasedatos();
            conexionBasedatos.iniciarTransaccion();
        }
        
        public List<Departamento> obtenerDepartamentos() {
            List<object> departamentos = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM departamento;"),new Departamento());
            return (departamentos == null) ? null : departamentos.ConvertAll(new Converter<object, Departamento>(delegate(object objeto) { return (Departamento)objeto;}));
        }
        
        public string[] obtenerPuestos() {
            List<object> usuarios = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM usuario GROUP BY puesto;"), new Usuario());
            string[] puestos = null;
            if(usuarios != null){
                int i;
                puestos = new string[usuarios.Count];
                for (i = 0; i < usuarios.Count;i++ )
                {
                    puestos[i] = ((Usuario)usuarios[i]).puesto;
                }
            }
            return puestos;
        }
        
        public string[] obtenerEstatus()
        {
            List<object> usuarios = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM usuario GROUP BY estatus;"), new Usuario());
            string[] estatus = null;
            if (usuarios != null)
            {
                int i;
                estatus = new string[usuarios.Count];
                for (i = 0; i < usuarios.Count; i++)
                {
                    estatus[i] = ((Usuario)usuarios[i]).estatus.ToString();
                }
            }
            return estatus;
        }

        public string[] obtenerCuentasUsuario() {
            List<object> usuarios = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM usuario;"), new Usuario());
            string[] cuentas=null;
            if (usuarios != null) { 
                cuentas=new string[usuarios.Count];
                int i;
                for (i = 0; i < usuarios.Count; i++)
                {
                    cuentas[i] = ((Usuario)usuarios[i]).cuenta;
                }
            }
            return cuentas;
        }

        public Departamento obtenerDepartamento(string abreviatura) {
            List<object> departamentos = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM departamento WHERE abreviatura='" + Mysql.escapaSQL(abreviatura) + "';"), new Departamento());
            return (departamentos == null) ? null : (Departamento)departamentos[0];
        }

        public bool tieneLlavePrimariaSeteada(Usuario usuario) {
            return Mysql.tieneLlavePrimariaSeteada(usuario,Mysql.llavePrimariaDeUnaTabla(conexionBasedatos,conexionBasedatos.obtenerBasedatos(),usuario.GetType().Name.ToLower()));
        }

        public List<string> llavePrimaria(object objeto) {
            return Mysql.llavePrimariaDeUnaTabla(conexionBasedatos, conexionBasedatos.obtenerBasedatos(), objeto.GetType().Name.ToLower());
        }

        public Usuario insertaUsuario(Usuario usuario) {
            return (conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(usuario))) ? usuario : null;
        }

        public Usuario obtenerUsuario(string cuenta)
        {
            List<object> usuarios = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM usuario WHERE cuenta='" + Mysql.escapaSQL(cuenta) + "';"), new Usuario());
            return (usuarios == null) ? null : (Usuario)usuarios[0];
        }

        public Usuario modificarUsuario(Usuario usuario) {
            return (conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaUpdate(conexionBasedatos,usuario))) ? usuario :  null;
        }

        public Usuario eliminarUsuario(Usuario usuario)
        {
            return (conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaDelete(conexionBasedatos,usuario))) ? usuario : null;
        }

        public bool terminarTransaccion() {
            return conexionBasedatos.terminarTransaccion();
        }
    }
}
