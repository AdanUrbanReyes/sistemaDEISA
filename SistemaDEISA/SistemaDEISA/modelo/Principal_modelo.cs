using System;
using System.Collections.Generic;
using SistemaDEISA.modelo.basedatos;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo
{
    public class Principal_modelo
    {
        private ConexionBasedatos conexionBasedatos;

        public Principal_modelo() {
            conexionBasedatos = new ConexionBasedatos();
            conexionBasedatos.iniciarTransaccion();
        }
        
        public List<Menu> obtenerSubmenus(string subconjunto) {
            List<object> submenus = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM menu WHERE es_submenu_de = '" + Mysql.escapaSQL(subconjunto) + "';"), new Menu());
            return (submenus == null) ? null : submenus.ConvertAll(new Converter<object, Menu>(delegate(object objeto) { return (Menu)objeto; }));
        }

        public List<Usuario_accesa_menu> obtenerMenusAcceso(string usuario) {
            List<object> menusAcceso = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM usuario_accesa_menu WHERE usuario = '" + Mysql.escapaSQL(usuario) + "';"), new Usuario_accesa_menu()); 
            return (menusAcceso == null) ? null : menusAcceso.ConvertAll(new Converter<object, Usuario_accesa_menu>(delegate(object objeto) { return (Usuario_accesa_menu)objeto; }));
        }
        
        public Menu obtenerMenu(string menu) {
            List<object> menus = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM menu WHERE nombre = '" + Mysql.escapaSQL(menu) + "';"), new Menu());
            return (menus == null) ? null : (Menu)menus[0];
        }

        public Modulo obtenerModulo(string menu) {
            List<object> modulos = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM modulo WHERE menu = '" + Mysql.escapaSQL(menu) + "';"), new Modulo());
            return (modulos == null) ? null : (Modulo)modulos[0];
        }
        public bool terminarTransaccion() {
            return conexionBasedatos.terminarTransaccion();
        }
    }
}
