using System;

namespace SistemaDEISA.modelo.basedatos
{
    public class Departamento : Copia
    {
        public Departamento() { 
            ;
        }
        public string abreviatura { set; get; }
        public string significado { set; get; }
        public string encargado { set; get; }
        public override string ToString()
        {
            return significado;
        }
    }
}
