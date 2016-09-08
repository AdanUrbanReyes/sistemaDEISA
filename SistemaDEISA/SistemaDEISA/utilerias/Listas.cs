using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaDEISA.utilerias
{
    public class Listas
    {
        public static string uneItems(List<string> list, string separador)
        {
            if (list == null)
            {
                return null;
            }
            string union = string.Empty;
            int i;
            for (i = 0; i < list.Count; i++)
            {
                union += list[i] + separador;
            }
            return union;
        }

        public static void establecerMenuListView(ListView menus_listView, SistemaDEISA.modelo.basedatos.Menu menu)
        {
            menus_listView.SmallImageList.Images.Add((Image)global::SistemaDEISA.Properties.Resources.ResourceManager.GetObject(menu.imagen));
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.ImageIndex = menus_listView.Items.Count;
            //listViewItem.Text = menu.imagen;
            listViewItem.SubItems.Add(menu.descripcion);
            listViewItem.SubItems.Add(menu.nombre);
            menus_listView.Items.Add(listViewItem);
        }

        public static void establecerMenusListView(ListView menus_listView, List<SistemaDEISA.modelo.basedatos.Menu> menus_list)
        {
            int i;
            menus_listView.SmallImageList.Images.Clear();
            menus_listView.Items.Clear();
            if (menus_list != null)
            {
                for (i = 0; i < menus_list.Count; i++)
                {
                    establecerMenuListView(menus_listView, menus_list[i]);
                }
            }
        }

        public static object[] aArreglo(List<object[]> lista, int indice)
        {
            if (lista == null || lista.Count == 0)
            {
                return null;
            }
            object[] arreglo = new object[lista.Count];
            int i;
            for (i = 0; i < lista.Count; i++)
            {
                arreglo[i] = lista[i][indice];
            }
            return arreglo;
        }
    }
}
