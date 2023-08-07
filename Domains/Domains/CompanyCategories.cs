using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class CompanyCategories : Base
    {
        public string? companyCategoryName { get; set; }
        public virtual List<Employees>? employees { get; set; }
    }
}
