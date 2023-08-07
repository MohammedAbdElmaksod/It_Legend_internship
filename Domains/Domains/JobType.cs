using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class JobType :Base
    {
        public string? Type { get; set; }
        public virtual List<Jobs>? jobs { get; set; }
    }
}
