using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaDEISA.utilerias;
using SistemaDEISA.modelo;
using SistemaDEISA.modelo.basedatos;
using SistemaDEISA.modelo.modulos;
namespace SistemaDEISA.vista
{
    public partial class Principal_vista : Form
    {
        public static Usuario usuario;
        private Form formularioAnterior;
        private Principal_modelo modelo;

        #region singlenton
        private static Principal_vista instancia=null;

        private Principal_vista(Usuario usuario, Form formularioAnterior)
        {
            Principal_vista.usuario = usuario;
            modelo = new Principal_modelo();
            this.formularioAnterior = formularioAnterior;
            InitializeComponent();
        }
        public static Principal_vista obtenerInstancia(Usuario usuario,Form formularioAnterior) { 
            return (instancia == null) ? (instancia=new Principal_vista(usuario,formularioAnterior)) : instancia;
        }
        private void Principal_vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formularioAnterior != null) {
                formularioAnterior.Show();
            }
            instancia.Dispose();
            instancia = null;
            //Application.Restart();
        }
        public static void agregaFormulario(Form formulario)
        {
            if (instancia == null || formulario == null)
            {
                return;
            }
            formulario.MdiParent = instancia;
            formulario.Show();
            formulario.Activate();
        }
        #endregion singlenton


        /// <summary>
        /// Carga recursivamente los submenus para cada raiz del menu;
        /// la recurcividad se detiene cuando ya no existen submenus para la raiz menu;
        /// es aqui cuando se agrega la clase encargada para el evento click del item
        /// </summary>
        /// <param name="raiz">Reprecenta la raiz del menu del cual "colgaran los demas elementos"</param>
        /// <param name="subconjunto">El nombre para buscar todos los nodos hijos de la raiz
        /// este deberia ser el nombre de la raiz menu (atributo nombre de la tabla menu en la base de datos)</param>
        private void cargarSubmenu(ToolStripMenuItem raiz,SistemaDEISA.modelo.basedatos.Menu menu) {
            List<SistemaDEISA.modelo.basedatos.Menu> submenus = modelo.obtenerSubmenus(menu.nombre);
            if (submenus == null) {
                Modulo modulo = modelo.obtenerModulo(menu.nombre);
                ((Manejador)Activator.CreateInstance(Type.GetType(modulo.espacio_nombres+"."+modulo.clase))).establecerEscuchadores(raiz);
                return;
            }
            int i;
            ToolStripMenuItem itemSubmenu = null;
            for (i = 0; i < submenus.Count;i++ )
            {
                itemSubmenu = ItemMenu.obtenerItem((Image)global::SistemaDEISA.Properties.Resources.ResourceManager.GetObject(submenus[i].imagen), submenus[i].nombre, submenus[i].texto);
                cargarSubmenu(itemSubmenu,submenus[i]);
                raiz.DropDownItems.Add(itemSubmenu);
            }
        }
        
        /// <summary>
        /// Carga los menus de acceso para cualquier usuario que ingrese al sistema
        /// siguiendo estos pasos:
        /// 1. Obtiene los menus a los que tiene acceso el usuario
        /// 2. Para cada acceso obtiene la informacion completa del menu
        /// 4. Para cada menu otiene la informacion de su imagen asociada
        /// 3. Una ves teniendo menu e imagen asociada se crea el item
        /// 4. Se llama a una funcion recursiva por si existen sub menus dentro del menu los agrege
        /// 5. Se agrega el item (Ya estaria completo gracias al paso anterior)
        /// </summary>
        private void cargarMenu() {
            List<Usuario_accesa_menu> menusAcceso = modelo.obtenerMenusAcceso(usuario.cuenta);
            if (menusAcceso == null) {
                return;
            }
            SistemaDEISA.modelo.basedatos.Menu menu = null;
            ToolStripMenuItem itemMenu = null;
            int i;
            for (i = 0; i < menusAcceso.Count; i++) {
                menu = modelo.obtenerMenu(menusAcceso[i].menu);
                itemMenu = ItemMenu.obtenerItem((Image)global::SistemaDEISA.Properties.Resources.ResourceManager.GetObject(menu.imagen), menu.nombre, menu.texto);
                cargarSubmenu(itemMenu,menu);
                menu_menuStrip.Items.Add(itemMenu);
            }
        }

        private void Principal_vista_Load(object sender, EventArgs e)
        {
            cargarMenu();
            modelo.terminarTransaccion();
        }

    }
}
