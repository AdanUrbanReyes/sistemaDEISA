using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaDEISA.utilerias;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.vista
{
    public partial class AdministracionClientes_vista : Form
    {
        private AdministracionClientes_modelo modelo=null;
        private string[] razonesSociales;
        private string estadoFocoEnter, municipioFocoEnter, asentamientoFocoEnter;
        private List<Telefono_cliente> telefonos_list;
        private List<Celular_cliente> celulares_list;
        private List<Correo_electronico_cliente> correos_list;

        #region singlenton
        private static AdministracionClientes_vista instancia=null;
        public AdministracionClientes_vista()
        {
            InitializeComponent();
            modelo = new AdministracionClientes_modelo();
            telefonos_list = new List<Telefono_cliente>();
            celulares_list = new List<Celular_cliente>();
            correos_list = new List<Correo_electronico_cliente>();
        }
        public static AdministracionClientes_vista obtenerInstancia() {
            return (instancia == null) ? (instancia = new AdministracionClientes_vista()) : instancia;
        }
        private void AdministracionClientes_vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            modelo.terminarTransaccion();
            instancia.Dispose();
            instancia = null;
        }
        #endregion singlenton

        private void AdministracionClientes_vista_Load(object sender, EventArgs e)
        {
            establecerRazonesSociales();
            establecerEstado_comboBox();
        }

        private void establecerRazonesSociales() {
            razonesSociales = modelo.obtenerRazonesSociales();
            if (razonesSociales == null) {
                return ;
            }
            razonSocial_comboBox.AutoCompleteCustomSource.AddRange(razonesSociales);
            razonSocial_comboBox.Items.AddRange(razonesSociales);
        }

        private void establecerEstado_comboBox()
        {
            string[] estados = modelo.obtenerEstados();
            estado_comboBox.Items.Clear();
            establecerMunicipio_comboBox();
            if (estados == null)
            {
                return;
            }
            estado_comboBox.Items.AddRange(estados);
        }

        private void establecerId_CodigoPostal_textBox()
        {
            idCodigoPostal_textBox.Text = "";
            codigoPostal_textBox.Text = "";
            if (asentamiento_comboBox.SelectedItem != null)
            {
                int[] id_codigoPostal = modelo.obtenerID_CodigoPostal(estado_comboBox.Text, municipio_comboBox.Text, asentamiento_comboBox.Text);
                if (id_codigoPostal != null)
                {
                    idCodigoPostal_textBox.Text = (id_codigoPostal[0] == Mysql.valorNoSeteadoInt) ? "" : "" + id_codigoPostal[0];
                    codigoPostal_textBox.Text = (id_codigoPostal[1] == Mysql.valorNoSeteadoInt) ? "" : "" + id_codigoPostal[1];
                }
            }
        }

        private void establecerCalle_textBox()
        {
            calle_textBox.AutoCompleteCustomSource.Clear();
            if (idCodigoPostal_textBox.Text.Trim() != string.Empty)
            {
                string[] calles_stringArray = modelo.obtenerCalles(Int32.Parse(idCodigoPostal_textBox.Text.Trim()));
                if (calles_stringArray != null)
                {
                    calle_textBox.AutoCompleteCustomSource.AddRange(calles_stringArray);
                }
            }
        }

        private void establecerAsentamiento_comboBox()
        {
            asentamiento_comboBox.Items.Clear();
            if (municipio_comboBox.SelectedItem != null)
            {
                string[] colonias = modelo.obtenerAsentamientos(estado_comboBox.Text, municipio_comboBox.Text);
                if (colonias != null)
                {
                    asentamiento_comboBox.Items.AddRange(colonias);
                }
            }
            establecerId_CodigoPostal_textBox();
            establecerCalle_textBox();
        }

        private void establecerMunicipio_comboBox()
        {
            municipio_comboBox.Items.Clear();
            string[] municipios = modelo.obtenerMunicipios(estado_comboBox.Text.Trim());
            if (municipios != null)
            {
                municipio_comboBox.Items.AddRange(municipios);
            }
            establecerAsentamiento_comboBox();
        }

        private Direccion leerDireccion()
        {
            Direccion direccion = new Direccion();
            direccion.calle = (calle_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : calle_textBox.Text.Trim();
            direccion.numero_exterior = (numeroExterior_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(numeroExterior_textBox.Text.Trim());
            direccion.numero_interior = (numeroInterior_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(numeroInterior_textBox.Text.Trim());
            direccion.codigo_postal = (idCodigoPostal_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(idCodigoPostal_textBox.Text.Trim());
            return direccion;
        }

        private Cliente leerCliente(){
            Cliente cliente= new Cliente();
            cliente.razon_social = (razonSocial_comboBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : razonSocial_comboBox.Text.Trim();
            cliente.planta = (planta_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : planta_textBox.Text.Trim();
            cliente.empresa = (empresa_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : empresa_textBox.Text.Trim();
            cliente.giro = (giro_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : giro_textBox.Text.Trim();
            //cliente.direccion = (idCodigoPostal_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(idCodigoPostal_textBox.Text.Trim());
            cliente.rfc = (rfc_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : rfc_textBox.Text.Trim();
            cliente.proveedor = (proveedor_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(proveedor_textBox.Text.Trim());
            cliente.sae = (sae_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(sae_textBox.Text.Trim());
            return cliente;
        }

        private void establecerCodigoPostal(Codigo_postal codigoPostal) {
            if (codigoPostal == null) {
                return;
            }
            estado_comboBox.SelectedItem = codigoPostal.estado;
            establecerMunicipio_comboBox();
            municipio_comboBox.SelectedItem = codigoPostal.municipio;
            establecerAsentamiento_comboBox();
            asentamiento_comboBox.SelectedItem = codigoPostal.asentamiento;
            codigoPostal_textBox.Text = "" + codigoPostal.codigo_postal;
            idCodigoPostal_textBox.Text = "" + codigoPostal.id;
        }

        private void establecerDireccion(Direccion direccion) {
            if (direccion == null) {
                return;
            }
            calle_textBox.Text = direccion.calle;
            numeroInterior_textBox.Text = (direccion.numero_interior == Mysql.valorNoSeteadoInt) ? "" : "" + direccion.numero_interior; 
            numeroExterior_textBox.Text = "" + direccion.numero_exterior;
            establecerCodigoPostal(modelo.obtenerCodigoPostal(direccion.codigo_postal));
        }

        private void establecerTelefonos() {
            int i;
            telefonoTipo_listView.Items.Clear();
            for (i = 0; i < telefonos_list.Count; i++) {
                telefonoTipo_listView.Items.Add(new ListViewItem(new string[]{telefonos_list[i].telefono, telefonos_list[i].tipo}));
            }
        }

        private void establecerCelulares()
        {
            int i;
            celularTipo_listView.Items.Clear();
            for (i = 0; i < celulares_list.Count; i++)
            {
                celularTipo_listView.Items.Add(new ListViewItem(new string[] { celulares_list[i].celular, celulares_list[i].tipo }));
            }
        }

        private void establecerCorreos()
        {
            int i;
            correoTipo_listView.Items.Clear();
            for (i = 0; i < correos_list.Count; i++)
            {
                correoTipo_listView.Items.Add(new ListViewItem(new string[] { correos_list[i].correo_electronico, correos_list[i].tipo }));
            }
        }

        private void establecerCliente(Cliente cliente) {
            if (cliente == null) {
                return;
            }
            if (cliente.planta == "MATRIZ") {
                matriz_radioButton.Checked = true;
            }
            else
            {
                sucursal_radioButton.Checked = true;
            }
            razonSocial_comboBox.Text = cliente.razon_social;
            planta_textBox.Text = cliente.planta;
            empresa_textBox.Text = cliente.empresa;
            giro_textBox.Text = cliente.giro;
            establecerDireccion(modelo.obtenerDireccion(cliente.direccion));
            rfc_textBox.Text = (cliente.rfc == Mysql.valorNoSeteadoString) ? "" : "" + cliente.rfc;
            proveedor_textBox.Text = (cliente.proveedor == Mysql.valorNoSeteadoInt) ? "" : "" + cliente.proveedor;
            sae_textBox.Text = (cliente.sae == Mysql.valorNoSeteadoInt) ? "" : "" + cliente.sae;
            telefonos_list = modelo.obtenerTelefonos(cliente.razon_social, cliente.planta);
            celulares_list = modelo.obtenerCelulares(cliente.razon_social, cliente.planta);
            correos_list = modelo.obtenerCorreos(cliente.razon_social, cliente.planta);
            establecerTelefonos();
            establecerCelulares();
            establecerCorreos();
        }

        private List<string> atributosFaltantesBusqueda() { 
            List<string> atributos = new List<string>();
            if (razonSocial_comboBox.Text.Trim() == string.Empty)
            {
                atributos.Add("Razon social");
            }
            if(planta_textBox.Text.Trim() == string.Empty){
                atributos.Add("Planta");
            }
            return (atributos.Count == 0) ? null : atributos;
        }

        private List<string> atributosFaltantesEntrada()
        {
            List<string> atributos = new List<string>();
            if (razonSocial_comboBox.Text.Trim() == string.Empty)
            {
                atributos.Add("Razon social");
            }
            if(planta_textBox.Text.Trim() == string.Empty){
                atributos.Add("Planta");
            }
            if(empresa_textBox.Text.Trim() == string.Empty){
                atributos.Add("Empresa");
            }
            if (giro_textBox.Text.Trim() == string.Empty) {
                atributos.Add("Giro");
            }
            if (estado_comboBox.Text.Trim() == string.Empty) {
                atributos.Add("Estado");
            }
            if (municipio_comboBox.Text.Trim() == string.Empty){
                atributos.Add("Municipio");
            }
            if (asentamiento_comboBox.Text.Trim() == string.Empty) {
                atributos.Add("Asentamiento");
            }
            if (calle_textBox.Text.Trim() == string.Empty) {
                atributos.Add("Calle");
            }
            if (numeroExterior_textBox.Text.Trim() == string.Empty) {
                atributos.Add("Numero exterior");
            }
            return (atributos.Count == 0) ? null : atributos;
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            List<string> atributosFaltantesEntrada =this.atributosFaltantesEntrada();
            if (atributosFaltantesEntrada == null)
            {
                Direccion direccion = modelo.insertaDireccion(leerDireccion());
                if (direccion != null)
                {
                    Cliente cliente = leerCliente();
                    cliente.direccion = direccion.id;
                    if (modelo.insertaCliente(cliente,telefonos_list,celulares_list,correos_list))
                    {
                        MessageBox.Show("Se agrego el cliente correctamente", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("No se pudo insertar el cliente\nAlgunas razones podrian ser:\nEl cliente ya existe\nSe perdio la conexion", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    MessageBox.Show("No se pudo insertar la direccion\nPor lo tanto no se pudo insertar el Cliente", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Para guardar el registro es necesario ingresar los campos:\n" + Listas.uneItems(atributosFaltantesEntrada, "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            List<string> atributosFaltantesBusqueda =this.atributosFaltantesBusqueda();
            if (atributosFaltantesBusqueda == null)
            {
                Cliente cliente = modelo.obtenerCliente(razonSocial_comboBox.Text.Trim(),planta_textBox.Text.Trim());
                if (cliente != null)
                {
                    establecerCliente(cliente);
                }
                else {
                    MessageBox.Show("No se encontro ningun cliente con Razon social "+razonSocial_comboBox.Text.Trim()+" y Planta "+planta_textBox.Text.Trim(), "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Para modificar el registro es necesario ingresar los campos:\n" + Listas.uneItems(atributosFaltantesBusqueda, "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modificar_button_Click(object sender, EventArgs e)
        {
            List<string> atributosFaltantesEntrada = this.atributosFaltantesEntrada();
            if (atributosFaltantesEntrada == null){
                Direccion direccion = modelo.insertaDireccion(leerDireccion());
                if(direccion != null){
                    Cliente cliente = leerCliente();
                    cliente.direccion = direccion.id;
                    if(modelo.actualizaCliente(cliente,telefonos_list,celulares_list,correos_list)){
                        MessageBox.Show("Se modifico el cliente correctamente", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else{
                        MessageBox.Show("No se pudo modificar el cliente\nAlgunas razones podrian ser:\nEl cliente no existe\nSe perdio la conexion", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else{
                    MessageBox.Show("No se pudo insertar la direccion\nPor lo tanto no se pudo insertar el Cliente", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else{
                MessageBox.Show("Para modificar el registro es necesario ingresar los campos:\n" + Listas.uneItems(atributosFaltantesEntrada, "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sucursal_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sucursal_radioButton.Checked) {
                this.razonSocial_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.planta_textBox.Text = "";
                this.planta_textBox.Enabled = true;
            }
        }

        private void matriz_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (matriz_radioButton.Checked) {
                
                this.razonSocial_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                //this.razonSocial_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
                this.razonSocial_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                this.planta_textBox.Text = "MATRIZ";
                this.planta_textBox.Enabled = false;
            }
        }

        private void agregarTelefono_button_Click(object sender, EventArgs e)
        {
            if (telefono_textBox.Text.Trim() == string.Empty || tipoTelefono_textBox.Text.Trim() == string.Empty) {
                MessageBox.Show("Por favor ingrese el telefono y el tipo", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Telefono_cliente telefono = new Telefono_cliente();
            telefono.telefono = telefono_textBox.Text.Trim();
            telefono.tipo = tipoTelefono_textBox.Text.Trim();
            if (telefonos_list.Contains(telefono)) {
                MessageBox.Show("El telefono que intentas agregar ("+telefono.telefono+") ya existe", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            telefonos_list.Add(telefono);
            telefonoTipo_listView.Items.Add(new ListViewItem(new string[]{telefono.telefono,telefono.tipo}));
        }

        private void agregarCelular_button_Click(object sender, EventArgs e)
        {
            if (celular_textBox.Text.Trim() == string.Empty || tipoCelular_textBox.Text.Trim() == string.Empty) {
                MessageBox.Show("Por favor ingrese el celular y el tipo","Entrada de datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            Celular_cliente celular = new Celular_cliente();
            celular.celular = celular_textBox.Text.Trim();
            celular.tipo = tipoCelular_textBox.Text.Trim();
            if(celulares_list.Contains(celular)){
                MessageBox.Show("El celular que intentas agregar ("+celular.celular+") ya existe", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            celulares_list.Add(celular);
            celularTipo_listView.Items.Add(new ListViewItem(new string[] { celular.celular, celular.tipo }));
        }

        private void agregarCorreo_button_Click(object sender, EventArgs e)
        {
            if (correo_textBox.Text.Trim() == string.Empty || tipoCorreo_textBox.Text.Trim() == string.Empty) {
                MessageBox.Show("Por favor ingrese el correo y el tipo","Entrada de datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            Correo_electronico_cliente correoElectronico = new Correo_electronico_cliente();
            correoElectronico.correo_electronico = correo_textBox.Text.Trim();
            correoElectronico.tipo = tipoCorreo_textBox.Text.Trim();
            if (correos_list.Contains(correoElectronico)) {
                MessageBox.Show("El correo electronico que intentas agregar ("+correoElectronico.correo_electronico+") ya existe","Entrada de datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            correos_list.Add(correoElectronico);
            correoTipo_listView.Items.Add(new ListViewItem(new string[]{correoElectronico.correo_electronico,correoElectronico.tipo}));
        }

        private void telefonoTipo_listView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete){
                ListView.SelectedIndexCollection indices = telefonoTipo_listView.SelectedIndices;
                if (indices.Count == 0) {
                    return;
                }
                telefonos_list.RemoveAt(indices[0]);
                telefonoTipo_listView.Items.RemoveAt(indices[0]);
                /*
                int i;
                for (i = 0; i < indices.Count; i++) {
                    telefonos_list.RemoveAt(indices[i]);
                    telefonoTipo_listView.Items.RemoveAt(indices[i]);
                    Console.Write("indice = "+indices[i]+"\n");
                }
                 */
            }
        }

        private void celularTipo_listView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete){
                ListView.SelectedIndexCollection indices = celularTipo_listView.SelectedIndices;
                if (indices.Count == 0) {
                    return;
                }
                celulares_list.RemoveAt(indices[0]);
                celularTipo_listView.Items.RemoveAt(indices[0]);
            }
        }

        private void correoTipo_listView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                ListView.SelectedIndexCollection indices = correoTipo_listView.SelectedIndices;
                if (indices.Count == 0) {
                    return;
                }
                correos_list.RemoveAt(indices[0]);
                correoTipo_listView.Items.RemoveAt(indices[0]);
            }
        }

        private void estado_comboBox_Leave(object sender, EventArgs e)
        {
            if ((estado_comboBox.SelectedItem == null || estadoFocoEnter != estado_comboBox.SelectedItem.ToString()) && municipio_comboBox.Items.Count == 0)
            {
                establecerMunicipio_comboBox();
            }
        }

        private void municipio_comboBox_Leave(object sender, EventArgs e)
        {
            if ((municipio_comboBox.SelectedItem == null || municipioFocoEnter != municipio_comboBox.SelectedItem.ToString()) && asentamiento_comboBox.Items.Count == 0)
            {
                establecerAsentamiento_comboBox();
            }
        }

        private void asentamiento_comboBox_Leave(object sender, EventArgs e)
        {
            if ((asentamiento_comboBox.SelectedItem == null || asentamientoFocoEnter != asentamiento_comboBox.SelectedItem.ToString()) && idCodigoPostal_textBox.Text == string.Empty)
            {
                establecerId_CodigoPostal_textBox();
                establecerCalle_textBox();
            }
        }

        private void estado_comboBox_Enter(object sender, EventArgs e)
        {
            estadoFocoEnter = (estado_comboBox.SelectedItem == null) ? "" : estado_comboBox.SelectedItem.ToString();
        }

        private void municipio_comboBox_Enter(object sender, EventArgs e)
        {
            municipioFocoEnter = (municipio_comboBox.SelectedItem == null) ? "" : municipio_comboBox.SelectedItem.ToString();
        }

        private void asentamiento_comboBox_Enter(object sender, EventArgs e)
        {
            asentamientoFocoEnter = (asentamiento_comboBox.SelectedItem == null) ? "" : asentamiento_comboBox.SelectedItem.ToString();
        }


    }
}
