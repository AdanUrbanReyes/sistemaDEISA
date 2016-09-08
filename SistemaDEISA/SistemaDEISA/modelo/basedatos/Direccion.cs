using System;
using SistemaDEISA.utilerias;
namespace SistemaDEISA.modelo.basedatos
{
    public class Direccion : Copia
    {
        public Direccion() {
            id = Mysql.valorNoSeteadoInt;
            codigo_postal = Mysql.valorNoSeteadoInt;
            numero_exterior = Mysql.valorNoSeteadoInt;
            numero_interior = Mysql.valorNoSeteadoInt;
        }

        public int id { set; get; }

        public string calle { set; get; }

        public int numero_exterior { set; get; }

        public int numero_interior { set; get; }

        public int codigo_postal { set; get; }

    }
}
