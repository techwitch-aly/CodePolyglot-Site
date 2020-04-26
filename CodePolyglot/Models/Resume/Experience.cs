using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodePolyglot.Models.Resume
{
    public class Experience
    {
        public string Title { get; set; }
        
        public string CompanyName { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM yyyy}")]
        public DateTime? EndDate { get; set; }

        public List<string> Details { get; set; }
    }
}
