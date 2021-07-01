using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201203
{
    public static class ExtensionPictureBox
    {
        public static char UltimoCaracter(this PictureBox picBox)
        {
            return picBox.Name[picBox.Name.Length - 1];
        }
    }
}
