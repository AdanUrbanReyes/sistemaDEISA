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
        private string razonSocialFocoEnter;

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


    }
}
