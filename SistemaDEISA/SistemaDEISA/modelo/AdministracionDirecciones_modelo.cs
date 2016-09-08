using System;
using System.Collections.Generic;
using SistemaDEISA.modelo.basedatos;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo
{
    public class AdministracionDirecciones_modelo
    {
        private ConexionBasedatos conexionBasedatos;

        public AdministracionDirecciones_modelo() {
            conexionBasedatos = new ConexionBasedatos();
            conexionBasedatos.iniciarTransaccion();
        }

        public string[] obtenerEstados() {
            List<object[]> estados_list = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT estado FROM codigo_postal GROUP BY estado;"));
            return (estados_list == null) ? null : Array.ConvertAll<object, string>(Listas.aArreglo(estados_list, 0), delegate(object objeto) { return (objeto == DBNull.Value ) ? Mysql.valorNoSeteadoString : (string)objeto; } );
        }

        public string[] obtenerMunicipios(string estado) {
            List<object[]> municipios_list = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT municipio FROM  codigo_postal WHERE estado = '"+Mysql.escapaSQL(estado)+"' GROUP BY municipio;"));
            return (municipios_list == null) ? null : Array.ConvertAll<object, string>(Listas.aArreglo(municipios_list, 0), delegate(object objeto) { return (objeto == DBNull.Value) ? Mysql.valorNoSeteadoString : (string)objeto; });
        }

        public string[] obtenerAsentamientos(string estado, string municipio)
        {
            List<object[]> asentamientos_list = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT asentamiento FROM  codigo_postal WHERE estado = '"+Mysql.escapaSQL(estado)+"' AND municipio = '"+Mysql.escapaSQL(municipio)+"' GROUP BY asentamiento;"));
            return (asentamientos_list == null) ? null : Array.ConvertAll<object, string>(Listas.aArreglo(asentamientos_list, 0), delegate(object objeto) { return (objeto == DBNull.Value) ? Mysql.valorNoSeteadoString : (string)objeto; });
        }

        public int[] obtenerID_CodigoPostal(string estado, string municipio,string asentamiento)
        {
            List<object[]> id_codigoPostal = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT id, codigo_postal FROM  codigo_postal WHERE estado = '"+Mysql.escapaSQL(estado)+"' AND municipio = '"+Mysql.escapaSQL(municipio)+"' AND asentamiento = '"+Mysql.escapaSQL(asentamiento)+"' LIMIT 1;"));
            return (id_codigoPostal == null) ? null : new int[] { (id_codigoPostal[0][0] == DBNull.Value) ? Mysql.valorNoSeteadoInt : (int)id_codigoPostal[0][0], (id_codigoPostal[0][1] == DBNull.Value) ? Mysql.valorNoSeteadoInt : (int)id_codigoPostal[0][1] };
        }

        public string[] obtenerCalles(int idCodigoPostal) {
            object[] calles_objectArray = Listas.aArreglo(Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT DISTINCT calle FROM direccion WHERE codigo_postal = "+idCodigoPostal+" ;")),0);
            return (calles_objectArray == null) ? null : Array.ConvertAll<object, string>(calles_objectArray, delegate(object objeto) { return (string)objeto; });
        }

        public Codigo_postal obtenerCodigoPostal(int id) {
            List<object> codigosPostales = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM codigo_postal WHERE id = "+id+";"),new Codigo_postal());
            return (codigosPostales == null) ? null : (Codigo_postal)codigosPostales[0];
        }

        public bool insertaDireccion(Direccion direccion)
        {
            string filtro = Mysql.generaFiltro(direccion,"AND");
            filtro = (filtro == null) ? "" : "WHERE " + filtro ; 
            if(Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT id FROM direccion "+filtro+";")) == null){
                return conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(direccion));
            }
            return false;
        }

        public List<Direccion> obtenerDirecciones(Direccion direccion) {
            List<object> direcciones = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS(Mysql.generaSentenciaSelect(direccion)),new Direccion());
            return (direcciones == null) ? null : direcciones.ConvertAll(new Converter<object, Direccion>(delegate(object objeto) { return (Direccion)objeto; }));
        }

        public bool eliminarDireccion(Direccion direccion) {
            return conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaDelete(conexionBasedatos, direccion));
        }

        public bool terminarTransaccion()
        {
            return conexionBasedatos.terminarTransaccion();
        }

    }
}
