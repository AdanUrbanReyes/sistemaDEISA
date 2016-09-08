using System;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo.basedatos
{
    public class Correo_electronico_cliente : Copia,IEquatable<Correo_electronico_cliente>
    {
        public Correo_electronico_cliente() {
            ;
        }
        public bool Equals(Correo_electronico_cliente correo) {
            return (correo != null && correo.correo_electronico == this.correo_electronico) ? true : false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }
            Correo_electronico_cliente correoElectronicoCliente = obj as Correo_electronico_cliente;
            return (correoElectronicoCliente == null) ? false : Equals(correoElectronicoCliente);
        }
        public string razon_social { set; get; }
        public string planta { set; get; }
        public string correo_electronico { set; get; }
        public string tipo { set; get; }
    }
}
