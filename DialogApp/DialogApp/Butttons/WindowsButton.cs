using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp.Butttons
{
    public class WindowsButton : IButton
    {
        public WindowsButton() { }

        public void onClick()
        {
            Console.WriteLine("onClick func called.");
        }

        public void render()
        {
            Console.WriteLine("render func called.");
        }
    }
}
