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
        
        public bool terminarTransaccion()
        {
            return conexionBasedatos.terminarTransaccion();
        }

    }
}
