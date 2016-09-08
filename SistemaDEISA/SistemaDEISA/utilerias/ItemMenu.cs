using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDEISA.utilerias
{
    public class ItemMenu
    {
        public static ToolStripMenuItem obtenerItem(Image imagen, string nombre, string texto)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.BackColor = Color.Transparent;
            item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            item.Font = new Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item.Image = imagen;
            item.ImageAlign = ContentAlignment.TopCenter;
            item.ImageScaling = ToolStripItemImageScaling.None;
            item.Name = nombre;
            item.Text = texto;
            item.TextImageRelation = TextImageRelation.ImageAboveText;
            return item;
        }
    }
}
