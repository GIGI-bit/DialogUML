using DialogApp.Butttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp.Dialogs
{
    internal class WebDialog:Dialog
    {
        public WebDialog()
        {
            
        }
        public override IButton createButton()
        {
            return new HTMLButton();
        }
    }
}
