using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class JobKind : Base
    {
        public string? kind { get; set; }
        public virtual List<Jobs>? jobs { get; set; }
    }
}
