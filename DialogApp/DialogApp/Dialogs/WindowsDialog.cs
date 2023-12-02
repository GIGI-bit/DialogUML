using DialogApp.Butttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp.Dialogs
{
    internal class WindowsDialog : Dialog
    {
        public WindowsDialog() { }
        public override IButton createButton()
        {
            return new WindowsButton();
        }
    }
}
