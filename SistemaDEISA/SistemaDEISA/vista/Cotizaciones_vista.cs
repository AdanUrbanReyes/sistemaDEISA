using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using SistemaDEISA.utilerias;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;

namespace SistemaDEISA.vista
{
    public partial class Cotizaciones_vista : Form
    {
        private Cotizaciones_modelo modelo;
        private string razonSocialFocoEnter,plantaFocoEnter;
        private Cliente cliente;
        private Direccion direccion;
        private Codigo_postal codigoPostal;
        private DateTime fechaHoraActualSistema;
        #region singlenton
        private static Cotizaciones_vista instancia = null;
        private Cotizaciones_vista()
        {
            InitializeComponent();
            modelo = new Cotizaciones_modelo();
        }
        public static Cotizaciones_vista obtenerInstancia() {
            return (instancia == null) ? (instancia = new Cotizaciones_vista()) : instancia;
        }

        private void Cotizaciones_vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            modelo.terminarTransaccion();
            instancia.Dispose();
            instancia = null;
        }
        #endregion singlenton

        private void Cotizaciones_vista_Load(object sender, EventArgs e)
        {
            establecerRazonSocial_comboBox();
            establecerFechaRealizacion_label();
        }

        private void establecerFechaRealizacion_label() {
            fechaHoraActualSistema = modelo.obtenerFechaHoraActual();
            if (fechaHoraActualSistema != Mysql.valorNoSeteadoDateTime) {
                fechaRealizacion_label.Text = fechaHoraActualSistema.ToString("dd 'de' MMMM 'del' yyyy HH:mm:ss");
            }
        }

        private void establecerRazonSocial_comboBox()
        {
            razonSocial_comboBox.Items.Clear();
            string []razonesSociales = modelo.obtenerRazonesSociales();
            if (razonesSociales == null)
            {
                return;
            }
            razonSocial_comboBox.Items.AddRange(razonesSociales);
        }

        private void establecerPlanta_comboBox() {
            planta_comboBox.Items.Clear();
            string[] plantas = modelo.obtenerPlantas(razonSocial_comboBox.SelectedItem.ToString());
            if (plantas == null) {
                return;
            }
            planta_comboBox.Items.AddRange(plantas);
        }

        private void establecerDireccion_textBox() {
            if (cliente != null) {
                direccion = modelo.obtenerDireccion(cliente.direccion);
                if (direccion != null) {
                    codigoPostal = modelo.obtenerCodigoPostal(direccion.codigo_postal);
                    if (codigoPostal != null) {
                        string temporal = (direccion.numero_interior == Mysql.valorNoSeteadoInt) ? "" : " " + direccion.numero_interior;
                        direccion_textBox.Text = codigoPostal.estado+" "+codigoPostal.municipio+" "+codigoPostal.asentamiento+" "+codigoPostal.codigo_postal+" "+direccion.calle+" "+direccion.numero_exterior + temporal;
                    }
                }
            }
        }

        private void razonSocial_comboBox_Enter(object sender, EventArgs e)
        {
            razonSocialFocoEnter = (razonSocial_comboBox.SelectedItem == null) ? "" : razonSocial_comboBox.SelectedItem.ToString();
        }

        private void razonSocial_comboBox_Leave(object sender, EventArgs e)
        {
            if (razonSocial_comboBox.SelectedItem != null && razonSocialFocoEnter != razonSocial_comboBox.SelectedItem.ToString()) {
                establecerPlanta_comboBox();
            }
        }

        private void planta_comboBox_Enter(object sender, EventArgs e)
        {
            plantaFocoEnter = (planta_comboBox.SelectedItem == null) ? "" : planta_comboBox.SelectedItem.ToString();
        }

        private void planta_comboBox_Leave(object sender, EventArgs e)
        {
            if(planta_comboBox.SelectedItem != null && plantaFocoEnter != planta_comboBox.SelectedItem.ToString()){
                if (razonSocial_comboBox.SelectedItem != null && planta_comboBox.SelectedItem != null)
                {
                    cliente = modelo.obtenerCliente(razonSocial_comboBox.SelectedItem.ToString().Trim(), planta_comboBox.SelectedItem.ToString().Trim());
                    if (cliente != null) {
                        empresa_textBox.Text = cliente.empresa;
                        giro_textBox.Text = cliente.giro;
                        if (cliente.rfc != Mysql.valorNoSeteadoString)
                        {
                            rfc_label.Text = cliente.rfc;
                        }
                        if (cliente.proveedor != Mysql.valorNoSeteadoInt) {
                            proveedor_label.Text = "" + cliente.proveedor;
                        }
                        if(cliente.sae != Mysql.valorNoSeteadoInt){
                            sae_label.Text = "" + cliente.sae;
                        }
                        establecerDireccion_textBox();
                    }
                    
                }
            }
        }


    }
}
