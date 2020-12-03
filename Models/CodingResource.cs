using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ua_acm_website.Models
{
    public class CodingResource
    {
        [Key]
        public int Id { get; set; }

        public string Resource { get; set; }

        public string TopicCovered{ get; set; }

        public string ApplicableClasses{ get; set; }

        [DataType(DataType.Url)]
        public string ResourceLink { get; set; }
    }
}
