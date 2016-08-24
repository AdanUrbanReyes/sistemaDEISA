using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.vista
{
    public partial class AdministracionDirecciones_vista : Form
    {
        private AdministracionDirecciones_modelo modelo;

        #region singlenton
        private static AdministracionDirecciones_vista instancia = null;
        private AdministracionDirecciones_vista()
        {
            InitializeComponent();
            modelo = new AdministracionDirecciones_modelo();
        }
        public static AdministracionDirecciones_vista obtenerInstancia() {
            return (instancia == null) ? (instancia = new AdministracionDirecciones_vista()) : instancia;
        }
        private void AdministracionDirecciones_vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            modelo.terminarTransaccion();
            instancia.Dispose();
            instancia = null;
        }
        #endregion singlenton

        private void AdministracionDirecciones_vista_Load(object sender, EventArgs e)
        {

        }



        private void guardar_button_Click(object sender, EventArgs e)
        {

        }

        private void buscar_button_Click(object sender, EventArgs e)
        {

        }

        private void modificar_button_Click(object sender, EventArgs e)
        {

        }

        private void colonia_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
