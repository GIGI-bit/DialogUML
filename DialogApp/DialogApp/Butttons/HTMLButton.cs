using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp.Butttons
{
    internal class HTMLButton : IButton
    {
        public HTMLButton()
        {

        }
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
