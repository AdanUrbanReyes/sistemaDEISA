using System;

namespace SistemaDEISA.modelo.basedatos
{
    public class Modulo : Copia
    {
        public Modulo() { 
            ;
        }
        public string clase { set; get; }
        public string espacio_nombres { set; get; }
        public string menu { set; get; }
    }
}
