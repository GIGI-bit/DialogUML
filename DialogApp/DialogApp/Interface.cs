using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp
{
    public interface IButton
    {
        public void render();
        public void onClick();
    }
}
