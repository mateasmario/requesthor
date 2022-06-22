using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace requesthor.Services
{
    internal class ResourceManagerService
    {
        [DllImport("gdi32.dll")]
        static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public static void InitializeFontCollection()
        {

            Globals.privateFontCollection = new PrivateFontCollection();

            int fontLength;
            byte[] fontdata;

            /* Comfortaa_Regular */
            fontLength = Properties.Resources.Comfortaa_Regular.Length;

            fontdata = Properties.Resources.Comfortaa_Regular;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontdata, 0, data, fontLength);

            Globals.privateFontCollection.AddMemoryFont(data, fontLength);
            /* End Comfortaa_Regular */

            /* DejaVu Sans Mono */
            fontLength = Properties.Resources.DejaVuSansMono.Length;

            fontdata = Properties.Resources.DejaVuSansMono;

            data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

            Globals.privateFontCollection.AddMemoryFont(data, fontLength);
            /* End DejaVu Sans Mono */
        }
    }
}
