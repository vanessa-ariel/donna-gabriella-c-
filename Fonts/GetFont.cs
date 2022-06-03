using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

namespace DonnaGabriela.Fonts
{
    class GetFont
    {
        public void CustomFonts (Form form)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Comfortaa-Regular.ttf");
            foreach (Control c in form.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, FontStyle.Regular);
            }
        }
    }
}
