using System;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo.basedatos
{
    public class Cliente : Copia
    {
        public Cliente() {
            direccion = Mysql.valorNoSeteadoInt;
            proveedor = Mysql.valorNoSeteadoInt;
            sae = Mysql.valorNoSeteadoInt;
        }
        public string razon_social { set; get; }
        public string planta { set; get; }
        public string empresa { set; get; }
        public string giro { set; get; }
        public int direccion { set; get; }
        public string rfc { set; get; }
        public int proveedor { set; get; }
        public int sae { set; get; }
    }
}
