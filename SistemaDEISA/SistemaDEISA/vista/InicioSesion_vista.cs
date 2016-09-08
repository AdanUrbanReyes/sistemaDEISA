using System;
using System.Windows.Forms;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.vista
{
    public partial class InicioSesion_vista : Form
    {
        private InicioSesion_modelo modelo;

        public InicioSesion_vista()
        {
            modelo = new InicioSesion_modelo();
            InitializeComponent();
        }

        private void InicioSesion_vista_FormClosing(object sender, FormClosingEventArgs e)
        {
            modelo.terminarTransaccion();
            this.Dispose();
        }

        public void iniciaSesion(Usuario usuario)
        {
            Principal_vista.obtenerInstancia(usuario,this).Show();
        }

        private void iniciar_button_Click(object sender, EventArgs e)
        {
            /*
                modelo.trataIniciarConexionBasedatos((this.local_radioButton.Checked) ? "Local" : "Remoto");
                modelo.insertaCodigosPostales();
             */
            string cuenta = this.cuenta_textBox.Text.Trim();
            string clave = this.clave_textBox.Text;
            if (cuenta == string.Empty || clave == string.Empty)
            {
                MessageBox.Show("Por favor ingrese la cuenta y la clave", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (modelo.trataIniciarConexionBasedatos((this.local_radioButton.Checked) ? "Local" : "Remoto"))
            {
                Usuario usuario = modelo.validaInicioSesion(cuenta, clave);
                if (usuario == null)
                {
                    MessageBox.Show("Cuenta o Clave incorrectos. Por favor revice que esten vien escritos", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    this.Hide();
                    iniciaSesion(usuario);
                }
            }
            else
            {
                MessageBox.Show("No se pudo establecer la conexion conexion \n con la base de datos.\n Por favor revice su conexion a internet", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cuenta_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                clave_textBox.Focus();
            }
        }

        private void clave_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                iniciar_button.PerformClick();
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InicioSesion_vista vista = new InicioSesion_vista();
            Application.Run(vista);
        }
    }
}
