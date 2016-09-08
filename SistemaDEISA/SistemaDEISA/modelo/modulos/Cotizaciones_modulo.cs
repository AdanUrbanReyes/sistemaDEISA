using System;
using System.Windows.Forms;
using SistemaDEISA.vista;

namespace SistemaDEISA.modelo.modulos
{
    public class Cotizaciones_modulo : Manejador
    {
        private void click(object objeto, EventArgs evento)
        {
            Principal_vista.agregaFormulario(Cotizaciones_vista.obtenerInstancia());
        }

        public void establecerEscuchadores(ToolStripMenuItem item)
        {
            item.Click += new EventHandler(this.click);
        }
    }
}
