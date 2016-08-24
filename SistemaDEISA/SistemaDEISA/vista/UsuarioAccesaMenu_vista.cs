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
        private List<SistemaDEISA.modelo.basedatos.Menu> menusAcceso_list;
        private List<SistemaDEISA.modelo.basedatos.Menu> menusSinAcceso_list;
        private Usuario usuario;

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
            menusAcceso_listView.SmallImageList = new ImageList();
            menusAcceso_listView.SmallImageList.ImageSize = new Size(32,32);
            menusSinAcceso_listView.SmallImageList = new ImageList();
            menusSinAcceso_listView.SmallImageList.ImageSize = new Size(32, 32);
            //menusAcceso_list = new List<SistemaDEISA.modelo.basedatos.Menu>();
            //menusSinAcceso_list = new List<SistemaDEISA.modelo.basedatos.Menu>();
        }

        public static void establecerMenuListView(ListView menus_listView,SistemaDEISA.modelo.basedatos.Menu menu) {
            menus_listView.SmallImageList.Images.Add((Image)global::SistemaDEISA.Properties.Resources.ResourceManager.GetObject(menu.imagen));
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.ImageIndex = menus_listView.Items.Count;
            //listViewItem.Text = menu.imagen;
            listViewItem.SubItems.Add(menu.descripcion);
            listViewItem.SubItems.Add(menu.nombre);
            menus_listView.Items.Add(listViewItem);
        }

        public static void establecerMenusListView(ListView menus_listView, List<SistemaDEISA.modelo.basedatos.Menu> menus_list) {
            int i;
            menus_listView.SmallImageList.Images.Clear();
            menus_listView.Items.Clear();
            if (menus_list != null)
            {
                for (i = 0; i < menus_list.Count; i++)
                {
                    establecerMenuListView(menus_listView,menus_list[i]);
                }
            }
        }
        
        private void establecerMenusAcceso(string cuenta) {
            menusAcceso_list = modelo.obtenerMenusAcceso(cuenta);
            establecerMenusListView(menusAcceso_listView, menusAcceso_list);
            if (menusAcceso_list == null) {
                menusAcceso_list = new List<SistemaDEISA.modelo.basedatos.Menu>();
            }
        }

        private void establecerMenusSinAcceso(string cuenta) {
            menusSinAcceso_list = modelo.obtenerMenusSinAcceso(cuenta);
            establecerMenusListView(menusSinAcceso_listView, menusSinAcceso_list);
            if (menusSinAcceso_list == null) {
                menusSinAcceso_list = new List<SistemaDEISA.modelo.basedatos.Menu>();
            }
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            usuario = (Usuario)cuenta_comboBox.SelectedItem;
            if (usuario != null) {
                nombreCompleto_label.Text = usuario.nombres + " " + usuario.primer_apellido + " " + usuario.segundo_apellido;
                estatus_label.Text = "" + usuario.estatus;
                departamento_label.Text = modelo.obtenerDepartamento(usuario.departamento).significado;
                puesto_label.Text = usuario.puesto;
                establecerMenusAcceso(usuario.cuenta);
                establecerMenusSinAcceso(usuario.cuenta);
            }
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection seleccion = menusSinAcceso_listView.SelectedItems;
            int i;
            for (i = 0; i < seleccion.Count;i++ )
            {
                menusAcceso_list.Add(menusSinAcceso_list[seleccion[i].ImageIndex - i]);
                menusSinAcceso_list.RemoveAt(seleccion[i].ImageIndex - i);
            }
            establecerMenusListView(menusSinAcceso_listView, menusSinAcceso_list);
            establecerMenusListView(menusAcceso_listView, menusAcceso_list);
        }

        private void quitar_button_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccion = menusAcceso_listView.SelectedItems;
            int i;
            for (i = 0; i < seleccion.Count; i++)
            {
                menusSinAcceso_list.Add(menusAcceso_list[seleccion[i].ImageIndex-i]);
                menusAcceso_list.RemoveAt(seleccion[i].ImageIndex-i);
            }
            establecerMenusListView(menusSinAcceso_listView, menusSinAcceso_list);
            establecerMenusListView(menusAcceso_listView, menusAcceso_list);
        }

        private void ejecutar_button_Click(object sender, EventArgs e)
        {
            if (usuario != null && menusAcceso_list != null)
            {
                modelo.establecerMenusAcceso(usuario.cuenta, menusAcceso_list);
                MessageBox.Show("Se han puesto "+menusAcceso_list.Count+" menus de acceso a "+usuario.cuenta, "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Por favor ingrese cuenta y al menos un menu de acceso", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
