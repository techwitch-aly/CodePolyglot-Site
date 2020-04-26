using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodePolyglot.Models.Resume
{
    public class ResumeModel
    {
        public ResumeModel()
        {
            Experiences = new List<Experience>();
            Schools = new List<Education>();
            Technologies = new List<string>();
        }

        public string Summary { get; set; }

        public List<string> Technologies { get; set; }

        public List<Experience> Experiences { get; set; }

        public List<Education> Schools { get; set; }
    }
}
