using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Formazione_01.Domain
{
    public class PartNumber
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public int Npk { get; set; }

        public string ToolFile { get; set; }

        public string RelatedCode { get; set; }

        public ICollection<PartNumberTool> PartNumberTools { get; set; }

 

    }



}
