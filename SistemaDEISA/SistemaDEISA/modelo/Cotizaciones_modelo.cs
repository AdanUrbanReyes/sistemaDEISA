using System;
using System.Collections.Generic;
using SistemaDEISA.modelo.basedatos;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo
{
    public class Cotizaciones_modelo
    {
        private ConexionBasedatos conexionBasedatos;
        public Cotizaciones_modelo() {
            conexionBasedatos = new ConexionBasedatos();
            conexionBasedatos.iniciarTransaccion();
        }

        public string[] obtenerRazonesSociales()
        {
            object[] razonesSociales = Listas.aArreglo(Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT DISTINCT razon_social FROM cliente;")), 0);
            return (razonesSociales == null) ? null : Array.ConvertAll<object, string>(razonesSociales, delegate(object objeto) { return (string)objeto; });
        }

        public string[] obtenerPlantas(string razonSocial) {
            object[] plantas = Listas.aArreglo(Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT DISTINCT planta FROM cliente WHERE razon_social='"+Mysql.escapaSQL(razonSocial)+"';")),0);
            return (plantas == null) ? null : Array.ConvertAll<object, string>(plantas, delegate(object objeto) { return (string)objeto; });
        }

        public Cliente obtenerCliente(string razonSocial, string planta) {
            List<object> clientes = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM cliente WHERE razon_social = '"+Mysql.escapaSQL(razonSocial)+"' AND planta = '"+Mysql.escapaSQL(planta)+"';"),new Cliente());
            return (clientes == null) ? null : (Cliente)clientes[0];
        }

        public Direccion obtenerDireccion(int id)
        {
            List<object> direcciones = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM direccion WHERE id = " + id + ";"), new Direccion());
            return (direcciones == null) ? null : (Direccion)direcciones[0];
        }

        public Codigo_postal obtenerCodigoPostal(int id)
        {
            List<object> codigosPostales = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM codigo_postal WHERE id = " + id + ";"), new Codigo_postal());
            return (codigosPostales == null) ? null : (Codigo_postal)codigosPostales[0];
        }

        public DateTime obtenerFechaHoraActual() {
            return Mysql.fechaHoraActual(conexionBasedatos);
        }

        public bool terminarTransaccion()
        {
            return conexionBasedatos.terminarTransaccion();
        }
    }
}
