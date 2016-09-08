using System;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo.basedatos
{
    public class Telefono_cliente : Copia,IEquatable<Telefono_cliente>
    {
        public Telefono_cliente() {
            ;
        }
        public bool Equals(Telefono_cliente telefono)
        {
            return (telefono != null && telefono.telefono == this.telefono) ? true : false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }
            Telefono_cliente telefonoCliente = obj as Telefono_cliente;
            return (telefonoCliente == null) ? false : Equals(telefonoCliente);
        }
        public string razon_social { set; get; }
        public string planta { set; get; }
        public string telefono { set; get; }
        public string tipo { set; get; }
    }
}
