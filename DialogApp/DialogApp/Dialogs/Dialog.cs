using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp.Dialogs
{
    internal class Dialog
    {
        public IButton button;
        public Dialog()
        {
            
        }
        public void render() { }
        public virtual IButton createButton() { return  button; }
    }
}
