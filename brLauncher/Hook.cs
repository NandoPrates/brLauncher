using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace brLauncher
{
    /* http://stackoverflow.com/questions/1592876/make-a-borderless-form-movable */

    /// <summary>
    /// Classe para realizar o hook na tela.
    /// </summary>
    internal static class Hook
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static void SetAsMoveable(Form frmMoveable)
        {
            ReleaseCapture();
            int response = SendMessage(frmMoveable.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            return;
        }

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
    }
}
