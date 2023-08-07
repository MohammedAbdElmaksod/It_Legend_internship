using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domains
{
    public class Base
    {
        public int Id { get; set; }

        public int? CurrentState { get; set; }

        public string? UpdatedBy { get; set; }
        [DefaultValue("getDate()")]
        public DateTime? UpdatedDate { get; set; }
        [DefaultValue("getDate()")]
        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }
    }
}
