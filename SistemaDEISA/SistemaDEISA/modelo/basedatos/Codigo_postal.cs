using System;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo.basedatos
{
    public class Codigo_postal : Copia
    {
        public Codigo_postal() {
            id = Mysql.valorNoSeteadoInt;
            codigo_postal = Mysql.valorNoSeteadoInt;
        }

        public int id { set; get; }        
        public int codigo_postal { set; get; }
        public string estado { set; get; }
        public string municipio { set; get; }
        public string asentamiento { set; get; }
    }
}
