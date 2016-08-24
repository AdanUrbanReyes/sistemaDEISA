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

        public List<Menu> obtenerMenusAcceso(string cuenta) {
            List<object> menusAcceso = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("CALL menusAcceso('"+Mysql.escapaSQL(cuenta)+"');"), new Menu());
            return (menusAcceso == null) ? null : menusAcceso.ConvertAll(new Converter<object, Menu>(delegate(object objeto) { return (Menu)objeto; }));
        }

        public List<Menu> obtenerMenusSinAcceso(string cuenta)
        {
            List<object> menusAcceso = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("CALL menusSinAcceso('" + Mysql.escapaSQL(cuenta) + "');"), new Menu());
            return (menusAcceso == null) ? null : menusAcceso.ConvertAll(new Converter<object, Menu>(delegate(object objeto) { return (Menu)objeto; }));
        }

        public bool establecerMenuAcceso(string cuenta, string menu) {
            return (cuenta == null || menu == null) ? false : conexionBasedatos.ejecutaSentenciaIUD("INSERT INTO usuario_accesa_menu VALUE('"+Mysql.escapaSQL(cuenta)+"','"+Mysql.escapaSQL(menu)+"');");
        }

        public bool establecerMenusAcceso(string cuenta,List<Menu> menus) {
            int i;
            conexionBasedatos.ejecutaSentenciaIUD("DELETE FROM usuario_accesa_menu WHERE usuario = '" + Mysql.escapaSQL(cuenta) + "';");
            for (i = 0; i < menus.Count; i++)
            {
                establecerMenuAcceso(cuenta, menus[i].nombre);
            }
            return true;
        }

        public bool terminarTransaccion()
        {
            return conexionBasedatos.terminarTransaccion();
        }
    }
}
