using System;
using System.Windows.Forms;

namespace SistemaDEISA.vista
{
    public partial class AdministracionClientes_vista : Form
    {
        #region singlenton
        private static AdministracionClientes_vista instancia=null;
        public AdministracionClientes_vista()
        {
            InitializeComponent();
        }
        public static AdministracionClientes_vista obtenerInstancia() {
            return (instancia == null) ? (instancia = new AdministracionClientes_vista()) : instancia;
        }
        private void AdministracionClientes_vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia.Dispose();
            instancia = null;
        }
        #endregion singlenton

    }
}
