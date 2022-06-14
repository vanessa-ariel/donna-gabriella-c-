using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DonnaGabriela.InputValidations
{
    class ValidateInputs
    {
        public void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }
    }
}
