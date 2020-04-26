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

        public IEnumerable<IGrouping<int, string>> PartitionedTechnologies()
        {
            if (Technologies == null)
            {
                return new List<IGrouping<int, string>>();
            }

            return Technologies.Select((i, index) => new
            {
                i,
                index
            }).GroupBy(group => group.index / 3, element => element.i);
        }
    }
}
