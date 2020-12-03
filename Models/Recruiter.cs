using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ua_acm_website.Models
{
    public class Recruiter
    {
        [Key]
        public int Id { get; set; }

        public string Company { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [DataType(DataType.Url)]
        public string CompanyWebsite { get; set; }
    }
}
