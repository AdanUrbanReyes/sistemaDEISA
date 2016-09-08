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

        public bool terminarTransaccion()
        {
            return conexionBasedatos.terminarTransaccion();
        }
    }
}
