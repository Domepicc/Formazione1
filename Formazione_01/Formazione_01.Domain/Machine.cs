using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formazione_01.Domain
{
    public class Machine
    {

        public string MachineCode { get; set; }

        public string Description { get; set; }

        public string StoreToolsFileName { get; set; }

        public string Line { get; set; }

        public virtual ICollection<ToolMachine> ToolMachine { get; set; }

    
    }

}
