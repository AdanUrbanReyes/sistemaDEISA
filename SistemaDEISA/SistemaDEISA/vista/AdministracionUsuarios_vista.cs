using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using SistemaDEISA.utilerias;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.vista
{
    public partial class AdministracionUsuarios_vista : Form
    {
        private AdministracionUsuarios_modelo modelo;
        private OpenFileDialog selector;
        #region singlenton
        private static AdministracionUsuarios_vista instancia=null;
        private AdministracionUsuarios_vista()
        {
            InitializeComponent();
            modelo = new AdministracionUsuarios_modelo();
            selector = new OpenFileDialog();
        }
        public static AdministracionUsuarios_vista obtenerInstancia() { 
            return (instancia == null) ? (instancia=new AdministracionUsuarios_vista()) : instancia;
        }
        private void AdministracionUsuarios_vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            modelo.terminarTransaccion();
            instancia.Dispose();
            instancia = null;
        }
        #endregion singlenton

        public void establecerCuenta_comboBox()
        {
            string[] cuentas = modelo.obtenerCuentasUsuario();
            cuenta_comboBox.Items.Clear();
            cuenta_comboBox.AutoCompleteCustomSource.Clear();
            if (cuentas != null)
            {
                cuenta_comboBox.Items.AddRange(cuentas);
                cuenta_comboBox.AutoCompleteCustomSource.AddRange(cuentas);
            }
        }

        public void establecerDepartamento_comboBox() {
            List<Departamento> departamentos = modelo.obtenerDepartamentos();
            departamento_comboBox.Items.Clear();
            if (departamentos != null)
            {
                int i;
                for (i = 0; i < departamentos.Count; i++)
                {
                    departamento_comboBox.Items.Add(departamentos[i]);
                }
            }
        }

        public void establecerPuesto_comboBox()
        {
            string[] puestos = modelo.obtenerPuestos();
            puesto_comboBox.Items.Clear();
            puesto_comboBox.AutoCompleteCustomSource.Clear();
            if (puestos != null)
            {
                puesto_comboBox.Items.AddRange(puestos);
                puesto_comboBox.AutoCompleteCustomSource.AddRange(puestos);
            }
        }

        public void establecerEstatus_comboBox()
        {
            string[] estatus = modelo.obtenerEstatus();
            estatus_comboBox.Items.Clear();
            estatus_comboBox.AutoCompleteCustomSource.Clear();
            if (estatus != null)
            {
                estatus_comboBox.Items.AddRange(estatus);
                estatus_comboBox.AutoCompleteCustomSource.AddRange(estatus);
            }
        }

        public void establecerFotografiaPerfil(Image imagen) {
            imagenPerfil_pictureBox.BackgroundImage = imagen;
            //imagenPerfil_pictureBox.Image = imagen;
        }

        public void establecerAutocompletados() {
            establecerCuenta_comboBox();
            establecerPuesto_comboBox();
            establecerEstatus_comboBox();
        }

        private void AdministracionUsuarios_vista_Load(object sender, EventArgs e)
        {
            establecerDepartamento_comboBox();
            establecerAutocompletados();
            establecerFotografiaPerfil(global::SistemaDEISA.Properties.Resources.sinFotoPerfil);
        }

        private void cargarFoto_button_Click(object sender, EventArgs e)
        {
            selector.Filter = "Solo imagenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            selector.Title = "Seleccione la imagen para el perfil";
            if (selector.ShowDialog() == DialogResult.OK)
            {
                imagenPerfil_pictureBox.BackgroundImage = System.Drawing.Image.FromFile(selector.FileName);
                //imagenPerfil_pictureBox.Image = System.Drawing.Image.FromFile(selector.FileName);
            }
            else {
                imagenPerfil_pictureBox.BackgroundImage = global::SistemaDEISA.Properties.Resources.sinFotoPerfil;
                //imagenPerfil_pictureBox.Image = global::SistemaDEISA.Properties.Resources.sinFotoPerfil;
            }
            selector.Dispose();
        }

        private void establecerUsuario(Usuario usuario) {
            cuenta_comboBox.Text = usuario.cuenta;
            clave_textBox.Text = usuario.clave;
            nombres_textBox.Text = usuario.nombres;
            primerApellido_textBox.Text = usuario.primer_apellido;
            segundoApellido_textBox.Text = usuario.segundo_apellido;
            estatus_comboBox.Text = usuario.estatus.ToString();
            fechaInicio_dateTimePicker.Value = usuario.inicio;
            departamento_comboBox.Text = modelo.obtenerDepartamento(usuario.departamento).significado;
            //departamento_comboBox.SelectedItem = modelo.obtenerDepartamento(usuario.departamento);
            puesto_comboBox.Text = usuario.puesto;
            try
            {
                establecerFotografiaPerfil(System.Drawing.Image.FromFile(usuario.foto));
                selector.FileName = usuario.foto;
            }
            catch (Exception) {
                establecerFotografiaPerfil(global::SistemaDEISA.Properties.Resources.sinFotoPerfil);
            }
        }

        private List<string> atributosFaltantesEntrada() {
            List<string> atributos = new List<string>();
            if (cuenta_comboBox.Text.Trim() == string.Empty) { 
                atributos.Add("Cuenta");
            }
            if (clave_textBox.Text.Trim() == string.Empty) {
                atributos.Add("Clave");
            }
            if (nombres_textBox.Text.Trim() == string.Empty) {
                atributos.Add("Nombres");
            }
            if (primerApellido_textBox.Text.Trim() == string.Empty) {
                atributos.Add("Primer apellido");
            }
            if (segundoApellido_textBox.Text.Trim() == string.Empty) {
                atributos.Add("Segundo apellido");
            }
            if (estatus_comboBox.Text.Trim() == string.Empty) {
                atributos.Add("Estatus");
            }
            if (departamento_comboBox.Text.Trim() == string.Empty) {
                atributos.Add("Departamento");
            }
            if (puesto_comboBox.Text.Trim() == string.Empty) {
                atributos.Add("Puesto");
            }
            return (atributos.Count == 0) ? null : atributos;
        }

        private Usuario leerUsuario() {
            Usuario usuario = new Usuario();
            usuario.cuenta = cuenta_comboBox.Text;
            usuario.clave = clave_textBox.Text;
            usuario.nombres = nombres_textBox.Text;
            usuario.primer_apellido = primerApellido_textBox.Text;
            usuario.segundo_apellido = segundoApellido_textBox.Text;
            usuario.estatus = estatus_comboBox.Text[0];
            usuario.inicio = fechaInicio_dateTimePicker.Value;
            usuario.departamento = ((Departamento)departamento_comboBox.SelectedItem).abreviatura;
            usuario.puesto = puesto_comboBox.Text;
            usuario.foto = selector.FileName;
            return usuario;
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            List<string> atributosFaltantesEntrada = this.atributosFaltantesEntrada();
            if (atributosFaltantesEntrada == null)
            {
                if (modelo.insertaUsuario(leerUsuario()) == null)
                {
                    MessageBox.Show("No se pudo insertar el registro\nAlgunas razones podrian ser:\nEl registro ya existe\nSe perdio la conexion", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro se ingreso exitosamente", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.establecerAutocompletados();
                }
            }
            else
            {
                MessageBox.Show("Para guardar el registro es necesario ingresar todos los campos\nPor favor ingrese los siguientes campos:\n" + Listas.uneItems(atributosFaltantesEntrada, "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            string cuenta = cuenta_comboBox.Text.Trim();
            if (cuenta == string.Empty) {
                MessageBox.Show("Para poder buscar es necesario insertar la cuenta del Usuario", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Usuario usuario = modelo.obtenerUsuario(cuenta);
            if (usuario == null)
            {
                MessageBox.Show("El usario con cuenta "+cuenta+" no existe en nuestros registros", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else {
                establecerUsuario(usuario);
            }
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            List<string> atributosFaltantesEntrada = this.atributosFaltantesEntrada();
            if (atributosFaltantesEntrada == null)
            {
                if (modelo.modificarUsuario(leerUsuario()) == null)
                {
                    MessageBox.Show("No se pudo modificar el registro\nAlgunas razones podrian ser:\nEl registro no existe\nSe perdio la conexion", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro se modifico exitosamente", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.establecerAutocompletados();
                }
            }
            else
            {
                MessageBox.Show("Para modificar el registro es necesario ingresar todos los campos\nPor favor ingrese los siguientes campos:\n" + Listas.uneItems(atributosFaltantesEntrada, "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.cuenta=cuenta_comboBox.Text.Trim();
            if (usuario.cuenta != string.Empty)
            {
                if (modelo.eliminarUsuario(usuario) == null)
                {
                    MessageBox.Show("No se pudo eliminar el registro\nAlgunas razones podrian ser:\nEl registro no existe\nEl filtro generado eliminaria todos los registros\nSe perdio la conexion", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El/Los registro(s) se eliminar exitosamente", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.establecerAutocompletados();
                }
            }
            else {
                MessageBox.Show("Para eliminar el registro es necesario ingresar\n" + Listas.uneItems(modelo.llavePrimaria(usuario), "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
