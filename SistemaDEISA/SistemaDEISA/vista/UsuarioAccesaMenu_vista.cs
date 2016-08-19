using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.vista
{
    public partial class UsuarioAccesaMenu_vista : Form
    {
        private UsuarioAccesaMenu_modelo modelo;
        #region singlenton
        private static UsuarioAccesaMenu_vista instancia = null;
        private UsuarioAccesaMenu_vista()
        {
            InitializeComponent();
            modelo = new UsuarioAccesaMenu_modelo();
        }
        public static UsuarioAccesaMenu_vista obtenerInstancia(){
            return (instancia == null) ? (instancia = new UsuarioAccesaMenu_vista()) : instancia;
        }
        private void UsuarioAccesaMenu_vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            modelo.terminarTransaccion();
            instancia.Dispose();
            instancia = null;
        }
        #endregion singlenton

        public void establecerCuenta_comboBox()
        {
            int i;
            List<Usuario> usuarios = modelo.obtenerUsuarios();
            cuenta_comboBox.Items.Clear();
            if (usuarios != null)
            {
                for(i=0; i < usuarios.Count ; i++){
                    cuenta_comboBox.Items.Add(usuarios[i]);
                }
            }
        }

        private void UsuarioAccesaMenu_vista_Load(object sender, EventArgs e)
        {
            establecerCuenta_comboBox();
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)cuenta_comboBox.SelectedItem;
            nombreCompleto_label.Text = usuario.nombres + " " + usuario.primer_apellido + " " + usuario.segundo_apellido;
            estatus_label.Text = ""+usuario.estatus;
            departamento_label.Text = modelo.obtenerDepartamento(usuario.departamento).significado;
            puesto_label.Text = usuario.puesto;
        }
        

    }
}
