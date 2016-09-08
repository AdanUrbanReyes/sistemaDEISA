using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using SistemaDEISA.utilerias;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.vista
{
    public partial class AdministracionDirecciones_vista : Form
    {
        private AdministracionDirecciones_modelo modelo;
        private string estadoFocoEnter, municipioFocoEnter, asentamientoFocoEnter;

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
            establecerEstado_comboBox();
        }

        private void establecerEstado_comboBox() {
            string[] estados = modelo.obtenerEstados();
            estado_comboBox.Items.Clear();
            establecerMunicipio_comboBox();
            if (estados == null) {
                return;
            }
            estado_comboBox.Items.AddRange(estados);
        }

        private void establecerId_CodigoPostal_textBox()
        {
            idCodigoPostal_textBox.Text = "";
            codigoPostal_textBox.Text = "";
            if(asentamiento_comboBox.SelectedItem != null){
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
            if (municipio_comboBox.SelectedItem !=null) {
                string[] colonias = modelo.obtenerAsentamientos(estado_comboBox.Text, municipio_comboBox.Text);
                if (colonias != null)
                {
                    asentamiento_comboBox.Items.AddRange(colonias);
                }
            }
            establecerId_CodigoPostal_textBox();
            establecerCalle_textBox();
        }
        
        private void establecerMunicipio_comboBox() {
            municipio_comboBox.Items.Clear();
            string[] municipios = modelo.obtenerMunicipios(estado_comboBox.Text.Trim());
            if (municipios != null) {
                municipio_comboBox.Items.AddRange(municipios);
            }
            establecerAsentamiento_comboBox();
        }

        private List<string> atributosFaltantesEntrada()
        {
            List<string> atributos = new List<string>();
            if (estado_comboBox.Text.Trim() == string.Empty)
            {
                atributos.Add("Estado");
            }
            if (municipio_comboBox.Text.Trim() == string.Empty)
            {
                atributos.Add("Municipio");
            }
            if (asentamiento_comboBox.Text.Trim() == string.Empty)
            {
                atributos.Add("Asentamiento");
            }
            if(calle_textBox.Text.Trim() == string.Empty){
                atributos.Add("Calle/Avenida/Calzada");
            }
            if (numeroExterior_textBox.Text.Trim() == string.Empty)
            {
                atributos.Add("Numero exterior");
            }
            return (atributos.Count == 0) ? null :atributos;
        }

        private Direccion leerDireccion() {
            Direccion direccion=new Direccion();
            direccion.calle = (calle_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : calle_textBox.Text.Trim();
            direccion.numero_exterior = (numeroExterior_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(numeroExterior_textBox.Text.Trim());
            direccion.numero_interior = (numeroInterior_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(numeroInterior_textBox.Text.Trim());
            direccion.codigo_postal = (idCodigoPostal_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(idCodigoPostal_textBox.Text.Trim());
            return direccion;
        }

        private Codigo_postal leerCodigoPostal() {
            Codigo_postal codigoPostal = new Codigo_postal();
            codigoPostal.id = (idCodigoPostal_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(idCodigoPostal_textBox.Text.Trim());
            codigoPostal.codigo_postal = (codigoPostal_textBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoInt : Int32.Parse(codigoPostal_textBox.Text.Trim());
            codigoPostal.estado = (estado_comboBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : estado_comboBox.Text.Trim();
            codigoPostal.municipio = (municipio_comboBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : municipio_comboBox.Text.Trim();
            codigoPostal.asentamiento = (asentamiento_comboBox.Text.Trim() == string.Empty) ? Mysql.valorNoSeteadoString : asentamiento_comboBox.Text.Trim();
            return codigoPostal;
        }

        private void establecerDirecciones(List<Direccion> direcciones) {
            direcciones_listView.Items.Clear();
            if (direcciones == null) {
                return;
            }
            int i;
            Codigo_postal codigoPostal;
            for (i = 0; i < direcciones.Count; i++ )
            {
                codigoPostal = modelo.obtenerCodigoPostal(direcciones[i].codigo_postal);
                ListViewItem listViewItem = null;
                if (codigoPostal != null)
                {
                    listViewItem = new ListViewItem(new string[] { "" + codigoPostal.codigo_postal, codigoPostal.estado, codigoPostal.municipio, codigoPostal.asentamiento, direcciones[i].calle, "" + direcciones[i].numero_exterior, (direcciones[i].numero_interior == Mysql.valorNoSeteadoInt) ? "" : "" + direcciones[i].numero_interior });
                }
                else {
                    listViewItem = new ListViewItem(new string[] { "", "", "", "", direcciones[i].calle, "" + direcciones[i].numero_exterior, (direcciones[i].numero_interior == Mysql.valorNoSeteadoInt) ? "" : "" + direcciones[i].numero_interior });
                }
                direcciones_listView.Items.Add(listViewItem);
            }
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            List<string> atributosFaltantesEntrada = this.atributosFaltantesEntrada();
            if(atributosFaltantesEntrada == null){
                if(modelo.insertaDireccion(leerDireccion()) ){
                    MessageBox.Show("Se agrego correctamente la direccion en los registros", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }else{
                    MessageBox.Show("No se pudo insertar la direccion en los registros\nAlgunas razones podrian ser:\nLa direccion ya existe\nSe perdio la conexion" , "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Para poder guardar el registro ingrese los siguientes campos:\n" + Listas.uneItems(atributosFaltantesEntrada, "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            if (idCodigoPostal_textBox.Text.Trim() != string.Empty)
            {
                List<Direccion> direcciones = modelo.obtenerDirecciones(leerDireccion());
                if (direcciones != null)
                {
                    establecerDirecciones(direcciones);
                }
                else
                {
                    MessageBox.Show("Al parecer no existe alguna direccion con los parametros proporcionados o se perdio la conexion", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Por favor asegurece que el campo ID este lleno\nPara que esto se deve ingresar:\nEstado\nMunicipio\nAsentamiento", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            List<string> atributosFaltantesEntrada = this.atributosFaltantesEntrada();
            if(atributosFaltantesEntrada == null){
                if(modelo.eliminarDireccion(leerDireccion())){
                    MessageBox.Show("Se elimino la direccion de los registros correctamente", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }else{
                    MessageBox.Show("No se encontro el registro, por lo tanto no se elimino", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }
            }else{
                MessageBox.Show("Para poder eliminar una direccion ingrese los siguientes campos:\n" + Listas.uneItems(atributosFaltantesEntrada, "\n"), "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void estado_comboBox_Leave(object sender, EventArgs e)
        {
            if ((estado_comboBox.SelectedItem == null || estadoFocoEnter != estado_comboBox.SelectedItem.ToString()) && municipio_comboBox.Items.Count == 0 ) {
                establecerMunicipio_comboBox();
            }
        }

        private void municipio_comboBox_Leave(object sender, EventArgs e)
        {
            if( (municipio_comboBox.SelectedItem == null || municipioFocoEnter != municipio_comboBox.SelectedItem.ToString()) && asentamiento_comboBox.Items.Count == 0 ){
                establecerAsentamiento_comboBox();
            }
        }

        private void asentamiento_comboBox_Leave(object sender, EventArgs e)
        {
            if( (asentamiento_comboBox.SelectedItem == null || asentamientoFocoEnter != asentamiento_comboBox.SelectedItem.ToString()) && idCodigoPostal_textBox.Text == string.Empty){
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
