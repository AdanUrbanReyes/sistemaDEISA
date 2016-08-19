using System;

namespace SistemaDEISA.modelo.basedatos
{
    public class Usuario_accesa_menu : Copia
    {
        public Usuario_accesa_menu() {
            ;
        }

        public string usuario { set; get; }
        public string menu { set; get; }
    }
}
