using System;
using SistemaDEISA.utilerias;

namespace SistemaDEISA.modelo.basedatos
{
    public class Celular_cliente : Copia,IEquatable<Celular_cliente>
    {
        public Celular_cliente() { 

        }
        public bool Equals(Celular_cliente celular) { 
            return (celular != null && celular.celular == this.celular) ? true : false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }
            Celular_cliente celularCliente = obj as Celular_cliente;
            return (celularCliente == null) ? false : Equals(celularCliente);
        }
        public string razon_social { set; get; }
        public string planta { set; get; }
        public string celular { set; get; }
        public string tipo { set; get; }

    }
}
