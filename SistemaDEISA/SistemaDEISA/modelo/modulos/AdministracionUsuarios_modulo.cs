using System;
using System.Windows.Forms;
using SistemaDEISA.vista;

namespace SistemaDEISA.modelo.modulos
{
    public class AdministracionUsuarios_modulo : Manejador
    {
        private void click(object objeto,EventArgs evento) {
            Principal_vista.agregaFormulario(AdministracionUsuarios_vista.obtenerInstancia());
        }

        public void establecerEscuchadores(ToolStripMenuItem item) {
            item.Click += new EventHandler(this.click);
        }
    }
}
