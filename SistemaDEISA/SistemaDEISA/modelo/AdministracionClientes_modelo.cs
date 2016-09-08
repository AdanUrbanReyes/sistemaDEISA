using System;
using System.Collections.Generic;
using SistemaDEISA.modelo.basedatos;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo
{
    public class AdministracionClientes_modelo
    {
        private ConexionBasedatos conexionBasedatos;
        public AdministracionClientes_modelo()
        {
            conexionBasedatos = new ConexionBasedatos();
            conexionBasedatos.iniciarTransaccion();
        }

        #region administracionDirecciones
        public string[] obtenerEstados()
        {
            List<object[]> estados_list = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT estado FROM codigo_postal GROUP BY estado;"));
            return (estados_list == null) ? null : Array.ConvertAll<object, string>(Listas.aArreglo(estados_list, 0), delegate(object objeto) { return (objeto == DBNull.Value) ? Mysql.valorNoSeteadoString : (string)objeto; });
        }

        public string[] obtenerMunicipios(string estado)
        {
            List<object[]> municipios_list = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT municipio FROM  codigo_postal WHERE estado = '" + Mysql.escapaSQL(estado) + "' GROUP BY municipio;"));
            return (municipios_list == null) ? null : Array.ConvertAll<object, string>(Listas.aArreglo(municipios_list, 0), delegate(object objeto) { return (objeto == DBNull.Value) ? Mysql.valorNoSeteadoString : (string)objeto; });
        }

        public string[] obtenerAsentamientos(string estado, string municipio)
        {
            List<object[]> asentamientos_list = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT asentamiento FROM  codigo_postal WHERE estado = '" + Mysql.escapaSQL(estado) + "' AND municipio = '" + Mysql.escapaSQL(municipio) + "' GROUP BY asentamiento;"));
            return (asentamientos_list == null) ? null : Array.ConvertAll<object, string>(Listas.aArreglo(asentamientos_list, 0), delegate(object objeto) { return (objeto == DBNull.Value) ? Mysql.valorNoSeteadoString : (string)objeto; });
        }

        public int[] obtenerID_CodigoPostal(string estado, string municipio, string asentamiento)
        {
            List<object[]> id_codigoPostal = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT id, codigo_postal FROM  codigo_postal WHERE estado = '" + Mysql.escapaSQL(estado) + "' AND municipio = '" + Mysql.escapaSQL(municipio) + "' AND asentamiento = '" + Mysql.escapaSQL(asentamiento) + "' LIMIT 1;"));
            return (id_codigoPostal == null) ? null : new int[] { (id_codigoPostal[0][0] == DBNull.Value) ? Mysql.valorNoSeteadoInt : (int)id_codigoPostal[0][0], (id_codigoPostal[0][1] == DBNull.Value) ? Mysql.valorNoSeteadoInt : (int)id_codigoPostal[0][1] };
        }

        public string[] obtenerCalles(int idCodigoPostal)
        {
            object[] calles_objectArray = Listas.aArreglo(Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT DISTINCT calle FROM direccion WHERE codigo_postal = " + idCodigoPostal + " ;")), 0);
            return (calles_objectArray == null) ? null : Array.ConvertAll<object, string>(calles_objectArray, delegate(object objeto) { return (string)objeto; });
        }

        public Codigo_postal obtenerCodigoPostal(int id)
        {
            List<object> codigosPostales = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM codigo_postal WHERE id = " + id + ";"), new Codigo_postal());
            return (codigosPostales == null) ? null : (Codigo_postal)codigosPostales[0];
        }

        #endregion administracionDirecciones

        public Direccion insertaDireccion(Direccion direccion)
        {
            string filtro = Mysql.generaFiltro(direccion, "AND");
            filtro = (filtro == null) ? "" : "WHERE " + filtro;
            if (Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT id FROM direccion " + filtro + ";")) == null)
            {
                conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(direccion));
            }
            return obtenerDireccion(direccion);
        }

        public string[] obtenerRazonesSociales() {
            object [] razonesSociales = Listas.aArreglo(Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT DISTINCT razon_social FROM cliente;")), 0);
            return (razonesSociales == null) ? null : Array.ConvertAll<object, string>(razonesSociales,delegate(object objeto) { return (string)objeto;});
        }

        public List<Telefono_cliente> obtenerTelefonos(string razonSocial, string planta) {
            List<object> telefonos = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM telefono_cliente WHERE razon_social = '"+Mysql.escapaSQL(razonSocial)+"' AND planta = '"+Mysql.escapaSQL(planta)+"';"), new Telefono_cliente());
            return (telefonos == null) ? new List<Telefono_cliente>() : telefonos.ConvertAll(new Converter<object, Telefono_cliente>(delegate(object objeto) { return (Telefono_cliente)objeto; }));
        }

        public List<Celular_cliente> obtenerCelulares(string razonSocial, string planta)
        {
            List<object> celulares = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM celular_cliente WHERE razon_social = '" + Mysql.escapaSQL(razonSocial) + "' AND planta = '" + Mysql.escapaSQL(planta) + "';"), new Celular_cliente());
            return (celulares == null) ? new List<Celular_cliente>() : celulares.ConvertAll(new Converter<object, Celular_cliente>(delegate(object objeto) { return (Celular_cliente)objeto; }));
        }

        public List<Correo_electronico_cliente> obtenerCorreos(string razonSocial, string planta)
        {
            List<object> correos = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM correo_electronico_cliente WHERE razon_social = '" + Mysql.escapaSQL(razonSocial) + "' AND planta = '" + Mysql.escapaSQL(planta) + "';"), new Correo_electronico_cliente());
            return (correos == null) ? new List<Correo_electronico_cliente>() : correos.ConvertAll(new Converter<object, Correo_electronico_cliente>(delegate(object objeto) { return (Correo_electronico_cliente)objeto; }));
        }

        public Direccion obtenerDireccion(int id) {
            List<object> direcciones = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM direccion WHERE id = "+id+";"),new Direccion());
            return (direcciones == null) ? null : (Direccion)direcciones[0];
        }

        public Direccion obtenerDireccion(Direccion direccion) { 
            List<object> direcciones=Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS(Mysql.generaSentenciaSelect(direccion)),new Direccion());
            return (direcciones == null) ? null : (Direccion)direcciones[0];
        }

        public Cliente obtenerCliente(string razonSocial,string planta) {
            List<object> clientes = Mysql.leerTuplas(conexionBasedatos.ejecutaSentenciaS("SELECT * FROM cliente WHERE razon_social = '"+Mysql.escapaSQL(razonSocial)+"' AND planta = '"+Mysql.escapaSQL(planta)+"';"),new Cliente());
            return (clientes == null) ? null : (Cliente)clientes[0];
        }

        public bool insertaCliente(Cliente cliente)
        {
            return conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(cliente));
        }

        public void insertaTelefonos(Cliente cliente, List<Telefono_cliente> telefonos) {
            int i;
            for (i = 0; i < telefonos.Count; i++)
            {
                telefonos[i].razon_social = cliente.razon_social;
                telefonos[i].planta = cliente.planta;
                conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(telefonos[i]));
            }
        }

        public void insertaCelulares(Cliente cliente, List<Celular_cliente> celulares) {
            int i;
            for (i = 0; i < celulares.Count; i++)
            {
                celulares[i].razon_social = cliente.razon_social;
                celulares[i].planta = cliente.planta;
                conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(celulares[i]));
            }
        }

        public void insertaCorreos(Cliente cliente, List<Correo_electronico_cliente> correos) {
            int i;
            for (i = 0; i < correos.Count; i++)
            {
                correos[i].razon_social = cliente.razon_social;
                correos[i].planta = cliente.planta;
                conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(correos[i]));
            }
        }

        public bool insertaCliente(Cliente cliente,List<Telefono_cliente> telefonos, List<Celular_cliente> celulares, List<Correo_electronico_cliente> correos)
        {
            if ( conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaInsertar(cliente)) ) {
                insertaTelefonos(cliente, telefonos);
                insertaCelulares(cliente, celulares);
                insertaCorreos(cliente, correos);
                return true;
            }
            return false;
        }

        public bool actualizaCliente(Cliente cliente, List<Telefono_cliente> telefonos, List<Celular_cliente> celulares, List<Correo_electronico_cliente> correos) {
            conexionBasedatos.ejecutaSentenciaIUD("DELETE FROM telefono_cliente WHERE razon_social = '"+cliente.razon_social+"' AND planta = '"+cliente.planta+"';");
            conexionBasedatos.ejecutaSentenciaIUD("DELETE FROM celular_cliente WHERE razon_social = '" + cliente.razon_social + "' AND planta = '" + cliente.planta + "';");
            conexionBasedatos.ejecutaSentenciaIUD("DELETE FROM correo_electronico_cliente WHERE razon_social = '" + cliente.razon_social + "' AND planta = '" + cliente.planta + "';");

            insertaTelefonos(cliente, telefonos);
            insertaCelulares(cliente, celulares);
            insertaCorreos(cliente, correos);

            return conexionBasedatos.ejecutaSentenciaIUD(Mysql.generaSentenciaUpdate(conexionBasedatos, cliente));
        }

        public bool terminarTransaccion()
        {
            return conexionBasedatos.terminarTransaccion();
        }
    }
}
