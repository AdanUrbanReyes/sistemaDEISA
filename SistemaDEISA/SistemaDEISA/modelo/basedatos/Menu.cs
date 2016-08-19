using System;

namespace SistemaDEISA.modelo.basedatos
{
    public class Menu : Copia
    {
        public Menu() {
            ;
        }
        public string nombre {set; get;}
        public string texto {set; get;}
        public string imagen {set; get;}
        public string es_submenu_de { set; get; }
        public string descripcion { set; get; }
    }
}
