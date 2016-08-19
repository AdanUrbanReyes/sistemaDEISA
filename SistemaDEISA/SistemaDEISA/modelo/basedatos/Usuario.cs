using System;

namespace SistemaDEISA.modelo.basedatos
{
    public class Usuario : Copia
    {
        public Usuario() {
            ;
        }
        public string cuenta { set; get; }
        public string clave { set; get; }
        public string nombres { set; get; }
        public string primer_apellido { set; get; }
        public string segundo_apellido { set; get; }
        public char estatus { set; get; }
        public DateTime inicio { set; get; }
        public string departamento { set; get; }
        public string foto { set; get; }
        public string puesto { set; get; }

        public override string ToString()
        {
            return this.cuenta;
        }
    }
}
