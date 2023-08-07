using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class JobPrivacey : Base
    {
        public string? privacey { get; set; }
        public virtual List<Jobs>? jobs { get; set; }
    }
}
