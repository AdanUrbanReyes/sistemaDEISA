using System;
using System.Text;

namespace SistemaDEISA.modelo
{
    [Serializable]
    public class Copia : ICloneable
    {
        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}
