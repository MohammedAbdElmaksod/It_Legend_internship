using System.Collections.Generic;

namespace Domains
{
    public class SocialMedia : Base
    {
        public string? faceBook { get; set; }
        public string? twitter { get; set; }
        public string? linkedIn { get; set; }
        public string? instgram { get; set; }
        public string? google { get; set; }
        public string? Be { get; set; }
        public virtual List<Employees>? Employees { get; set; }
        public virtual List<Candidates>? Candidates { get; set; }
    }
}
