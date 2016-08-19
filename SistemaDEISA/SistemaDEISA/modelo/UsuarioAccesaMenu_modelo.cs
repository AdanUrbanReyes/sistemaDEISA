using System;
using System.Collections.Generic;
using SistemaDEISA.utilerias;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.modelo
{
    public class UsuarioAccesaMenu_modelo
    {
        private ConexionBasedatos conexionBasedatos;
        public UsuarioAccesaMenu_modelo() {
            conexionBasedatos = new ConexionBasedatos();
            conexionBasedatos.iniciarTransaccion();
        }

        public List<Usuario> obtenerUsuarios() {
            List<object> usuarios = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM usuario;"),new Usuario());
            return (usuarios == null) ? null : usuarios.ConvertAll(new Converter<object,Usuario>(delegate(object objecto){return (Usuario)objecto;}));
        }

        public Departamento obtenerDepartamento(string abreviatura)
        {
            List<object> departamentos = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM departamento WHERE abreviatura='" + Mysql.escapaSQL(abreviatura) + "';"), new Departamento());
            return (departamentos == null) ? null : (Departamento)departamentos[0];
        }

        public bool terminarTransaccion()
        {
            return conexionBasedatos.terminarTransaccion();
        }
    }
}
