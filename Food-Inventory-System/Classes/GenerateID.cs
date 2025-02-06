using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Inventory_System.Classes
{
    internal class GenerateID
    {
        public GenerateID()
        {
        }
        public string GenID()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
